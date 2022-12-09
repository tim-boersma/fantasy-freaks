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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBenchSelection));
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
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
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentPlayerModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSeasonPlayerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fantasyFreaksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToAddRows = false;
            this.dgvPlayers.AllowUserToDeleteRows = false;
            this.dgvPlayers.AllowUserToResizeColumns = false;
            this.dgvPlayers.AllowUserToResizeRows = false;
            this.dgvPlayers.AutoGenerateColumns = false;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerNameDataGridViewTextBoxColumn,
            this.playerPositionDataGridViewTextBoxColumn});
            this.dgvPlayers.DataSource = this.currentPlayerModelBindingSource;
            this.dgvPlayers.Location = new System.Drawing.Point(8, 51);
            this.dgvPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPlayers.MultiSelect = false;
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.RowHeadersWidth = 62;
            this.dgvPlayers.RowTemplate.Height = 28;
            this.dgvPlayers.Size = new System.Drawing.Size(351, 610);
            this.dgvPlayers.TabIndex = 0;
            this.dgvPlayers.SelectionChanged += new System.EventHandler(this.dgvPlayers_SelectionChanged);
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
            this.btnSubmit.Location = new System.Drawing.Point(376, 325);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(204, 40);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit Bench";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelection.Location = new System.Drawing.Point(8, 21);
            this.lblSelection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(298, 25);
            this.lblSelection.TabIndex = 2;
            this.lblSelection.Text = "Select 8 Players for Your Bench";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Currently Selected:";
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "PlayerName";
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.playerNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            this.playerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.playerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // playerPositionDataGridViewTextBoxColumn
            // 
            this.playerPositionDataGridViewTextBoxColumn.DataPropertyName = "PlayerPosition";
            this.playerPositionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.playerPositionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.playerPositionDataGridViewTextBoxColumn.Name = "playerPositionDataGridViewTextBoxColumn";
            this.playerPositionDataGridViewTextBoxColumn.ReadOnly = true;
            this.playerPositionDataGridViewTextBoxColumn.Width = 50;
            // 
            // FormBenchSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(602, 672);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvPlayers);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerPositionDataGridViewTextBoxColumn;
    }
}