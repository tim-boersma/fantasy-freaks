namespace Fantasy_Freaks {
    partial class FormSeason {
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
            this.labelDash = new System.Windows.Forms.Label();
            this.labelOPPscore = new System.Windows.Forms.Label();
            this.labelScoreFF = new System.Windows.Forms.Label();
            this.labelWeek = new System.Windows.Forms.Label();
            this.btnWeekResults = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 563);
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
            // labelDash
            // 
            this.labelDash.AutoSize = true;
            this.labelDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDash.Location = new System.Drawing.Point(484, 250);
            this.labelDash.Name = "labelDash";
            this.labelDash.Size = new System.Drawing.Size(20, 25);
            this.labelDash.TabIndex = 4;
            this.labelDash.Text = "-";
            // 
            // labelOPPscore
            // 
            this.labelOPPscore.AutoSize = true;
            this.labelOPPscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOPPscore.Location = new System.Drawing.Point(535, 250);
            this.labelOPPscore.Name = "labelOPPscore";
            this.labelOPPscore.Size = new System.Drawing.Size(163, 25);
            this.labelOPPscore.TabIndex = 3;
            this.labelOPPscore.Text = "*OPP SCORE*";
            // 
            // labelScoreFF
            // 
            this.labelScoreFF.AutoSize = true;
            this.labelScoreFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScoreFF.Location = new System.Drawing.Point(319, 250);
            this.labelScoreFF.Name = "labelScoreFF";
            this.labelScoreFF.Size = new System.Drawing.Size(144, 25);
            this.labelScoreFF.TabIndex = 2;
            this.labelScoreFF.Text = "*FF SCORE*";
            // 
            // labelWeek
            // 
            this.labelWeek.AutoSize = true;
            this.labelWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeek.Location = new System.Drawing.Point(403, 175);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(185, 50);
            this.labelWeek.TabIndex = 1;
            this.labelWeek.Text = "*INSERT WEEK*\r\nVS\r\n";
            this.labelWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWeekResults
            // 
            this.btnWeekResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(255)))), ((int)(((byte)(165)))));
            this.btnWeekResults.FlatAppearance.BorderSize = 0;
            this.btnWeekResults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(255)))), ((int)(((byte)(138)))));
            this.btnWeekResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(209)))));
            this.btnWeekResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeekResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeekResults.Location = new System.Drawing.Point(683, 600);
            this.btnWeekResults.Name = "btnWeekResults";
            this.btnWeekResults.Size = new System.Drawing.Size(287, 58);
            this.btnWeekResults.TabIndex = 0;
            this.btnWeekResults.Text = "NEXT";
            this.btnWeekResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWeekResults.UseVisualStyleBackColor = false;
            this.btnWeekResults.Click += new System.EventHandler(this.btnWeekResults_Click);
            // 
            // FormSeason
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 672);
            this.ControlBox = false;
            this.Controls.Add(this.labelDash);
            this.Controls.Add(this.labelOPPscore);
            this.Controls.Add(this.labelScoreFF);
            this.Controls.Add(this.labelWeek);
            this.Controls.Add(this.btnWeekResults);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.title);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormSeason";
            this.Load += new System.EventHandler(this.FormSeason_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btnWeekResults;
        private System.Windows.Forms.Label labelDash;
        private System.Windows.Forms.Label labelOPPscore;
        private System.Windows.Forms.Label labelScoreFF;
        private System.Windows.Forms.Label labelWeek;
    }
}