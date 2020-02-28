namespace MarsWeight
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtEarth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMars = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObjName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(138, 193);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 27);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtEarth
            // 
            this.txtEarth.Location = new System.Drawing.Point(203, 82);
            this.txtEarth.Name = "txtEarth";
            this.txtEarth.Size = new System.Drawing.Size(221, 22);
            this.txtEarth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weight on Earth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Weight on Mars";
            // 
            // txtMars
            // 
            this.txtMars.Location = new System.Drawing.Point(203, 140);
            this.txtMars.Name = "txtMars";
            this.txtMars.ReadOnly = true;
            this.txtMars.Size = new System.Drawing.Size(221, 22);
            this.txtMars.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name of Object";
            // 
            // txtObjName
            // 
            this.txtObjName.Location = new System.Drawing.Point(203, 26);
            this.txtObjName.Name = "txtObjName";
            this.txtObjName.Size = new System.Drawing.Size(221, 22);
            this.txtObjName.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 232);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtObjName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEarth);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Mars Weight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtEarth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMars;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObjName;
    }
}

