﻿namespace RealNews
{
    partial class frmSettings
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
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpdate = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkUseSystemProxy = new System.Windows.Forms.CheckBox();
            this.numWebPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numDownloadSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWebPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDownloadSize)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(170, 177);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(131, 22);
            this.txtStart.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Downloading Images";
            // 
            // numUpdate
            // 
            this.numUpdate.Location = new System.Drawing.Point(170, 49);
            this.numUpdate.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.numUpdate.Name = "numUpdate";
            this.numUpdate.Size = new System.Drawing.Size(131, 22);
            this.numUpdate.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "Global Update Every";
            // 
            // chkUseSystemProxy
            // 
            this.chkUseSystemProxy.AutoSize = true;
            this.chkUseSystemProxy.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUseSystemProxy.Location = new System.Drawing.Point(59, 12);
            this.chkUseSystemProxy.Name = "chkUseSystemProxy";
            this.chkUseSystemProxy.Size = new System.Drawing.Size(124, 18);
            this.chkUseSystemProxy.TabIndex = 19;
            this.chkUseSystemProxy.Text = "Use System Proxy";
            this.chkUseSystemProxy.UseVisualStyleBackColor = true;
            // 
            // numWebPort
            // 
            this.numWebPort.Location = new System.Drawing.Point(170, 92);
            this.numWebPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numWebPort.Name = "numWebPort";
            this.numWebPort.Size = new System.Drawing.Size(131, 22);
            this.numWebPort.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 14);
            this.label2.TabIndex = 20;
            this.label2.Text = "View Items Web Port";
            // 
            // numDownloadSize
            // 
            this.numDownloadSize.Location = new System.Drawing.Point(170, 135);
            this.numDownloadSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numDownloadSize.Name = "numDownloadSize";
            this.numDownloadSize.Size = new System.Drawing.Size(131, 22);
            this.numDownloadSize.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 14);
            this.label5.TabIndex = 22;
            this.label5.Text = "Download Images Under";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 14);
            this.label6.TabIndex = 24;
            this.label6.Text = "KB";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(170, 220);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(131, 22);
            this.txtEnd.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 14);
            this.label7.TabIndex = 25;
            this.label7.Text = "End Downloading Images";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 296);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 33);
            this.button3.TabIndex = 28;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 33);
            this.button2.TabIndex = 27;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 14);
            this.label8.TabIndex = 29;
            this.label8.Text = "24 Hour";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 14);
            this.label9.TabIndex = 30;
            this.label9.Text = "24 Hour";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 14);
            this.label10.TabIndex = 25;
            this.label10.Text = "Last Updated";
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Location = new System.Drawing.Point(167, 264);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(11, 14);
            this.lblLastUpdated.TabIndex = 25;
            this.lblLastUpdated.Text = "-";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(307, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(79, 14);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Edit Style.css";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 341);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numDownloadSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numWebPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkUseSystemProxy);
            this.Controls.Add(this.numUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWebPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDownloadSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkUseSystemProxy;
        private System.Windows.Forms.NumericUpDown numWebPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDownloadSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}