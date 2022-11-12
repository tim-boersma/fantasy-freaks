
namespace Fantasy_Freaks
{
    partial class FormHelpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelpScreen));
            this.WhatIsFFDesc = new System.Windows.Forms.Label();
            this.WhatIsFF = new System.Windows.Forms.Label();
            this.Rules = new System.Windows.Forms.Label();
            this.RulesDesc = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WhatIsFFDesc
            // 
            this.WhatIsFFDesc.AutoSize = true;
            this.WhatIsFFDesc.Location = new System.Drawing.Point(47, 78);
            this.WhatIsFFDesc.Name = "WhatIsFFDesc";
            this.WhatIsFFDesc.Size = new System.Drawing.Size(643, 78);
            this.WhatIsFFDesc.TabIndex = 0;
            this.WhatIsFFDesc.Text = resources.GetString("WhatIsFFDesc.Text");
            // 
            // WhatIsFF
            // 
            this.WhatIsFF.AutoSize = true;
            this.WhatIsFF.Location = new System.Drawing.Point(47, 53);
            this.WhatIsFF.Name = "WhatIsFF";
            this.WhatIsFF.Size = new System.Drawing.Size(118, 13);
            this.WhatIsFF.TabIndex = 1;
            this.WhatIsFF.Text = "What is Fantasy Freaks";
            // 
            // Rules
            // 
            this.Rules.AutoSize = true;
            this.Rules.Location = new System.Drawing.Point(47, 177);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(138, 13);
            this.Rules.TabIndex = 2;
            this.Rules.Text = "How to play Fantasy Freaks";
            // 
            // RulesDesc
            // 
            this.RulesDesc.AutoSize = true;
            this.RulesDesc.Location = new System.Drawing.Point(48, 200);
            this.RulesDesc.Name = "RulesDesc";
            this.RulesDesc.Size = new System.Drawing.Size(672, 117);
            this.RulesDesc.TabIndex = 3;
            this.RulesDesc.Text = resources.GetString("RulesDesc.Text");
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(585, 372);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(134, 52);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Back";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // FormHelpScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.RulesDesc);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.WhatIsFF);
            this.Controls.Add(this.WhatIsFFDesc);
            this.Name = "FormHelpScreen";
            this.Text = "FormHelpScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WhatIsFFDesc;
        private System.Windows.Forms.Label WhatIsFF;
        private System.Windows.Forms.Label Rules;
        private System.Windows.Forms.Label RulesDesc;
        private System.Windows.Forms.Button btnHome;
    }
}