namespace SchoolCancellation
{
    partial class Form1
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
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtAirTemp = new System.Windows.Forms.TextBox();
            this.txtWindTemp = new System.Windows.Forms.TextBox();
            this.txtSnowfall = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReasonTemp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClosing = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtReasonWind = new System.Windows.Forms.TextBox();
            this.txtReasonSnow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(31, 227);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(94, 29);
            this.btnVerify.TabIndex = 0;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtAirTemp
            // 
            this.txtAirTemp.Location = new System.Drawing.Point(31, 54);
            this.txtAirTemp.Name = "txtAirTemp";
            this.txtAirTemp.Size = new System.Drawing.Size(117, 22);
            this.txtAirTemp.TabIndex = 2;
            // 
            // txtWindTemp
            // 
            this.txtWindTemp.Location = new System.Drawing.Point(31, 106);
            this.txtWindTemp.Name = "txtWindTemp";
            this.txtWindTemp.Size = new System.Drawing.Size(117, 22);
            this.txtWindTemp.TabIndex = 3;
            // 
            // txtSnowfall
            // 
            this.txtSnowfall.Location = new System.Drawing.Point(31, 159);
            this.txtSnowfall.Name = "txtSnowfall";
            this.txtSnowfall.Size = new System.Drawing.Size(117, 22);
            this.txtSnowfall.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Air Temperature in F";
            // 
            // txtReasonTemp
            // 
            this.txtReasonTemp.Location = new System.Drawing.Point(262, 103);
            this.txtReasonTemp.Name = "txtReasonTemp";
            this.txtReasonTemp.ReadOnly = true;
            this.txtReasonTemp.Size = new System.Drawing.Size(173, 22);
            this.txtReasonTemp.TabIndex = 6;
            this.txtReasonTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wind Chill in F";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Snowfall in inches";
            // 
            // lblClosing
            // 
            this.lblClosing.AutoSize = true;
            this.lblClosing.Location = new System.Drawing.Point(259, 54);
            this.lblClosing.Name = "lblClosing";
            this.lblClosing.Size = new System.Drawing.Size(73, 17);
            this.lblClosing.TabIndex = 9;
            this.lblClosing.Text = "School will";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Reasoning:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(341, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtReasonWind
            // 
            this.txtReasonWind.Location = new System.Drawing.Point(262, 131);
            this.txtReasonWind.Name = "txtReasonWind";
            this.txtReasonWind.ReadOnly = true;
            this.txtReasonWind.Size = new System.Drawing.Size(173, 22);
            this.txtReasonWind.TabIndex = 12;
            this.txtReasonWind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReasonSnow
            // 
            this.txtReasonSnow.Location = new System.Drawing.Point(262, 159);
            this.txtReasonSnow.Name = "txtReasonSnow";
            this.txtReasonSnow.ReadOnly = true;
            this.txtReasonSnow.Size = new System.Drawing.Size(173, 22);
            this.txtReasonSnow.TabIndex = 13;
            this.txtReasonSnow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 290);
            this.Controls.Add(this.txtReasonSnow);
            this.Controls.Add(this.txtReasonWind);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblClosing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReasonTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSnowfall);
            this.Controls.Add(this.txtWindTemp);
            this.Controls.Add(this.txtAirTemp);
            this.Controls.Add(this.btnVerify);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "School Cancellation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.TextBox txtAirTemp;
        private System.Windows.Forms.TextBox txtWindTemp;
        private System.Windows.Forms.TextBox txtSnowfall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReasonTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClosing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtReasonWind;
        private System.Windows.Forms.TextBox txtReasonSnow;
    }
}

