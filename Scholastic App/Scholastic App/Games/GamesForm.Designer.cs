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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bckBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blackjack
            // 
            this.blackjack.BackColor = System.Drawing.Color.Fuchsia;
            this.blackjack.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackjack.ForeColor = System.Drawing.Color.OldLace;
            this.blackjack.Location = new System.Drawing.Point(55, 44);
            this.blackjack.Name = "blackjack";
            this.blackjack.Size = new System.Drawing.Size(407, 64);
            this.blackjack.TabIndex = 6;
            this.blackjack.Text = "Black Jack";
            this.blackjack.UseVisualStyleBackColor = false;
            this.blackjack.Click += new System.EventHandler(this.blackjack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Fuchsia;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.OldLace;
            this.button1.Location = new System.Drawing.Point(55, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(407, 64);
            this.button1.TabIndex = 7;
            this.button1.Text = "Black Jack";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Fuchsia;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.OldLace;
            this.button2.Location = new System.Drawing.Point(55, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(407, 64);
            this.button2.TabIndex = 8;
            this.button2.Text = "Black Jack";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // bckBtn
            // 
            this.bckBtn.BackColor = System.Drawing.Color.Fuchsia;
            this.bckBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckBtn.ForeColor = System.Drawing.Color.OldLace;
            this.bckBtn.Location = new System.Drawing.Point(55, 539);
            this.bckBtn.Name = "bckBtn";
            this.bckBtn.Size = new System.Drawing.Size(407, 64);
            this.bckBtn.TabIndex = 9;
            this.bckBtn.Text = "BACK";
            this.bckBtn.UseVisualStyleBackColor = false;
            this.bckBtn.Click += new System.EventHandler(this.bckBtn_Click);
            // 
            // GamesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(522, 629);
            this.Controls.Add(this.bckBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.blackjack);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "GamesForm";
            this.Text = "Games";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button blackjack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bckBtn;
    }
}