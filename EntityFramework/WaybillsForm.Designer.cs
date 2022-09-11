namespace EntityFramework
{
    partial class WaybillsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaybillsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cranesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetWB = new EntityFramework.Database1DataSetWB();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetWBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workObjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waybillsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waybillsTableAdapter = new EntityFramework.Database1DataSetWBTableAdapters.WaybillsTableAdapter();
            this.cranesTableAdapter = new EntityFramework.Database1DataSetWBTableAdapters.CranesTableAdapter();
            this.driversTableAdapter = new EntityFramework.Database1DataSetWBTableAdapters.DriversTableAdapter();
            this.customersTableAdapter = new EntityFramework.Database1DataSetWBTableAdapters.CustomersTableAdapter();
            this.workObjectsTableAdapter = new EntityFramework.Database1DataSetWBTableAdapters.WorkObjectsTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crane_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Driver_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WorkTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WorkObject_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tariff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefillPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cranesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetWB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetWBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workObjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waybillsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUpdate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1189, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonUpdate
            // 
            this.toolStripButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdate.Image")));
            this.toolStripButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            this.toolStripButtonUpdate.Size = new System.Drawing.Size(109, 22);
            this.toolStripButtonUpdate.Text = "Обновить данные";
            this.toolStripButtonUpdate.Click += new System.EventHandler(this.toolStripButtonUpdate_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Crane_ID,
            this.Driver_ID,
            this.WorkTime,
            this.Customer_ID,
            this.WorkObject_ID,
            this.Address,
            this.Tariff,
            this.Payment,
            this.Refill,
            this.RefillPrice,
            this.DELETE});
            this.dataGridView.DataSource = this.waybillsBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 25);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1189, 836);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellValueChanged);
            this.dataGridView.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView_EditingControlShowing);
            this.dataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_UserAddedRow);
            // 
            // cranesBindingSource
            // 
            this.cranesBindingSource.DataMember = "Cranes";
            this.cranesBindingSource.DataSource = this.database1DataSetWB;
            // 
            // database1DataSetWB
            // 
            this.database1DataSetWB.DataSetName = "Database1DataSetWB";
            this.database1DataSetWB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.database1DataSetWBBindingSource;
            // 
            // database1DataSetWBBindingSource
            // 
            this.database1DataSetWBBindingSource.DataSource = this.database1DataSetWB;
            this.database1DataSetWBBindingSource.Position = 0;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.database1DataSetWBBindingSource;
            // 
            // workObjectsBindingSource
            // 
            this.workObjectsBindingSource.DataMember = "WorkObjects";
            this.workObjectsBindingSource.DataSource = this.database1DataSetWBBindingSource;
            // 
            // waybillsBindingSource
            // 
            this.waybillsBindingSource.DataMember = "Waybills";
            this.waybillsBindingSource.DataSource = this.database1DataSetWB;
            // 
            // waybillsTableAdapter
            // 
            this.waybillsTableAdapter.ClearBeforeFill = true;
            // 
            // cranesTableAdapter
            // 
            this.cranesTableAdapter.ClearBeforeFill = true;
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // workObjectsTableAdapter
            // 
            this.workObjectsTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            // 
            // Crane_ID
            // 
            this.Crane_ID.DataPropertyName = "Crane_ID";
            this.Crane_ID.DataSource = this.cranesBindingSource;
            this.Crane_ID.DisplayMember = "Number";
            this.Crane_ID.HeaderText = "Кран";
            this.Crane_ID.Name = "Crane_ID";
            this.Crane_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Crane_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Crane_ID.ValueMember = "Id";
            // 
            // Driver_ID
            // 
            this.Driver_ID.DataPropertyName = "Driver_ID";
            this.Driver_ID.DataSource = this.driversBindingSource;
            this.Driver_ID.DisplayMember = "FullName";
            this.Driver_ID.HeaderText = "Водитель";
            this.Driver_ID.Name = "Driver_ID";
            this.Driver_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Driver_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Driver_ID.ValueMember = "Id";
            // 
            // WorkTime
            // 
            this.WorkTime.DataPropertyName = "WorkTime";
            this.WorkTime.HeaderText = "Вр.Раб.";
            this.WorkTime.Name = "WorkTime";
            // 
            // Customer_ID
            // 
            this.Customer_ID.DataPropertyName = "Customer_ID";
            this.Customer_ID.DataSource = this.customersBindingSource;
            this.Customer_ID.DisplayMember = "Naming";
            this.Customer_ID.HeaderText = "Заказчик";
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Customer_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Customer_ID.ValueMember = "Id";
            // 
            // WorkObject_ID
            // 
            this.WorkObject_ID.DataPropertyName = "WorkObject_ID";
            this.WorkObject_ID.DataSource = this.workObjectsBindingSource;
            this.WorkObject_ID.DisplayMember = "Naming";
            this.WorkObject_ID.HeaderText = "Объект";
            this.WorkObject_ID.Name = "WorkObject_ID";
            this.WorkObject_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WorkObject_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WorkObject_ID.ValueMember = "Id";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            // 
            // Tariff
            // 
            this.Tariff.DataPropertyName = "Tariff";
            this.Tariff.HeaderText = "Тариф";
            this.Tariff.Name = "Tariff";
            // 
            // Payment
            // 
            this.Payment.DataPropertyName = "Payment";
            this.Payment.HeaderText = "Оплата";
            this.Payment.Name = "Payment";
            this.Payment.ReadOnly = true;
            // 
            // Refill
            // 
            this.Refill.DataPropertyName = "Refill";
            this.Refill.HeaderText = "Заправка";
            this.Refill.Name = "Refill";
            // 
            // RefillPrice
            // 
            this.RefillPrice.DataPropertyName = "RefillPrice";
            this.RefillPrice.HeaderText = "Зап-ка Стоимость";
            this.RefillPrice.Name = "RefillPrice";
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "";
            this.DELETE.Name = "DELETE";
            // 
            // WaybillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 861);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1205, 900);
            this.MinimumSize = new System.Drawing.Size(1205, 900);
            this.Name = "WaybillsForm";
            this.Text = "Путевые листы";
            this.Load += new System.EventHandler(this.WaybillsForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cranesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetWB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetWBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workObjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waybillsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource database1DataSetWBBindingSource;
        private Database1DataSetWB database1DataSetWB;
        private System.Windows.Forms.BindingSource waybillsBindingSource;
        private Database1DataSetWBTableAdapters.WaybillsTableAdapter waybillsTableAdapter;
        private System.Windows.Forms.BindingSource cranesBindingSource;
        private Database1DataSetWBTableAdapters.CranesTableAdapter cranesTableAdapter;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private Database1DataSetWBTableAdapters.DriversTableAdapter driversTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Database1DataSetWBTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource workObjectsBindingSource;
        private Database1DataSetWBTableAdapters.WorkObjectsTableAdapter workObjectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewComboBoxColumn Crane_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Driver_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkTime;
        private System.Windows.Forms.DataGridViewComboBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn WorkObject_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tariff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Refill;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefillPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DELETE;
    }
}