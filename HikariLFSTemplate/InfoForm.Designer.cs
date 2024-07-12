using System.ComponentModel;

namespace HikariLFSTemplate
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.infoLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(35, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(120, 30);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Information";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.infoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.infoLabel.CustomBackground = true;
            this.infoLabel.CustomForeColor = true;
            this.infoLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.infoLabel.Location = new System.Drawing.Point(35, 66);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(540, 28);
            this.infoLabel.Style = MetroFramework.MetroColorStyle.Black;
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "This program in mainly developed and maintained by the Hikari Dev Team\r\n";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.infoLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.infoLabel.UseStyleColors = true;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.ResumeLayout(false);
        }

        private MetroFramework.Controls.MetroLabel infoLabel;

        private MetroFramework.Controls.MetroLabel metroLabel1;

        #endregion
    }
}