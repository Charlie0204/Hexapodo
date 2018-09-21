namespace _0409
{
    partial class w1
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
            this.btnPaws = new System.Windows.Forms.Button();
            this.btnHexapod = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.cbxPorts = new System.Windows.Forms.ComboBox();
            this.lblPortName = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPaws
            // 
            this.btnPaws.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPaws.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaws.Location = new System.Drawing.Point(277, 403);
            this.btnPaws.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnPaws.Name = "btnPaws";
            this.btnPaws.Size = new System.Drawing.Size(261, 86);
            this.btnPaws.TabIndex = 0;
            this.btnPaws.Text = "Paws Controller";
            this.btnPaws.UseVisualStyleBackColor = true;
            this.btnPaws.Click += new System.EventHandler(this.btnPaws_Click);
            // 
            // btnHexapod
            // 
            this.btnHexapod.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnHexapod.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHexapod.Location = new System.Drawing.Point(277, 503);
            this.btnHexapod.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnHexapod.Name = "btnHexapod";
            this.btnHexapod.Size = new System.Drawing.Size(261, 86);
            this.btnHexapod.TabIndex = 1;
            this.btnHexapod.Text = "Hexapod Moves";
            this.btnHexapod.UseVisualStyleBackColor = true;
            this.btnHexapod.Click += new System.EventHandler(this.btnHexapod_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(277, 603);
            this.btnClose.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(261, 55);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(32, 21);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(667, 46);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome to the Hexapod Controller!";
            // 
            // cbxPorts
            // 
            this.cbxPorts.FormattingEnabled = true;
            this.cbxPorts.Location = new System.Drawing.Point(277, 148);
            this.cbxPorts.Name = "cbxPorts";
            this.cbxPorts.Size = new System.Drawing.Size(261, 39);
            this.cbxPorts.TabIndex = 4;
            // 
            // lblPortName
            // 
            this.lblPortName.AutoSize = true;
            this.lblPortName.Location = new System.Drawing.Point(271, 113);
            this.lblPortName.Name = "lblPortName";
            this.lblPortName.Size = new System.Drawing.Size(153, 32);
            this.lblPortName.TabIndex = 5;
            this.lblPortName.Text = "Port name:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(277, 193);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(261, 50);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // w1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 687);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblPortName);
            this.Controls.Add(this.cbxPorts);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHexapod);
            this.Controls.Add(this.btnPaws);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "w1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w1_FormClosing);
            this.Load += new System.EventHandler(this.w1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPaws;
        private System.Windows.Forms.Button btnHexapod;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ComboBox cbxPorts;
        private System.Windows.Forms.Label lblPortName;
        private System.Windows.Forms.Button btnConnect;
    }
}

