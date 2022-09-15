namespace PoppelSolution.Presentation_Layer
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panelLower = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonMarketing = new System.Windows.Forms.Button();
            this.buttonCustomers = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.poppelSolutionDatabaseDataSet2 = new PoppelSolution.PoppelSolutionDatabaseDataSet();
            this.loginBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.productsTableAdapter = new PoppelSolution.PoppelSolutionDatabaseDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new PoppelSolution.PoppelSolutionDatabaseDataSetTableAdapters.TableAdapterManager();
            this.fresh_ProductsToolStrip = new System.Windows.Forms.ToolStrip();
            this.fresh_ProductsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.expired_ProductsToolStrip = new System.Windows.Forms.ToolStrip();
            this.expired_ProductsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppelSolutionDatabaseDataSet2)).BeginInit();
            this.fresh_ProductsToolStrip.SuspendLayout();
            this.expired_ProductsToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SlateBlue;
            this.panelTop.Controls.Add(this.panelProducts);
            this.panelTop.Location = new System.Drawing.Point(0, -2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 27);
            this.panelTop.TabIndex = 16;
            // 
            // panelProducts
            // 
            this.panelProducts.Location = new System.Drawing.Point(177, 23);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(623, 405);
            this.panelProducts.TabIndex = 18;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.SlateBlue;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.exitBtn.Location = new System.Drawing.Point(785, -2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(35, 27);
            this.exitBtn.TabIndex = 10;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panelLower
            // 
            this.panelLower.BackColor = System.Drawing.Color.SlateBlue;
            this.panelLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLower.Location = new System.Drawing.Point(0, 472);
            this.panelLower.Name = "panelLower";
            this.panelLower.Size = new System.Drawing.Size(820, 26);
            this.panelLower.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(1)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.buttonMarketing);
            this.panel1.Controls.Add(this.buttonCustomers);
            this.panel1.Controls.Add(this.buttonProducts);
            this.panel1.Controls.Add(this.buttonOrders);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 454);
            this.panel1.TabIndex = 15;
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(12, 379);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(159, 27);
            this.buttonSettings.TabIndex = 20;
            this.buttonSettings.Text = "   Settings";
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonMarketing
            // 
            this.buttonMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarketing.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMarketing.Image = ((System.Drawing.Image)(resources.GetObject("buttonMarketing.Image")));
            this.buttonMarketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMarketing.Location = new System.Drawing.Point(12, 335);
            this.buttonMarketing.Name = "buttonMarketing";
            this.buttonMarketing.Size = new System.Drawing.Size(159, 27);
            this.buttonMarketing.TabIndex = 19;
            this.buttonMarketing.Text = "   Marketing";
            this.buttonMarketing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMarketing.UseVisualStyleBackColor = true;
            // 
            // buttonCustomers
            // 
            this.buttonCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCustomers.Image = ((System.Drawing.Image)(resources.GetObject("buttonCustomers.Image")));
            this.buttonCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomers.Location = new System.Drawing.Point(12, 287);
            this.buttonCustomers.Name = "buttonCustomers";
            this.buttonCustomers.Size = new System.Drawing.Size(159, 27);
            this.buttonCustomers.TabIndex = 18;
            this.buttonCustomers.Text = "   Customers";
            this.buttonCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCustomers.UseVisualStyleBackColor = true;
            this.buttonCustomers.Click += new System.EventHandler(this.buttonCustomers_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProducts.Image = ((System.Drawing.Image)(resources.GetObject("buttonProducts.Image")));
            this.buttonProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts.Location = new System.Drawing.Point(12, 241);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(159, 27);
            this.buttonProducts.TabIndex = 17;
            this.buttonProducts.Text = "   Products";
            this.buttonProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonProducts.UseVisualStyleBackColor = true;
            // 
            // buttonOrders
            // 
            this.buttonOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOrders.Image = ((System.Drawing.Image)(resources.GetObject("buttonOrders.Image")));
            this.buttonOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrders.Location = new System.Drawing.Point(12, 193);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(159, 27);
            this.buttonOrders.TabIndex = 16;
            this.buttonOrders.Text = "   Orders";
            this.buttonOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonDashboard.Image")));
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(12, 146);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(159, 27);
            this.buttonDashboard.TabIndex = 15;
            this.buttonDashboard.Text = "   Dashboard";
            this.buttonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PoppelSolution.Properties.Resources.High_Resolution_Logo___Transparent_Background;
            this.pictureBox4.Location = new System.Drawing.Point(37, 33);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(134, 94);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(373, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Products On The System";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.expireDateDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(241, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(541, 221);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expireDateDataGridViewTextBoxColumn
            // 
            this.expireDateDataGridViewTextBoxColumn.DataPropertyName = "ExpireDate";
            this.expireDateDataGridViewTextBoxColumn.HeaderText = "ExpireDate";
            this.expireDateDataGridViewTextBoxColumn.Name = "expireDateDataGridViewTextBoxColumn";
            this.expireDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.poppelSolutionDatabaseDataSet2;
            // 
            // poppelSolutionDatabaseDataSet2
            // 
            this.poppelSolutionDatabaseDataSet2.DataSetName = "PoppelSolutionDatabaseDataSet";
            this.poppelSolutionDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.MediumPurple;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Location = new System.Drawing.Point(300, 406);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(140, 32);
            this.loginBtn.TabIndex = 21;
            this.loginBtn.Text = "Exit";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumPurple;
            this.button1.Location = new System.Drawing.Point(563, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 32);
            this.button1.TabIndex = 22;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BlacklistTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.OrderItemTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = PoppelSolution.PoppelSolutionDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fresh_ProductsToolStrip
            // 
            this.fresh_ProductsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fresh_ProductsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fresh_ProductsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fresh_ProductsToolStripButton,
            this.toolStripButton2});
            this.fresh_ProductsToolStrip.Location = new System.Drawing.Point(578, 122);
            this.fresh_ProductsToolStrip.Name = "fresh_ProductsToolStrip";
            this.fresh_ProductsToolStrip.Size = new System.Drawing.Size(117, 25);
            this.fresh_ProductsToolStrip.TabIndex = 23;
            this.fresh_ProductsToolStrip.Text = "fresh_ProductsToolStrip";
            // 
            // fresh_ProductsToolStripButton
            // 
            this.fresh_ProductsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fresh_ProductsToolStripButton.Name = "fresh_ProductsToolStripButton";
            this.fresh_ProductsToolStripButton.Size = new System.Drawing.Size(91, 22);
            this.fresh_ProductsToolStripButton.Text = "Fresh_Products";
            this.fresh_ProductsToolStripButton.Click += new System.EventHandler(this.fresh_ProductsToolStripButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // expired_ProductsToolStrip
            // 
            this.expired_ProductsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.expired_ProductsToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.expired_ProductsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expired_ProductsToolStripButton,
            this.toolStripButton1});
            this.expired_ProductsToolStrip.Location = new System.Drawing.Point(326, 122);
            this.expired_ProductsToolStrip.Name = "expired_ProductsToolStrip";
            this.expired_ProductsToolStrip.Size = new System.Drawing.Size(128, 25);
            this.expired_ProductsToolStrip.TabIndex = 24;
            this.expired_ProductsToolStrip.Text = "expired_ProductsToolStrip";
            // 
            // expired_ProductsToolStripButton
            // 
            this.expired_ProductsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.expired_ProductsToolStripButton.Name = "expired_ProductsToolStripButton";
            this.expired_ProductsToolStripButton.Size = new System.Drawing.Size(102, 22);
            this.expired_ProductsToolStripButton.Text = "Expired_Products";
            this.expired_ProductsToolStripButton.Click += new System.EventHandler(this.expired_ProductsToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 498);
            this.Controls.Add(this.expired_ProductsToolStrip);
            this.Controls.Add(this.fresh_ProductsToolStrip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLower);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poppelSolutionDatabaseDataSet2)).EndInit();
            this.fresh_ProductsToolStrip.ResumeLayout(false);
            this.fresh_ProductsToolStrip.PerformLayout();
            this.expired_ProductsToolStrip.ResumeLayout(false);
            this.expired_ProductsToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panelLower;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonMarketing;
        private System.Windows.Forms.Button buttonCustomers;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        public System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private PoppelSolutionDatabaseDataSet poppelSolutionDatabaseDataSet2;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private PoppelSolutionDatabaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private PoppelSolutionDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fresh_ProductsToolStrip;
        private System.Windows.Forms.ToolStripButton fresh_ProductsToolStripButton;
        private System.Windows.Forms.ToolStrip expired_ProductsToolStrip;
        private System.Windows.Forms.ToolStripButton expired_ProductsToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}