namespace Time
{
    partial class Time
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn30m = new System.Windows.Forms.RadioButton();
            this.rbtn15m = new System.Windows.Forms.RadioButton();
            this.rbtn5m = new System.Windows.Forms.RadioButton();
            this.rbtn1m = new System.Windows.Forms.RadioButton();
            this.rbtn30 = new System.Windows.Forms.RadioButton();
            this.countdownlbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.setTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTime)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Fuchsia;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.OldLace;
            this.exitBtn.Location = new System.Drawing.Point(278, 406);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(132, 37);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startBtn.BackColor = System.Drawing.Color.Fuchsia;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.OldLace;
            this.startBtn.Location = new System.Drawing.Point(251, 289);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(182, 49);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resetBtn.BackColor = System.Drawing.Color.Fuchsia;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.OldLace;
            this.resetBtn.Location = new System.Drawing.Point(251, 343);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(182, 49);
            this.resetBtn.TabIndex = 2;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbtn30m);
            this.panel1.Controls.Add(this.rbtn15m);
            this.panel1.Controls.Add(this.rbtn5m);
            this.panel1.Controls.Add(this.rbtn1m);
            this.panel1.Controls.Add(this.rbtn30);
            this.panel1.ForeColor = System.Drawing.Color.OldLace;
            this.panel1.Location = new System.Drawing.Point(8, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 228);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choos a Time:";
            // 
            // rbtn30m
            // 
            this.rbtn30m.AutoSize = true;
            this.rbtn30m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn30m.Location = new System.Drawing.Point(30, 192);
            this.rbtn30m.Name = "rbtn30m";
            this.rbtn30m.Size = new System.Drawing.Size(105, 24);
            this.rbtn30m.TabIndex = 4;
            this.rbtn30m.TabStop = true;
            this.rbtn30m.Text = "30 Minutes";
            this.rbtn30m.UseVisualStyleBackColor = true;
            this.rbtn30m.CheckedChanged += new System.EventHandler(this.rbtn30m_CheckedChanged);
            // 
            // rbtn15m
            // 
            this.rbtn15m.AutoSize = true;
            this.rbtn15m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn15m.Location = new System.Drawing.Point(30, 157);
            this.rbtn15m.Name = "rbtn15m";
            this.rbtn15m.Size = new System.Drawing.Size(105, 24);
            this.rbtn15m.TabIndex = 3;
            this.rbtn15m.TabStop = true;
            this.rbtn15m.Text = "15 Minutes";
            this.rbtn15m.UseVisualStyleBackColor = true;
            this.rbtn15m.CheckedChanged += new System.EventHandler(this.rbtn15m_CheckedChanged);
            // 
            // rbtn5m
            // 
            this.rbtn5m.AutoSize = true;
            this.rbtn5m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn5m.Location = new System.Drawing.Point(30, 124);
            this.rbtn5m.Name = "rbtn5m";
            this.rbtn5m.Size = new System.Drawing.Size(96, 24);
            this.rbtn5m.TabIndex = 2;
            this.rbtn5m.TabStop = true;
            this.rbtn5m.Text = "5 Minutes";
            this.rbtn5m.UseVisualStyleBackColor = true;
            this.rbtn5m.CheckedChanged += new System.EventHandler(this.rbtn5m_CheckedChanged);
            // 
            // rbtn1m
            // 
            this.rbtn1m.AutoSize = true;
            this.rbtn1m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn1m.Location = new System.Drawing.Point(30, 90);
            this.rbtn1m.Name = "rbtn1m";
            this.rbtn1m.Size = new System.Drawing.Size(88, 24);
            this.rbtn1m.TabIndex = 1;
            this.rbtn1m.TabStop = true;
            this.rbtn1m.Text = "1 Minute";
            this.rbtn1m.UseVisualStyleBackColor = true;
            this.rbtn1m.CheckedChanged += new System.EventHandler(this.rbtn1m_CheckedChanged);
            // 
            // rbtn30
            // 
            this.rbtn30.AutoSize = true;
            this.rbtn30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn30.Location = new System.Drawing.Point(30, 57);
            this.rbtn30.Name = "rbtn30";
            this.rbtn30.Size = new System.Drawing.Size(112, 24);
            this.rbtn30.TabIndex = 0;
            this.rbtn30.TabStop = true;
            this.rbtn30.Text = "30 Seconds";
            this.rbtn30.UseVisualStyleBackColor = true;
            this.rbtn30.CheckedChanged += new System.EventHandler(this.rbtn30_CheckedChanged);
            // 
            // countdownlbl
            // 
            this.countdownlbl.AutoSize = true;
            this.countdownlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownlbl.ForeColor = System.Drawing.Color.OldLace;
            this.countdownlbl.Location = new System.Drawing.Point(241, 126);
            this.countdownlbl.Name = "countdownlbl";
            this.countdownlbl.Size = new System.Drawing.Size(192, 55);
            this.countdownlbl.TabIndex = 4;
            this.countdownlbl.Text = "0:00:00";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.setTime);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.Color.OldLace;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 188);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "(in minutes)";
            // 
            // setTime
            // 
            this.setTime.Location = new System.Drawing.Point(23, 51);
            this.setTime.Name = "setTime";
            this.setTime.Size = new System.Drawing.Size(145, 20);
            this.setTime.TabIndex = 1;
            this.setTime.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.setTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.setTime_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Set a Time:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OldLace;
            this.label5.Location = new System.Drawing.Point(294, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "TIMER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OldLace;
            this.label4.Location = new System.Drawing.Point(244, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Timer Set:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OldLace;
            this.label6.Location = new System.Drawing.Point(79, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 37);
            this.label6.TabIndex = 9;
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(483, 459);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.countdownlbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.exitBtn);
            this.Name = "Time";
            this.Text = "Timer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtn30m;
        private System.Windows.Forms.RadioButton rbtn15m;
        private System.Windows.Forms.RadioButton rbtn5m;
        private System.Windows.Forms.RadioButton rbtn1m;
        private System.Windows.Forms.RadioButton rbtn30;
        private System.Windows.Forms.Label countdownlbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown setTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

