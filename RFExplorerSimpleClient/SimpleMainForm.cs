//============================================================================
//RF Explorer for Windows - A Handheld Spectrum Analyzer for everyone!
//Copyright © 2010-13 Ariel Rocholl, www.rf-explorer.com
//
//This application is free software; you can redistribute it and/or
//modify it under the terms of the GNU Lesser General Public
//License as published by the Free Software Foundation; either
//version 3.0 of the License, or (at your option) any later version.
//
//This software is distributed in the hope that it will be useful,
//but WITHOUT ANY WARRANTY; without even the implied warranty of
//MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//General Public License for more details.
//
//You should have received a copy of the GNU General Public
//License along with this library; if not, write to the Free Software
//Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//=============================================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using RFExplorerCommunicator;

namespace RFExplorerSimpleClient
{
    public partial class SimpleMainForm : Form
    {
        #region Members
        System.Windows.Forms.Timer m_RefreshTimer = new System.Windows.Forms.Timer();
        string m_sRFEReceivedString = "";
        RFECommunicator m_objRFE;
        #endregion
        private double freqSpan;
        private List<DataPoint> peakHoldData = new List<DataPoint>();
        private List<DataPoint> currentData = new List<DataPoint>();

        public struct DataPoint
        {
            public double freq;
            public double amp;
        }

        #region Main Form handling
        public SimpleMainForm()
        {
            InitializeComponent();

            m_objRFE = new RFECommunicator(true);
            m_objRFE.ReceivedConfigurationDataEvent += new EventHandler(OnRFE_ReceivedConfigData);
            m_objRFE.UpdateDataEvent += new EventHandler(OnRFE_UpdateData);
            CenterFreq.KeyDown += new KeyEventHandler(OnCenterFreqChanged);
            Span.KeyDown+= new KeyEventHandler(OnSpanChanged);
            freqSpan = Convert.ToDouble(Span.Text);
            ScanPlot.Series.Add("peakHold");



        }

        private void SimpleMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            m_objRFE.Close();
        }

