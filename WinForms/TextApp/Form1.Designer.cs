namespace TextApp
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
            button1 = new Button();
            createTextObject = new Button();
            richTextBox1 = new RichTextBox();
            saveTextBtn = new Button();
            openTextBtn = new Button();
            openTextAnalyser = new Button();
            button3 = new Button();
            label2 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(46, 232);
            button1.Name = "button1";
            button1.Size = new Size(206, 54);
            button1.TabIndex = 0;
            button1.Text = "Открыть конструктор предложений";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // createTextObject
            // 
            createTextObject.BackgroundImageLayout = ImageLayout.None;
            createTextObject.Location = new Point(46, 48);
            createTextObject.Name = "createTextObject";
            createTextObject.Size = new Size(206, 54);
            createTextObject.TabIndex = 1;
            createTextObject.Text = "Создать объект класса Text";
            createTextObject.UseVisualStyleBackColor = true;
            createTextObject.Click += createTextObject_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(370, 48);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(585, 340);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // saveTextBtn
            // 
            saveTextBtn.Location = new Point(370, 407);
            saveTextBtn.Name = "saveTextBtn";
            saveTextBtn.Size = new Size(170, 49);
            saveTextBtn.TabIndex = 3;
            saveTextBtn.Text = "Сохранить текст в файл";
            saveTextBtn.UseVisualStyleBackColor = true;
            saveTextBtn.Click += btnSaveFile_Click;
            // 
            // openTextBtn
            // 
            openTextBtn.Location = new Point(546, 407);
            openTextBtn.Name = "openTextBtn";
            openTextBtn.Size = new Size(170, 49);
            openTextBtn.TabIndex = 4;
            openTextBtn.Text = "Загрузить текст из файла";
            openTextBtn.UseVisualStyleBackColor = true;
            openTextBtn.Click += btnLoadFile_Click;
            // 
            // openTextAnalyser
            // 
            openTextAnalyser.Location = new Point(46, 175);
            openTextAnalyser.Name = "openTextAnalyser";
            openTextAnalyser.Size = new Size(206, 51);
            openTextAnalyser.TabIndex = 5;
            openTextAnalyser.Text = "Открыть анализатор текста";
            openTextAnalyser.UseVisualStyleBackColor = true;
            openTextAnalyser.Click += openTextAnalyser_Click;
            // 
            // button3
            // 
            button3.Location = new Point(824, 407);
            button3.Name = "button3";
            button3.Size = new Size(131, 49);
            button3.TabIndex = 7;
            button3.Text = "Очистить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(46, 151);
            label2.Name = "label2";
            label2.Size = new Size(214, 21);
            label2.TabIndex = 10;
            label2.Text = "Модули работы с текстом";
            // 
            // button4
            // 
            button4.Location = new Point(46, 292);
            button4.Name = "button4";
            button4.Size = new Size(206, 53);
            button4.TabIndex = 12;
            button4.Text = "Открыть редактор текста";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 571);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(openTextAnalyser);
            Controls.Add(openTextBtn);
            Controls.Add(saveTextBtn);
            Controls.Add(richTextBox1);
            Controls.Add(createTextObject);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button createTextObject;
        private RichTextBox richTextBox1;
        private Button saveTextBtn;
        private Button openTextBtn;
        private Button openTextAnalyser;
        private Button button3;
        private Label label2;
        private Button button4;
    }
}
