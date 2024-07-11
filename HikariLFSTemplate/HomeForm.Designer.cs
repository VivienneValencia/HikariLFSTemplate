namespace HikariLFSTemplate
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.adminButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.navigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.adminButton, "adminButton");
            this.adminButton.Name = "adminButton";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.homeButton, "homeButton");
            this.homeButton.Name = "homeButton";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.SystemColors.Window;
            this.navigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigationPanel.Controls.Add(this.homeButton);
            this.navigationPanel.Controls.Add(this.adminButton);
            resources.ApplyResources(this.navigationPanel, "navigationPanel");
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.navigationPanel_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // HomeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navigationPanel);
            this.Name = "HomeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.navigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel navigationPanel;

        private System.Windows.Forms.Button homeButton;

        private System.Windows.Forms.Button adminButton;

        #endregion
    }
}