namespace TextApp
{
    partial class TextAnalyserForm
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
            textRichBox = new RichTextBox();
            loadTextFile = new Button();
            saveStatistics = new Button();
            analysedTextBox = new RichTextBox();
            analyseTextBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            enableSearchCheckBox = new CheckBox();
            searchTextBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // textRichBox
            // 
            textRichBox.Location = new Point(420, 44);
            textRichBox.Name = "textRichBox";
            textRichBox.Size = new Size(649, 222);
            textRichBox.TabIndex = 0;
            textRichBox.Text = "";
            textRichBox.TextChanged += textRichBox_TextChanged;
            // 
            // loadTextFile
            // 
            loadTextFile.Location = new Point(45, 43);
            loadTextFile.Name = "loadTextFile";
            loadTextFile.Size = new Size(236, 63);
            loadTextFile.TabIndex = 1;
            loadTextFile.Text = "Загрузить текст из файла";
            loadTextFile.UseVisualStyleBackColor = true;
            loadTextFile.Click += loadTextFile_Click;
            // 
            // saveStatistics
            // 
            saveStatistics.Location = new Point(45, 285);
            saveStatistics.Name = "saveStatistics";
            saveStatistics.Size = new Size(236, 62);
            saveStatistics.TabIndex = 2;
            saveStatistics.Text = "Сохранить статистику в файл";
            saveStatistics.UseVisualStyleBackColor = true;
            saveStatistics.Click += saveStatistics_Click;
            // 
            // analysedTextBox
            // 
            analysedTextBox.Location = new Point(420, 303);
            analysedTextBox.Name = "analysedTextBox";
            analysedTextBox.Size = new Size(649, 218);
            analysedTextBox.TabIndex = 3;
            analysedTextBox.Text = "";
            analysedTextBox.TextChanged += analysedTextBox_TextChanged;
            // 
            // analyseTextBtn
            // 
            analyseTextBtn.Location = new Point(45, 124);
            analyseTextBtn.Name = "analyseTextBtn";
            analyseTextBtn.Size = new Size(236, 58);
            analyseTextBtn.TabIndex = 4;
            analyseTextBtn.Text = "Анализировать текст";
            analyseTextBtn.UseVisualStyleBackColor = true;
            analyseTextBtn.Click += analyseTextBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(420, 26);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 5;
            label1.Text = "Исходный текст";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(420, 285);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 6;
            label2.Text = "Анализ текста";
            // 
            // enableSearchCheckBox
            // 
            enableSearchCheckBox.AutoSize = true;
            enableSearchCheckBox.Location = new Point(45, 188);
            enableSearchCheckBox.Name = "enableSearchCheckBox";
            enableSearchCheckBox.Size = new Size(178, 19);
            enableSearchCheckBox.TabIndex = 7;
            enableSearchCheckBox.Text = "Включить функцию поиска";
            enableSearchCheckBox.UseVisualStyleBackColor = true;
            enableSearchCheckBox.CheckedChanged += enableSearchCheckBox_CheckedChanged;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(45, 243);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(236, 23);
            searchTextBox.TabIndex = 8;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 225);
            label3.Name = "label3";
            label3.Size = new Size(150, 15);
            label3.TabIndex = 9;
            label3.Text = "Введите слово для поиска";
            // 
            // TextAnalyserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 561);
            Controls.Add(label3);
            Controls.Add(searchTextBox);
            Controls.Add(enableSearchCheckBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(analyseTextBtn);
            Controls.Add(analysedTextBox);
            Controls.Add(saveStatistics);
            Controls.Add(loadTextFile);
            Controls.Add(textRichBox);
            Name = "TextAnalyserForm";
            Text = "TextAnalyserForm";
            Load += TextAnalyserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox textRichBox;
        private Button loadTextFile;
        private Button saveStatistics;
        private RichTextBox analysedTextBox;
        private Button analyseTextBtn;
        private Label label1;
        private Label label2;
        private CheckBox enableSearchCheckBox;
        private TextBox searchTextBox;
        private Label label3;
    }
}