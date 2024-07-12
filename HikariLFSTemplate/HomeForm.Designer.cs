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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.btnOrderManager = new MetroFramework.Controls.MetroButton();
            this.infoButton = new MetroFramework.Controls.MetroButton();
            this.adminButton = new MetroFramework.Controls.MetroButton();
            this.homeButton = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.SystemColors.Window;
            this.navigationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigationPanel.Controls.Add(this.btnOrderManager);
            this.navigationPanel.Controls.Add(this.infoButton);
            this.navigationPanel.Controls.Add(this.adminButton);
            this.navigationPanel.Controls.Add(this.homeButton);
            resources.ApplyResources(this.navigationPanel, "navigationPanel");
            this.navigationPanel.Name = "navigationPanel";
            // 
            // btnOrderManager
            // 
            resources.ApplyResources(this.btnOrderManager, "btnOrderManager");
            this.btnOrderManager.Name = "btnOrderManager";
            this.btnOrderManager.Style = MetroFramework.MetroColorStyle.Silver;
            this.btnOrderManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnOrderManager.Click += new System.EventHandler(this.btnOrderManager_Click);
            // 
            // infoButton
            // 
            resources.ApplyResources(this.infoButton, "infoButton");
            this.infoButton.Name = "infoButton";
            this.infoButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.infoButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // adminButton
            // 
            resources.ApplyResources(this.adminButton, "adminButton");
            this.adminButton.Name = "adminButton";
            this.adminButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.adminButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click_1);
            // 
            // homeButton
            // 
            resources.ApplyResources(this.homeButton, "homeButton");
            this.homeButton.Name = "homeButton";
            this.homeButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.homeButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
        }

        private MetroFramework.Controls.MetroButton btnOrderManager;

        private MetroFramework.Controls.MetroButton infoButton;

        private MetroFramework.Controls.MetroButton adminButton;

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;

        private MetroFramework.Controls.MetroButton homeButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel navigationPanel;

        #endregion
    }
}