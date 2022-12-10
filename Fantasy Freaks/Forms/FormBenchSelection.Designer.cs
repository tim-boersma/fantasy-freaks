namespace Fantasy_Freaks {
    partial class FormBenchSelection {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBenchSelection));
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPlayerModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newSeasonPlayerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fantasyFreaksDataSet = new Fantasy_Freaks.fantasyFreaksDataSet();
            this.newSeasonPlayerTableAdapter = new Fantasy_Freaks.fantasyFreaksDataSetTableAdapters.NewSeasonPlayerTableAdapter();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSelection = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBoxBenchSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPlayerModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSeasonPlayerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantasyFreaksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AllowUserToResizeColumns = false;
            this.dgvPlayers.AllowUserToResizeRows = false;
            this.dgvPlayers.AutoGenerateColumns = false;
            this.dgvPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerNameDataGridViewTextBoxColumn,
            this.playerPositionDataGridViewTextBoxColumn});
            this.dgvPlayers.DataSource = this.currentPlayerModelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(239)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlayers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlayers.Location = new System.Drawing.Point(8, 94);
            this.dgvPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPlayers.MultiSelect = false;
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.RowHeadersWidth = 62;
            this.dgvPlayers.RowTemplate.Height = 28;
            this.dgvPlayers.Size = new System.Drawing.Size(351, 567);
            this.dgvPlayers.TabIndex = 0;
            this.dgvPlayers.SelectionChanged += new System.EventHandler(this.dgvPlayers_SelectionChanged);
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.playerNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            this.playerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // playerPositionDataGridViewTextBoxColumn
            // 
            this.playerPositionDataGridViewTextBoxColumn.DataPropertyName = "PlayerPosition";
            this.playerPositionDataGridViewTextBoxColumn.FillWeight = 30F;
            this.playerPositionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.playerPositionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.playerPositionDataGridViewTextBoxColumn.Name = "playerPositionDataGridViewTextBoxColumn";
            this.playerPositionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentPlayerModelBindingSource
            // 
            this.currentPlayerModelBindingSource.DataSource = typeof(DataAccess.Models.CurrentPlayerModel);
            // 
            // newSeasonPlayerBindingSource
            // 
            this.newSeasonPlayerBindingSource.DataMember = "NewSeasonPlayer";
            this.newSeasonPlayerBindingSource.DataSource = this.fantasyFreaksDataSet;
            // 
            // fantasyFreaksDataSet
            // 
            this.fantasyFreaksDataSet.DataSetName = "fantasyFreaksDataSet";
            this.fantasyFreaksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newSeasonPlayerTableAdapter
            // 
            this.newSeasonPlayerTableAdapter.ClearBeforeFill = true;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(255)))), ((int)(((byte)(165)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(255)))), ((int)(((byte)(138)))));
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(209)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(470, 8);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 40);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelection.Location = new System.Drawing.Point(3, 13);
            this.lblSelection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(305, 24);
            this.lblSelection.TabIndex = 2;
            this.lblSelection.Text = "Select 8 Players for Your Bench";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Currently Selected:";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Black;
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.line.Location = new System.Drawing.Point(-2, 42);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(300, 3);
            this.line.TabIndex = 6;
            this.line.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 617);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(290, 349);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 3);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // textBoxBenchSearch
            // 
            this.textBoxBenchSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBenchSearch.Location = new System.Drawing.Point(7, 63);
            this.textBoxBenchSearch.Name = "textBoxBenchSearch";
            this.textBoxBenchSearch.Size = new System.Drawing.Size(352, 26);
            this.textBoxBenchSearch.TabIndex = 0;
            this.textBoxBenchSearch.TextChanged += new System.EventHandler(this.textBoxBenchSearch_TextChanged);
            // 
            // FormBenchSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(602, 672);
            this.Controls.Add(this.textBoxBenchSearch);
            this.Controls.Add(this.line);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBenchSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Selection";
            this.Load += new System.EventHandler(this.FormPlayerSelection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPlayerModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSeasonPlayerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantasyFreaksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayers;
        private fantasyFreaksDataSet fantasyFreaksDataSet;
        private System.Windows.Forms.BindingSource newSeasonPlayerBindingSource;
        private fantasyFreaksDataSetTableAdapters.NewSeasonPlayerTableAdapter newSeasonPlayerTableAdapter;
        private System.Windows.Forms.BindingSource currentPlayerModelBindingSource;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxBenchSearch;
    }
}