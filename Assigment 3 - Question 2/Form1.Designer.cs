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
            butAnswer = new Button();
            richTextBoxAnswer = new RichTextBox();
            labelShowResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 29);
            label1.Name = "label1";
            label1.Size = new Size(224, 15);
            label1.TabIndex = 0;
            label1.Text = "Please select the number between 1-1000";
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(27, 76);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(88, 23);
            btnGuess.TabIndex = 1;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += btnGuess_Click;
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(151, 73);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(100, 23);
            txtGuess.TabIndex = 2;
            // 
            // butAnswer
            // 
            butAnswer.AccessibleRole = AccessibleRole.None;
            butAnswer.Location = new Point(27, 105);
            butAnswer.Name = "butAnswer";
            butAnswer.Size = new Size(88, 63);
            butAnswer.TabIndex = 3;
            butAnswer.Text = "Please Show Answer";
            butAnswer.UseVisualStyleBackColor = true;
            butAnswer.Click += butAnswer_Click;
            // 
            // richTextBoxAnswer
            // 
            richTextBoxAnswer.Location = new Point(151, 106);
            richTextBoxAnswer.Name = "richTextBoxAnswer";
            richTextBoxAnswer.ReadOnly = true;
            richTextBoxAnswer.Size = new Size(350, 62);
            richTextBoxAnswer.TabIndex = 4;
            richTextBoxAnswer.Text = "";
            // 
            // labelShowResult
            // 
            labelShowResult.AutoSize = true;
            labelShowResult.Location = new Point(257, 76);
            labelShowResult.Name = "labelShowResult";
            labelShowResult.Size = new Size(0, 15);
            labelShowResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 194);
            Controls.Add(labelShowResult);
            Controls.Add(richTextBoxAnswer);
            Controls.Add(butAnswer);
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
        private Button butAnswer;
        private RichTextBox richTextBoxAnswer;
        private Label labelShowResult;
    }
}
