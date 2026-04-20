namespace project1
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            txtGenre = new TextBox();
            txtTitle = new TextBox();
            label4 = new Label();
            numRating = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            lstMovies = new ListBox();
            btnShowHistory = new Button();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 51);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 52);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "moviename:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 170);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "type:";
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(24, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtGenre
            // 
            txtGenre.BackColor = Color.White;
            txtGenre.Location = new Point(24, 193);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(120, 23);
            txtGenre.TabIndex = 4;
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.Beige;
            txtTitle.Location = new Point(162, 71);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(120, 23);
            txtTitle.TabIndex = 5;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 173);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 6;
            label4.Text = "rate:";
            label4.Click += label4_Click;
            // 
            // numRating
            // 
            numRating.BackColor = SystemColors.ButtonHighlight;
            numRating.Location = new Point(162, 193);
            numRating.Name = "numRating";
            numRating.Size = new Size(120, 23);
            numRating.TabIndex = 7;
            numRating.ValueChanged += numRating_ValueChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Cursor = Cursors.Cross;
            button1.FlatStyle = FlatStyle.System;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(162, 305);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 8;
            button1.Text = "Rate";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Snow;
            button2.Location = new Point(24, 305);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 9;
            button2.Text = "Watch";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lstMovies
            // 
            lstMovies.BackColor = SystemColors.Info;
            lstMovies.FormattingEnabled = true;
            lstMovies.ItemHeight = 15;
            lstMovies.Location = new Point(311, 143);
            lstMovies.Name = "lstMovies";
            lstMovies.Size = new Size(304, 199);
            lstMovies.TabIndex = 10;
            // 
            // btnShowHistory
            // 
            btnShowHistory.Location = new Point(311, 94);
            btnShowHistory.Name = "btnShowHistory";
            btnShowHistory.Size = new Size(304, 43);
            btnShowHistory.TabIndex = 11;
            btnShowHistory.Text = "Show History";
            btnShowHistory.UseVisualStyleBackColor = true;
            btnShowHistory.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = MiniNetflixWin.Properties.Resources.images1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowHistory);
            Controls.Add(lstMovies);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numRating);
            Controls.Add(label4);
            Controls.Add(txtTitle);
            Controls.Add(txtGenre);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox txtGenre;
        private TextBox txtTitle;
        private Label label4;
        private NumericUpDown numRating;
        private Button button1;
        private Button button2;
        private ListBox lstMovies;
        private Button btnShowHistory;
    }
}
