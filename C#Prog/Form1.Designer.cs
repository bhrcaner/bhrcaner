namespace WinFormsTest1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonMesajGörüntüle = new Button();
            textBoxMesaj = new TextBox();
            buttonMesajSil = new Button();
            comboBoxIsimler = new ComboBox();
            buttonIsimEkle = new Button();
            labelYazılanIsim = new Label();
            buttonLabeldeğişitir = new Button();
            listBoxKişiler = new ListBox();
            richTextBoxMetin = new RichTextBox();
            buttonRichTextBox = new Button();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            trackBarVolume = new TrackBar();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox6 = new GroupBox();
            panel1 = new Panel();
            groupBoxpencere = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            panel1.SuspendLayout();
            groupBoxpencere.SuspendLayout();
            SuspendLayout();
            // 
            // buttonMesajGörüntüle
            // 
            buttonMesajGörüntüle.Location = new Point(12, 22);
            buttonMesajGörüntüle.Name = "buttonMesajGörüntüle";
            buttonMesajGörüntüle.Size = new Size(114, 24);
            buttonMesajGörüntüle.TabIndex = 0;
            buttonMesajGörüntüle.Text = "İletiyi yaz";
            buttonMesajGörüntüle.UseVisualStyleBackColor = true;
            buttonMesajGörüntüle.Click += button1_Click;
            // 
            // textBoxMesaj
            // 
            textBoxMesaj.Location = new Point(132, 23);
            textBoxMesaj.Name = "textBoxMesaj";
            textBoxMesaj.Size = new Size(173, 23);
            textBoxMesaj.TabIndex = 1;
            // 
            // buttonMesajSil
            // 
            buttonMesajSil.Location = new Point(12, 57);
            buttonMesajSil.Name = "buttonMesajSil";
            buttonMesajSil.Size = new Size(114, 25);
            buttonMesajSil.TabIndex = 2;
            buttonMesajSil.Text = "Sil";
            buttonMesajSil.UseVisualStyleBackColor = true;
            buttonMesajSil.Click += button1_Click_1;
            // 
            // comboBoxIsimler
            // 
            comboBoxIsimler.FormattingEnabled = true;
            comboBoxIsimler.Items.AddRange(new object[] { "Alp veli", "Ayşe kaya", "Şen türk" });
            comboBoxIsimler.Location = new Point(132, 57);
            comboBoxIsimler.Name = "comboBoxIsimler";
            comboBoxIsimler.Size = new Size(173, 23);
            comboBoxIsimler.TabIndex = 3;
            // 
            // buttonIsimEkle
            // 
            buttonIsimEkle.Location = new Point(182, 493);
            buttonIsimEkle.Name = "buttonIsimEkle";
            buttonIsimEkle.Size = new Size(102, 23);
            buttonIsimEkle.TabIndex = 4;
            buttonIsimEkle.Text = "İsmi Komboya Ekle";
            buttonIsimEkle.UseVisualStyleBackColor = true;
            buttonIsimEkle.Click += buttonİsimEkle_Click;
            // 
            // labelYazılanIsim
            // 
            labelYazılanIsim.AutoSize = true;
            labelYazılanIsim.BackColor = Color.FromArgb(255, 192, 128);
            labelYazılanIsim.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelYazılanIsim.Location = new Point(81, 241);
            labelYazılanIsim.Name = "labelYazılanIsim";
            labelYazılanIsim.Size = new Size(74, 30);
            labelYazılanIsim.TabIndex = 5;
            labelYazılanIsim.Text = "Space";
            labelYazılanIsim.Click += label1_Click;
            // 
            // buttonLabeldeğişitir
            // 
            buttonLabeldeğişitir.Location = new Point(53, 167);
            buttonLabeldeğişitir.Name = "buttonLabeldeğişitir";
            buttonLabeldeğişitir.Size = new Size(129, 38);
            buttonLabeldeğişitir.TabIndex = 6;
            buttonLabeldeğişitir.Text = "Label Değiştir";
            buttonLabeldeğişitir.UseVisualStyleBackColor = true;
            buttonLabeldeğişitir.Click += buttonLabeldeğişitir_Click;
            // 
            // listBoxKişiler
            // 
            listBoxKişiler.BackColor = Color.White;
            listBoxKişiler.FormattingEnabled = true;
            listBoxKişiler.ItemHeight = 15;
            listBoxKişiler.Items.AddRange(new object[] { "Matematik", "Fizik", "Kimya", "Biyoloji" });
            listBoxKişiler.Location = new Point(146, 23);
            listBoxKişiler.Name = "listBoxKişiler";
            listBoxKişiler.Size = new Size(138, 469);
            listBoxKişiler.TabIndex = 7;
            // 
            // richTextBoxMetin
            // 
            richTextBoxMetin.Location = new Point(6, 24);
            richTextBoxMetin.Name = "richTextBoxMetin";
            richTextBoxMetin.Size = new Size(134, 468);
            richTextBoxMetin.TabIndex = 8;
            richTextBoxMetin.Text = "Hello c#\nMerhaba c#";
            // 
            // buttonRichTextBox
            // 
            buttonRichTextBox.Location = new Point(27, 493);
            buttonRichTextBox.Name = "buttonRichTextBox";
            buttonRichTextBox.Size = new Size(95, 23);
            buttonRichTextBox.TabIndex = 9;
            buttonRichTextBox.Text = "button1";
            buttonRichTextBox.UseVisualStyleBackColor = true;
            buttonRichTextBox.Click += buttonRichTextBox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(774, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(20, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(167, 23);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // trackBarVolume
            // 
            trackBarVolume.BackColor = SystemColors.AppWorkspace;
            trackBarVolume.Location = new Point(51, 73);
            trackBarVolume.Maximum = 100;
            trackBarVolume.Name = "trackBarVolume";
            trackBarVolume.Size = new Size(104, 45);
            trackBarVolume.TabIndex = 12;
            trackBarVolume.Scroll += trackBarVolume_Scroll;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(14, 22);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 19);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Sayısal";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(14, 64);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(53, 19);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "Sözel";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(13, 111);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(81, 19);
            checkBox3.TabIndex = 15;
            checkBox3.Text = "Eşit Ağırlık";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Location = new Point(28, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(99, 205);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "İçindekiler";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxIsimler);
            groupBox2.Controls.Add(buttonMesajSil);
            groupBox2.Controls.Add(textBoxMesaj);
            groupBox2.Controls.Add(buttonMesajGörüntüle);
            groupBox2.Location = new Point(18, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(318, 88);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sınıflar";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonRichTextBox);
            groupBox3.Controls.Add(richTextBoxMetin);
            groupBox3.Controls.Add(listBoxKişiler);
            groupBox3.Controls.Add(buttonIsimEkle);
            groupBox3.Location = new Point(342, 45);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(302, 554);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "İsimler";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonLabeldeğişitir);
            groupBox4.Controls.Add(labelYazılanIsim);
            groupBox4.Location = new Point(43, 176);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(233, 385);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "İsimleri Değiştir";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(6, 21);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(64, 19);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "Seviye1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 61);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(64, 19);
            radioButton2.TabIndex = 22;
            radioButton2.Text = "Seviye2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 104);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(64, 19);
            radioButton3.TabIndex = 23;
            radioButton3.Text = "Seviye3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(radioButton1);
            groupBox6.Controls.Add(radioButton3);
            groupBox6.Controls.Add(radioButton2);
            groupBox6.Location = new Point(156, 9);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(80, 199);
            groupBox6.TabIndex = 24;
            groupBox6.TabStop = false;
            groupBox6.Text = "GrupBox";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(groupBoxpencere);
            panel1.Controls.Add(groupBox6);
            panel1.Controls.Add(groupBox1);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(650, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 549);
            panel1.TabIndex = 25;
            // 
            // groupBoxpencere
            // 
            groupBoxpencere.Controls.Add(dateTimePicker1);
            groupBoxpencere.Controls.Add(trackBarVolume);
            groupBoxpencere.Location = new Point(29, 214);
            groupBoxpencere.Name = "groupBoxpencere";
            groupBoxpencere.Size = new Size(205, 384);
            groupBoxpencere.TabIndex = 25;
            groupBoxpencere.TabStop = false;
            groupBoxpencere.Text = "Tarih ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(883, 602);
            Controls.Add(panel1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarVolume).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panel1.ResumeLayout(false);
            groupBoxpencere.ResumeLayout(false);
            groupBoxpencere.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonMesajGörüntüle;
        private TextBox textBoxMesaj;
        private Button buttonMesajSil;
        private ComboBox comboBoxIsimler;
        private Button buttonIsimEkle;
        private Label labelYazılanIsim;
        private Button buttonLabeldeğişitir;
        private ListBox listBoxKişiler;
        private RichTextBox richTextBoxMetin;
        private Button buttonRichTextBox;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private TrackBar trackBarVolume;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox6;
        private Panel panel1;
        private GroupBox groupBoxpencere;
    }
}