namespace Fantasy_Freaks {
    partial class FormHomeScreen {
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.titleBackground = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(328, 447);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(328, 78);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(0)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(910, 600);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(60, 60);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = " ?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // logo
            // 
            this.logo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::Fantasy_Freaks.Properties.Resources.FFlogo_black;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Location = new System.Drawing.Point(-1, 245);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(985, 185);
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // titleBackground
            // 
            this.titleBackground.BackgroundImage = global::Fantasy_Freaks.Properties.Resources.titlepic;
            this.titleBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titleBackground.Location = new System.Drawing.Point(-1, 0);
            this.titleBackground.Name = "titleBackground";
            this.titleBackground.Size = new System.Drawing.Size(985, 672);
            this.titleBackground.TabIndex = 4;
            this.titleBackground.TabStop = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 132);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(984, 161);
            this.title.TabIndex = 0;
            this.title.Text = "FANTASY FREAKS";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(984, 672);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.title);
            this.Controls.Add(this.titleBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHomeScreen";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.FormHomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titleBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox titleBackground;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button1;
    }
}