namespace Futocsiga
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Form1_Csiga1 = new System.Windows.Forms.PictureBox();
            this.La_Player_1 = new System.Windows.Forms.Button();
            this.Form1_Csiga2 = new System.Windows.Forms.PictureBox();
            this.Form1_Csiga3 = new System.Windows.Forms.PictureBox();
            this.La_Player_2 = new System.Windows.Forms.Button();
            this.La_Player_3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.La_Reset = new System.Windows.Forms.Button();
            this.Pb_Finish = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.La_out = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.La_Start = new System.Windows.Forms.Button();
            this.La_Game1 = new System.Windows.Forms.Label();
            this.La_Game2 = new System.Windows.Forms.Label();
            this.La_Game3 = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.La_Exit1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Form1_Csiga1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form1_Csiga2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form1_Csiga3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Finish)).BeginInit();
            this.SuspendLayout();
            // 
            // Form1_Csiga1
            // 
            this.Form1_Csiga1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.Form1_Csiga1, "Form1_Csiga1");
            this.Form1_Csiga1.Name = "Form1_Csiga1";
            this.Form1_Csiga1.TabStop = false;
            this.Form1_Csiga1.Tag = "1. Játékos";
            this.Form1_Csiga1.Move += new System.EventHandler(this.Csiga1_Move);
            // 
            // La_Player_1
            // 
            resources.ApplyResources(this.La_Player_1, "La_Player_1");
            this.La_Player_1.Name = "La_Player_1";
            this.La_Player_1.Tag = "A";
            this.La_Player_1.UseVisualStyleBackColor = true;
            this.La_Player_1.Click += new System.EventHandler(this.button1_Click_1);
            this.La_Player_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.La_Player_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.La_Player_1_KeyPress);
            this.La_Player_1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Form1_Csiga2
            // 
            this.Form1_Csiga2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.Form1_Csiga2, "Form1_Csiga2");
            this.Form1_Csiga2.Name = "Form1_Csiga2";
            this.Form1_Csiga2.TabStop = false;
            this.Form1_Csiga2.Tag = "2. Játékos";
            this.Form1_Csiga2.Move += new System.EventHandler(this.Csiga1_Move);
            // 
            // Form1_Csiga3
            // 
            this.Form1_Csiga3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.Form1_Csiga3, "Form1_Csiga3");
            this.Form1_Csiga3.Name = "Form1_Csiga3";
            this.Form1_Csiga3.TabStop = false;
            this.Form1_Csiga3.Tag = "3. Játékos";
            this.Form1_Csiga3.Move += new System.EventHandler(this.Csiga1_Move);
            // 
            // La_Player_2
            // 
            resources.ApplyResources(this.La_Player_2, "La_Player_2");
            this.La_Player_2.Name = "La_Player_2";
            this.La_Player_2.Tag = "H";
            this.La_Player_2.UseVisualStyleBackColor = true;
            this.La_Player_2.Click += new System.EventHandler(this.button1_Click_1);
            this.La_Player_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.La_Player_2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // La_Player_3
            // 
            resources.ApplyResources(this.La_Player_3, "La_Player_3");
            this.La_Player_3.Name = "La_Player_3";
            this.La_Player_3.Tag = "L";
            this.La_Player_3.UseVisualStyleBackColor = true;
            this.La_Player_3.Click += new System.EventHandler(this.button1_Click_1);
            this.La_Player_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.La_Player_3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button3_MouseClick);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // La_Reset
            // 
            resources.ApplyResources(this.La_Reset, "La_Reset");
            this.La_Reset.Name = "La_Reset";
            this.La_Reset.UseVisualStyleBackColor = true;
            this.La_Reset.Click += new System.EventHandler(this.button4_Click);
            // 
            // Pb_Finish
            // 
            resources.ApplyResources(this.Pb_Finish, "Pb_Finish");
            this.Pb_Finish.Name = "Pb_Finish";
            this.Pb_Finish.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // La_out
            // 
            resources.ApplyResources(this.La_out, "La_out");
            this.La_out.Name = "La_out";
            this.La_out.TabStop = false;
            this.La_out.UseVisualStyleBackColor = true;
            this.La_out.Click += new System.EventHandler(this.button5_Click);
            this.La_out.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Tag = "3";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Tag = "2";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Tag = "5";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // La_Start
            // 
            resources.ApplyResources(this.La_Start, "La_Start");
            this.La_Start.Name = "La_Start";
            this.La_Start.UseVisualStyleBackColor = true;
            this.La_Start.Click += new System.EventHandler(this.button6_Click);
            // 
            // La_Game1
            // 
            this.La_Game1.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.La_Game1, "La_Game1");
            this.La_Game1.Name = "La_Game1";
            // 
            // La_Game2
            // 
            this.La_Game2.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.La_Game2, "La_Game2");
            this.La_Game2.Name = "La_Game2";
            // 
            // La_Game3
            // 
            this.La_Game3.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.La_Game3, "La_Game3");
            this.La_Game3.Name = "La_Game3";
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.Help, "Help");
            this.Help.Name = "Help";
            this.Help.Click += new System.EventHandler(this.label8_Click);
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.TabStop = false;
            this.button7.Tag = "";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_Click_1);
            this.button7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            // 
            // La_Exit1
            // 
            resources.ApplyResources(this.La_Exit1, "La_Exit1");
            this.La_Exit1.Name = "La_Exit1";
            this.La_Exit1.UseVisualStyleBackColor = true;
            this.La_Exit1.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.La_Exit1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.La_Game3);
            this.Controls.Add(this.La_Game2);
            this.Controls.Add(this.La_Game1);
            this.Controls.Add(this.La_Start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Form1_Csiga3);
            this.Controls.Add(this.Form1_Csiga2);
            this.Controls.Add(this.Form1_Csiga1);
            this.Controls.Add(this.La_out);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.La_Reset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.La_Player_3);
            this.Controls.Add(this.La_Player_2);
            this.Controls.Add(this.La_Player_1);
            this.Controls.Add(this.Pb_Finish);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Tag = "1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Form1_Csiga1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form1_Csiga2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Form1_Csiga3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Finish)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Form1_Csiga1;
        private System.Windows.Forms.Button La_Player_1;
        private System.Windows.Forms.PictureBox Form1_Csiga2;
        private System.Windows.Forms.PictureBox Form1_Csiga3;
        private System.Windows.Forms.Button La_Player_2;
        private System.Windows.Forms.Button La_Player_3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button La_Reset;
        private System.Windows.Forms.PictureBox Pb_Finish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button La_out;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button La_Start;
        private System.Windows.Forms.Label La_Game1;
        private System.Windows.Forms.Label La_Game2;
        private System.Windows.Forms.Label La_Game3;
        private System.Windows.Forms.Label Help;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button La_Exit1;
    }
}

