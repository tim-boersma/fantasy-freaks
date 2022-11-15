namespace Fantasy_Freaks {
    partial class FormUpcomingSeason {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWeekResults = new System.Windows.Forms.Button();
            this.labelWeek = new System.Windows.Forms.Label();
            this.labelScoreFF = new System.Windows.Forms.Label();
            this.labelOPPscore = new System.Windows.Forms.Label();
            this.labelDash = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(982, 563);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Black;
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.line.Location = new System.Drawing.Point(0, 80);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(883, 5);
            this.line.TabIndex = 7;
            this.line.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(516, 55);
            this.title.TabIndex = 6;
            this.title.Text = "UPCOMING SEASON";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDash);
            this.panel1.Controls.Add(this.labelOPPscore);
            this.panel1.Controls.Add(this.labelScoreFF);
            this.panel1.Controls.Add(this.labelWeek);
            this.panel1.Controls.Add(this.btnWeekResults);
            this.panel1.Location = new System.Drawing.Point(25, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 541);
            this.panel1.TabIndex = 9;
            // 
            // btnWeekResults
            // 
            this.btnWeekResults.Location = new System.Drawing.Point(682, 420);
            this.btnWeekResults.Name = "btnWeekResults";
            this.btnWeekResults.Size = new System.Drawing.Size(219, 76);
            this.btnWeekResults.TabIndex = 0;
            this.btnWeekResults.Text = "Next\r\n";
            this.btnWeekResults.UseVisualStyleBackColor = true;
            this.btnWeekResults.Click += new System.EventHandler(this.btnWeekResults_Click);
            // 
            // labelWeek
            // 
            this.labelWeek.AutoSize = true;
            this.labelWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeek.Location = new System.Drawing.Point(323, 30);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(223, 62);
            this.labelWeek.TabIndex = 1;
            this.labelWeek.Text = "*INSERT WEEK*\r\n             VS\r\n";
            // 
            // labelScoreFF
            // 
            this.labelScoreFF.AutoSize = true;
            this.labelScoreFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreFF.Location = new System.Drawing.Point(242, 115);
            this.labelScoreFF.Name = "labelScoreFF";
            this.labelScoreFF.Size = new System.Drawing.Size(154, 29);
            this.labelScoreFF.TabIndex = 2;
            this.labelScoreFF.Text = "*FF SCORE*";
            // 
            // labelOPPscore
            // 
            this.labelOPPscore.AutoSize = true;
            this.labelOPPscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOPPscore.Location = new System.Drawing.Point(487, 115);
            this.labelOPPscore.Name = "labelOPPscore";
            this.labelOPPscore.Size = new System.Drawing.Size(175, 29);
            this.labelOPPscore.TabIndex = 3;
            this.labelOPPscore.Text = "*OPP SCORE*";
            // 
            // labelDash
            // 
            this.labelDash.AutoSize = true;
            this.labelDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDash.Location = new System.Drawing.Point(424, 115);
            this.labelDash.Name = "labelDash";
            this.labelDash.Size = new System.Drawing.Size(21, 29);
            this.labelDash.TabIndex = 4;
            this.labelDash.Text = "-";
            // 
            // FormUpcomingSeason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 670);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormUpcomingSeason";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWeekResults;
        private System.Windows.Forms.Label labelDash;
        private System.Windows.Forms.Label labelOPPscore;
        private System.Windows.Forms.Label labelScoreFF;
        private System.Windows.Forms.Label labelWeek;
    }
}