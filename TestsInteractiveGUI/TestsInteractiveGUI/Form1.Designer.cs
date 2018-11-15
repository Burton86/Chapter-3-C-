namespace TestsInteractiveGUI
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
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore5 = new System.Windows.Forms.TextBox();
            this.txtScore4 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(175, 62);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(100, 20);
            this.txtScore1.TabIndex = 0;
            // 
            // txtScore5
            // 
            this.txtScore5.Location = new System.Drawing.Point(254, 114);
            this.txtScore5.Name = "txtScore5";
            this.txtScore5.Size = new System.Drawing.Size(100, 20);
            this.txtScore5.TabIndex = 1;
            // 
            // txtScore4
            // 
            this.txtScore4.Location = new System.Drawing.Point(326, 88);
            this.txtScore4.Name = "txtScore4";
            this.txtScore4.Size = new System.Drawing.Size(100, 20);
            this.txtScore4.TabIndex = 2;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(175, 88);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(100, 20);
            this.txtScore3.TabIndex = 3;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(326, 62);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(100, 20);
            this.txtScore2.TabIndex = 4;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(478, 71);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 23);
            this.btnAverage.TabIndex = 5;
            this.btnAverage.Text = "Convert";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(605, 71);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(169, 23);
            this.lblAverage.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Test Scores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.txtScore2);
            this.Controls.Add(this.txtScore3);
            this.Controls.Add(this.txtScore4);
            this.Controls.Add(this.txtScore5);
            this.Controls.Add(this.txtScore1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore5;
        private System.Windows.Forms.TextBox txtScore4;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label label2;
    }
}

