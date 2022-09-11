namespace EntityFramework
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonWaybills = new System.Windows.Forms.Button();
            this.buttonDrivers = new System.Windows.Forms.Button();
            this.buttonCranes = new System.Windows.Forms.Button();
            this.buttonRequests = new System.Windows.Forms.Button();
            this.buttonStorehouse = new System.Windows.Forms.Button();
            this.buttonReportService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.buttonWorkObjects = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRequests = new System.Windows.Forms.DataGridView();
            this.Requests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWaybills
            // 
            this.buttonWaybills.Enabled = false;
            this.buttonWaybills.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonWaybills.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonWaybills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWaybills.Location = new System.Drawing.Point(12, 12);
            this.buttonWaybills.Name = "buttonWaybills";
            this.buttonWaybills.Size = new System.Drawing.Size(222, 29);
            this.buttonWaybills.TabIndex = 1;
            this.buttonWaybills.Text = "Путевые листы";
            this.buttonWaybills.UseVisualStyleBackColor = true;
            this.buttonWaybills.Click += new System.EventHandler(this.buttonWaybills_Click);
            // 
            // buttonDrivers
            // 
            this.buttonDrivers.Enabled = false;
            this.buttonDrivers.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDrivers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrivers.Location = new System.Drawing.Point(12, 82);
            this.buttonDrivers.Name = "buttonDrivers";
            this.buttonDrivers.Size = new System.Drawing.Size(222, 29);
            this.buttonDrivers.TabIndex = 3;
            this.buttonDrivers.Text = "Водители";
            this.buttonDrivers.UseVisualStyleBackColor = true;
            this.buttonDrivers.Click += new System.EventHandler(this.buttonDrivers_Click);
            // 
            // buttonCranes
            // 
            this.buttonCranes.Enabled = false;
            this.buttonCranes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCranes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCranes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCranes.Location = new System.Drawing.Point(12, 117);
            this.buttonCranes.Name = "buttonCranes";
            this.buttonCranes.Size = new System.Drawing.Size(222, 29);
            this.buttonCranes.TabIndex = 4;
            this.buttonCranes.Text = "Краны";
            this.buttonCranes.UseVisualStyleBackColor = true;
            this.buttonCranes.Click += new System.EventHandler(this.buttonCranes_Click);
            // 
            // buttonRequests
            // 
            this.buttonRequests.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonRequests.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonRequests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRequests.Location = new System.Drawing.Point(438, 12);
            this.buttonRequests.Name = "buttonRequests";
            this.buttonRequests.Size = new System.Drawing.Size(284, 29);
            this.buttonRequests.TabIndex = 7;
            this.buttonRequests.Text = "Заявки";
            this.buttonRequests.UseVisualStyleBackColor = true;
            this.buttonRequests.Click += new System.EventHandler(this.buttonRequests_Click);
            // 
            // buttonStorehouse
            // 
            this.buttonStorehouse.Enabled = false;
            this.buttonStorehouse.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonStorehouse.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonStorehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStorehouse.Location = new System.Drawing.Point(12, 47);
            this.buttonStorehouse.Name = "buttonStorehouse";
            this.buttonStorehouse.Size = new System.Drawing.Size(222, 29);
            this.buttonStorehouse.TabIndex = 2;
            this.buttonStorehouse.Text = "Зап.Части";
            this.buttonStorehouse.UseVisualStyleBackColor = true;
            this.buttonStorehouse.Click += new System.EventHandler(this.buttonStorehouse_Click);
            // 
            // buttonReportService
            // 
            this.buttonReportService.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonReportService.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonReportService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportService.Location = new System.Drawing.Point(12, 328);
            this.buttonReportService.Name = "buttonReportService";
            this.buttonReportService.Size = new System.Drawing.Size(222, 33);
            this.buttonReportService.TabIndex = 9;
            this.buttonReportService.Text = "Реестр услуг";
            this.buttonReportService.UseVisualStyleBackColor = true;
            this.buttonReportService.Click += new System.EventHandler(this.buttonReportDriverWorkTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Отчёты";
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.Enabled = false;
            this.buttonCustomers.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomers.Location = new System.Drawing.Point(12, 152);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(222, 29);
            this.buttonCustomers.TabIndex = 5;
            this.buttonCustomers.Text = "Заказчики";
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // buttonWorkObjects
            // 
            this.buttonWorkObjects.Enabled = false;
            this.buttonWorkObjects.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonWorkObjects.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonWorkObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWorkObjects.Location = new System.Drawing.Point(12, 187);
            this.buttonWorkObjects.Name = "buttonWorkObjects";
            this.buttonWorkObjects.Size = new System.Drawing.Size(222, 29);
            this.buttonWorkObjects.TabIndex = 6;
            this.buttonWorkObjects.Text = "Объекты";
            this.buttonWorkObjects.UseVisualStyleBackColor = true;
            this.buttonWorkObjects.Click += new System.EventHandler(this.buttonWorkObjects_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(495, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Список заявок на завтра:";
            // 
            // dgvRequests
            // 
            this.dgvRequests.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Requests});
            this.dgvRequests.Location = new System.Drawing.Point(438, 82);
            this.dgvRequests.Name = "dgvRequests";
            this.dgvRequests.Size = new System.Drawing.Size(284, 134);
            this.dgvRequests.TabIndex = 10;
            this.dgvRequests.TabStop = false;
            // 
            // Requests
            // 
            this.Requests.HeaderText = "Заявки";
            this.Requests.Name = "Requests";
            this.Requests.Width = 240;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Location = new System.Drawing.Point(438, 222);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(284, 23);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUsers.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Location = new System.Drawing.Point(12, 222);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(222, 29);
            this.buttonUsers.TabIndex = 11;
            this.buttonUsers.Text = "Пользователи";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Visible = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 446);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dgvRequests);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonWorkObjects);
            this.Controls.Add(this.buttonCustomers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReportService);
            this.Controls.Add(this.buttonStorehouse);
            this.Controls.Add(this.buttonRequests);
            this.Controls.Add(this.buttonCranes);
            this.Controls.Add(this.buttonDrivers);
            this.Controls.Add(this.buttonWaybills);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(750, 485);
            this.MinimumSize = new System.Drawing.Size(750, 485);
            this.Name = "MainForm";
            this.Text = "Кран42";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonWaybills;
        private System.Windows.Forms.Button buttonDrivers;
        private System.Windows.Forms.Button buttonCranes;
        private System.Windows.Forms.Button buttonRequests;
        private System.Windows.Forms.Button buttonStorehouse;
        private System.Windows.Forms.Button buttonReportService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Button buttonWorkObjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requests;
        private System.Windows.Forms.Button buttonUsers;
    }
}