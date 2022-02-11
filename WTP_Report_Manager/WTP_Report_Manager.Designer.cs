namespace WTP_Report_Manager
{
    partial class WTP_Report_Manager
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonResume = new System.Windows.Forms.Button();
            this.buttonEventMessages = new System.Windows.Forms.Button();
            this.buttonTrends = new System.Windows.Forms.Button();
            this.buttonExport = new System.Windows.Forms.Button();
            this.panelChildform = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelMenu.ColumnCount = 1;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMenu.Controls.Add(this.pictureBoxLogo, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.buttonSearch, 0, 1);
            this.tableLayoutPanelMenu.Controls.Add(this.buttonResume, 0, 2);
            this.tableLayoutPanelMenu.Controls.Add(this.buttonEventMessages, 0, 3);
            this.tableLayoutPanelMenu.Controls.Add(this.buttonTrends, 0, 4);
            this.tableLayoutPanelMenu.Controls.Add(this.buttonExport, 0, 9);
            this.tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 10;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(200, 950);
            this.tableLayoutPanelMenu.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::WTP_Report_Manager.Properties.Resources.TopcastLogo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(194, 89);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSearch.Image = global::WTP_Report_Manager.Properties.Resources.search;
            this.buttonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSearch.Location = new System.Drawing.Point(3, 98);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(194, 89);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonResume
            // 
            this.buttonResume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonResume.Image = global::WTP_Report_Manager.Properties.Resources.database;
            this.buttonResume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonResume.Location = new System.Drawing.Point(3, 193);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(194, 89);
            this.buttonResume.TabIndex = 2;
            this.buttonResume.Text = "Resume";
            this.buttonResume.UseVisualStyleBackColor = true;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            // 
            // buttonEventMessages
            // 
            this.buttonEventMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEventMessages.Image = global::WTP_Report_Manager.Properties.Resources.alarm;
            this.buttonEventMessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEventMessages.Location = new System.Drawing.Point(3, 288);
            this.buttonEventMessages.Name = "buttonEventMessages";
            this.buttonEventMessages.Size = new System.Drawing.Size(194, 89);
            this.buttonEventMessages.TabIndex = 3;
            this.buttonEventMessages.Text = "Events / Messages";
            this.buttonEventMessages.UseVisualStyleBackColor = true;
            this.buttonEventMessages.Click += new System.EventHandler(this.buttonEventMessages_Click);
            // 
            // buttonTrends
            // 
            this.buttonTrends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTrends.Image = global::WTP_Report_Manager.Properties.Resources.shuffle;
            this.buttonTrends.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTrends.Location = new System.Drawing.Point(3, 383);
            this.buttonTrends.Name = "buttonTrends";
            this.buttonTrends.Size = new System.Drawing.Size(194, 89);
            this.buttonTrends.TabIndex = 4;
            this.buttonTrends.Text = "Trends";
            this.buttonTrends.UseVisualStyleBackColor = true;
            this.buttonTrends.Click += new System.EventHandler(this.buttonTrends_Click);
            // 
            // buttonExport
            // 
            this.buttonExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonExport.Image = global::WTP_Report_Manager.Properties.Resources.notepad;
            this.buttonExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExport.Location = new System.Drawing.Point(3, 858);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(194, 89);
            this.buttonExport.TabIndex = 5;
            this.buttonExport.Text = "Reports";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // panelChildform
            // 
            this.panelChildform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildform.Location = new System.Drawing.Point(200, 0);
            this.panelChildform.Name = "panelChildform";
            this.panelChildform.Size = new System.Drawing.Size(1650, 950);
            this.panelChildform.TabIndex = 2;
            // 
            // WTP_Report_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelChildform);
            this.Controls.Add(this.tableLayoutPanelMenu);
            this.Name = "WTP_Report_Manager";
            this.Size = new System.Drawing.Size(1850, 950);
            this.tableLayoutPanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.Button buttonEventMessages;
        private System.Windows.Forms.Button buttonTrends;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Panel panelChildform;
    }
}
