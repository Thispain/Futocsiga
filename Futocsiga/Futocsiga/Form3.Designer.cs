namespace Futocsiga
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Form3_button1 = new System.Windows.Forms.Button();
            this.Form3_Csiga1 = new System.Windows.Forms.PictureBox();
            this.Form3_Csiga2 = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Form1_label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form3_Csiga1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form3_Csiga2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(456, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 23);
            this.button5.TabIndex = 15;
            this.button5.TabStop = false;
            this.button5.Text = "Kilépés a Játékmódból";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(119, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Várjuk a jelzést!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(938, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 199);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(930, 199);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(260, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Újraindítás";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Tag = "L";
            this.button2.Text = "2. Játékos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // Form3_button1
            // 
            this.Form3_button1.Location = new System.Drawing.Point(173, 279);
            this.Form3_button1.Name = "Form3_button1";
            this.Form3_button1.Size = new System.Drawing.Size(75, 23);
            this.Form3_button1.TabIndex = 16;
            this.Form3_button1.Tag = "A";
            this.Form3_button1.Text = "1. Játékos";
            this.Form3_button1.UseVisualStyleBackColor = true;
            this.Form3_button1.Click += new System.EventHandler(this.button1_Click);
            this.Form3_button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.Form3_button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Form3_Csiga1
            // 
            this.Form3_Csiga1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Form3_Csiga1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Form3_Csiga1.BackgroundImage")));
            this.Form3_Csiga1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Form3_Csiga1.Location = new System.Drawing.Point(30, 151);
            this.Form3_Csiga1.Name = "Form3_Csiga1";
            this.Form3_Csiga1.Size = new System.Drawing.Size(39, 46);
            this.Form3_Csiga1.TabIndex = 23;
            this.Form3_Csiga1.TabStop = false;
            this.Form3_Csiga1.Tag = "1. Játékos";
            this.Form3_Csiga1.Move += new System.EventHandler(this.Csiga1_Move);
            // 
            // Form3_Csiga2
            // 
            this.Form3_Csiga2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Form3_Csiga2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Form3_Csiga2.BackgroundImage")));
            this.Form3_Csiga2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Form3_Csiga2.Location = new System.Drawing.Point(30, 81);
            this.Form3_Csiga2.Name = "Form3_Csiga2";
            this.Form3_Csiga2.Size = new System.Drawing.Size(39, 46);
            this.Form3_Csiga2.TabIndex = 24;
            this.Form3_Csiga2.TabStop = false;
            this.Form3_Csiga2.Tag = "2. Játékos";
            this.Form3_Csiga2.Move += new System.EventHandler(this.Csiga1_Move);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(55, 335);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 25;
            this.numericUpDown1.TabStop = false;
            this.numericUpDown1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // Form1_label2
            // 
            this.Form1_label2.BackColor = System.Drawing.Color.Yellow;
            this.Form1_label2.Location = new System.Drawing.Point(675, 309);
            this.Form1_label2.Name = "Form1_label2";
            this.Form1_label2.Size = new System.Drawing.Size(393, 23);
            this.Form1_label2.TabIndex = 26;
            this.Form1_label2.Tag = "78";
            this.Form1_label2.Text = "Várjuk a jelzést!";
            this.Form1_label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Form1_label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(675, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(393, 23);
            this.label3.TabIndex = 27;
            this.label3.Tag = "86";
            this.label3.Text = "Várjuk a jelzést!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(244, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 23);
            this.label4.TabIndex = 28;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(434, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 23);
            this.label5.TabIndex = 29;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(85, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(122, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Rajt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Form1_label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Form3_Csiga2);
            this.Controls.Add(this.Form3_Csiga1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Form3_button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.HelpButton = true;
            this.IsMdiContainer = true;
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form3_Csiga1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form3_Csiga2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Form3_button1;
        private System.Windows.Forms.PictureBox Form3_Csiga1;
        private System.Windows.Forms.PictureBox Form3_Csiga2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Form1_label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
    }
}