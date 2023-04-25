namespace Brainiac
{
    partial class AddFlashcardForm
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
            this.QuestionTextBox = new MetroFramework.Controls.MetroTextBox();
            this.AnswerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.SaveButton = new MetroFramework.Controls.MetroButton();
            this.ChapterTextBox = new MetroFramework.Controls.MetroTextBox();
            this.QuestionLabel = new MetroFramework.Controls.MetroLabel();
            this.AnswerLabel = new MetroFramework.Controls.MetroLabel();
            this.ChapterLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Location = new System.Drawing.Point(65, 72);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(242, 307);
            this.QuestionTextBox.TabIndex = 0;
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(354, 72);
            this.AnswerTextBox.Multiline = true;
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(220, 307);
            this.AnswerTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(615, 125);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 32);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.Save_Click);
            // 
            // ChapterTextBox
            // 
            this.ChapterTextBox.Location = new System.Drawing.Point(615, 72);
            this.ChapterTextBox.Name = "ChapterTextBox";
            this.ChapterTextBox.Size = new System.Drawing.Size(100, 22);
            this.ChapterTextBox.TabIndex = 3;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.QuestionLabel.Location = new System.Drawing.Point(130, 33);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(65, 20);
            this.QuestionLabel.TabIndex = 4;
            this.QuestionLabel.Text = "Question";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(432, 33);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(55, 20);
            this.AnswerLabel.TabIndex = 5;
            this.AnswerLabel.Text = "Answer";
            // 
            // ChapterLabel
            // 
            this.ChapterLabel.AutoSize = true;
            this.ChapterLabel.Location = new System.Drawing.Point(627, 33);
            this.ChapterLabel.Name = "ChapterLabel";
            this.ChapterLabel.Size = new System.Drawing.Size(58, 20);
            this.ChapterLabel.TabIndex = 6;
            this.ChapterLabel.Text = "Chapter";
            // 
            // AddFlashcardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChapterLabel);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.ChapterTextBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.QuestionTextBox);
            this.Name = "AddFlashcardForm";
            this.Text = "Add Flashcard";
            this.Load += new System.EventHandler(this.AddFlashcardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox QuestionTextBox;
        private MetroFramework.Controls.MetroTextBox AnswerTextBox;
        private MetroFramework.Controls.MetroButton SaveButton;
        private MetroFramework.Controls.MetroTextBox ChapterTextBox;
        private MetroFramework.Controls.MetroLabel QuestionLabel;
        private MetroFramework.Controls.MetroLabel AnswerLabel;
        private MetroFramework.Controls.MetroLabel ChapterLabel;
    }
}