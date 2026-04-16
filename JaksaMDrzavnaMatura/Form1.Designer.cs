namespace JaksaMDrzavnaMatura
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
            this.Ime = new System.Windows.Forms.Label();
            this.DrugiPredmet = new System.Windows.Forms.Label();
            this.TreciPredmet = new System.Windows.Forms.Label();
            this.PrviPredmet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TipDrzavneMature = new System.Windows.Forms.Label();
            this.Skola = new System.Windows.Forms.Label();
            this.Odeljenje = new System.Windows.Forms.Label();
            this.Prezime = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imetp = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Ime
            // 
            this.Ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ime.Location = new System.Drawing.Point(39, 41);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(100, 23);
            this.Ime.TabIndex = 0;
            this.Ime.Text = "Ime";
            this.Ime.Click += new System.EventHandler(this.label1_Click);
            // 
            // DrugiPredmet
            // 
            this.DrugiPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrugiPredmet.Location = new System.Drawing.Point(415, 196);
            this.DrugiPredmet.Name = "DrugiPredmet";
            this.DrugiPredmet.Size = new System.Drawing.Size(118, 23);
            this.DrugiPredmet.TabIndex = 1;
            this.DrugiPredmet.Text = "Drugi predmet:";
            this.DrugiPredmet.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TreciPredmet
            // 
            this.TreciPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreciPredmet.Location = new System.Drawing.Point(750, 196);
            this.TreciPredmet.Name = "TreciPredmet";
            this.TreciPredmet.Size = new System.Drawing.Size(114, 23);
            this.TreciPredmet.TabIndex = 3;
            this.TreciPredmet.Text = "Treci predmet:";
            this.TreciPredmet.Click += new System.EventHandler(this.TreciPredmet_Click);
            // 
            // PrviPredmet
            // 
            this.PrviPredmet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrviPredmet.Location = new System.Drawing.Point(39, 196);
            this.PrviPredmet.Name = "PrviPredmet";
            this.PrviPredmet.Size = new System.Drawing.Size(110, 23);
            this.PrviPredmet.TabIndex = 4;
            this.PrviPredmet.Text = "Prvi Predmet:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(415, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jezik za 2. i 3. predmet:";
            // 
            // TipDrzavneMature
            // 
            this.TipDrzavneMature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipDrzavneMature.Location = new System.Drawing.Point(415, 81);
            this.TipDrzavneMature.Name = "TipDrzavneMature";
            this.TipDrzavneMature.Size = new System.Drawing.Size(151, 23);
            this.TipDrzavneMature.TabIndex = 6;
            this.TipDrzavneMature.Text = "Tip drzavne mature:";
            this.TipDrzavneMature.Click += new System.EventHandler(this.TipDrzavneMature_Click);
            // 
            // Skola
            // 
            this.Skola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Skola.Location = new System.Drawing.Point(415, 41);
            this.Skola.Name = "Skola";
            this.Skola.Size = new System.Drawing.Size(100, 23);
            this.Skola.TabIndex = 7;
            this.Skola.Text = "Skola";
            // 
            // Odeljenje
            // 
            this.Odeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Odeljenje.Location = new System.Drawing.Point(39, 118);
            this.Odeljenje.Name = "Odeljenje";
            this.Odeljenje.Size = new System.Drawing.Size(100, 23);
            this.Odeljenje.TabIndex = 8;
            this.Odeljenje.Text = "Odeljenje";
            // 
            // Prezime
            // 
            this.Prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prezime.Location = new System.Drawing.Point(39, 81);
            this.Prezime.Name = "Prezime";
            this.Prezime.Size = new System.Drawing.Size(100, 23);
            this.Prezime.TabIndex = 9;
            this.Prezime.Text = "Prezime";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(495, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "Sacuvaj";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(12, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 67);
            this.button2.TabIndex = 11;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Location = new System.Drawing.Point(1064, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 67);
            this.button3.TabIndex = 12;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button5.Location = new System.Drawing.Point(268, 424);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 41);
            this.button5.TabIndex = 14;
            this.button5.Text = "Napravi template";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(469, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(429, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(539, 198);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(155, 198);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(238, 21);
            this.comboBox3.TabIndex = 17;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(596, 118);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(302, 21);
            this.comboBox4.TabIndex = 18;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(572, 83);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(326, 21);
            this.comboBox5.TabIndex = 19;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(870, 196);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(269, 21);
            this.comboBox6.TabIndex = 20;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(181, 20);
            this.textBox3.TabIndex = 23;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(560, 435);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(184, 21);
            this.comboBox7.TabIndex = 25;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Izaberi te template";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "nazovi te template";
            // 
            // imetp
            // 
            this.imetp.Location = new System.Drawing.Point(244, 365);
            this.imetp.Name = "imetp";
            this.imetp.Size = new System.Drawing.Size(100, 20);
            this.imetp.TabIndex = 29;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button7.Location = new System.Drawing.Point(672, 257);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 53);
            this.button7.TabIndex = 30;
            this.button7.Text = "izmeni";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(764, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "izaberi te ucenika";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(860, 370);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(191, 21);
            this.comboBox8.TabIndex = 32;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1151, 523);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.imetp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Prezime);
            this.Controls.Add(this.Odeljenje);
            this.Controls.Add(this.Skola);
            this.Controls.Add(this.TipDrzavneMature);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrviPredmet);
            this.Controls.Add(this.TreciPredmet);
            this.Controls.Add(this.DrugiPredmet);
            this.Controls.Add(this.Ime);
            this.Name = "Form1";
            this.Text = "Formular za drzavnu maturu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ime;
        private System.Windows.Forms.Label DrugiPredmet;
        private System.Windows.Forms.Label TreciPredmet;
        private System.Windows.Forms.Label PrviPredmet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TipDrzavneMature;
        private System.Windows.Forms.Label Skola;
        private System.Windows.Forms.Label Odeljenje;
        private System.Windows.Forms.Label Prezime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox imetp;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox8;
    }
}

