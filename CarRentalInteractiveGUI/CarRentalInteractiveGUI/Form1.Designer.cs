namespace CarRentalInteractiveGUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(201, 128);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 1;
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(201, 241);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 2;
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFee.Location = new System.Drawing.Point(503, 181);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(155, 23);
            this.lblTotalFee.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount of Days";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount of Miles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalFee);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

