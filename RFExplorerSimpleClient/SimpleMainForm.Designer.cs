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

namespace RFExplorerSimpleClient
{
    partial class SimpleMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelAmplitude = new System.Windows.Forms.Label();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.labelSweeps = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRescanPortsRFExplorer = new System.Windows.Forms.Button();
            this.comboBoxBaudrateRFExplorer = new System.Windows.Forms.ComboBox();
            this.btnConnectRFExplorer = new System.Windows.Forms.Button();
            this.btnDisconnectRFExplorer = new System.Windows.Forms.Button();
            this.comboBoxPortsRFExplorer = new System.Windows.Forms.ComboBox();
            this.CenterFreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Span = new System.Windows.Forms.TextBox();
            this.ScanPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScanPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelAmplitude);
            this.groupBox2.Controls.Add(this.labelFrequency);
            this.groupBox2.Controls.Add(this.labelSweeps);
            this.groupBox2.Location = new System.Drawing.Point(12, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 108);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RF Explorer live Data";
            // 
            // labelAmplitude
            // 
            this.labelAmplitude.AutoSize = true;
            this.labelAmplitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelAmplitude.Location = new System.Drawing.Point(6, 52);
            this.labelAmplitude.Name = "labelAmplitude";
            this.labelAmplitude.Size = new System.Drawing.Size(59, 25);
            this.labelAmplitude.TabIndex = 58;
            this.labelAmplitude.Text = "dBM";
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrequency.Location = new System.Drawing.Point(6, 20);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(61, 25);
            this.labelFrequency.TabIndex = 58;
            this.labelFrequency.Text = "MHZ";
            // 
            // labelSweeps
            // 
            this.labelSweeps.AutoSize = true;
            this.labelSweeps.Location = new System.Drawing.Point(6, 81);
            this.labelSweeps.Name = "labelSweeps";
            this.labelSweeps.Size = new System.Drawing.Size(57, 13);
            this.labelSweeps.TabIndex = 57;
            this.labelSweeps.Text = "Sweeps: 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRescanPortsRFExplorer);
            this.groupBox1.Controls.Add(this.comboBoxBaudrateRFExplorer);
            this.groupBox1.Controls.Add(this.btnConnectRFExplorer);
            this.groupBox1.Controls.Add(this.btnDisconnectRFExplorer);
            this.groupBox1.Controls.Add(this.comboBoxPortsRFExplorer);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 108);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RF Explorer COM Port";
            // 
            // btnRescanPortsRFExplorer
            // 
            this.btnRescanPortsRFExplorer.AutoSize = true;
            this.btnRescanPortsRFExplorer.Location = new System.Drawing.Point(110, 19);
            this.btnRescanPortsRFExplorer.Name = "btnRescanPortsRFExplorer";
            this.btnRescanPortsRFExplorer.Size = new System.Drawing.Size(34, 23);
            this.btnRescanPortsRFExplorer.TabIndex = 11;
            this.btnRescanPortsRFExplorer.Text = "*";
            this.btnRescanPortsRFExplorer.UseVisualStyleBackColor = true;
            this.btnRescanPortsRFExplorer.Click += new System.EventHandler(this.btnRescanPortsRFExplorer_Click);
            // 
            // comboBoxBaudrateRFExplorer
            // 
            this.comboBoxBaudrateRFExplorer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudrateRFExplorer.Items.AddRange(new object[] {
            "500000",
            "2400"});
            this.comboBoxBaudrateRFExplorer.Location = new System.Drawing.Point(150, 20);
            this.comboBoxBaudrateRFExplorer.Name = "comboBoxBaudrateRFExplorer";
            this.comboBoxBaudrateRFExplorer.Size = new System.Drawing.Size(92, 21);
            this.comboBoxBaudrateRFExplorer.TabIndex = 12;
            // 
            // btnConnectRFExplorer
            // 
            this.btnConnectRFExplorer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConnectRFExplorer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectRFExplorer.Location = new System.Drawing.Point(22, 50);
            this.btnConnectRFExplorer.Name = "btnConnectRFExplorer";
            this.btnConnectRFExplorer.Size = new System.Drawing.Size(107, 38);
            this.btnConnectRFExplorer.TabIndex = 13;
            this.btnConnectRFExplorer.Text = "Connect";
            this.btnConnectRFExplorer.Click += new System.EventHandler(this.btnConnectRFExplorer_Click);
            // 
            // btnDisconnectRFExplorer
            // 
            this.btnDisconnectRFExplorer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDisconnectRFExplorer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnectRFExplorer.Location = new System.Drawing.Point(135, 50);
            this.btnDisconnectRFExplorer.Name = "btnDisconnectRFExplorer";
            this.btnDisconnectRFExplorer.Size = new System.Drawing.Size(107, 38);
            this.btnDisconnectRFExplorer.TabIndex = 41;
            this.btnDisconnectRFExplorer.Text = "Disconnect";
            this.btnDisconnectRFExplorer.Click += new System.EventHandler(this.btnDisconnectRFExplorer_Click);
            // 
            // comboBoxPortsRFExplorer
            // 
            this.comboBoxPortsRFExplorer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPortsRFExplorer.Location = new System.Drawing.Point(22, 20);
            this.comboBoxPortsRFExplorer.Name = "comboBoxPortsRFExplorer";
            this.comboBoxPortsRFExplorer.Size = new System.Drawing.Size(82, 21);
            this.comboBoxPortsRFExplorer.TabIndex = 10;
            // 
            // CenterFreq
            // 
            this.CenterFreq.Location = new System.Drawing.Point(12, 391);
            this.CenterFreq.Name = "CenterFreq";
            this.CenterFreq.Size = new System.Drawing.Size(100, 20);
            this.CenterFreq.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Center Freq";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Center Freq";
            this.label2.Visible = false;
            // 
            // Span
            // 
            this.Span.Location = new System.Drawing.Point(130, 391);
            this.Span.Name = "Span";
            this.Span.Size = new System.Drawing.Size(100, 20);
            this.Span.TabIndex = 65;
            this.Span.Text = "10";
            // 
            // ScanPlot
            // 
            chartArea1.Name = "ChartArea1";
            this.ScanPlot.ChartAreas.Add(chartArea1);
            this.ScanPlot.Location = new System.Drawing.Point(278, 13);
            this.ScanPlot.Name = "ScanPlot";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.ScanPlot.Series.Add(series1);
            this.ScanPlot.Size = new System.Drawing.Size(649, 398);
            this.ScanPlot.TabIndex = 67;
            this.ScanPlot.Text = "chart1";
            // 
            // SimpleMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 423);
            this.Controls.Add(this.ScanPlot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Span);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CenterFreq);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SimpleMainForm";
            this.Text = "RF Explorer - simple automation sample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimpleMainForm_FormClosing);
            this.Load += new System.EventHandler(this.SimpleMainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScanPlot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelAmplitude;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.Label labelSweeps;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRescanPortsRFExplorer;
        private System.Windows.Forms.ComboBox comboBoxBaudrateRFExplorer;
        private System.Windows.Forms.Button btnConnectRFExplorer;
        private System.Windows.Forms.Button btnDisconnectRFExplorer;
        private System.Windows.Forms.ComboBox comboBoxPortsRFExplorer;
        private System.Windows.Forms.TextBox CenterFreq;

        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Span;
        private System.Windows.Forms.DataVisualization.Charting.Chart ScanPlot;
    }
}

