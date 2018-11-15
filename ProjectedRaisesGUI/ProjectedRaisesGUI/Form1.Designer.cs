namespace ProjectedRaisesGUI
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
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.btnRaise = new System.Windows.Forms.Button();
            this.lblNewSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(98, 36);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 0;
            // 
            // btnRaise
            // 
            this.btnRaise.Location = new System.Drawing.Point(292, 36);
            this.btnRaise.Name = "btnRaise";
            this.btnRaise.Size = new System.Drawing.Size(75, 23);
            this.btnRaise.TabIndex = 1;
            this.btnRaise.Text = "4% Raise";
            this.btnRaise.UseVisualStyleBackColor = true;
            this.btnRaise.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNewSalary
            // 
            this.lblNewSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNewSalary.Location = new System.Drawing.Point(439, 36);
            this.lblNewSalary.Name = "lblNewSalary";
            this.lblNewSalary.Size = new System.Drawing.Size(100, 23);
            this.lblNewSalary.TabIndex = 2;
            this.lblNewSalary.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNewSalary);
            this.Controls.Add(this.btnRaise);
            this.Controls.Add(this.txtSalary);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Button btnRaise;
        private System.Windows.Forms.Label lblNewSalary;
    }
}

