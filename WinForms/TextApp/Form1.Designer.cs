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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(56, 48);
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
            createTextObject.Location = new Point(56, 117);
            createTextObject.Name = "createTextObject";
            createTextObject.Size = new Size(206, 54);
            createTextObject.TabIndex = 1;
            createTextObject.Text = "Создать объект класса Text";
            createTextObject.UseVisualStyleBackColor = true;
            createTextObject.Click += createTextObject_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(376, 48);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(585, 340);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // saveTextBtn
            // 
            saveTextBtn.Location = new Point(56, 190);
            saveTextBtn.Name = "saveTextBtn";
            saveTextBtn.Size = new Size(99, 49);
            saveTextBtn.TabIndex = 3;
            saveTextBtn.Text = "Сохранить текст в файл";
            saveTextBtn.UseVisualStyleBackColor = true;
            saveTextBtn.Click += saveTextBtn_Click;
            // 
            // openTextBtn
            // 
            openTextBtn.Location = new Point(163, 190);
            openTextBtn.Name = "openTextBtn";
            openTextBtn.Size = new Size(99, 49);
            openTextBtn.TabIndex = 4;
            openTextBtn.Text = "Загрузить текст из файла";
            openTextBtn.UseVisualStyleBackColor = true;
            openTextBtn.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 657);
            Controls.Add(openTextBtn);
            Controls.Add(saveTextBtn);
            Controls.Add(richTextBox1);
            Controls.Add(createTextObject);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button createTextObject;
        private RichTextBox richTextBox1;
        private Button saveTextBtn;
        private Button openTextBtn;
    }
}
