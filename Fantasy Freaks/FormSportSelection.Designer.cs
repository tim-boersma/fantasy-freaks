namespace Fantasy_Freaks {
    partial class FormSportSelection {
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
            this.title = new System.Windows.Forms.Label();
            this.btnFootball = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("IBM Plex Sans Thai Looped", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(491, 85);
            this.title.TabIndex = 0;
            this.title.Text = "SPORT SELECTION";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFootball
            // 
            this.btnFootball.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.btnFootball.Font = new System.Drawing.Font("IBM Plex Sans Thai Looped", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFootball.Location = new System.Drawing.Point(223, 146);
            this.btnFootball.Name = "btnFootball";
            this.btnFootball.Size = new System.Drawing.Size(526, 121);
            this.btnFootball.TabIndex = 3;
            this.btnFootball.Text = "FOOTBALL";
            this.btnFootball.UseVisualStyleBackColor = false;
            this.btnFootball.Click += new System.EventHandler(this.btnFootball_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 563);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Black;
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.line.Location = new System.Drawing.Point(-1, 80);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(883, 5);
            this.line.TabIndex = 1;
            this.line.TabStop = false;
            // 
            // FormSportSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 672);
            this.ControlBox = false;
            this.Controls.Add(this.btnFootball);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.line);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSportSelection";
            this.Load += new System.EventHandler(this.FormSportSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFootball;
    }
}