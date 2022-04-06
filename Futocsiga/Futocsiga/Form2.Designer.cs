namespace Futocsiga
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Bt_Exit = new System.Windows.Forms.Button();
            this.La_Pyss = new System.Windows.Forms.Label();
            this.Bt_Restart = new System.Windows.Forms.Button();
            this.Csiga1 = new System.Windows.Forms.PictureBox();
            this.Csiga2 = new System.Windows.Forms.PictureBox();
            this.Csiga3 = new System.Windows.Forms.PictureBox();
            this.PB_Palya = new System.Windows.Forms.PictureBox();
            this.Bt_Py1 = new System.Windows.Forms.Button();
            this.PB_Cel = new System.Windows.Forms.PictureBox();
            this.PyB_Py1_Csiga = new System.Windows.Forms.PictureBox();
            this.La_Py1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.La_Support = new System.Windows.Forms.Label();
            this.Bt_Rajt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Csiga1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Csiga2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Csiga3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Palya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Cel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PyB_Py1_Csiga)).BeginInit();
            this.SuspendLayout();
            // 
            // Bt_Exit
            // 
            this.Bt_Exit.Location = new System.Drawing.Point(379, 391);
            this.Bt_Exit.Name = "Bt_Exit";
            this.Bt_Exit.Size = new System.Drawing.Size(141, 23);
            this.Bt_Exit.TabIndex = 20;
            this.Bt_Exit.TabStop = false;
            this.Bt_Exit.Text = "Kilépés a Játékmódból";
            this.Bt_Exit.UseVisualStyleBackColor = true;
            this.Bt_Exit.Click += new System.EventHandler(this.button5_Click);
            this.Bt_Exit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // La_Pyss
            // 
            this.La_Pyss.BackColor = System.Drawing.Color.Yellow;
            this.La_Pyss.Location = new System.Drawing.Point(42, 259);
            this.La_Pyss.Name = "La_Pyss";
            this.La_Pyss.Size = new System.Drawing.Size(393, 23);
            this.La_Pyss.TabIndex = 19;
            this.La_Pyss.Text = "Várom a jelzést!";
            this.La_Pyss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bt_Restart
            // 
            this.Bt_Restart.Location = new System.Drawing.Point(209, 391);
            this.Bt_Restart.Name = "Bt_Restart";
            this.Bt_Restart.Size = new System.Drawing.Size(75, 23);
            this.Bt_Restart.TabIndex = 0;
            this.Bt_Restart.Text = "Újraindítás";
            this.Bt_Restart.UseVisualStyleBackColor = true;
            this.Bt_Restart.Visible = false;
            this.Bt_Restart.Click += new System.EventHandler(this.button4_Click);
            this.Bt_Restart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // Csiga1
            // 
            this.Csiga1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Csiga1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Csiga1.BackgroundImage")));
            this.Csiga1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Csiga1.Location = new System.Drawing.Point(-43, 181);
            this.Csiga1.Name = "Csiga1";
            this.Csiga1.Size = new System.Drawing.Size(39, 46);
            this.Csiga1.TabIndex = 11;
            this.Csiga1.TabStop = false;
            // 
            // Csiga2
            // 
            this.Csiga2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Csiga2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Csiga2.BackgroundImage")));
            this.Csiga2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Csiga2.Location = new System.Drawing.Point(-43, 127);
            this.Csiga2.Name = "Csiga2";
            this.Csiga2.Size = new System.Drawing.Size(39, 48);
            this.Csiga2.TabIndex = 13;
            this.Csiga2.TabStop = false;
            // 
            // Csiga3
            // 
            this.Csiga3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Csiga3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Csiga3.BackgroundImage")));
            this.Csiga3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Csiga3.Location = new System.Drawing.Point(-43, 74);
            this.Csiga3.Name = "Csiga3";
            this.Csiga3.Size = new System.Drawing.Size(39, 47);
            this.Csiga3.TabIndex = 14;
            this.Csiga3.TabStop = false;
            // 
            // PB_Palya
            // 
            this.PB_Palya.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Palya.BackgroundImage")));
            this.PB_Palya.Location = new System.Drawing.Point(19, 37);
            this.PB_Palya.Name = "PB_Palya";
            this.PB_Palya.Size = new System.Drawing.Size(930, 199);
            this.PB_Palya.TabIndex = 17;
            this.PB_Palya.TabStop = false;
            // 
            // Bt_Py1
            // 
            this.Bt_Py1.Location = new System.Drawing.Point(209, 302);
            this.Bt_Py1.Name = "Bt_Py1";
            this.Bt_Py1.Size = new System.Drawing.Size(75, 23);
            this.Bt_Py1.TabIndex = 15;
            this.Bt_Py1.TabStop = false;
            this.Bt_Py1.Tag = "A";
            this.Bt_Py1.Text = "1. Játékos";
            this.Bt_Py1.UseVisualStyleBackColor = true;
            this.Bt_Py1.Click += new System.EventHandler(this.button1_Click);
            this.Bt_Py1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // PB_Cel
            // 
            this.PB_Cel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB_Cel.BackgroundImage")));
            this.PB_Cel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Cel.Location = new System.Drawing.Point(871, 37);
            this.PB_Cel.Name = "PB_Cel";
            this.PB_Cel.Size = new System.Drawing.Size(163, 199);
            this.PB_Cel.TabIndex = 21;
            this.PB_Cel.TabStop = false;
            // 
            // PyB_Py1_Csiga
            // 
            this.PyB_Py1_Csiga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PyB_Py1_Csiga.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PyB_Py1_Csiga.BackgroundImage")));
            this.PyB_Py1_Csiga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PyB_Py1_Csiga.Location = new System.Drawing.Point(45, 165);
            this.PyB_Py1_Csiga.Name = "PyB_Py1_Csiga";
            this.PyB_Py1_Csiga.Size = new System.Drawing.Size(39, 46);
            this.PyB_Py1_Csiga.TabIndex = 22;
            this.PyB_Py1_Csiga.TabStop = false;
            this.PyB_Py1_Csiga.Tag = "1. Játékos";
            this.PyB_Py1_Csiga.Move += new System.EventHandler(this.pictureBox3_Move);
            // 
            // La_Py1
            // 
            this.La_Py1.BackColor = System.Drawing.Color.Yellow;
            this.La_Py1.Location = new System.Drawing.Point(556, 325);
            this.La_Py1.Name = "La_Py1";
            this.La_Py1.Size = new System.Drawing.Size(393, 23);
            this.La_Py1.TabIndex = 23;
            this.La_Py1.Text = "Várom a jelzést!";
            this.La_Py1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.La_Py1.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(290, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 23);
            this.label3.TabIndex = 24;
            this.label3.Tag = "1";
            this.label3.Text = "A";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // La_Support
            // 
            this.La_Support.BackColor = System.Drawing.Color.Yellow;
            this.La_Support.Location = new System.Drawing.Point(12, 259);
            this.La_Support.Name = "La_Support";
            this.La_Support.Size = new System.Drawing.Size(23, 23);
            this.La_Support.TabIndex = 25;
            this.La_Support.Text = "?";
            this.La_Support.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.La_Support.Visible = false;
            this.La_Support.Click += new System.EventHandler(this.label4_Click);
            // 
            // Bt_Rajt
            // 
            this.Bt_Rajt.Location = new System.Drawing.Point(45, 391);
            this.Bt_Rajt.Name = "Bt_Rajt";
            this.Bt_Rajt.Size = new System.Drawing.Size(75, 23);
            this.Bt_Rajt.TabIndex = 26;
            this.Bt_Rajt.TabStop = false;
            this.Bt_Rajt.Text = "Rajt";
            this.Bt_Rajt.UseVisualStyleBackColor = true;
            this.Bt_Rajt.Visible = false;
            this.Bt_Rajt.Click += new System.EventHandler(this.button6_Click);
            this.Bt_Rajt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.Bt_Rajt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 450);
            this.Controls.Add(this.Bt_Rajt);
            this.Controls.Add(this.La_Support);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.La_Py1);
            this.Controls.Add(this.PyB_Py1_Csiga);
            this.Controls.Add(this.PB_Cel);
            this.Controls.Add(this.Bt_Exit);
            this.Controls.Add(this.La_Pyss);
            this.Controls.Add(this.Bt_Restart);
            this.Controls.Add(this.Csiga1);
            this.Controls.Add(this.Csiga2);
            this.Controls.Add(this.Csiga3);
            this.Controls.Add(this.PB_Palya);
            this.Controls.Add(this.Bt_Py1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Csiga1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Csiga2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Csiga3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Palya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Cel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PyB_Py1_Csiga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bt_Exit;
        private System.Windows.Forms.Label La_Pyss;
        private System.Windows.Forms.Button Bt_Restart;
        private System.Windows.Forms.PictureBox Csiga1;
        private System.Windows.Forms.PictureBox Csiga2;
        private System.Windows.Forms.PictureBox Csiga3;
        private System.Windows.Forms.PictureBox PB_Palya;
        private System.Windows.Forms.Button Bt_Py1;
        private System.Windows.Forms.PictureBox PB_Cel;
        private System.Windows.Forms.PictureBox PyB_Py1_Csiga;
        private System.Windows.Forms.Label La_Py1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label La_Support;
        private System.Windows.Forms.Button Bt_Rajt;
        private System.Windows.Forms.Timer timer1;
    }
}