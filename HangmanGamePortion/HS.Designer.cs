namespace HangmanGamePortion
{
    partial class HS
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.highscoreData = new HangmanGamePortion.HighscoreData();
            this.highscoreDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highscoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.highscoresTableAdapter = new HangmanGamePortion.HighscoreDataTableAdapters.HighscoresTableAdapter();
            this.gameIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoreData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoreDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameIDDataGridViewTextBoxColumn,
            this.tDateDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.iScoreDataGridViewTextBoxColumn,
            this.roundsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.highscoresBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // highscoreData
            // 
            this.highscoreData.DataSetName = "HighscoreData";
            this.highscoreData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // highscoreDataBindingSource
            // 
            this.highscoreDataBindingSource.DataSource = this.highscoreData;
            this.highscoreDataBindingSource.Position = 0;
            // 
            // highscoresBindingSource
            // 
            this.highscoresBindingSource.DataMember = "Highscores";
            this.highscoresBindingSource.DataSource = this.highscoreDataBindingSource;
            // 
            // highscoresTableAdapter
            // 
            this.highscoresTableAdapter.ClearBeforeFill = true;
            // 
            // gameIDDataGridViewTextBoxColumn
            // 
            this.gameIDDataGridViewTextBoxColumn.DataPropertyName = "GameID";
            this.gameIDDataGridViewTextBoxColumn.HeaderText = "GameID";
            this.gameIDDataGridViewTextBoxColumn.Name = "gameIDDataGridViewTextBoxColumn";
            // 
            // tDateDataGridViewTextBoxColumn
            // 
            this.tDateDataGridViewTextBoxColumn.DataPropertyName = "tDate";
            this.tDateDataGridViewTextBoxColumn.HeaderText = "tDate";
            this.tDateDataGridViewTextBoxColumn.Name = "tDateDataGridViewTextBoxColumn";
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "sName";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "sName";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            // 
            // iScoreDataGridViewTextBoxColumn
            // 
            this.iScoreDataGridViewTextBoxColumn.DataPropertyName = "iScore";
            this.iScoreDataGridViewTextBoxColumn.HeaderText = "iScore";
            this.iScoreDataGridViewTextBoxColumn.Name = "iScoreDataGridViewTextBoxColumn";
            // 
            // roundsDataGridViewTextBoxColumn
            // 
            this.roundsDataGridViewTextBoxColumn.DataPropertyName = "Rounds";
            this.roundsDataGridViewTextBoxColumn.HeaderText = "Rounds";
            this.roundsDataGridViewTextBoxColumn.Name = "roundsDataGridViewTextBoxColumn";
            // 
            // HS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HS";
            this.Text = "HS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HS_FormClosing);
            this.Load += new System.EventHandler(this.HS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoreData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoreDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highscoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource highscoreDataBindingSource;
        private HighscoreData highscoreData;
        private System.Windows.Forms.BindingSource highscoresBindingSource;
        private HighscoreDataTableAdapters.HighscoresTableAdapter highscoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundsDataGridViewTextBoxColumn;
    }
}