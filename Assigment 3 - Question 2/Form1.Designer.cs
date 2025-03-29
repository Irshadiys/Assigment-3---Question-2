namespace Assigment_3___Question_2
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
            label1 = new Label();
            btnGuess = new Button();
            txtGuess = new TextBox();
            button1 = new Button();
            richTextBoxAnswer = new RichTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(224, 15);
            label1.TabIndex = 0;
            label1.Text = "Please select the number between 1-1000";
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(27, 72);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(88, 23);
            btnGuess.TabIndex = 1;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = true;
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(151, 73);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(100, 23);
            txtGuess.TabIndex = 2;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.None;
            button1.Location = new Point(27, 105);
            button1.Name = "button1";
            button1.Size = new Size(88, 63);
            button1.TabIndex = 3;
            button1.Text = "Please Show Answer";
            button1.UseVisualStyleBackColor = true;
            // 
            // richTextBoxAnswer
            // 
            richTextBoxAnswer.Location = new Point(151, 106);
            richTextBoxAnswer.Name = "richTextBoxAnswer";
            richTextBoxAnswer.ReadOnly = true;
            richTextBoxAnswer.Size = new Size(275, 62);
            richTextBoxAnswer.TabIndex = 4;
            richTextBoxAnswer.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(257, 76);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 194);
            Controls.Add(label2);
            Controls.Add(richTextBoxAnswer);
            Controls.Add(button1);
            Controls.Add(txtGuess);
            Controls.Add(btnGuess);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guess the Number";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGuess;
        private TextBox txtGuess;
        private Button button1;
        private RichTextBox richTextBoxAnswer;
        private Label label2;
    }
}
