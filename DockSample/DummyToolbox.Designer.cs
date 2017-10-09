namespace ZLB_Zutai
{
    partial class DummyToolbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DummyToolbox));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pnlToolBox = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Mouse.bmp");
            // 
            // pnlToolBox
            // 
            this.pnlToolBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlToolBox.Location = new System.Drawing.Point(0, 2);
            this.pnlToolBox.Name = "pnlToolBox";
            this.pnlToolBox.Size = new System.Drawing.Size(284, 361);
            this.pnlToolBox.TabIndex = 1;
            // 
            // DummyToolbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(284, 365);
            this.Controls.Add(this.pnlToolBox);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(16, 38);
            this.Name = "DummyToolbox";
            this.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockLeftAutoHide;
            this.TabText = "Toolbox";
            this.Text = "Toolbox";
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel pnlToolBox;
    }
}