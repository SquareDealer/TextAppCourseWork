namespace TextApp
{
    partial class TextEditorForm
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
            formatTextBtn = new Button();
            richTextBox1 = new RichTextBox();
            deleteSentenceBtn = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // formatTextBtn
            // 
            formatTextBtn.Location = new Point(48, 40);
            formatTextBtn.Name = "formatTextBtn";
            formatTextBtn.Size = new Size(156, 49);
            formatTextBtn.TabIndex = 0;
            formatTextBtn.Text = "Форматировать текст";
            formatTextBtn.UseVisualStyleBackColor = true;
            formatTextBtn.Click += formatTextBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(276, 40);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(467, 302);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // deleteSentenceBtn
            // 
            deleteSentenceBtn.Location = new Point(48, 95);
            deleteSentenceBtn.Name = "deleteSentenceBtn";
            deleteSentenceBtn.Size = new Size(156, 48);
            deleteSentenceBtn.TabIndex = 3;
            deleteSentenceBtn.Text = "Удалить предложение";
            deleteSentenceBtn.UseVisualStyleBackColor = true;
            deleteSentenceBtn.Click += deleteSentenceBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(60, 23);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 152);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 5;
            label1.Text = "Введите индекс";
            // 
            // TextEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 402);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(deleteSentenceBtn);
            Controls.Add(richTextBox1);
            Controls.Add(formatTextBtn);
            Name = "TextEditorForm";
            Text = "TextEditorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button formatTextBtn;
        private RichTextBox richTextBox1;
        private Button deleteSentenceBtn;
        private TextBox textBox1;
        private Label label1;
    }
}