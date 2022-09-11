namespace EntityFramework
{
    partial class RequestsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Crane_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cranesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetReq = new EntityFramework.Database1DataSetReq();
            this.Driver_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.driversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RequestText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestsTableAdapter = new EntityFramework.Database1DataSetReqTableAdapters.RequestsTableAdapter();
            this.cranesTableAdapter = new EntityFramework.Database1DataSetReqTableAdapters.CranesTableAdapter();
            this.driversTableAdapter = new EntityFramework.Database1DataSetReqTableAdapters.DriversTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cranesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUpdate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(879, 25);
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
            this.Date,
            this.Crane_ID,
            this.Driver_ID,
            this.RequestText,
            this.DELETE});
            this.dataGridView.DataSource = this.requestsBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 25);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(879, 436);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView_UserAddedRow);
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
            // cranesBindingSource
            // 
            this.cranesBindingSource.DataMember = "Cranes";
            this.cranesBindingSource.DataSource = this.database1DataSetReq;
            // 
            // database1DataSetReq
            // 
            this.database1DataSetReq.DataSetName = "Database1DataSetReq";
            this.database1DataSetReq.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // driversBindingSource
            // 
            this.driversBindingSource.DataMember = "Drivers";
            this.driversBindingSource.DataSource = this.database1DataSetReq;
            // 
            // RequestText
            // 
            this.RequestText.DataPropertyName = "RequestText";
            this.RequestText.HeaderText = "Заявка";
            this.RequestText.Name = "RequestText";
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "";
            this.DELETE.Name = "DELETE";
            // 
            // requestsBindingSource
            // 
            this.requestsBindingSource.DataMember = "Requests";
            this.requestsBindingSource.DataSource = this.database1DataSetReq;
            // 
            // requestsTableAdapter
            // 
            this.requestsTableAdapter.ClearBeforeFill = true;
            // 
            // cranesTableAdapter
            // 
            this.cranesTableAdapter.ClearBeforeFill = true;
            // 
            // driversTableAdapter
            // 
            this.driversTableAdapter.ClearBeforeFill = true;
            // 
            // RequestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 461);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(895, 500);
            this.MinimumSize = new System.Drawing.Size(895, 500);
            this.Name = "RequestsForm";
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.RequestsForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cranesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.DataGridView dataGridView;
        private Database1DataSetReq database1DataSetReq;
        private System.Windows.Forms.BindingSource requestsBindingSource;
        private Database1DataSetReqTableAdapters.RequestsTableAdapter requestsTableAdapter;
        private System.Windows.Forms.BindingSource cranesBindingSource;
        private Database1DataSetReqTableAdapters.CranesTableAdapter cranesTableAdapter;
        private System.Windows.Forms.BindingSource driversBindingSource;
        private Database1DataSetReqTableAdapters.DriversTableAdapter driversTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewComboBoxColumn Crane_ID;
        private System.Windows.Forms.DataGridViewComboBoxColumn Driver_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequestText;
        private System.Windows.Forms.DataGridViewTextBoxColumn DELETE;
    }
}