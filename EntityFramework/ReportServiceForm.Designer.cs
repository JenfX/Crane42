namespace EntityFramework
{
    partial class ReportServiceForm
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
            this.comboBoxDriver = new System.Windows.Forms.ComboBox();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetWB = new EntityFramework.Database1DataSetWB();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.checkBoxDriver = new System.Windows.Forms.CheckBox();
            this.checkBoxCrane = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCrane = new System.Windows.Forms.ComboBox();
            this.cranesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxCustomer = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxObject = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxObject = new System.Windows.Forms.ComboBox();
            this.workObjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonExport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.driversTableAdapter = new EntityFramework.Database1DataSetWBTableAdapters.DriversTableAdapter();
            this.cranesTableAdapter = new EntityFramework.Database1DataSetWBTableAdapters.CranesTableAdapter();
            this.customersTableAdapter = new EntityFramework.Database1DataSetWBTableAdapters.CustomersTableAdapter();
            this.workObjectsTableAdapter = new EntityFramework.Database1DataSetWBTableAdapters.WorkObjectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetWB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cranesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workObjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDriver
            // 
            this.comboBoxDriver.DataSource = this.driversBindingSource;
            this.comboBoxDriver.DisplayMember = "FullName";
            this.comboBoxDriver.FormattingEnabled = true;
            this.comboBoxDriver.Location = new System.Drawing.Point(284, 70);
            this.comboBoxDriver.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDriver.Name = "comboBoxDriver";
            this.comboBoxDriver.Size = new System.Drawing.Size(201, 24);
            this.comboBoxDriver.TabIndex = 0;
            this.comboBoxDriver.ValueMember = "Id";
            this.comboBoxDriver.SelectedIndexChanged += new System.EventHandler(this.comboBoxDriver_SelectedIndexChanged);
            // 
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.database1DataSetWB;
            // 
            // database1DataSetWB
            // 
            this.database1DataSetWB.DataSetName = "Database1DataSetWB";
            this.database1DataSetWB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerStart.Location = new System.Drawing.Point(47, 27);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(201, 22);
            this.dateTimePickerStart.TabIndex = 1;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerEnd.Location = new System.Drawing.Point(284, 27);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(201, 22);
            this.dateTimePickerEnd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "От:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "До:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Водитель:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.Location = new System.Drawing.Point(493, 27);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(152, 163);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Сформировать";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // checkBoxDriver
            // 
            this.checkBoxDriver.AutoSize = true;
            this.checkBoxDriver.Location = new System.Drawing.Point(261, 75);
            this.checkBoxDriver.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxDriver.Name = "checkBoxDriver";
            this.checkBoxDriver.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDriver.TabIndex = 7;
            this.checkBoxDriver.UseVisualStyleBackColor = true;
            // 
            // checkBoxCrane
            // 
            this.checkBoxCrane.AutoSize = true;
            this.checkBoxCrane.Location = new System.Drawing.Point(261, 107);
            this.checkBoxCrane.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCrane.Name = "checkBoxCrane";
            this.checkBoxCrane.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCrane.TabIndex = 10;
            this.checkBoxCrane.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "АТС:";
            // 
            // comboBoxCrane
            // 
            this.comboBoxCrane.DataSource = this.cranesBindingSource;
            this.comboBoxCrane.DisplayMember = "Number";
            this.comboBoxCrane.FormattingEnabled = true;
            this.comboBoxCrane.Location = new System.Drawing.Point(284, 102);
            this.comboBoxCrane.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCrane.Name = "comboBoxCrane";
            this.comboBoxCrane.Size = new System.Drawing.Size(201, 24);
            this.comboBoxCrane.TabIndex = 8;
            this.comboBoxCrane.ValueMember = "Id";
            this.comboBoxCrane.SelectedIndexChanged += new System.EventHandler(this.comboBoxCrane_SelectedIndexChanged);
            // 
            // cranesBindingSource
            // 
            this.cranesBindingSource.DataMember = "Cranes";
            this.cranesBindingSource.DataSource = this.database1DataSetWB;
            // 
            // checkBoxCustomer
            // 
            this.checkBoxCustomer.AutoSize = true;
            this.checkBoxCustomer.Location = new System.Drawing.Point(261, 139);
            this.checkBoxCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCustomer.Name = "checkBoxCustomer";
            this.checkBoxCustomer.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCustomer.TabIndex = 13;
            this.checkBoxCustomer.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Заказчик:";
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.DataSource = this.customersBindingSource;
            this.comboBoxCustomer.DisplayMember = "Naming";
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(284, 134);
            this.comboBoxCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(201, 24);
            this.comboBoxCustomer.TabIndex = 11;
            this.comboBoxCustomer.ValueMember = "Id";
            this.comboBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomer_SelectedIndexChanged);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.database1DataSetWB;
            // 
            // checkBoxObject
            // 
            this.checkBoxObject.AutoSize = true;
            this.checkBoxObject.Location = new System.Drawing.Point(261, 171);
            this.checkBoxObject.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxObject.Name = "checkBoxObject";
            this.checkBoxObject.Size = new System.Drawing.Size(15, 14);
            this.checkBoxObject.TabIndex = 16;
            this.checkBoxObject.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Объект:";
            // 
            // comboBoxObject
            // 
            this.comboBoxObject.DataSource = this.workObjectsBindingSource;
            this.comboBoxObject.DisplayMember = "Naming";
            this.comboBoxObject.FormattingEnabled = true;
            this.comboBoxObject.Location = new System.Drawing.Point(284, 166);
            this.comboBoxObject.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxObject.Name = "comboBoxObject";
            this.comboBoxObject.Size = new System.Drawing.Size(201, 24);
            this.comboBoxObject.TabIndex = 14;
            this.comboBoxObject.ValueMember = "Id";
            this.comboBoxObject.SelectedIndexChanged += new System.EventHandler(this.comboBoxObject_SelectedIndexChanged);
            // 
            // workObjectsBindingSource
            // 
            this.workObjectsBindingSource.DataMember = "WorkObjects";
            this.workObjectsBindingSource.DataSource = this.database1DataSetWB;
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExport.Location = new System.Drawing.Point(652, 27);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(152, 163);
            this.buttonExport.TabIndex = 17;
            this.buttonExport.Text = "Выгрузить в Excel";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(22, 217);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(782, 321);
            this.dgvReport.TabIndex = 18;
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // cranesTableAdapter
            // 
            this.cranesTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // workObjectsTableAdapter
            // 
            this.workObjectsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 576);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.checkBoxObject);
            this.Controls.Add(this.comboBoxDriver);
            this.Controls.Add(this.comboBoxCrane);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.checkBoxDriver);
            this.Controls.Add(this.comboBoxObject);
            this.Controls.Add(this.checkBoxCrane);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.checkBoxCustomer);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(845, 615);
            this.MinimumSize = new System.Drawing.Size(845, 615);
            this.Name = "ReportServiceForm";
            this.Text = "Реестр услуг";
            this.Load += new System.EventHandler(this.ReportServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetWB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cranesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workObjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDriver;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.CheckBox checkBoxDriver;
        private System.Windows.Forms.CheckBox checkBoxCrane;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCrane;
        private System.Windows.Forms.CheckBox checkBoxCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.CheckBox checkBoxObject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxObject;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.DataGridView dgvReport;
        private Database1DataSetWB database1DataSetWB;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private Database1DataSetWBTableAdapters.DriversTableAdapter driversTableAdapter;
        private System.Windows.Forms.BindingSource cranesBindingSource;
        private Database1DataSetWBTableAdapters.CranesTableAdapter cranesTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Database1DataSetWBTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource workObjectsBindingSource;
        private Database1DataSetWBTableAdapters.WorkObjectsTableAdapter workObjectsTableAdapter;
    }
}