namespace BitWarden_JSON
{
    partial class Results
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            itemBindingSource = new BindingSource(components);
            revisionDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creationDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deletedDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            organizationIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            folderIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            repromptDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            notesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            favoriteDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            secureNoteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            identityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cardDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { revisionDateDataGridViewTextBoxColumn, creationDateDataGridViewTextBoxColumn, deletedDateDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, organizationIdDataGridViewTextBoxColumn, folderIdDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, repromptDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, notesDataGridViewTextBoxColumn, favoriteDataGridViewCheckBoxColumn, secureNoteDataGridViewTextBoxColumn, identityDataGridViewTextBoxColumn, cardDataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn });
            dataGridView1.DataSource = itemBindingSource;
            dataGridView1.Location = new Point(35, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1015, 327);
            dataGridView1.TabIndex = 0;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Item);
            // 
            // revisionDateDataGridViewTextBoxColumn
            // 
            revisionDateDataGridViewTextBoxColumn.DataPropertyName = "revisionDate";
            revisionDateDataGridViewTextBoxColumn.HeaderText = "revisionDate";
            revisionDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            revisionDateDataGridViewTextBoxColumn.Name = "revisionDateDataGridViewTextBoxColumn";
            revisionDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            creationDateDataGridViewTextBoxColumn.DataPropertyName = "creationDate";
            creationDateDataGridViewTextBoxColumn.HeaderText = "creationDate";
            creationDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            creationDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // deletedDateDataGridViewTextBoxColumn
            // 
            deletedDateDataGridViewTextBoxColumn.DataPropertyName = "deletedDate";
            deletedDateDataGridViewTextBoxColumn.HeaderText = "deletedDate";
            deletedDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            deletedDateDataGridViewTextBoxColumn.Name = "deletedDateDataGridViewTextBoxColumn";
            deletedDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // organizationIdDataGridViewTextBoxColumn
            // 
            organizationIdDataGridViewTextBoxColumn.DataPropertyName = "organizationId";
            organizationIdDataGridViewTextBoxColumn.HeaderText = "organizationId";
            organizationIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            organizationIdDataGridViewTextBoxColumn.Name = "organizationIdDataGridViewTextBoxColumn";
            organizationIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // folderIdDataGridViewTextBoxColumn
            // 
            folderIdDataGridViewTextBoxColumn.DataPropertyName = "folderId";
            folderIdDataGridViewTextBoxColumn.HeaderText = "folderId";
            folderIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            folderIdDataGridViewTextBoxColumn.Name = "folderIdDataGridViewTextBoxColumn";
            folderIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            typeDataGridViewTextBoxColumn.HeaderText = "type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // repromptDataGridViewTextBoxColumn
            // 
            repromptDataGridViewTextBoxColumn.DataPropertyName = "reprompt";
            repromptDataGridViewTextBoxColumn.HeaderText = "reprompt";
            repromptDataGridViewTextBoxColumn.MinimumWidth = 8;
            repromptDataGridViewTextBoxColumn.Name = "repromptDataGridViewTextBoxColumn";
            repromptDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            notesDataGridViewTextBoxColumn.HeaderText = "notes";
            notesDataGridViewTextBoxColumn.MinimumWidth = 8;
            notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            notesDataGridViewTextBoxColumn.Width = 150;
            // 
            // favoriteDataGridViewCheckBoxColumn
            // 
            favoriteDataGridViewCheckBoxColumn.DataPropertyName = "favorite";
            favoriteDataGridViewCheckBoxColumn.HeaderText = "favorite";
            favoriteDataGridViewCheckBoxColumn.MinimumWidth = 8;
            favoriteDataGridViewCheckBoxColumn.Name = "favoriteDataGridViewCheckBoxColumn";
            favoriteDataGridViewCheckBoxColumn.Width = 150;
            // 
            // secureNoteDataGridViewTextBoxColumn
            // 
            secureNoteDataGridViewTextBoxColumn.DataPropertyName = "secureNote";
            secureNoteDataGridViewTextBoxColumn.HeaderText = "secureNote";
            secureNoteDataGridViewTextBoxColumn.MinimumWidth = 8;
            secureNoteDataGridViewTextBoxColumn.Name = "secureNoteDataGridViewTextBoxColumn";
            secureNoteDataGridViewTextBoxColumn.Width = 150;
            // 
            // identityDataGridViewTextBoxColumn
            // 
            identityDataGridViewTextBoxColumn.DataPropertyName = "identity";
            identityDataGridViewTextBoxColumn.HeaderText = "identity";
            identityDataGridViewTextBoxColumn.MinimumWidth = 8;
            identityDataGridViewTextBoxColumn.Name = "identityDataGridViewTextBoxColumn";
            identityDataGridViewTextBoxColumn.Width = 150;
            // 
            // cardDataGridViewTextBoxColumn
            // 
            cardDataGridViewTextBoxColumn.DataPropertyName = "card";
            cardDataGridViewTextBoxColumn.HeaderText = "card";
            cardDataGridViewTextBoxColumn.MinimumWidth = 8;
            cardDataGridViewTextBoxColumn.Name = "cardDataGridViewTextBoxColumn";
            cardDataGridViewTextBoxColumn.Width = 150;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            loginDataGridViewTextBoxColumn.HeaderText = "login";
            loginDataGridViewTextBoxColumn.MinimumWidth = 8;
            loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            loginDataGridViewTextBoxColumn.Width = 150;
            // 
            // Results
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 593);
            Controls.Add(dataGridView1);
            Name = "Results";
            Text = "Results";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn revisionDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deletedDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn organizationIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn folderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn repromptDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn favoriteDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn secureNoteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn identityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cardDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private BindingSource itemBindingSource;
    }
}