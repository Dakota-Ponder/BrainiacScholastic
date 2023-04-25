namespace Brainiac
{
    partial class Form1
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
            this.Flip = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.comboBoxChapters = new System.Windows.Forms.ComboBox();
            this.FlashcardTextBox = new System.Windows.Forms.TextBox();
            this.StudyAll = new System.Windows.Forms.Button();
            this.CorrectAnswerButton = new System.Windows.Forms.Button();
            this.IncorrectAnswerButton = new System.Windows.Forms.Button();
            this.ProgressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Flip
            // 
            this.Flip.BackColor = System.Drawing.Color.Transparent;
            this.Flip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Flip.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flip.ForeColor = System.Drawing.Color.Fuchsia;
            this.Flip.Location = new System.Drawing.Point(221, 369);
            this.Flip.Name = "Flip";
            this.Flip.Size = new System.Drawing.Size(502, 48);
            this.Flip.TabIndex = 0;
            this.Flip.Text = "Flip";
            this.Flip.UseVisualStyleBackColor = false;
            this.Flip.Click += new System.EventHandler(this.Flip_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Transparent;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Next.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.Fuchsia;
            this.Next.Location = new System.Drawing.Point(753, 369);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(126, 48);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.Color.Transparent;
            this.Previous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Previous.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous.ForeColor = System.Drawing.Color.Fuchsia;
            this.Previous.Location = new System.Drawing.Point(36, 369);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(153, 48);
            this.Previous.TabIndex = 2;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Add
            // 
            this.Add.AutoSize = true;
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Fuchsia;
            this.Add.Location = new System.Drawing.Point(761, 33);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(118, 34);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // comboBoxChapters
            // 
            this.comboBoxChapters.BackColor = System.Drawing.Color.GhostWhite;
            this.comboBoxChapters.FormattingEnabled = true;
            this.comboBoxChapters.Location = new System.Drawing.Point(369, 33);
            this.comboBoxChapters.Name = "comboBoxChapters";
            this.comboBoxChapters.Size = new System.Drawing.Size(170, 24);
            this.comboBoxChapters.TabIndex = 7;
            this.comboBoxChapters.SelectedIndexChanged += new System.EventHandler(this.comboBoxChapters_SelectedIndexChanged);
            // 
            // FlashcardTextBox
            // 
            this.FlashcardTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FlashcardTextBox.Font = new System.Drawing.Font("Fira Code Retina", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlashcardTextBox.ForeColor = System.Drawing.Color.Fuchsia;
            this.FlashcardTextBox.Location = new System.Drawing.Point(36, 78);
            this.FlashcardTextBox.Multiline = true;
            this.FlashcardTextBox.Name = "FlashcardTextBox";
            this.FlashcardTextBox.ReadOnly = true;
            this.FlashcardTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FlashcardTextBox.Size = new System.Drawing.Size(843, 269);
            this.FlashcardTextBox.TabIndex = 8;
            this.FlashcardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudyAll
            // 
            this.StudyAll.BackColor = System.Drawing.Color.Transparent;
            this.StudyAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StudyAll.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyAll.ForeColor = System.Drawing.Color.Fuchsia;
            this.StudyAll.Location = new System.Drawing.Point(36, 29);
            this.StudyAll.Name = "StudyAll";
            this.StudyAll.Size = new System.Drawing.Size(153, 36);
            this.StudyAll.TabIndex = 9;
            this.StudyAll.Text = "Study All ";
            this.StudyAll.UseVisualStyleBackColor = false;
            this.StudyAll.Click += new System.EventHandler(this.StudyAll_Click);
            // 
            // CorrectAnswerButton
            // 
            this.CorrectAnswerButton.BackColor = System.Drawing.Color.Lime;
            this.CorrectAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CorrectAnswerButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswerButton.ForeColor = System.Drawing.Color.Black;
            this.CorrectAnswerButton.Location = new System.Drawing.Point(36, 449);
            this.CorrectAnswerButton.Name = "CorrectAnswerButton";
            this.CorrectAnswerButton.Size = new System.Drawing.Size(153, 47);
            this.CorrectAnswerButton.TabIndex = 10;
            this.CorrectAnswerButton.Text = "Correct";
            this.CorrectAnswerButton.UseVisualStyleBackColor = false;
            this.CorrectAnswerButton.Click += new System.EventHandler(this.CorrectAnswerButton_Click);
            // 
            // IncorrectAnswerButton
            // 
            this.IncorrectAnswerButton.BackColor = System.Drawing.Color.Red;
            this.IncorrectAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IncorrectAnswerButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncorrectAnswerButton.ForeColor = System.Drawing.Color.Black;
            this.IncorrectAnswerButton.Location = new System.Drawing.Point(737, 449);
            this.IncorrectAnswerButton.Name = "IncorrectAnswerButton";
            this.IncorrectAnswerButton.Size = new System.Drawing.Size(142, 47);
            this.IncorrectAnswerButton.TabIndex = 11;
            this.IncorrectAnswerButton.Text = "Incorrect";
            this.IncorrectAnswerButton.UseVisualStyleBackColor = false;
            this.IncorrectAnswerButton.Click += new System.EventHandler(this.IncorrectAnswerButton_Click);
            // 
            // ProgressButton
            // 
            this.ProgressButton.BackColor = System.Drawing.Color.Transparent;
            this.ProgressButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProgressButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressButton.ForeColor = System.Drawing.Color.Fuchsia;
            this.ProgressButton.Location = new System.Drawing.Point(302, 449);
            this.ProgressButton.Name = "ProgressButton";
            this.ProgressButton.Size = new System.Drawing.Size(334, 47);
            this.ProgressButton.TabIndex = 12;
            this.ProgressButton.Text = "View Progress";
            this.ProgressButton.UseVisualStyleBackColor = false;
            this.ProgressButton.Click += new System.EventHandler(this.ProgressButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(924, 553);
            this.Controls.Add(this.ProgressButton);
            this.Controls.Add(this.IncorrectAnswerButton);
            this.Controls.Add(this.CorrectAnswerButton);
            this.Controls.Add(this.StudyAll);
            this.Controls.Add(this.FlashcardTextBox);
            this.Controls.Add(this.comboBoxChapters);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Flip);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShowIcon = false;
            this.Text = "Brainiac";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Flip;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox comboBoxChapters;
        private System.Windows.Forms.TextBox FlashcardTextBox;
        private System.Windows.Forms.Button StudyAll;
        private System.Windows.Forms.Button CorrectAnswerButton;
        private System.Windows.Forms.Button IncorrectAnswerButton;
        private System.Windows.Forms.Button ProgressButton;
    }
}

