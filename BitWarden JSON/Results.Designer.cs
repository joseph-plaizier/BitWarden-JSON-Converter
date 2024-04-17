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
            itemBindingSource = new BindingSource(components);
            loginBindingSource = new BindingSource(components);
            cardBindingSource = new BindingSource(components);
            rootobjectBindingSource = new BindingSource(components);
            identityBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            securenoteBindingSource = new BindingSource(components);
            Columns = new Button();
            showColumns = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rootobjectBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)identityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)securenoteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { revisionDateDataGridViewTextBoxColumn, creationDateDataGridViewTextBoxColumn, deletedDateDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, organizationIdDataGridViewTextBoxColumn, folderIdDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, repromptDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, notesDataGridViewTextBoxColumn, favoriteDataGridViewCheckBoxColumn, secureNoteDataGridViewTextBoxColumn, identityDataGridViewTextBoxColumn, cardDataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn });
            dataGridView1.DataSource = itemBindingSource;
            dataGridView1.Location = new Point(35, 48);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1015, 255);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // revisionDateDataGridViewTextBoxColumn
            // 
            revisionDateDataGridViewTextBoxColumn.DataPropertyName = "revisionDate";
            revisionDateDataGridViewTextBoxColumn.HeaderText = "revisionDate";
            revisionDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            revisionDateDataGridViewTextBoxColumn.Name = "revisionDateDataGridViewTextBoxColumn";
            revisionDateDataGridViewTextBoxColumn.ReadOnly = true;
            revisionDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            creationDateDataGridViewTextBoxColumn.DataPropertyName = "creationDate";
            creationDateDataGridViewTextBoxColumn.HeaderText = "creationDate";
            creationDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            creationDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // deletedDateDataGridViewTextBoxColumn
            // 
            deletedDateDataGridViewTextBoxColumn.DataPropertyName = "deletedDate";
            deletedDateDataGridViewTextBoxColumn.HeaderText = "deletedDate";
            deletedDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            deletedDateDataGridViewTextBoxColumn.Name = "deletedDateDataGridViewTextBoxColumn";
            deletedDateDataGridViewTextBoxColumn.ReadOnly = true;
            deletedDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "id";
            idDataGridViewTextBoxColumn.HeaderText = "id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // organizationIdDataGridViewTextBoxColumn
            // 
            organizationIdDataGridViewTextBoxColumn.DataPropertyName = "organizationId";
            organizationIdDataGridViewTextBoxColumn.HeaderText = "organizationId";
            organizationIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            organizationIdDataGridViewTextBoxColumn.Name = "organizationIdDataGridViewTextBoxColumn";
            organizationIdDataGridViewTextBoxColumn.ReadOnly = true;
            organizationIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // folderIdDataGridViewTextBoxColumn
            // 
            folderIdDataGridViewTextBoxColumn.DataPropertyName = "folderId";
            folderIdDataGridViewTextBoxColumn.HeaderText = "folderId";
            folderIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            folderIdDataGridViewTextBoxColumn.Name = "folderIdDataGridViewTextBoxColumn";
            folderIdDataGridViewTextBoxColumn.ReadOnly = true;
            folderIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            typeDataGridViewTextBoxColumn.HeaderText = "type";
            typeDataGridViewTextBoxColumn.MinimumWidth = 8;
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            typeDataGridViewTextBoxColumn.Width = 150;
            // 
            // repromptDataGridViewTextBoxColumn
            // 
            repromptDataGridViewTextBoxColumn.DataPropertyName = "reprompt";
            repromptDataGridViewTextBoxColumn.HeaderText = "reprompt";
            repromptDataGridViewTextBoxColumn.MinimumWidth = 8;
            repromptDataGridViewTextBoxColumn.Name = "repromptDataGridViewTextBoxColumn";
            repromptDataGridViewTextBoxColumn.ReadOnly = true;
            repromptDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = "name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            notesDataGridViewTextBoxColumn.HeaderText = "notes";
            notesDataGridViewTextBoxColumn.MinimumWidth = 8;
            notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            notesDataGridViewTextBoxColumn.ReadOnly = true;
            notesDataGridViewTextBoxColumn.Width = 150;
            // 
            // favoriteDataGridViewCheckBoxColumn
            // 
            favoriteDataGridViewCheckBoxColumn.DataPropertyName = "favorite";
            favoriteDataGridViewCheckBoxColumn.HeaderText = "favorite";
            favoriteDataGridViewCheckBoxColumn.MinimumWidth = 8;
            favoriteDataGridViewCheckBoxColumn.Name = "favoriteDataGridViewCheckBoxColumn";
            favoriteDataGridViewCheckBoxColumn.ReadOnly = true;
            favoriteDataGridViewCheckBoxColumn.Width = 150;
            // 
            // secureNoteDataGridViewTextBoxColumn
            // 
            secureNoteDataGridViewTextBoxColumn.DataPropertyName = "secureNote";
            secureNoteDataGridViewTextBoxColumn.HeaderText = "secureNote";
            secureNoteDataGridViewTextBoxColumn.MinimumWidth = 8;
            secureNoteDataGridViewTextBoxColumn.Name = "secureNoteDataGridViewTextBoxColumn";
            secureNoteDataGridViewTextBoxColumn.ReadOnly = true;
            secureNoteDataGridViewTextBoxColumn.Width = 150;
            // 
            // identityDataGridViewTextBoxColumn
            // 
            identityDataGridViewTextBoxColumn.DataPropertyName = "identity";
            identityDataGridViewTextBoxColumn.HeaderText = "identity";
            identityDataGridViewTextBoxColumn.MinimumWidth = 8;
            identityDataGridViewTextBoxColumn.Name = "identityDataGridViewTextBoxColumn";
            identityDataGridViewTextBoxColumn.ReadOnly = true;
            identityDataGridViewTextBoxColumn.Width = 150;
            // 
            // cardDataGridViewTextBoxColumn
            // 
            cardDataGridViewTextBoxColumn.DataPropertyName = "card";
            cardDataGridViewTextBoxColumn.HeaderText = "card";
            cardDataGridViewTextBoxColumn.MinimumWidth = 8;
            cardDataGridViewTextBoxColumn.Name = "cardDataGridViewTextBoxColumn";
            cardDataGridViewTextBoxColumn.ReadOnly = true;
            cardDataGridViewTextBoxColumn.Width = 150;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            loginDataGridViewTextBoxColumn.HeaderText = "login";
            loginDataGridViewTextBoxColumn.MinimumWidth = 8;
            loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            loginDataGridViewTextBoxColumn.ReadOnly = true;
            loginDataGridViewTextBoxColumn.Width = 150;
            // 
            // itemBindingSource
            // 
            itemBindingSource.DataSource = typeof(Item);
            // 
            // loginBindingSource
            // 
            loginBindingSource.DataSource = typeof(Login);
            // 
            // cardBindingSource
            // 
            cardBindingSource.DataSource = typeof(Card);
            // 
            // rootobjectBindingSource
            // 
            rootobjectBindingSource.DataSource = typeof(Rootobject);
            // 
            // identityBindingSource
            // 
            identityBindingSource.DataSource = typeof(Identity);
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(39, 341);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1011, 225);
            dataGridView2.TabIndex = 1;
            // 
            // securenoteBindingSource
            // 
            securenoteBindingSource.DataSource = typeof(Securenote);
            // 
            // Columns
            // 
            Columns.Location = new Point(1078, 83);
            Columns.Name = "Columns";
            Columns.Size = new Size(127, 65);
            Columns.TabIndex = 2;
            Columns.Text = "Hide Columns";
            Columns.UseVisualStyleBackColor = true;
            Columns.Click += Columns_Click;
            // 
            // showColumns
            // 
            showColumns.Location = new Point(1078, 184);
            showColumns.Name = "showColumns";
            showColumns.Size = new Size(127, 65);
            showColumns.TabIndex = 3;
            showColumns.Text = "Show All Columns";
            showColumns.UseVisualStyleBackColor = true;
            showColumns.Click += showColumns_Click;
            // 
            // Results
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 753);
            Controls.Add(showColumns);
            Controls.Add(Columns);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Results";
            Text = "Results";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rootobjectBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)identityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)securenoteBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource itemBindingSource;
        private BindingSource loginBindingSource;
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
        private BindingSource cardBindingSource;
        private BindingSource rootobjectBindingSource;
        private BindingSource identityBindingSource;
        private DataGridView dataGridView2;
        private BindingSource securenoteBindingSource;
        private Button Columns;
        private Button showColumns;
    }
}