namespace HikariLFSTemplate.Admin
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblRelationName;
        private System.Windows.Forms.Label lblBarcode;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRelationType;
        private System.Windows.Forms.TextBox txtRelationName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cmbRelationType;
        private System.Windows.Forms.ListBox lstRelations;
        private System.Windows.Forms.Button btnAddRelation;
        private System.Windows.Forms.Button btnEditRelation;
        private System.Windows.Forms.Button btnDeleteRelation;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRelationName = new System.Windows.Forms.Label();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtRelationName = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lstRelations = new System.Windows.Forms.ListBox();
            this.btnAddRelation = new System.Windows.Forms.Button();
            this.btnEditRelation = new System.Windows.Forms.Button();
            this.btnDeleteRelation = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblRelationType = new System.Windows.Forms.Label();
            this.cmbRelationType = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // lblRelationName
            // 
            this.lblRelationName.AutoSize = true;
            this.lblRelationName.Location = new System.Drawing.Point(20, 20);
            this.lblRelationName.Name = "lblRelationName";
            this.lblRelationName.Size = new System.Drawing.Size(121, 13);
            this.lblRelationName.TabIndex = 0;
            this.lblRelationName.Text = "Name des Lagerplatzes:";
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(20, 60);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(50, 13);
            this.lblBarcode.TabIndex = 1;
            this.lblBarcode.Text = "Barcode:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(20, 100);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(86, 13);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Größe/Stellplatz:";
            // 
            // txtRelationName
            // 
            this.txtRelationName.Location = new System.Drawing.Point(180, 20);
            this.txtRelationName.Name = "txtRelationName";
            this.txtRelationName.Size = new System.Drawing.Size(200, 20);
            this.txtRelationName.TabIndex = 3;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(180, 60);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(200, 20);
            this.txtBarcode.TabIndex = 4;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(180, 100);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(200, 20);
            this.txtSize.TabIndex = 5;
            // 
            // lstRelations
            // 
            this.lstRelations.FormattingEnabled = true;
            this.lstRelations.Location = new System.Drawing.Point(20, 166);
            this.lstRelations.Name = "lstRelations";
            this.lstRelations.Size = new System.Drawing.Size(360, 121);
            this.lstRelations.TabIndex = 6;
            this.lstRelations.SelectedIndexChanged += new System.EventHandler(this.lstRelations_SelectedIndexChanged);
            // 
            // btnAddRelation
            // 
            this.btnAddRelation.Location = new System.Drawing.Point(20, 310);
            this.btnAddRelation.Name = "btnAddRelation";
            this.btnAddRelation.Size = new System.Drawing.Size(100, 35);
            this.btnAddRelation.TabIndex = 7;
            this.btnAddRelation.Text = "Lagerplatz hinzufügen";
            this.btnAddRelation.UseVisualStyleBackColor = true;
            this.btnAddRelation.Click += new System.EventHandler(this.btnAddRelation_Click);
            // 
            // btnEditRelation
            // 
            this.btnEditRelation.Location = new System.Drawing.Point(126, 310);
            this.btnEditRelation.Name = "btnEditRelation";
            this.btnEditRelation.Size = new System.Drawing.Size(148, 35);
            this.btnEditRelation.TabIndex = 8;
            this.btnEditRelation.Text = "Lagerplatz bearbeiten";
            this.btnEditRelation.UseVisualStyleBackColor = true;
            this.btnEditRelation.Click += new System.EventHandler(this.btnEditRelation_Click);
            // 
            // btnDeleteRelation
            // 
            this.btnDeleteRelation.Location = new System.Drawing.Point(280, 310);
            this.btnDeleteRelation.Name = "btnDeleteRelation";
            this.btnDeleteRelation.Size = new System.Drawing.Size(100, 35);
            this.btnDeleteRelation.TabIndex = 9;
            this.btnDeleteRelation.Text = "Lagerplatz löschen";
            this.btnDeleteRelation.UseVisualStyleBackColor = true;
            this.btnDeleteRelation.Click += new System.EventHandler(this.btnDeleteRelation_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 140);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(102, 13);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Kurze Beschreibung";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(180, 137);
            this.txtDescription.MaxLength = 200;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 20);
            this.txtDescription.TabIndex = 11;
            // 
            // lblRelationType
            // 
            this.lblRelationType.AutoSize = true;
            this.lblRelationType.Location = new System.Drawing.Point(403, 23);
            this.lblRelationType.Name = "lblRelationType";
            this.lblRelationType.Size = new System.Drawing.Size(68, 13);
            this.lblRelationType.TabIndex = 12;
            this.lblRelationType.Text = "Relationstyp:";
            // 
            // cmbRelationType
            // 
            this.cmbRelationType.FormattingEnabled = true;
            this.cmbRelationType.ItemHeight = 23;
            this.cmbRelationType.Items.AddRange(new object[] { "Festplatz", "Kommissionierplatz" });
            this.cmbRelationType.Location = new System.Drawing.Point(499, 17);
            this.cmbRelationType.Name = "cmbRelationType";
            this.cmbRelationType.Size = new System.Drawing.Size(79, 29);
            this.cmbRelationType.TabIndex = 9;
            // 
            // AdminForm
            // 
            this.ClientSize = new System.Drawing.Size(633, 350);
            this.Controls.Add(this.cmbRelationType);
            this.Controls.Add(this.lblRelationType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnDeleteRelation);
            this.Controls.Add(this.btnEditRelation);
            this.Controls.Add(this.btnAddRelation);
            this.Controls.Add(this.lstRelations);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtRelationName);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblBarcode);
            this.Controls.Add(this.lblRelationName);
            this.Name = "AdminForm";
            this.Text = "LFS AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
