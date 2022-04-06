
namespace Futocsiga
{
    partial class Fuel
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
            this.Bt_Kesz = new System.Windows.Forms.Button();
            this.ProgB_Energiaszint = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.T_Effect = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.La_Helyes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.La_Probalkozas = new System.Windows.Forms.Label();
            this.Tb_Valasz = new System.Windows.Forms.MaskedTextBox();
            this.Kr_Pont = new System.Windows.Forms.Label();
            this.Kr_Kerdes = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bt_Kesz
            // 
            this.Bt_Kesz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Bt_Kesz.Location = new System.Drawing.Point(314, 189);
            this.Bt_Kesz.Name = "Bt_Kesz";
            this.Bt_Kesz.Size = new System.Drawing.Size(75, 23);
            this.Bt_Kesz.TabIndex = 3;
            this.Bt_Kesz.Text = "Kész";
            this.Bt_Kesz.UseVisualStyleBackColor = true;
            this.Bt_Kesz.Click += new System.EventHandler(this.Bt_Kesz_Click);
            // 
            // ProgB_Energiaszint
            // 
            this.ProgB_Energiaszint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgB_Energiaszint.Location = new System.Drawing.Point(90, 189);
            this.ProgB_Energiaszint.Name = "ProgB_Energiaszint";
            this.ProgB_Energiaszint.Size = new System.Drawing.Size(100, 23);
            this.ProgB_Energiaszint.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Energiaszint:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "/";
            // 
            // T_Effect
            // 
            this.T_Effect.Interval = 250;
            this.T_Effect.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 170);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.La_Helyes);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.La_Probalkozas);
            this.tabPage1.Controls.Add(this.Tb_Valasz);
            this.tabPage1.Controls.Add(this.Kr_Pont);
            this.tabPage1.Controls.Add(this.Kr_Kerdes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(385, 144);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quest";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(385, 144);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cookie clicker";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // La_Helyes
            // 
            this.La_Helyes.BackColor = System.Drawing.Color.Silver;
            this.La_Helyes.Location = new System.Drawing.Point(32, 104);
            this.La_Helyes.Name = "La_Helyes";
            this.La_Helyes.Size = new System.Drawing.Size(13, 13);
            this.La_Helyes.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Válasz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // La_Probalkozas
            // 
            this.La_Probalkozas.AutoSize = true;
            this.La_Probalkozas.Location = new System.Drawing.Point(248, 104);
            this.La_Probalkozas.Name = "La_Probalkozas";
            this.La_Probalkozas.Size = new System.Drawing.Size(24, 13);
            this.La_Probalkozas.TabIndex = 13;
            this.La_Probalkozas.Text = "0/3";
            // 
            // Tb_Valasz
            // 
            this.Tb_Valasz.Location = new System.Drawing.Point(51, 101);
            this.Tb_Valasz.Name = "Tb_Valasz";
            this.Tb_Valasz.Size = new System.Drawing.Size(190, 20);
            this.Tb_Valasz.TabIndex = 12;
            // 
            // Kr_Pont
            // 
            this.Kr_Pont.AutoSize = true;
            this.Kr_Pont.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Kr_Pont.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kr_Pont.ForeColor = System.Drawing.Color.Red;
            this.Kr_Pont.Location = new System.Drawing.Point(269, 20);
            this.Kr_Pont.Name = "Kr_Pont";
            this.Kr_Pont.Size = new System.Drawing.Size(14, 13);
            this.Kr_Pont.TabIndex = 11;
            this.Kr_Pont.Text = "0";
            // 
            // Kr_Kerdes
            // 
            this.Kr_Kerdes.AutoSize = true;
            this.Kr_Kerdes.Location = new System.Drawing.Point(23, 20);
            this.Kr_Kerdes.Name = "Kr_Kerdes";
            this.Kr_Kerdes.Size = new System.Drawing.Size(35, 13);
            this.Kr_Kerdes.TabIndex = 10;
            this.Kr_Kerdes.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(316, 103);
            this.button2.TabIndex = 0;
            this.button2.Text = "Süti";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Fuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 224);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProgB_Energiaszint);
            this.Controls.Add(this.Bt_Kesz);
            this.Name = "Fuel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fuel";
            this.Load += new System.EventHandler(this.Fuel_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Bt_Kesz;
        private System.Windows.Forms.ProgressBar ProgB_Energiaszint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer T_Effect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label La_Helyes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label La_Probalkozas;
        private System.Windows.Forms.MaskedTextBox Tb_Valasz;
        private System.Windows.Forms.Label Kr_Pont;
        private System.Windows.Forms.Label Kr_Kerdes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
    }
}