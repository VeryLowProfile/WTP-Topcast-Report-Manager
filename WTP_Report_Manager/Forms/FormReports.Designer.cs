
namespace WTP_Report_Manager.Forms
{
    partial class FormReports
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelSelect = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxHide = new System.Windows.Forms.ListBox();
            this.listBoxShow = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonAddAll = new System.Windows.Forms.Button();
            this.buttonSubAll = new System.Windows.Forms.Button();
            this.buttonPrintReport = new System.Windows.Forms.Button();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.checkBoxCountersData = new System.Windows.Forms.CheckBox();
            this.checkBoxEventData = new System.Windows.Forms.CheckBox();
            this.checkBoxMsgData = new System.Windows.Forms.CheckBox();
            this.checkBoxTrendData = new System.Windows.Forms.CheckBox();
            this.checkBoxOutData = new System.Windows.Forms.CheckBox();
            this.checkBoxInData = new System.Windows.Forms.CheckBox();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.buttonSelectPath = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.labelOptions = new System.Windows.Forms.Label();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.checkBoxResume = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelSelect.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelSelect, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonPrintReport, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelOptions, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxLog, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1834, 911);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanelSelect
            // 
            this.tableLayoutPanelSelect.ColumnCount = 3;
            this.tableLayoutPanelSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSelect.Controls.Add(this.listBoxHide, 0, 0);
            this.tableLayoutPanelSelect.Controls.Add(this.listBoxShow, 2, 0);
            this.tableLayoutPanelSelect.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanelSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSelect.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelSelect.Name = "tableLayoutPanelSelect";
            this.tableLayoutPanelSelect.RowCount = 1;
            this.tableLayoutPanelSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanelSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanelSelect.Size = new System.Drawing.Size(1828, 174);
            this.tableLayoutPanelSelect.TabIndex = 4;
            // 
            // listBoxHide
            // 
            this.listBoxHide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxHide.FormattingEnabled = true;
            this.listBoxHide.Location = new System.Drawing.Point(3, 3);
            this.listBoxHide.Name = "listBoxHide";
            this.listBoxHide.Size = new System.Drawing.Size(603, 168);
            this.listBoxHide.TabIndex = 0;
            // 
            // listBoxShow
            // 
            this.listBoxShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxShow.FormattingEnabled = true;
            this.listBoxShow.Location = new System.Drawing.Point(1221, 3);
            this.listBoxShow.Name = "listBoxShow";
            this.listBoxShow.Size = new System.Drawing.Size(604, 168);
            this.listBoxShow.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonSub, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonAddAll, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonSubAll, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(612, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(603, 168);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Image = global::WTP_Report_Manager.Properties.Resources.add;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(597, 36);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSub.Image = global::WTP_Report_Manager.Properties.Resources.minus;
            this.buttonSub.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSub.Location = new System.Drawing.Point(3, 45);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(597, 36);
            this.buttonSub.TabIndex = 1;
            this.buttonSub.Text = "Remove";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonAddAll
            // 
            this.buttonAddAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAddAll.Image = global::WTP_Report_Manager.Properties.Resources.add;
            this.buttonAddAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddAll.Location = new System.Drawing.Point(3, 87);
            this.buttonAddAll.Name = "buttonAddAll";
            this.buttonAddAll.Size = new System.Drawing.Size(597, 36);
            this.buttonAddAll.TabIndex = 2;
            this.buttonAddAll.Text = "Add All";
            this.buttonAddAll.UseVisualStyleBackColor = true;
            this.buttonAddAll.Click += new System.EventHandler(this.buttonAddAll_Click);
            // 
            // buttonSubAll
            // 
            this.buttonSubAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSubAll.Image = global::WTP_Report_Manager.Properties.Resources.minus;
            this.buttonSubAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSubAll.Location = new System.Drawing.Point(3, 129);
            this.buttonSubAll.Name = "buttonSubAll";
            this.buttonSubAll.Size = new System.Drawing.Size(597, 36);
            this.buttonSubAll.TabIndex = 3;
            this.buttonSubAll.Text = "Remove All";
            this.buttonSubAll.UseVisualStyleBackColor = true;
            this.buttonSubAll.Click += new System.EventHandler(this.buttonSubAll_Click);
            // 
            // buttonPrintReport
            // 
            this.buttonPrintReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPrintReport.Image = global::WTP_Report_Manager.Properties.Resources.notepad;
            this.buttonPrintReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPrintReport.Location = new System.Drawing.Point(3, 283);
            this.buttonPrintReport.Name = "buttonPrintReport";
            this.buttonPrintReport.Size = new System.Drawing.Size(1828, 44);
            this.buttonPrintReport.TabIndex = 5;
            this.buttonPrintReport.TabStop = false;
            this.buttonPrintReport.Text = "Print";
            this.buttonPrintReport.UseVisualStyleBackColor = true;
            this.buttonPrintReport.Click += new System.EventHandler(this.buttonPrintReport_Click);
            // 
            // panelOptions
            // 
            this.panelOptions.Controls.Add(this.checkBoxResume);
            this.panelOptions.Controls.Add(this.checkBoxCountersData);
            this.panelOptions.Controls.Add(this.checkBoxEventData);
            this.panelOptions.Controls.Add(this.checkBoxMsgData);
            this.panelOptions.Controls.Add(this.checkBoxTrendData);
            this.panelOptions.Controls.Add(this.checkBoxOutData);
            this.panelOptions.Controls.Add(this.checkBoxInData);
            this.panelOptions.Controls.Add(this.labelFilePath);
            this.panelOptions.Controls.Add(this.buttonSelectPath);
            this.panelOptions.Controls.Add(this.textBoxFilePath);
            this.panelOptions.Controls.Add(this.labelOptions);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOptions.Location = new System.Drawing.Point(3, 183);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(1828, 94);
            this.panelOptions.TabIndex = 6;
            // 
            // checkBoxCountersData
            // 
            this.checkBoxCountersData.AutoSize = true;
            this.checkBoxCountersData.Location = new System.Drawing.Point(272, 39);
            this.checkBoxCountersData.Name = "checkBoxCountersData";
            this.checkBoxCountersData.Size = new System.Drawing.Size(92, 17);
            this.checkBoxCountersData.TabIndex = 14;
            this.checkBoxCountersData.Text = "Print Counters";
            this.checkBoxCountersData.UseVisualStyleBackColor = true;
            // 
            // checkBoxEventData
            // 
            this.checkBoxEventData.AutoSize = true;
            this.checkBoxEventData.Location = new System.Drawing.Point(582, 39);
            this.checkBoxEventData.Name = "checkBoxEventData";
            this.checkBoxEventData.Size = new System.Drawing.Size(83, 17);
            this.checkBoxEventData.TabIndex = 13;
            this.checkBoxEventData.Text = "Print Events";
            this.checkBoxEventData.UseVisualStyleBackColor = true;
            // 
            // checkBoxMsgData
            // 
            this.checkBoxMsgData.AutoSize = true;
            this.checkBoxMsgData.Location = new System.Drawing.Point(499, 39);
            this.checkBoxMsgData.Name = "checkBoxMsgData";
            this.checkBoxMsgData.Size = new System.Drawing.Size(70, 17);
            this.checkBoxMsgData.TabIndex = 12;
            this.checkBoxMsgData.Text = "Print Msg";
            this.checkBoxMsgData.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrendData
            // 
            this.checkBoxTrendData.AutoSize = true;
            this.checkBoxTrendData.Location = new System.Drawing.Point(377, 39);
            this.checkBoxTrendData.Name = "checkBoxTrendData";
            this.checkBoxTrendData.Size = new System.Drawing.Size(109, 17);
            this.checkBoxTrendData.TabIndex = 11;
            this.checkBoxTrendData.Text = "Print Trends Data";
            this.checkBoxTrendData.UseVisualStyleBackColor = true;
            // 
            // checkBoxOutData
            // 
            this.checkBoxOutData.AutoSize = true;
            this.checkBoxOutData.Location = new System.Drawing.Point(84, 39);
            this.checkBoxOutData.Name = "checkBoxOutData";
            this.checkBoxOutData.Size = new System.Drawing.Size(73, 17);
            this.checkBoxOutData.TabIndex = 10;
            this.checkBoxOutData.Text = "Print OUT";
            this.checkBoxOutData.UseVisualStyleBackColor = true;
            // 
            // checkBoxInData
            // 
            this.checkBoxInData.AutoSize = true;
            this.checkBoxInData.Location = new System.Drawing.Point(10, 39);
            this.checkBoxInData.Name = "checkBoxInData";
            this.checkBoxInData.Size = new System.Drawing.Size(61, 17);
            this.checkBoxInData.TabIndex = 9;
            this.checkBoxInData.Text = "Print IN";
            this.checkBoxInData.UseVisualStyleBackColor = true;
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(791, 18);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(48, 13);
            this.labelFilePath.TabIndex = 8;
            this.labelFilePath.Text = "File Path";
            // 
            // buttonSelectPath
            // 
            this.buttonSelectPath.Location = new System.Drawing.Point(1084, 36);
            this.buttonSelectPath.Name = "buttonSelectPath";
            this.buttonSelectPath.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectPath.TabIndex = 7;
            this.buttonSelectPath.Text = "Select Path";
            this.buttonSelectPath.UseVisualStyleBackColor = true;
            this.buttonSelectPath.Click += new System.EventHandler(this.buttonSelectPath_Click);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(791, 37);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(279, 20);
            this.textBoxFilePath.TabIndex = 6;
            // 
            // labelOptions
            // 
            this.labelOptions.AutoSize = true;
            this.labelOptions.Location = new System.Drawing.Point(4, 9);
            this.labelOptions.Name = "labelOptions";
            this.labelOptions.Size = new System.Drawing.Size(43, 13);
            this.labelOptions.TabIndex = 3;
            this.labelOptions.Text = "Options";
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Location = new System.Drawing.Point(3, 333);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(1828, 575);
            this.richTextBoxLog.TabIndex = 7;
            this.richTextBoxLog.Text = "";
            // 
            // checkBoxResume
            // 
            this.checkBoxResume.AutoSize = true;
            this.checkBoxResume.Location = new System.Drawing.Point(170, 39);
            this.checkBoxResume.Name = "checkBoxResume";
            this.checkBoxResume.Size = new System.Drawing.Size(89, 17);
            this.checkBoxResume.TabIndex = 15;
            this.checkBoxResume.Text = "Print Resume";
            this.checkBoxResume.UseVisualStyleBackColor = true;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 911);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormReports";
            this.Text = "FormReports";
            this.Load += new System.EventHandler(this.FormReports_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelSelect.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelOptions.ResumeLayout(false);
            this.panelOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSelect;
        private System.Windows.Forms.ListBox listBoxHide;
        private System.Windows.Forms.ListBox listBoxShow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonAddAll;
        private System.Windows.Forms.Button buttonSubAll;
        private System.Windows.Forms.Button buttonPrintReport;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Label labelOptions;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Button buttonSelectPath;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.CheckBox checkBoxEventData;
        private System.Windows.Forms.CheckBox checkBoxMsgData;
        private System.Windows.Forms.CheckBox checkBoxTrendData;
        private System.Windows.Forms.CheckBox checkBoxOutData;
        private System.Windows.Forms.CheckBox checkBoxInData;
        private System.Windows.Forms.CheckBox checkBoxCountersData;
        private System.Windows.Forms.CheckBox checkBoxResume;
    }
}