namespace timer
{
    partial class Timer
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            setTime = new NumericUpDown();
            panel1 = new Panel();
            rbtn_30min = new RadioButton();
            chooseLabel = new Label();
            rbtn_15min = new RadioButton();
            rbtn_5min = new RadioButton();
            rbtn_1min = new RadioButton();
            rbtn_30s = new RadioButton();
            setLabel = new Label();
            label2 = new Label();
            btnStart = new Button();
            label3 = new Label();
            btnReset = new Button();
            panel2 = new Panel();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)setTime).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(1039, 79);
            label1.TabIndex = 0;
            label1.Text = "TIMER";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // setTime
            // 
            setTime.Location = new Point(0, 91);
            setTime.Margin = new Padding(30);
            setTime.Name = "setTime";
            setTime.Size = new Size(370, 39);
            setTime.TabIndex = 1;
            setTime.TextAlign = HorizontalAlignment.Center;
            setTime.ValueChanged += numericUpDown1_ValueChanged;
            setTime.Click += numericUpDown1_ValueChanged;
            setTime.KeyDown += numericUpDown1_KeyDown;
            setTime.KeyPress += numericUpDown1_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbtn_30min);
            panel1.Controls.Add(chooseLabel);
            panel1.Controls.Add(rbtn_15min);
            panel1.Controls.Add(rbtn_5min);
            panel1.Controls.Add(rbtn_1min);
            panel1.Controls.Add(rbtn_30s);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(669, 79);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 894);
            panel1.TabIndex = 2;
            // 
            // rbtn_30min
            // 
            rbtn_30min.AutoSize = true;
            rbtn_30min.Location = new Point(92, 478);
            rbtn_30min.Margin = new Padding(30);
            rbtn_30min.Name = "rbtn_30min";
            rbtn_30min.Size = new Size(165, 36);
            rbtn_30min.TabIndex = 4;
            rbtn_30min.Text = "30 Minutes";
            rbtn_30min.UseVisualStyleBackColor = true;
            rbtn_30min.CheckedChanged += rbtn_30min_CheckedChanged;
            // 
            // chooseLabel
            // 
            chooseLabel.Location = new Point(0, 0);
            chooseLabel.Name = "chooseLabel";
            chooseLabel.Size = new Size(370, 64);
            chooseLabel.TabIndex = 3;
            chooseLabel.Text = "Choose a Time:";
            chooseLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbtn_15min
            // 
            rbtn_15min.AutoSize = true;
            rbtn_15min.Location = new Point(92, 382);
            rbtn_15min.Margin = new Padding(30);
            rbtn_15min.Name = "rbtn_15min";
            rbtn_15min.Size = new Size(165, 36);
            rbtn_15min.TabIndex = 3;
            rbtn_15min.Text = "15 Minutes";
            rbtn_15min.UseVisualStyleBackColor = true;
            rbtn_15min.CheckedChanged += rbtn_15min_CheckedChanged;
            // 
            // rbtn_5min
            // 
            rbtn_5min.AutoSize = true;
            rbtn_5min.Location = new Point(92, 286);
            rbtn_5min.Margin = new Padding(30);
            rbtn_5min.Name = "rbtn_5min";
            rbtn_5min.Size = new Size(152, 36);
            rbtn_5min.TabIndex = 2;
            rbtn_5min.Text = "5 Minutes";
            rbtn_5min.UseVisualStyleBackColor = true;
            rbtn_5min.CheckedChanged += rbtn_5min_CheckedChanged;
            // 
            // rbtn_1min
            // 
            rbtn_1min.AutoSize = true;
            rbtn_1min.Location = new Point(92, 190);
            rbtn_1min.Margin = new Padding(30);
            rbtn_1min.Name = "rbtn_1min";
            rbtn_1min.Size = new Size(142, 36);
            rbtn_1min.TabIndex = 1;
            rbtn_1min.Text = "1 Minute";
            rbtn_1min.UseVisualStyleBackColor = true;
            rbtn_1min.CheckedChanged += rbtn_1min_CheckedChanged;
            // 
            // rbtn_30s
            // 
            rbtn_30s.AutoSize = true;
            rbtn_30s.Location = new Point(92, 94);
            rbtn_30s.Margin = new Padding(30);
            rbtn_30s.Name = "rbtn_30s";
            rbtn_30s.Size = new Size(167, 36);
            rbtn_30s.TabIndex = 0;
            rbtn_30s.Text = "30 Seconds";
            rbtn_30s.UseVisualStyleBackColor = true;
            rbtn_30s.CheckedChanged += rbtn_30s_CheckedChanged;
            // 
            // setLabel
            // 
            setLabel.Location = new Point(-3, 0);
            setLabel.Name = "setLabel";
            setLabel.Size = new Size(370, 64);
            setLabel.TabIndex = 4;
            setLabel.Text = "Set the Time:";
            setLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(-3, 162);
            label2.Name = "label2";
            label2.Size = new Size(370, 64);
            label2.TabIndex = 5;
            label2.Text = "(in minutes)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(39, 601);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(370, 85);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(328, 143);
            label3.Name = "label3";
            label3.Size = new Size(400, 400);
            label3.TabIndex = 7;
            label3.Text = "Timer Started";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            label3.VisibleChanged += btnStart_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(39, 728);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(370, 85);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(setTime);
            panel2.Controls.Add(setLabel);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 514);
            panel2.TabIndex = 9;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(39, 855);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(370, 85);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Timer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1039, 973);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Controls.Add(btnReset);
            Controls.Add(label3);
            Controls.Add(btnStart);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "Timer";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)setTime).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }





        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private NumericUpDown setTime;
        private Panel panel1;
        private Label chooseLabel;
        private Label setLabel;
        private Label label2;
        private RadioButton rbtn_30min;
        private RadioButton rbtn_15min;
        private RadioButton rbtn_5min;
        private RadioButton rbtn_1min;
        private RadioButton rbtn_30s;
        private Button btnStart;
        private Label label3;
        private Button btnReset;
        private Panel panel2;
        private Button btnExit;
    }
}