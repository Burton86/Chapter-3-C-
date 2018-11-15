namespace MadLibsGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlural = new System.Windows.Forms.TextBox();
            this.txtNoun = new System.Windows.Forms.TextBox();
            this.txtAnimal = new System.Windows.Forms.TextBox();
            this.txtBodyPart = new System.Windows.Forms.TextBox();
            this.txtEST = new System.Windows.Forms.TextBox();
            this.btnPress = new System.Windows.Forms.Button();
            this.lblDragon = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblNumber2 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name a color";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(88, 92);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name a word ending in EST";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name a Body part plural";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name a Animal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name a Noun";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Name a Plural Noun";
            // 
            // txtPlural
            // 
            this.txtPlural.Location = new System.Drawing.Point(120, 309);
            this.txtPlural.Name = "txtPlural";
            this.txtPlural.Size = new System.Drawing.Size(100, 20);
            this.txtPlural.TabIndex = 7;
            this.txtPlural.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNoun
            // 
            this.txtNoun.Location = new System.Drawing.Point(91, 258);
            this.txtNoun.Name = "txtNoun";
            this.txtNoun.Size = new System.Drawing.Size(100, 20);
            this.txtNoun.TabIndex = 8;
            // 
            // txtAnimal
            // 
            this.txtAnimal.Location = new System.Drawing.Point(96, 213);
            this.txtAnimal.Name = "txtAnimal";
            this.txtAnimal.Size = new System.Drawing.Size(100, 20);
            this.txtAnimal.TabIndex = 9;
            // 
            // txtBodyPart
            // 
            this.txtBodyPart.Location = new System.Drawing.Point(138, 175);
            this.txtBodyPart.Name = "txtBodyPart";
            this.txtBodyPart.Size = new System.Drawing.Size(100, 20);
            this.txtBodyPart.TabIndex = 10;
            // 
            // txtEST
            // 
            this.txtEST.Location = new System.Drawing.Point(158, 134);
            this.txtEST.Name = "txtEST";
            this.txtEST.Size = new System.Drawing.Size(100, 20);
            this.txtEST.TabIndex = 11;
            // 
            // btnPress
            // 
            this.btnPress.Location = new System.Drawing.Point(304, 213);
            this.btnPress.Name = "btnPress";
            this.btnPress.Size = new System.Drawing.Size(92, 23);
            this.btnPress.TabIndex = 12;
            this.btnPress.Text = "PRESS HERE";
            this.btnPress.UseVisualStyleBackColor = true;
            this.btnPress.Click += new System.EventHandler(this.btnPress_Click);
            // 
            // lblDragon
            // 
            this.lblDragon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDragon.Location = new System.Drawing.Point(511, 213);
            this.lblDragon.Name = "lblDragon";
            this.lblDragon.Size = new System.Drawing.Size(225, 211);
            this.lblDragon.TabIndex = 13;
            this.lblDragon.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(120, 359);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 14;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 359);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(84, 13);
            this.lblNumber.TabIndex = 15;
            this.lblNumber.Text = "Name a Number";
            // 
            // lblNumber2
            // 
            this.lblNumber2.AutoSize = true;
            this.lblNumber2.Location = new System.Drawing.Point(12, 411);
            this.lblNumber2.Name = "lblNumber2";
            this.lblNumber2.Size = new System.Drawing.Size(120, 13);
            this.lblNumber2.TabIndex = 16;
            this.lblNumber2.Text = "Name a second number";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(138, 404);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(427, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.lblNumber2);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblDragon);
            this.Controls.Add(this.btnPress);
            this.Controls.Add(this.txtEST);
            this.Controls.Add(this.txtBodyPart);
            this.Controls.Add(this.txtAnimal);
            this.Controls.Add(this.txtNoun);
            this.Controls.Add(this.txtPlural);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlural;
        private System.Windows.Forms.TextBox txtNoun;
        private System.Windows.Forms.TextBox txtAnimal;
        private System.Windows.Forms.TextBox txtBodyPart;
        private System.Windows.Forms.TextBox txtEST;
        private System.Windows.Forms.Button btnPress;
        private System.Windows.Forms.Label lblDragon;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblNumber2;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

