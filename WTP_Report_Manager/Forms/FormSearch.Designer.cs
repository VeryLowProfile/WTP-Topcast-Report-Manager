
namespace WTP_Report_Manager.Forms
{
    partial class FormSearch
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
            this.tableLayoutPanelSearch = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewSelected = new System.Windows.Forms.DataGridView();
            this.dataGridViewSearchResult = new System.Windows.Forms.DataGridView();
            this.panelSelect = new System.Windows.Forms.Panel();
            this.labelSerachID = new System.Windows.Forms.Label();
            this.textBoxBatchID = new System.Windows.Forms.TextBox();
            this.labelSearchTo = new System.Windows.Forms.Label();
            this.checkBoxSearchID = new System.Windows.Forms.CheckBox();
            this.labelSearchFrom = new System.Windows.Forms.Label();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.datePickerTo = new System.Windows.Forms.DateTimePicker();
            this.checkBoxSearchDate = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.tableLayoutPanelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).BeginInit();
            this.panelSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelSearch
            // 
            this.tableLayoutPanelSearch.ColumnCount = 1;
            this.tableLayoutPanelSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSearch.Controls.Add(this.dataGridViewSelected, 0, 4);
            this.tableLayoutPanelSearch.Controls.Add(this.dataGridViewSearchResult, 0, 2);
            this.tableLayoutPanelSearch.Controls.Add(this.panelSelect, 0, 0);
            this.tableLayoutPanelSearch.Controls.Add(this.buttonSearch, 0, 1);
            this.tableLayoutPanelSearch.Controls.Add(this.buttonSelect, 0, 3);
            this.tableLayoutPanelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSearch.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelSearch.Name = "tableLayoutPanelSearch";
            this.tableLayoutPanelSearch.RowCount = 5;
            this.tableLayoutPanelSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSearch.Size = new System.Drawing.Size(1834, 911);
            this.tableLayoutPanelSearch.TabIndex = 0;
            // 
            // dataGridViewSelected
            // 
            this.dataGridViewSelected.AllowUserToAddRows = false;
            this.dataGridViewSelected.AllowUserToDeleteRows = false;
            this.dataGridViewSelected.AllowUserToResizeColumns = false;
            this.dataGridViewSelected.AllowUserToResizeRows = false;
            this.dataGridViewSelected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelected.Location = new System.Drawing.Point(3, 583);
            this.dataGridViewSelected.Name = "dataGridViewSelected";
            this.dataGridViewSelected.ReadOnly = true;
            this.dataGridViewSelected.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSelected.Size = new System.Drawing.Size(1828, 325);
            this.dataGridViewSelected.TabIndex = 4;
            // 
            // dataGridViewSearchResult
            // 
            this.dataGridViewSearchResult.AllowUserToAddRows = false;
            this.dataGridViewSearchResult.AllowUserToDeleteRows = false;
            this.dataGridViewSearchResult.AllowUserToResizeColumns = false;
            this.dataGridViewSearchResult.AllowUserToResizeRows = false;
            this.dataGridViewSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSearchResult.Location = new System.Drawing.Point(3, 203);
            this.dataGridViewSearchResult.Name = "dataGridViewSearchResult";
            this.dataGridViewSearchResult.ReadOnly = true;
            this.dataGridViewSearchResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSearchResult.Size = new System.Drawing.Size(1828, 324);
            this.dataGridViewSearchResult.TabIndex = 3;
            // 
            // panelSelect
            // 
            this.panelSelect.Controls.Add(this.labelSerachID);
            this.panelSelect.Controls.Add(this.textBoxBatchID);
            this.panelSelect.Controls.Add(this.labelSearchTo);
            this.panelSelect.Controls.Add(this.checkBoxSearchID);
            this.panelSelect.Controls.Add(this.labelSearchFrom);
            this.panelSelect.Controls.Add(this.datePickerFrom);
            this.panelSelect.Controls.Add(this.datePickerTo);
            this.panelSelect.Controls.Add(this.checkBoxSearchDate);
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSelect.Location = new System.Drawing.Point(3, 3);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(1828, 144);
            this.panelSelect.TabIndex = 0;
            // 
            // labelSerachID
            // 
            this.labelSerachID.AutoSize = true;
            this.labelSerachID.Location = new System.Drawing.Point(528, 30);
            this.labelSerachID.Name = "labelSerachID";
            this.labelSerachID.Size = new System.Drawing.Size(55, 13);
            this.labelSerachID.TabIndex = 21;
            this.labelSerachID.Text = "Search ID";
            // 
            // textBoxBatchID
            // 
            this.textBoxBatchID.Location = new System.Drawing.Point(528, 52);
            this.textBoxBatchID.Name = "textBoxBatchID";
            this.textBoxBatchID.Size = new System.Drawing.Size(204, 20);
            this.textBoxBatchID.TabIndex = 15;
            this.textBoxBatchID.TextChanged += new System.EventHandler(this.textBoxBatchID_TextChanged);
            // 
            // labelSearchTo
            // 
            this.labelSearchTo.AutoSize = true;
            this.labelSearchTo.Location = new System.Drawing.Point(9, 86);
            this.labelSearchTo.Name = "labelSearchTo";
            this.labelSearchTo.Size = new System.Drawing.Size(57, 13);
            this.labelSearchTo.TabIndex = 16;
            this.labelSearchTo.Text = "Search To";
            // 
            // checkBoxSearchID
            // 
            this.checkBoxSearchID.AutoSize = true;
            this.checkBoxSearchID.Location = new System.Drawing.Point(528, 8);
            this.checkBoxSearchID.Name = "checkBoxSearchID";
            this.checkBoxSearchID.Size = new System.Drawing.Size(89, 17);
            this.checkBoxSearchID.TabIndex = 20;
            this.checkBoxSearchID.Text = "Search By ID";
            this.checkBoxSearchID.UseVisualStyleBackColor = true;
            this.checkBoxSearchID.Click += new System.EventHandler(this.checkBoxSearchID_Click);
            // 
            // labelSearchFrom
            // 
            this.labelSearchFrom.AutoSize = true;
            this.labelSearchFrom.Location = new System.Drawing.Point(9, 30);
            this.labelSearchFrom.Name = "labelSearchFrom";
            this.labelSearchFrom.Size = new System.Drawing.Size(67, 13);
            this.labelSearchFrom.TabIndex = 12;
            this.labelSearchFrom.Text = "Search From";
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerFrom.Location = new System.Drawing.Point(9, 52);
            this.datePickerFrom.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.datePickerFrom.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.datePickerFrom.TabIndex = 13;
            this.datePickerFrom.ValueChanged += new System.EventHandler(this.datePickerFrom_ValueChanged);
            // 
            // datePickerTo
            // 
            this.datePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerTo.Location = new System.Drawing.Point(9, 107);
            this.datePickerTo.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.datePickerTo.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.datePickerTo.Name = "datePickerTo";
            this.datePickerTo.Size = new System.Drawing.Size(200, 20);
            this.datePickerTo.TabIndex = 17;
            this.datePickerTo.ValueChanged += new System.EventHandler(this.datePickerTo_ValueChanged);
            // 
            // checkBoxSearchDate
            // 
            this.checkBoxSearchDate.AutoSize = true;
            this.checkBoxSearchDate.Location = new System.Drawing.Point(9, 8);
            this.checkBoxSearchDate.Name = "checkBoxSearchDate";
            this.checkBoxSearchDate.Size = new System.Drawing.Size(101, 17);
            this.checkBoxSearchDate.TabIndex = 19;
            this.checkBoxSearchDate.Text = "Search By Date";
            this.checkBoxSearchDate.UseVisualStyleBackColor = true;
            this.checkBoxSearchDate.Click += new System.EventHandler(this.checkBoxSearchDate_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearch.Image = global::WTP_Report_Manager.Properties.Resources.search;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(3, 153);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(1828, 44);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.TabStop = false;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSelect.Location = new System.Drawing.Point(3, 533);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(1828, 44);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 911);
            this.Controls.Add(this.tableLayoutPanelSearch);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.tableLayoutPanelSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).EndInit();
            this.panelSelect.ResumeLayout(false);
            this.panelSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSearch;
        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.Label labelSerachID;
        private System.Windows.Forms.TextBox textBoxBatchID;
        private System.Windows.Forms.Label labelSearchTo;
        private System.Windows.Forms.CheckBox checkBoxSearchID;
        private System.Windows.Forms.Label labelSearchFrom;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.DateTimePicker datePickerTo;
        private System.Windows.Forms.CheckBox checkBoxSearchDate;
        private System.Windows.Forms.DataGridView dataGridViewSelected;
        private System.Windows.Forms.DataGridView dataGridViewSearchResult;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonSelect;
    }
}