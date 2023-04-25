namespace Scholastic_App.Games
{
    partial class GamesForm
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
            this.blackjack = new System.Windows.Forms.Button();
            this.EndlessRunner = new System.Windows.Forms.Button();
            this.bckBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blackjack
            // 
            this.blackjack.BackColor = System.Drawing.Color.Fuchsia;
            this.blackjack.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackjack.ForeColor = System.Drawing.Color.OldLace;
            this.blackjack.Location = new System.Drawing.Point(73, 54);
            this.blackjack.Margin = new System.Windows.Forms.Padding(4);
            this.blackjack.Name = "blackjack";
            this.blackjack.Size = new System.Drawing.Size(543, 79);
            this.blackjack.TabIndex = 6;
            this.blackjack.Text = "Black Jack";
            this.blackjack.UseVisualStyleBackColor = false;
            this.blackjack.Click += new System.EventHandler(this.blackjack_Click);
            // 
            // EndlessRunner
            // 
            this.EndlessRunner.BackColor = System.Drawing.Color.Fuchsia;
            this.EndlessRunner.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndlessRunner.ForeColor = System.Drawing.Color.OldLace;
            this.EndlessRunner.Location = new System.Drawing.Point(73, 186);
            this.EndlessRunner.Margin = new System.Windows.Forms.Padding(4);
            this.EndlessRunner.Name = "EndlessRunner";
            this.EndlessRunner.Size = new System.Drawing.Size(543, 79);
            this.EndlessRunner.TabIndex = 8;
            this.EndlessRunner.Text = "Endless Runner";
            this.EndlessRunner.UseVisualStyleBackColor = false;
            this.EndlessRunner.Click += new System.EventHandler(this.button2_Click);
            // 
            // bckBtn
            // 
            this.bckBtn.BackColor = System.Drawing.Color.Fuchsia;
            this.bckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckBtn.ForeColor = System.Drawing.Color.OldLace;
            this.bckBtn.Location = new System.Drawing.Point(73, 663);
            this.bckBtn.Margin = new System.Windows.Forms.Padding(4);
            this.bckBtn.Name = "bckBtn";
            this.bckBtn.Size = new System.Drawing.Size(543, 79);
            this.bckBtn.TabIndex = 9;
            this.bckBtn.Text = "BACK";
            this.bckBtn.UseVisualStyleBackColor = false;
            this.bckBtn.Click += new System.EventHandler(this.bckBtn_Click);
            // 
            // GamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(696, 774);
            this.Controls.Add(this.bckBtn);
            this.Controls.Add(this.EndlessRunner);
            this.Controls.Add(this.blackjack);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GamesForm";
            this.Text = "Games";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button blackjack;
        private System.Windows.Forms.Button EndlessRunner;
        private System.Windows.Forms.Button bckBtn;
    }
}