namespace FileInformationControl
{
    partial class DrivesControls
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLabelInfo = new System.Windows.Forms.Label();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.txtspaceInfo = new System.Windows.Forms.Label();
            this.driveContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelfull = new System.Windows.Forms.Label();
            this.txtprcent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.driveContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FileInformationControl.Properties.Resources.Drive_OS_Windows_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtLabelInfo
            // 
            this.txtLabelInfo.AutoSize = true;
            this.txtLabelInfo.Font = new System.Drawing.Font("Ubuntu Mono", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabelInfo.Location = new System.Drawing.Point(90, 0);
            this.txtLabelInfo.Name = "txtLabelInfo";
            this.txtLabelInfo.Size = new System.Drawing.Size(32, 35);
            this.txtLabelInfo.TabIndex = 1;
            this.txtLabelInfo.Text = "-";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(90, 38);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.metroProgressBar1.Size = new System.Drawing.Size(312, 16);
            this.metroProgressBar1.TabIndex = 2;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtspaceInfo
            // 
            this.txtspaceInfo.AutoSize = true;
            this.txtspaceInfo.Font = new System.Drawing.Font("Ubuntu Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtspaceInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtspaceInfo.Location = new System.Drawing.Point(90, 57);
            this.txtspaceInfo.Name = "txtspaceInfo";
            this.txtspaceInfo.Size = new System.Drawing.Size(27, 29);
            this.txtspaceInfo.TabIndex = 3;
            this.txtspaceInfo.Text = "-";
            // 
            // driveContextMenu
            // 
            this.driveContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.driveContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.propertyToolStripMenuItem});
            this.driveContextMenu.Name = "driveContextMenu";
            this.driveContextMenu.Size = new System.Drawing.Size(211, 104);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // propertyToolStripMenuItem
            // 
            this.propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            this.propertyToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.propertyToolStripMenuItem.Text = "Property";
            this.propertyToolStripMenuItem.Click += new System.EventHandler(this.propertyToolStripMenuItem_Click);
            // 
            // labelfull
            // 
            this.labelfull.AutoSize = true;
            this.labelfull.Font = new System.Drawing.Font("Ubuntu Mono", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfull.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelfull.Location = new System.Drawing.Point(90, 86);
            this.labelfull.Name = "labelfull";
            this.labelfull.Size = new System.Drawing.Size(27, 29);
            this.labelfull.TabIndex = 5;
            this.labelfull.Text = "-";
            // 
            // txtprcent
            // 
            this.txtprcent.AutoSize = true;
            this.txtprcent.Location = new System.Drawing.Point(346, 57);
            this.txtprcent.Name = "txtprcent";
            this.txtprcent.Size = new System.Drawing.Size(28, 17);
            this.txtprcent.TabIndex = 6;
            this.txtprcent.Text = "0%";
            // 
            // DrivesControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.driveContextMenu;
            this.Controls.Add(this.txtprcent);
            this.Controls.Add(this.labelfull);
            this.Controls.Add(this.txtspaceInfo);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.txtLabelInfo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DrivesControls";
            this.Size = new System.Drawing.Size(405, 131);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.driveContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtLabelInfo;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Label txtspaceInfo;
        private System.Windows.Forms.ContextMenuStrip driveContextMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyToolStripMenuItem;
        private System.Windows.Forms.Label labelfull;
        private System.Windows.Forms.Label txtprcent;
    }
}
