namespace KursSha3
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.HeshButton = new System.Windows.Forms.Button();
            this.CheskHashButton = new System.Windows.Forms.Button();
            this.Hash_TextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.takeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.отриматиХешToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перевіритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.AuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.інструкціяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.іНструкціяПоРоботіЗФайламиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Text_TextBox = new System.Windows.Forms.RichTextBox();
            this.зберегтиХешToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeshButton
            // 
            this.HeshButton.Location = new System.Drawing.Point(594, 28);
            this.HeshButton.Name = "HeshButton";
            this.HeshButton.Size = new System.Drawing.Size(96, 23);
            this.HeshButton.TabIndex = 0;
            this.HeshButton.Text = "Обчислити хеш";
            this.HeshButton.UseVisualStyleBackColor = true;
            this.HeshButton.Click += new System.EventHandler(this.HeshButton_Click);
            // 
            // CheskHashButton
            // 
            this.CheskHashButton.Location = new System.Drawing.Point(594, 57);
            this.CheskHashButton.Name = "CheskHashButton";
            this.CheskHashButton.Size = new System.Drawing.Size(96, 23);
            this.CheskHashButton.TabIndex = 3;
            this.CheskHashButton.Text = "Перевірити";
            this.CheskHashButton.UseVisualStyleBackColor = true;
            this.CheskHashButton.Click += new System.EventHandler(this.CheskHashButton_Click);
            // 
            // Hash_TextBox1
            // 
            this.Hash_TextBox1.Location = new System.Drawing.Point(3, 324);
            this.Hash_TextBox1.Name = "Hash_TextBox1";
            this.Hash_TextBox1.Size = new System.Drawing.Size(585, 42);
            this.Hash_TextBox1.TabIndex = 4;
            this.Hash_TextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(594, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 203);
            this.panel1.TabIndex = 5;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 72);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(43, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "512";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(43, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "384";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "256";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "224";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Очистити";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(691, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeFileToolStripMenuItem,
            this.зберегтиХешToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(49, 22);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // takeFileToolStripMenuItem
            // 
            this.takeFileToolStripMenuItem.Name = "takeFileToolStripMenuItem";
            this.takeFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.takeFileToolStripMenuItem.Text = "Обрати файл";
            this.takeFileToolStripMenuItem.Click += new System.EventHandler(this.takeFileToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отриматиХешToolStripMenuItem,
            this.перевіритиToolStripMenuItem,
            this.очиститиToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(68, 22);
            this.toolStripDropDownButton2.Text = "Операції";
            // 
            // отриматиХешToolStripMenuItem
            // 
            this.отриматиХешToolStripMenuItem.Name = "отриматиХешToolStripMenuItem";
            this.отриматиХешToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.отриматиХешToolStripMenuItem.Text = "Отримати хеш";
            this.отриматиХешToolStripMenuItem.Click += new System.EventHandler(this.отриматиХешToolStripMenuItem_Click);
            // 
            // перевіритиToolStripMenuItem
            // 
            this.перевіритиToolStripMenuItem.Name = "перевіритиToolStripMenuItem";
            this.перевіритиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.перевіритиToolStripMenuItem.Text = "Перевірити";
            this.перевіритиToolStripMenuItem.Click += new System.EventHandler(this.перевіритиToolStripMenuItem_Click);
            // 
            // очиститиToolStripMenuItem
            // 
            this.очиститиToolStripMenuItem.Name = "очиститиToolStripMenuItem";
            this.очиститиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститиToolStripMenuItem.Text = "Очистити";
            this.очиститиToolStripMenuItem.Click += new System.EventHandler(this.очиститиToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorsToolStripMenuItem,
            this.AboutToolStripMenuItem,
            this.інструкціяToolStripMenuItem,
            this.іНструкціяПоРоботіЗФайламиToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(100, 22);
            this.toolStripDropDownButton3.Text = "Про програму";
            // 
            // AuthorsToolStripMenuItem
            // 
            this.AuthorsToolStripMenuItem.Name = "AuthorsToolStripMenuItem";
            this.AuthorsToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.AuthorsToolStripMenuItem.Text = "Автори";
            this.AuthorsToolStripMenuItem.Click += new System.EventHandler(this.AuthorsToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.AboutToolStripMenuItem.Text = "Про програму";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // інструкціяToolStripMenuItem
            // 
            this.інструкціяToolStripMenuItem.Name = "інструкціяToolStripMenuItem";
            this.інструкціяToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.інструкціяToolStripMenuItem.Text = "Інструкція";
            this.інструкціяToolStripMenuItem.Click += new System.EventHandler(this.інструкціяToolStripMenuItem_Click);
            // 
            // іНструкціяПоРоботіЗФайламиToolStripMenuItem
            // 
            this.іНструкціяПоРоботіЗФайламиToolStripMenuItem.Name = "іНструкціяПоРоботіЗФайламиToolStripMenuItem";
            this.іНструкціяПоРоботіЗФайламиToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.іНструкціяПоРоботіЗФайламиToolStripMenuItem.Text = "Інструкція по роботі  з файлами";
            this.іНструкціяПоРоботіЗФайламиToolStripMenuItem.Click += new System.EventHandler(this.іНструкціяПоРоботіЗФайламиToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Text_TextBox
            // 
            this.Text_TextBox.Location = new System.Drawing.Point(3, 28);
            this.Text_TextBox.Name = "Text_TextBox";
            this.Text_TextBox.Size = new System.Drawing.Size(585, 290);
            this.Text_TextBox.TabIndex = 8;
            this.Text_TextBox.Text = "";
            // 
            // зберегтиХешToolStripMenuItem
            // 
            this.зберегтиХешToolStripMenuItem.Name = "зберегтиХешToolStripMenuItem";
            this.зберегтиХешToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.зберегтиХешToolStripMenuItem.Text = "Зберегти хеш";
            this.зберегтиХешToolStripMenuItem.Click += new System.EventHandler(this.зберегтиХешToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 370);
            this.Controls.Add(this.Text_TextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Hash_TextBox1);
            this.Controls.Add(this.CheskHashButton);
            this.Controls.Add(this.HeshButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Візуалізація алгоритму SHA3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HeshButton;
        private System.Windows.Forms.Button CheskHashButton;
        private System.Windows.Forms.RichTextBox Hash_TextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
		private System.Windows.Forms.ToolStripMenuItem AuthorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem отриматиХешToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem перевіритиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem очиститиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem takeFileToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.RichTextBox Text_TextBox;
		private System.Windows.Forms.ToolStripMenuItem інструкціяToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem іНструкціяПоРоботіЗФайламиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиХешToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

