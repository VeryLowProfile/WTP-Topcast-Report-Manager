
namespace WTP_Report_Manager.Forms
{
    partial class FormEvents
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
            this.tableLayoutPanelEvents = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewEvents = new System.Windows.Forms.DataGridView();
            this.dataGridViewMsg = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSelectID = new System.Windows.Forms.Label();
            this.comboBoxIDList = new System.Windows.Forms.ComboBox();
            this.buttonShowEvents = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.labelEvents = new System.Windows.Forms.Label();
            this.tableLayoutPanelEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMsg)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelEvents
            // 
            this.tableLayoutPanelEvents.ColumnCount = 1;
            this.tableLayoutPanelEvents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelEvents.Controls.Add(this.dataGridViewEvents, 0, 5);
            this.tableLayoutPanelEvents.Controls.Add(this.dataGridViewMsg, 0, 3);
            this.tableLayoutPanelEvents.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanelEvents.Controls.Add(this.buttonShowEvents, 0, 1);
            this.tableLayoutPanelEvents.Controls.Add(this.labelMsg, 0, 2);
            this.tableLayoutPanelEvents.Controls.Add(this.labelEvents, 0, 4);
            this.tableLayoutPanelEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelEvents.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelEvents.Name = "tableLayoutPanelEvents";
            this.tableLayoutPanelEvents.RowCount = 6;
            this.tableLayoutPanelEvents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanelEvents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanelEvents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelEvents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEvents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelEvents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelEvents.Size = new System.Drawing.Size(1834, 911);
            this.tableLayoutPanelEvents.TabIndex = 0;
            // 
            // dataGridViewEvents
            // 
            this.dataGridViewEvents.AllowUserToAddRows = false;
            this.dataGridViewEvents.AllowUserToDeleteRows = false;
            this.dataGridViewEvents.AllowUserToResizeColumns = false;
            this.dataGridViewEvents.AllowUserToResizeRows = false;
            this.dataGridViewEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEvents.Location = new System.Drawing.Point(3, 538);
            this.dataGridViewEvents.Name = "dataGridViewEvents";
            this.dataGridViewEvents.ReadOnly = true;
            this.dataGridViewEvents.Size = new System.Drawing.Size(1828, 370);
            this.dataGridViewEvents.TabIndex = 6;
            // 
            // dataGridViewMsg
            // 
            this.dataGridViewMsg.AllowUserToAddRows = false;
            this.dataGridViewMsg.AllowUserToDeleteRows = false;
            this.dataGridViewMsg.AllowUserToResizeColumns = false;
            this.dataGridViewMsg.AllowUserToResizeRows = false;
            this.dataGridViewMsg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMsg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMsg.Location = new System.Drawing.Point(3, 143);
            this.dataGridViewMsg.Name = "dataGridViewMsg";
            this.dataGridViewMsg.ReadOnly = true;
            this.dataGridViewMsg.Size = new System.Drawing.Size(1828, 369);
            this.dataGridViewMsg.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSelectID);
            this.panel1.Controls.Add(this.comboBoxIDList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1828, 64);
            this.panel1.TabIndex = 1;
            // 
            // labelSelectID
            // 
            this.labelSelectID.AutoSize = true;
            this.labelSelectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectID.ForeColor = System.Drawing.Color.Gray;
            this.labelSelectID.Location = new System.Drawing.Point(9, 5);
            this.labelSelectID.Name = "labelSelectID";
            this.labelSelectID.Size = new System.Drawing.Size(60, 15);
            this.labelSelectID.TabIndex = 3;
            this.labelSelectID.Text = "Select OF";
            // 
            // comboBoxIDList
            // 
            this.comboBoxIDList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIDList.FormattingEnabled = true;
            this.comboBoxIDList.Location = new System.Drawing.Point(9, 25);
            this.comboBoxIDList.Name = "comboBoxIDList";
            this.comboBoxIDList.Size = new System.Drawing.Size(303, 32);
            this.comboBoxIDList.TabIndex = 2;
            // 
            // buttonShowEvents
            // 
            this.buttonShowEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShowEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowEvents.ForeColor = System.Drawing.Color.Gray;
            this.buttonShowEvents.Image = global::WTP_Report_Manager.Properties.Resources.alarm;
            this.buttonShowEvents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowEvents.Location = new System.Drawing.Point(3, 73);
            this.buttonShowEvents.Name = "buttonShowEvents";
            this.buttonShowEvents.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonShowEvents.Size = new System.Drawing.Size(1828, 44);
            this.buttonShowEvents.TabIndex = 2;
            this.buttonShowEvents.Text = "Show Msg / Events";
            this.buttonShowEvents.UseVisualStyleBackColor = true;
            this.buttonShowEvents.Click += new System.EventHandler(this.buttonShowEvents_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMsg.ForeColor = System.Drawing.Color.Gray;
            this.labelMsg.Location = new System.Drawing.Point(3, 120);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(31, 15);
            this.labelMsg.TabIndex = 3;
            this.labelMsg.Text = "Msg";
            // 
            // labelEvents
            // 
            this.labelEvents.AutoSize = true;
            this.labelEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvents.ForeColor = System.Drawing.Color.Gray;
            this.labelEvents.Location = new System.Drawing.Point(3, 515);
            this.labelEvents.Name = "labelEvents";
            this.labelEvents.Size = new System.Drawing.Size(43, 15);
            this.labelEvents.TabIndex = 4;
            this.labelEvents.Text = "Events";
            // 
            // FormEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 911);
            this.Controls.Add(this.tableLayoutPanelEvents);
            this.Name = "FormEvents";
            this.Text = "FormEvents";
            this.Load += new System.EventHandler(this.FormEvents_Load);
            this.tableLayoutPanelEvents.ResumeLayout(false);
            this.tableLayoutPanelEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMsg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEvents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSelectID;
        private System.Windows.Forms.ComboBox comboBoxIDList;
        private System.Windows.Forms.Button buttonShowEvents;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Label labelEvents;
        private System.Windows.Forms.DataGridView dataGridViewEvents;
        private System.Windows.Forms.DataGridView dataGridViewMsg;
    }
}