namespace EggsInteractiveGUI
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
            this.txtChicken1 = new System.Windows.Forms.TextBox();
            this.txtChicken5 = new System.Windows.Forms.TextBox();
            this.txtChicken4 = new System.Windows.Forms.TextBox();
            this.txtChicken3 = new System.Windows.Forms.TextBox();
            this.txtChicken2 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtChicken1
            // 
            this.txtChicken1.Location = new System.Drawing.Point(137, 126);
            this.txtChicken1.Name = "txtChicken1";
            this.txtChicken1.Size = new System.Drawing.Size(100, 20);
            this.txtChicken1.TabIndex = 0;
            // 
            // txtChicken5
            // 
            this.txtChicken5.Location = new System.Drawing.Point(137, 230);
            this.txtChicken5.Name = "txtChicken5";
            this.txtChicken5.Size = new System.Drawing.Size(100, 20);
            this.txtChicken5.TabIndex = 1;
            // 
            // txtChicken4
            // 
            this.txtChicken4.Location = new System.Drawing.Point(137, 204);
            this.txtChicken4.Name = "txtChicken4";
            this.txtChicken4.Size = new System.Drawing.Size(100, 20);
            this.txtChicken4.TabIndex = 2;
            // 
            // txtChicken3
            // 
            this.txtChicken3.Location = new System.Drawing.Point(137, 178);
            this.txtChicken3.Name = "txtChicken3";
            this.txtChicken3.Size = new System.Drawing.Size(100, 20);
            this.txtChicken3.TabIndex = 3;
            // 
            // txtChicken2
            // 
            this.txtChicken2.Location = new System.Drawing.Point(137, 152);
            this.txtChicken2.Name = "txtChicken2";
            this.txtChicken2.Size = new System.Drawing.Size(100, 20);
            this.txtChicken2.TabIndex = 4;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(307, 178);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter eggs produced by each of 5 chickens ";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(456, 178);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(236, 23);
            this.lblTotal.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtChicken2);
            this.Controls.Add(this.txtChicken3);
            this.Controls.Add(this.txtChicken4);
            this.Controls.Add(this.txtChicken5);
            this.Controls.Add(this.txtChicken1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChicken1;
        private System.Windows.Forms.TextBox txtChicken5;
        private System.Windows.Forms.TextBox txtChicken4;
        private System.Windows.Forms.TextBox txtChicken3;
        private System.Windows.Forms.TextBox txtChicken2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
    }
}

