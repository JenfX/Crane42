namespace EntityFramework
{
    partial class StorehouseForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonReload = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new EntityFramework.Database1DataSet1();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new EntityFramework.Database1DataSet();
            this.itemsTableAdapter = new EntityFramework.Database1DataSetTableAdapters.ItemsTableAdapter();
            this.unitsTableAdapter = new EntityFramework.Database1DataSet1TableAdapters.UnitsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CatNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naming = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonReload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonReload
            // 
            this.toolStripButtonReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReload.Name = "toolStripButtonReload";
            this.toolStripButtonReload.Size = new System.Drawing.Size(109, 22);
            this.toolStripButtonReload.Text = "Обновить данные";
            this.toolStripButtonReload.Click += new System.EventHandler(this.toolStripButtonReload_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.CatNumber,
            this.Naming,
            this.Unit_ID,
            this.Quantity,
            this.Price,
            this.DELETE});
            this.dataGridView.DataSource = this.itemsBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 25);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(934, 536);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            this.dataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_UserAddedRow);
            // 
            // unitsBindingSource
            // 
            this.unitsBindingSource.DataMember = "Units";
            this.unitsBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 25;
            // 
            // CatNumber
            // 
            this.CatNumber.DataPropertyName = "CatNumber";
            this.CatNumber.HeaderText = "Кат. Номер";
            this.CatNumber.Name = "CatNumber";
            this.CatNumber.Width = 125;
            // 
            // Naming
            // 
            this.Naming.DataPropertyName = "Naming";
            this.Naming.HeaderText = "Название";
            this.Naming.Name = "Naming";
            this.Naming.Width = 400;
            // 
            // Unit_ID
            // 
            this.Unit_ID.DataPropertyName = "Unit_ID";
            this.Unit_ID.DataSource = this.unitsBindingSource;
            this.Unit_ID.DisplayMember = "ShortNaming";
            this.Unit_ID.HeaderText = "Ед. изм.";
            this.Unit_ID.Name = "Unit_ID";
            this.Unit_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Unit_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Unit_ID.ValueMember = "Id";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Кол-во";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 60;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Стоимость";
            this.Price.Name = "Price";
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "";
            this.DELETE.Name = "DELETE";
            // 
            // StorehouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "StorehouseForm";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.StorehouseForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonReload;
        private System.Windows.Forms.DataGridView dataGridView;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private Database1DataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private Database1DataSet1TableAdapters.UnitsTableAdapter unitsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CatNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naming;
        private System.Windows.Forms.DataGridViewComboBoxColumn Unit_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn DELETE;
    }
}