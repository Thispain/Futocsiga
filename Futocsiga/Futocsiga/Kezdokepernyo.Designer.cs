namespace Futocsiga
{
    partial class Kezdokepernyo
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
            this.BT_Kilepes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_EvT = new System.Windows.Forms.ComboBox();
            this.BT_Play = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Bt_NewData = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bt_Push = new System.Windows.Forms.Button();
            this.nUP_JatekosSzam = new System.Windows.Forms.NumericUpDown();
            this.La_SingleOrMulty = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Bt_Setup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUP_JatekosSzam)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BT_Kilepes
            // 
            this.BT_Kilepes.Location = new System.Drawing.Point(8, 526);
            this.BT_Kilepes.Name = "BT_Kilepes";
            this.BT_Kilepes.Size = new System.Drawing.Size(102, 24);
            this.BT_Kilepes.TabIndex = 4;
            this.BT_Kilepes.Text = "Kilépés";
            this.BT_Kilepes.UseVisualStyleBackColor = true;
            this.BT_Kilepes.Click += new System.EventHandler(this.BT_Kilepes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Játékosok száma:";
            // 
            // CB_EvT
            // 
            this.CB_EvT.FormattingEnabled = true;
            this.CB_EvT.Items.AddRange(new object[] {
            "Minden játékos egy gépnél",
            "Minden játékos több gépnél"});
            this.CB_EvT.Location = new System.Drawing.Point(33, 167);
            this.CB_EvT.Name = "CB_EvT";
            this.CB_EvT.Size = new System.Drawing.Size(121, 21);
            this.CB_EvT.TabIndex = 8;
            this.CB_EvT.Text = "-- Válassz --";
            this.CB_EvT.Visible = false;
            // 
            // BT_Play
            // 
            this.BT_Play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_Play.Location = new System.Drawing.Point(381, 349);
            this.BT_Play.Name = "BT_Play";
            this.BT_Play.Size = new System.Drawing.Size(103, 23);
            this.BT_Play.TabIndex = 10;
            this.BT_Play.Text = "Játék indítása";
            this.BT_Play.UseVisualStyleBackColor = true;
            this.BT_Play.Click += new System.EventHandler(this.BT_Play_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(511, 419);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Bt_NewData);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.BT_Play);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Bt_Push);
            this.tabPage1.Controls.Add(this.nUP_JatekosSzam);
            this.tabPage1.Controls.Add(this.La_SingleOrMulty);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CB_EvT);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(503, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Játék létrehozása";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Bt_NewData
            // 
            this.Bt_NewData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_NewData.Location = new System.Drawing.Point(393, 247);
            this.Bt_NewData.Name = "Bt_NewData";
            this.Bt_NewData.Size = new System.Drawing.Size(91, 37);
            this.Bt_NewData.TabIndex = 12;
            this.Bt_NewData.Text = "Új adathalmaz létrehozása";
            this.Bt_NewData.UseVisualStyleBackColor = true;
            this.Bt_NewData.Click += new System.EventHandler(this.Bt_NewData_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(306, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(178, 147);
            this.listBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kiválasztott adathalmazok:";
            // 
            // Bt_Push
            // 
            this.Bt_Push.Location = new System.Drawing.Point(306, 247);
            this.Bt_Push.Name = "Bt_Push";
            this.Bt_Push.Size = new System.Drawing.Size(81, 37);
            this.Bt_Push.TabIndex = 13;
            this.Bt_Push.Text = "Adathalmaz Kiválasztása";
            this.Bt_Push.UseVisualStyleBackColor = true;
            this.Bt_Push.Click += new System.EventHandler(this.Bt_Push_Click);
            // 
            // nUP_JatekosSzam
            // 
            this.nUP_JatekosSzam.Location = new System.Drawing.Point(156, 33);
            this.nUP_JatekosSzam.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUP_JatekosSzam.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUP_JatekosSzam.Name = "nUP_JatekosSzam";
            this.nUP_JatekosSzam.Size = new System.Drawing.Size(120, 20);
            this.nUP_JatekosSzam.TabIndex = 11;
            this.nUP_JatekosSzam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUP_JatekosSzam.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // La_SingleOrMulty
            // 
            this.La_SingleOrMulty.AutoSize = true;
            this.La_SingleOrMulty.Location = new System.Drawing.Point(282, 36);
            this.La_SingleOrMulty.Name = "La_SingleOrMulty";
            this.La_SingleOrMulty.Size = new System.Drawing.Size(79, 13);
            this.La_SingleOrMulty.TabIndex = 10;
            this.La_SingleOrMulty.Text = "Egyjátékosmód";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(503, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Játék keresése";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(56, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(202, 170);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(236, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Csatlakozás kód alapján:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Csatlakozás";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(503, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "?";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Bt_Setup
            // 
            this.Bt_Setup.Location = new System.Drawing.Point(591, 527);
            this.Bt_Setup.Name = "Bt_Setup";
            this.Bt_Setup.Size = new System.Drawing.Size(75, 23);
            this.Bt_Setup.TabIndex = 16;
            this.Bt_Setup.Text = "Beállítások";
            this.Bt_Setup.UseVisualStyleBackColor = true;
            this.Bt_Setup.Click += new System.EventHandler(this.Bt_Setup_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Szerkesztés";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Kezdokepernyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 561);
            this.Controls.Add(this.Bt_Setup);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BT_Kilepes);
            this.Name = "Kezdokepernyo";
            this.Text = "Kezdokepernyo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kezdokepernyo_FormClosing);
            this.Load += new System.EventHandler(this.Kezdokepernyo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUP_JatekosSzam)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BT_Kilepes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_EvT;
        private System.Windows.Forms.Button BT_Play;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown nUP_JatekosSzam;
        private System.Windows.Forms.Label La_SingleOrMulty;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Bt_NewData;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bt_Push;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Bt_Setup;
        private System.Windows.Forms.Button button1;
    }
}