
namespace WTP_Report_Manager.Forms
{
    partial class FormTrends
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
            this.tableLayoutPanelTrends = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSelectID = new System.Windows.Forms.Label();
            this.comboBoxIDList = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelSelect = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonAddAll = new System.Windows.Forms.Button();
            this.buttonSubAll = new System.Windows.Forms.Button();
            this.listBoxHide = new System.Windows.Forms.ListBox();
            this.listBoxShow = new System.Windows.Forms.ListBox();
            this.buttonShowTrends = new System.Windows.Forms.Button();
            this.panelPlot = new System.Windows.Forms.Panel();
            this.dataGridViewPlot = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelTrends.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanelSelect.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlot)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTrends
            // 
            this.tableLayoutPanelTrends.CausesValidation = false;
            this.tableLayoutPanelTrends.ColumnCount = 1;
            this.tableLayoutPanelTrends.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTrends.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelTrends.Controls.Add(this.tableLayoutPanelSelect, 0, 1);
            this.tableLayoutPanelTrends.Controls.Add(this.buttonShowTrends, 0, 2);
            this.tableLayoutPanelTrends.Controls.Add(this.panelPlot, 0, 4);
            this.tableLayoutPanelTrends.Controls.Add(this.dataGridViewPlot, 0, 3);
            this.tableLayoutPanelTrends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTrends.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTrends.Name = "tableLayoutPanelTrends";
            this.tableLayoutPanelTrends.RowCount = 5;
            this.tableLayoutPanelTrends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelTrends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanelTrends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelTrends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanelTrends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTrends.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTrends.Size = new System.Drawing.Size(1834, 911);
            this.tableLayoutPanelTrends.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSelectID);
            this.panel1.Controls.Add(this.comboBoxIDList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1828, 64);
            this.panel1.TabIndex = 2;
            // 
            // labelSelectID
            // 
            this.labelSelectID.AutoSize = true;
            this.labelSelectID.Location = new System.Drawing.Point(9, 7);
            this.labelSelectID.Name = "labelSelectID";
            this.labelSelectID.Size = new System.Drawing.Size(54, 13);
            this.labelSelectID.TabIndex = 3;
            this.labelSelectID.Text = "Select OF";
            // 
            // comboBoxIDList
            // 
            this.comboBoxIDList.FormattingEnabled = true;
            this.comboBoxIDList.Location = new System.Drawing.Point(9, 27);
            this.comboBoxIDList.Name = "comboBoxIDList";
            this.comboBoxIDList.Size = new System.Drawing.Size(303, 21);
            this.comboBoxIDList.TabIndex = 2;
            // 
            // tableLayoutPanelSelect
            // 
            this.tableLayoutPanelSelect.ColumnCount = 3;
            this.tableLayoutPanelSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSelect.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSelect.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanelSelect.Controls.Add(this.listBoxHide, 0, 0);
            this.tableLayoutPanelSelect.Controls.Add(this.listBoxShow, 2, 0);
            this.tableLayoutPanelSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSelect.Location = new System.Drawing.Point(3, 73);
            this.tableLayoutPanelSelect.Name = "tableLayoutPanelSelect";
            this.tableLayoutPanelSelect.RowCount = 1;
            this.tableLayoutPanelSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanelSelect.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanelSelect.Size = new System.Drawing.Size(1828, 174);
            this.tableLayoutPanelSelect.TabIndex = 3;
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
            this.tableLayoutPanel2.TabIndex = 3;
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
            // buttonShowTrends
            // 
            this.buttonShowTrends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShowTrends.Image = global::WTP_Report_Manager.Properties.Resources.shuffle;
            this.buttonShowTrends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowTrends.Location = new System.Drawing.Point(3, 253);
            this.buttonShowTrends.Name = "buttonShowTrends";
            this.buttonShowTrends.Size = new System.Drawing.Size(1828, 44);
            this.buttonShowTrends.TabIndex = 4;
            this.buttonShowTrends.Text = "Show Trends";
            this.buttonShowTrends.UseVisualStyleBackColor = true;
            this.buttonShowTrends.Click += new System.EventHandler(this.buttonShowTrends_Click);
            // 
            // panelPlot
            // 
            this.panelPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlot.Location = new System.Drawing.Point(3, 453);
            this.panelPlot.Name = "panelPlot";
            this.panelPlot.Size = new System.Drawing.Size(1828, 455);
            this.panelPlot.TabIndex = 5;
            // 
            // dataGridViewPlot
            // 
            this.dataGridViewPlot.AllowUserToAddRows = false;
            this.dataGridViewPlot.AllowUserToDeleteRows = false;
            this.dataGridViewPlot.AllowUserToResizeColumns = false;
            this.dataGridViewPlot.AllowUserToResizeRows = false;
            this.dataGridViewPlot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPlot.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewPlot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPlot.Location = new System.Drawing.Point(3, 303);
            this.dataGridViewPlot.Name = "dataGridViewPlot";
            this.dataGridViewPlot.Size = new System.Drawing.Size(1828, 144);
            this.dataGridViewPlot.TabIndex = 6;
            // 
            // FormTrends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 911);
            this.Controls.Add(this.tableLayoutPanelTrends);
            this.Name = "FormTrends";
            this.Text = "FormTrends";
            this.Load += new System.EventHandler(this.FormTrends_Load);
            this.tableLayoutPanelTrends.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanelSelect.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTrends;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSelectID;
        private System.Windows.Forms.ComboBox comboBoxIDList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSelect;
        private System.Windows.Forms.ListBox listBoxHide;
        private System.Windows.Forms.ListBox listBoxShow;
        private System.Windows.Forms.Button buttonShowTrends;
        private System.Windows.Forms.Panel panelPlot;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonAddAll;
        private System.Windows.Forms.Button buttonSubAll;
        private System.Windows.Forms.DataGridView dataGridViewPlot;
    }
}