namespace Fantasy_Freaks {
    partial class FormEndResults {
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelInjury = new System.Windows.Forms.Label();
            this.labelBadDay = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelGoodDay = new System.Windows.Forms.Label();
            this.labelMiraclePlay = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fantasy Freaks";
            // 
            // labelInjury
            // 
            this.labelInjury.AutoSize = true;
            this.labelInjury.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInjury.Location = new System.Drawing.Point(44, 165);
            this.labelInjury.Name = "labelInjury";
            this.labelInjury.Size = new System.Drawing.Size(51, 20);
            this.labelInjury.TabIndex = 1;
            this.labelInjury.Text = "Injury:";
            // 
            // labelBadDay
            // 
            this.labelBadDay.AutoSize = true;
            this.labelBadDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBadDay.Location = new System.Drawing.Point(179, 165);
            this.labelBadDay.Name = "labelBadDay";
            this.labelBadDay.Size = new System.Drawing.Size(74, 20);
            this.labelBadDay.TabIndex = 2;
            this.labelBadDay.Text = "Bad Day:";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAverage.Location = new System.Drawing.Point(321, 165);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(72, 20);
            this.labelAverage.TabIndex = 3;
            this.labelAverage.Text = "Average:";
            // 
            // labelGoodDay
            // 
            this.labelGoodDay.AutoSize = true;
            this.labelGoodDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoodDay.Location = new System.Drawing.Point(452, 165);
            this.labelGoodDay.Name = "labelGoodDay";
            this.labelGoodDay.Size = new System.Drawing.Size(85, 20);
            this.labelGoodDay.TabIndex = 4;
            this.labelGoodDay.Text = "Good Day:";
            // 
            // labelMiraclePlay
            // 
            this.labelMiraclePlay.AutoSize = true;
            this.labelMiraclePlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMiraclePlay.Location = new System.Drawing.Point(618, 165);
            this.labelMiraclePlay.Name = "labelMiraclePlay";
            this.labelMiraclePlay.Size = new System.Drawing.Size(96, 20);
            this.labelMiraclePlay.TabIndex = 5;
            this.labelMiraclePlay.Text = "Miracle Play:";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(39, 370);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(207, 51);
            this.buttonRestart.TabIndex = 6;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(601, 370);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(160, 54);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // FormEndResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelMiraclePlay);
            this.Controls.Add(this.labelGoodDay);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelBadDay);
            this.Controls.Add(this.labelInjury);
            this.Controls.Add(this.label1);
            this.Name = "FormEndResults";
            this.Text = "FormEndResults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInjury;
        private System.Windows.Forms.Label labelBadDay;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelGoodDay;
        private System.Windows.Forms.Label labelMiraclePlay;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonExit;
    }
}