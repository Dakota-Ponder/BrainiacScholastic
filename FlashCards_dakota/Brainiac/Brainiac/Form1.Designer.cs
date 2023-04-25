using MetroFramework.Controls;

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
            this.components = new System.ComponentModel.Container();
            this.Flip = new MetroFramework.Controls.MetroButton();
            this.Next = new MetroFramework.Controls.MetroButton();
            this.Previous = new MetroFramework.Controls.MetroButton();
            this.Add = new MetroFramework.Controls.MetroButton();
            this.comboBoxChapters = new MetroFramework.Controls.MetroComboBox();
            this.FlashcardTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Flip
            // 
            this.Flip.Location = new System.Drawing.Point(209, 369);
            this.Flip.Name = "Flip";
            this.Flip.Size = new System.Drawing.Size(502, 48);
            this.Flip.TabIndex = 0;
            this.Flip.Text = "Flip";
            this.Flip.Click += new System.EventHandler(this.Flip_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(753, 369);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(126, 48);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(23, 369);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(153, 48);
            this.Previous.TabIndex = 2;
            this.Previous.Text = "Previous";
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(23, 22);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(131, 46);
            this.Add.TabIndex = 3;
            this.Add.Text = "Add";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // comboBoxChapters
            // 
            this.comboBoxChapters.FormattingEnabled = true;
            this.comboBoxChapters.ItemHeight = 24;
            this.comboBoxChapters.Location = new System.Drawing.Point(329, 38);
            this.comboBoxChapters.Name = "comboBoxChapters";
            this.comboBoxChapters.Size = new System.Drawing.Size(170, 30);
            this.comboBoxChapters.TabIndex = 7;
            this.comboBoxChapters.SelectedIndexChanged += new System.EventHandler(this.comboBoxChapters_SelectedIndexChanged);
            // 
            // FlashcardTextBox
            // 
            this.FlashcardTextBox.BackColor = System.Drawing.Color.White;
            this.FlashcardTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.FlashcardTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.FlashcardTextBox.ForeColor = System.Drawing.Color.Fuchsia;
            this.FlashcardTextBox.Location = new System.Drawing.Point(23, 88);
            this.FlashcardTextBox.Multiline = true;
            this.FlashcardTextBox.Name = "FlashcardTextBox";
            this.FlashcardTextBox.ReadOnly = true;
            this.FlashcardTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FlashcardTextBox.Size = new System.Drawing.Size(856, 248);
            this.FlashcardTextBox.TabIndex = 8;
            this.FlashcardTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(924, 450);
            this.Controls.Add(this.FlashcardTextBox);
            this.Controls.Add(this.comboBoxChapters);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Flip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Flip;
        private MetroFramework.Controls.MetroButton Next;
        private MetroFramework.Controls.MetroButton Previous;
        private MetroFramework.Controls.MetroButton Add;
        private MetroFramework.Controls.MetroComboBox comboBoxChapters;
        private MetroFramework.Controls.MetroTextBox FlashcardTextBox;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;



    }
}

