namespace HikariLFSTemplate
{
    partial class AuftragsverwaltungForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.Label lblOrderDetails;
        private System.Windows.Forms.TextBox txtOrderDetails;
        private System.Windows.Forms.Label lblRelation;
        private System.Windows.Forms.ComboBox cmbRelation;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnEditOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.ListBox lstOrders;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblOrderType = new System.Windows.Forms.Label();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.txtOrderDetails = new System.Windows.Forms.TextBox();
            this.lblRelation = new System.Windows.Forms.Label();
            this.cmbRelation = new System.Windows.Forms.ComboBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnEditOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Location = new System.Drawing.Point(20, 20);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(60, 13);
            this.lblOrderType.TabIndex = 0;
            this.lblOrderType.Text = "Auftragstyp:";
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Items.AddRange(new object[] { "Umlagerung", "Kommissionierung", "Auslagern" });
            this.cmbOrderType.Location = new System.Drawing.Point(120, 20);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(200, 21);
            this.cmbOrderType.TabIndex = 1;
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Location = new System.Drawing.Point(20, 60);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(73, 13);
            this.lblOrderDetails.TabIndex = 2;
            this.lblOrderDetails.Text = "Auftragsdetails:";
            // 
            // txtOrderDetails
            // 
            this.txtOrderDetails.Location = new System.Drawing.Point(120, 60);
            this.txtOrderDetails.Name = "txtOrderDetails";
            this.txtOrderDetails.Size = new System.Drawing.Size(200, 20);
            this.txtOrderDetails.TabIndex = 3;
            // 
            // lblRelation
            // 
            this.lblRelation.AutoSize = true;
            this.lblRelation.Location = new System.Drawing.Point(20, 100);
            this.lblRelation.Name = "lblRelation";
            this.lblRelation.Size = new System.Drawing.Size(60, 13);
            this.lblRelation.TabIndex = 4;
            this.lblRelation.Text = "Lagerplatz:";
            // 
            // cmbRelation
            // 
            this.cmbRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRelation.FormattingEnabled = true;
            this.cmbRelation.Location = new System.Drawing.Point(120, 100);
            this.cmbRelation.Name = "cmbRelation";
            this.cmbRelation.Size = new System.Drawing.Size(200, 21);
            this.cmbRelation.TabIndex = 5;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(20, 140);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(100, 23);
            this.btnAddOrder.TabIndex = 6;
            this.btnAddOrder.Text = "Auftrag hinzufügen";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.Location = new System.Drawing.Point(140, 140);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(100, 23);
            this.btnEditOrder.TabIndex = 7;
            this.btnEditOrder.Text = "Auftrag bearbeiten";
            this.btnEditOrder.UseVisualStyleBackColor = true;
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(260, 140);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteOrder.TabIndex = 8;
            this.btnDeleteOrder.Text = "Auftrag löschen";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.Location = new System.Drawing.Point(20, 180);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(360, 150);
            this.lstOrders.TabIndex = 9;
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.lstOrders_SelectedIndexChanged);
            // 
            // OrderForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnEditOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.cmbRelation);
            this.Controls.Add(this.lblRelation);
            this.Controls.Add(this.txtOrderDetails);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.cmbOrderType);
            this.Controls.Add(this.lblOrderType);
            this.Name = "OrderForm";
            this.Text = "Auftragserstellung";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
