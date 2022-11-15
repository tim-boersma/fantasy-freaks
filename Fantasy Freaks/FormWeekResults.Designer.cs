namespace Fantasy_Freaks {
    partial class FormWeekResults {
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
            this.progressbarWeekCount = new System.Windows.Forms.ProgressBar();
            this.buttonChangeRoster = new System.Windows.Forms.Button();
            this.labelFFscore = new System.Windows.Forms.Label();
            this.labelOPPscore = new System.Windows.Forms.Label();
            this.labelFFevent = new System.Windows.Forms.Label();
            this.labelOPPevent = new System.Windows.Forms.Label();
            this.FFlabel = new System.Windows.Forms.Label();
            this.OPPlabel = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressbarWeekCount
            // 
            this.progressbarWeekCount.Location = new System.Drawing.Point(188, 364);
            this.progressbarWeekCount.Name = "progressbarWeekCount";
            this.progressbarWeekCount.Size = new System.Drawing.Size(444, 60);
            this.progressbarWeekCount.TabIndex = 0;
            // 
            // buttonChangeRoster
            // 
            this.buttonChangeRoster.Location = new System.Drawing.Point(35, 364);
            this.buttonChangeRoster.Name = "buttonChangeRoster";
            this.buttonChangeRoster.Size = new System.Drawing.Size(133, 60);
            this.buttonChangeRoster.TabIndex = 2;
            this.buttonChangeRoster.Text = "Change Roster";
            this.buttonChangeRoster.UseVisualStyleBackColor = true;
            this.buttonChangeRoster.Click += new System.EventHandler(this.buttonChangeRoster_Click);
            // 
            // labelFFscore
            // 
            this.labelFFscore.AutoSize = true;
            this.labelFFscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFFscore.Location = new System.Drawing.Point(112, 103);
            this.labelFFscore.Name = "labelFFscore";
            this.labelFFscore.Size = new System.Drawing.Size(165, 31);
            this.labelFFscore.TabIndex = 3;
            this.labelFFscore.Text = "Score for FF";
            // 
            // labelOPPscore
            // 
            this.labelOPPscore.AutoSize = true;
            this.labelOPPscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOPPscore.Location = new System.Drawing.Point(446, 103);
            this.labelOPPscore.Name = "labelOPPscore";
            this.labelOPPscore.Size = new System.Drawing.Size(250, 31);
            this.labelOPPscore.TabIndex = 4;
            this.labelOPPscore.Text = "Score for Opponent";
            // 
            // labelFFevent
            // 
            this.labelFFevent.AutoSize = true;
            this.labelFFevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFFevent.Location = new System.Drawing.Point(82, 236);
            this.labelFFevent.Name = "labelFFevent";
            this.labelFFevent.Size = new System.Drawing.Size(254, 31);
            this.labelFFevent.TabIndex = 5;
            this.labelFFevent.Text = "Event for day for FF";
            // 
            // labelOPPevent
            // 
            this.labelOPPevent.AutoSize = true;
            this.labelOPPevent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOPPevent.Location = new System.Drawing.Point(464, 236);
            this.labelOPPevent.Name = "labelOPPevent";
            this.labelOPPevent.Size = new System.Drawing.Size(254, 31);
            this.labelOPPevent.TabIndex = 6;
            this.labelOPPevent.Text = "Event for day for FF";
            // 
            // FFlabel
            // 
            this.FFlabel.AutoSize = true;
            this.FFlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FFlabel.Location = new System.Drawing.Point(115, 151);
            this.FFlabel.Name = "FFlabel";
            this.FFlabel.Size = new System.Drawing.Size(105, 17);
            this.FFlabel.TabIndex = 7;
            this.FFlabel.Text = "Fantasy Freaks";
            // 
            // OPPlabel
            // 
            this.OPPlabel.AutoSize = true;
            this.OPPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPPlabel.Location = new System.Drawing.Point(595, 151);
            this.OPPlabel.Name = "OPPlabel";
            this.OPPlabel.Size = new System.Drawing.Size(101, 17);
            this.OPPlabel.TabIndex = 8;
            this.OPPlabel.Text = "*INSERT OPP*";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(655, 364);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 60);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // FormWeekResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.OPPlabel);
            this.Controls.Add(this.FFlabel);
            this.Controls.Add(this.labelOPPevent);
            this.Controls.Add(this.labelFFevent);
            this.Controls.Add(this.labelOPPscore);
            this.Controls.Add(this.labelFFscore);
            this.Controls.Add(this.buttonChangeRoster);
            this.Controls.Add(this.progressbarWeekCount);
            this.Name = "FormWeekResults";
            this.Text = "FormWeekResults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressbarWeekCount;
        private System.Windows.Forms.Button buttonChangeRoster;
        private System.Windows.Forms.Label labelFFscore;
        private System.Windows.Forms.Label labelOPPscore;
        private System.Windows.Forms.Label labelFFevent;
        private System.Windows.Forms.Label labelOPPevent;
        private System.Windows.Forms.Label FFlabel;
        private System.Windows.Forms.Label OPPlabel;
        private System.Windows.Forms.Button btnNext;
    }
}