        private void SimpleMainForm_Load(object sender, EventArgs e)
        {
            GetConnectedPortsRFExplorer(); 
            UpdateButtonStatus();

            m_RefreshTimer.Enabled = true;
            m_RefreshTimer.Interval = 100;
            m_RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_tick);
        }
        #endregion

        #region RFExplorer Events
        private void OnRFE_ReceivedConfigData(object sender, EventArgs e)
        {
            m_objRFE.SweepData.CleanAll(); //we do not want mixed data sweep values
        }


        private void OnRFE_UpdateData(object sender, EventArgs e)
        {
            labelSweeps.Text = "Sweeps: " + m_objRFE.SweepData.Count.ToString();


            RFESweepData objData = m_objRFE.SweepData.GetData(m_objRFE.SweepData.Count - 1);
            if (objData != null)
            {
                UInt16 nPeak = objData.GetPeakStep();
                labelFrequency.Text = objData.GetFrequencyMHZ(nPeak).ToString("f3") + " MHZ";
                labelAmplitude.Text = objData.GetAmplitudeDBM(nPeak).ToString("f2") + " dBm";


                for (ushort i = 0; i< objData.TotalSteps; i++)
                {
                    DataPoint point = new DataPoint();
                    point.freq = objData.GetFrequencyMHZ(i);
                    point.amp = objData.GetAmplitudeDBM(i);

                    if (currentData.Count < objData.TotalSteps)
                    {
                        currentData.Add(point);

                    }
                    else
                    {
                        currentData[i] = point;
                    }

                    if (peakHoldData.Count< objData.TotalSteps)
                    {
                        peakHoldData.Add(point);
                    }
                    else
                    {
                        if (point.amp > peakHoldData[i].amp)
                        {
                            peakHoldData[i] = point;
                        }
                    }
                }

                for (ushort i =0; i < objData.TotalSteps;i++)
                {

                    if (ScanPlot.Series[0].Points.Count < currentData.Count)
                    {
                        ScanPlot.Series[0].Points.AddXY(currentData[i].freq,currentData[i].amp);
                    }
                    else
                    {
                        ScanPlot.Series[0].Points[i].SetValueXY(currentData[i].freq, currentData[i].amp);
                    }
                    if (ScanPlot.Series[1].Points.Count < peakHoldData.Count)
                    {
                        ScanPlot.Series[1].Points.AddXY(peakHoldData[i].freq, peakHoldData[i].amp);
                    }
                    else
                    {
                        ScanPlot.Series[1].Points[i].SetValueXY(peakHoldData[i].freq, peakHoldData[i].amp);
                        
                    }
                }
                ScanPlot.Refresh();







            }
        }

       private void OnCenterFreqChanged(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                double center = Convert.ToDouble(CenterFreq.Text);
                m_objRFE.UpdateDeviceConfig(center - freqSpan / 2, center + freqSpan / 2);

                currentData.Clear();
                peakHoldData.Clear();
                ScanPlot.Series[0].Points.Clear();
                ScanPlot.Series[1].Points.Clear();
                ScanPlot.Refresh();

            }

        }

        private void OnSpanChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Span.Text != "" && Convert.ToDouble(Span.Text) > 0.9d)
                {
                    freqSpan = Convert.ToDouble(Span.Text);

                }
                else
                {
                    freqSpan = 1d;
                }
                currentData.Clear();
                peakHoldData.Clear();
                ScanPlot.Series[0].Points.Clear();
                ScanPlot.Series[1].Points.Clear();
                ScanPlot.Refresh();

                m_objRFE.UpdateDeviceConfig(Convert.ToDouble(CenterFreq.Text) - freqSpan / 2, Convert.ToDouble(CenterFreq.Text) + freqSpan / 2);
            }

        }

        #endregion

        #region RF Explorer handling
        private void UpdateButtonStatus()
        {
            btnConnectRFExplorer.Enabled = !m_objRFE.PortConnected && (comboBoxPortsRFExplorer.Items.Count > 0);
            btnDisconnectRFExplorer.Enabled = m_objRFE.PortConnected;
            comboBoxPortsRFExplorer.Enabled = !m_objRFE.PortConnected;
            comboBoxBaudrateRFExplorer.Enabled = !m_objRFE.PortConnected;
            btnRescanPortsRFExplorer.Enabled = !m_objRFE.PortConnected;

            if (!m_objRFE.PortConnected)
            {
                if (comboBoxBaudrateRFExplorer.SelectedItem == null)
                {
                    comboBoxBaudrateRFExplorer.SelectedItem = "500000";
                }
            }
        }

        private void btnConnectRFExplorer_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (comboBoxPortsRFExplorer.Items.Count > 0)
            {
                m_objRFE.ConnectPort(comboBoxPortsRFExplorer.SelectedValue.ToString(), Convert.ToInt32(comboBoxBaudrateRFExplorer.SelectedItem.ToString()));
                if (m_objRFE.PortConnected)
                {
                    m_objRFE.SendCommand_RequestConfigData();
                }
                Thread.Sleep(2000);
                m_objRFE.ProcessReceivedString(true, out m_sRFEReceivedString);
            }
            UpdateButtonStatus();
            Cursor.Current = Cursors.Default;
        }

        private void btnDisconnectRFExplorer_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            m_objRFE.ClosePort();
            UpdateButtonStatus();
            Cursor.Current = Cursors.Default;
        }

        private void GetConnectedPortsRFExplorer()
        {
            Cursor.Current = Cursors.WaitCursor;
            comboBoxPortsRFExplorer.DataSource = null;
            if (m_objRFE.GetConnectedPorts())
            {
                comboBoxPortsRFExplorer.DataSource = m_objRFE.ValidCP2101Ports;
            }
            UpdateButtonStatus();
            Cursor.Current = Cursors.Default;
        }

        private void btnRescanPortsRFExplorer_Click(object sender, EventArgs e)
        {
            GetConnectedPortsRFExplorer();
        }

        private void RefreshTimer_tick(object sender, EventArgs e)
        {
            if (m_objRFE.PortConnected)
            {
                m_objRFE.ProcessReceivedString(true, out m_sRFEReceivedString);
            }
        }
        #endregion
    }
}
