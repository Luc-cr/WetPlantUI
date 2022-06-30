﻿namespace WetPlantUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblLightning = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.pbFanOff = new System.Windows.Forms.PictureBox();
            this.pbBombOff = new System.Windows.Forms.PictureBox();
            this.pbLightOff = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFanOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBombOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLightOff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTemperature
            // 
            this.lblTemperature.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(60)))));
            this.lblTemperature.Location = new System.Drawing.Point(11, 144);
            this.lblTemperature.Margin = new System.Windows.Forms.Padding(0);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(141, 72);
            this.lblTemperature.TabIndex = 0;
            this.lblTemperature.Text = "100";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTemperature.UseMnemonic = false;
            this.lblTemperature.Click += new System.EventHandler(this.lblTemperature_Click);
            // 
            // lblPort
            // 
            this.lblPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPort.BackColor = System.Drawing.Color.Transparent;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.Color.White;
            this.lblPort.Location = new System.Drawing.Point(24, 744);
            this.lblPort.Margin = new System.Windows.Forms.Padding(0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(432, 72);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Puerto: COM3";
            this.lblPort.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblHumidity
            // 
            this.lblHumidity.BackColor = System.Drawing.Color.Transparent;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(60)))));
            this.lblHumidity.Location = new System.Drawing.Point(11, 264);
            this.lblHumidity.Margin = new System.Windows.Forms.Padding(0);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(141, 72);
            this.lblHumidity.TabIndex = 5;
            this.lblHumidity.Text = "100";
            this.lblHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHumidity.UseMnemonic = false;
            // 
            // lblLightning
            // 
            this.lblLightning.BackColor = System.Drawing.Color.Transparent;
            this.lblLightning.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblLightning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(60)))));
            this.lblLightning.Location = new System.Drawing.Point(11, 384);
            this.lblLightning.Margin = new System.Windows.Forms.Padding(0);
            this.lblLightning.Name = "lblLightning";
            this.lblLightning.Size = new System.Drawing.Size(141, 72);
            this.lblLightning.TabIndex = 6;
            this.lblLightning.Text = "100";
            this.lblLightning.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLightning.UseMnemonic = false;
            // 
            // lblSpeed
            // 
            this.lblSpeed.BackColor = System.Drawing.Color.Transparent;
            this.lblSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(60)))));
            this.lblSpeed.Location = new System.Drawing.Point(-3, 505);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(179, 72);
            this.lblSpeed.TabIndex = 7;
            this.lblSpeed.Text = "9600";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSpeed.UseMnemonic = false;
            // 
            // pbFanOff
            // 
            this.pbFanOff.BackColor = System.Drawing.Color.Transparent;
            this.pbFanOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFanOff.BackgroundImage")));
            this.pbFanOff.Location = new System.Drawing.Point(144, 24);
            this.pbFanOff.Name = "pbFanOff";
            this.pbFanOff.Size = new System.Drawing.Size(72, 72);
            this.pbFanOff.TabIndex = 8;
            this.pbFanOff.TabStop = false;
            // 
            // pbBombOff
            // 
            this.pbBombOff.BackColor = System.Drawing.Color.Transparent;
            this.pbBombOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBombOff.BackgroundImage")));
            this.pbBombOff.Location = new System.Drawing.Point(264, 24);
            this.pbBombOff.Name = "pbBombOff";
            this.pbBombOff.Size = new System.Drawing.Size(72, 72);
            this.pbBombOff.TabIndex = 9;
            this.pbBombOff.TabStop = false;
            // 
            // pbLightOff
            // 
            this.pbLightOff.BackColor = System.Drawing.Color.Transparent;
            this.pbLightOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLightOff.BackgroundImage")));
            this.pbLightOff.Location = new System.Drawing.Point(384, 24);
            this.pbLightOff.Name = "pbLightOff";
            this.pbLightOff.Size = new System.Drawing.Size(72, 72);
            this.pbLightOff.TabIndex = 10;
            this.pbLightOff.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(480, 840);
            this.Controls.Add(this.pbLightOff);
            this.Controls.Add(this.pbBombOff);
            this.Controls.Add(this.pbFanOff);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblLightning);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblTemperature);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(496, 879);
            this.MinimumSize = new System.Drawing.Size(496, 879);
            this.Name = "Form1";
            this.Text = "WetPlant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFanOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBombOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLightOff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblLightning;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.PictureBox pbFanOff;
        private System.Windows.Forms.PictureBox pbBombOff;
        private System.Windows.Forms.PictureBox pbLightOff;
    }
}

