namespace TextApp
{
    partial class WordsConstuctorForm
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
            autoSpaceCBox = new CheckBox();
            indexPickerComboBox = new ComboBox();
            deleteWordByIndexBtn = new Button();
            addSentenceTextBox = new TextBox();
            addWordBtn = new Button();
            richTextBox1 = new RichTextBox();
            createSentenceBtn = new Button();
            richTextBox2 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // autoSpaceCBox
            // 
            autoSpaceCBox.AutoSize = true;
            autoSpaceCBox.Location = new Point(305, 33);
            autoSpaceCBox.Name = "autoSpaceCBox";
            autoSpaceCBox.Size = new Size(93, 19);
            autoSpaceCBox.TabIndex = 11;
            autoSpaceCBox.Text = "Автопробел";
            autoSpaceCBox.UseVisualStyleBackColor = true;
            // 
            // indexPickerComboBox
            // 
            indexPickerComboBox.FormattingEnabled = true;
            indexPickerComboBox.Location = new Point(25, 145);
            indexPickerComboBox.Name = "indexPickerComboBox";
            indexPickerComboBox.Size = new Size(258, 23);
            indexPickerComboBox.TabIndex = 10;
            indexPickerComboBox.SelectedIndexChanged += indexPickerComboBox_SelectedIndexChanged_1;
            // 
            // deleteWordByIndexBtn
            // 
            deleteWordByIndexBtn.Location = new Point(25, 111);
            deleteWordByIndexBtn.Name = "deleteWordByIndexBtn";
            deleteWordByIndexBtn.Size = new Size(258, 28);
            deleteWordByIndexBtn.TabIndex = 9;
            deleteWordByIndexBtn.Text = "Удалить по индексу";
            deleteWordByIndexBtn.UseVisualStyleBackColor = true;
            deleteWordByIndexBtn.Click += deleteWordByIndexBtn_Click;
            // 
            // addSentenceTextBox
            // 
            addSentenceTextBox.Location = new Point(25, 62);
            addSentenceTextBox.Name = "addSentenceTextBox";
            addSentenceTextBox.Size = new Size(258, 23);
            addSentenceTextBox.TabIndex = 8;
            // 
            // addWordBtn
            // 
            addWordBtn.Location = new Point(25, 27);
            addWordBtn.Name = "addWordBtn";
            addWordBtn.Size = new Size(258, 29);
            addWordBtn.TabIndex = 7;
            addWordBtn.Text = "Добавить слово";
            addWordBtn.UseVisualStyleBackColor = true;
            addWordBtn.Click += addWordBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(435, 62);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(398, 161);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged_1;
            // 
            // createSentenceBtn
            // 
            createSentenceBtn.Location = new Point(25, 191);
            createSentenceBtn.Name = "createSentenceBtn";
            createSentenceBtn.Size = new Size(258, 50);
            createSentenceBtn.TabIndex = 12;
            createSentenceBtn.Text = "Сформировать предложение из текущих слов";
            createSentenceBtn.UseVisualStyleBackColor = true;
            createSentenceBtn.Click += createSentenceBtn_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(435, 307);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(398, 200);
            richTextBox2.TabIndex = 13;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(435, 27);
            label1.Name = "label1";
            label1.Size = new Size(229, 15);
            label1.TabIndex = 14;
            label1.Text = "Редактирование текущего предложения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 276);
            label2.Name = "label2";
            label2.Size = new Size(204, 15);
            label2.TabIndex = 15;
            label2.Text = "Список добавленных предложений";
            // 
            // WordsConstuctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 560);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox2);
            Controls.Add(createSentenceBtn);
            Controls.Add(autoSpaceCBox);
            Controls.Add(indexPickerComboBox);
            Controls.Add(deleteWordByIndexBtn);
            Controls.Add(addSentenceTextBox);
            Controls.Add(addWordBtn);
            Controls.Add(richTextBox1);
            Name = "WordsConstuctorForm";
            Text = "Конструктор слов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox autoSpaceCBox;
        private ComboBox indexPickerComboBox;
        private Button deleteWordByIndexBtn;
        private TextBox addSentenceTextBox;
        private Button addWordBtn;
        private RichTextBox richTextBox1;
        private Button createSentenceBtn;
        private RichTextBox richTextBox2;
        private Label label1;
        private Label label2;
    }
}