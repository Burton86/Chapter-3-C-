namespace PayrollGUI
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.txtSocial = new System.Windows.Forms.TextBox();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculation = new System.Windows.Forms.Button();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblFederal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(193, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(193, 178);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(100, 20);
            this.txtHoursWorked.TabIndex = 1;
            // 
            // txtSocial
            // 
            this.txtSocial.Location = new System.Drawing.Point(193, 126);
            this.txtSocial.Name = "txtSocial";
            this.txtSocial.Size = new System.Drawing.Size(100, 20);
            this.txtSocial.TabIndex = 2;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(193, 152);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(100, 20);
            this.txtPayRate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Name Here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Social Security Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter Hourly Pay Rate";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter Hours Worked";
            // 
            // btnCalculation
            // 
            this.btnCalculation.Location = new System.Drawing.Point(347, 142);
            this.btnCalculation.Name = "btnCalculation";
            this.btnCalculation.Size = new System.Drawing.Size(75, 23);
            this.btnCalculation.TabIndex = 8;
            this.btnCalculation.Text = "Pay Roll";
            this.btnCalculation.UseVisualStyleBackColor = true;
            this.btnCalculation.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrossPay.Location = new System.Drawing.Point(462, 99);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGrossPay.Size = new System.Drawing.Size(119, 23);
            this.lblGrossPay.TabIndex = 9;
            this.lblGrossPay.Click += new System.EventHandler(this.lblGrossPay_Click);
            // 
            // lblNet
            // 
            this.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNet.Location = new System.Drawing.Point(462, 180);
            this.lblNet.Name = "lblNet";
            this.lblNet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNet.Size = new System.Drawing.Size(119, 23);
            this.lblNet.TabIndex = 10;
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblState.Location = new System.Drawing.Point(462, 154);
            this.lblState.Name = "lblState";
            this.lblState.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblState.Size = new System.Drawing.Size(119, 23);
            this.lblState.TabIndex = 11;
            // 
            // lblFederal
            // 
            this.lblFederal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFederal.Location = new System.Drawing.Point(462, 128);
            this.lblFederal.Name = "lblFederal";
            this.lblFederal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFederal.Size = new System.Drawing.Size(119, 23);
            this.lblFederal.TabIndex = 12;
            this.lblFederal.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFederal);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.btnCalculation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPayRate);
            this.Controls.Add(this.txtSocial);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.TextBox txtSocial;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculation;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblFederal;
    }
}

