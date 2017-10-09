namespace ZLB_Zutai
{
    partial class DesignWorkbench
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignWorkbench));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tpCode = new System.Windows.Forms.TabPage();
            this.tpDesign = new System.Windows.Forms.TabPage();
            this.tabContent = new System.Windows.Forms.TabControl();
            this.tabContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpCode
            // 
            this.tpCode.Location = new System.Drawing.Point(4, 4);
            this.tpCode.Name = "tpCode";
            this.tpCode.Padding = new System.Windows.Forms.Padding(3);
            this.tpCode.Size = new System.Drawing.Size(595, 438);
            this.tpCode.TabIndex = 1;
            this.tpCode.Text = "Code";
            this.tpCode.UseVisualStyleBackColor = true;
            // 
            // tpDesign
            // 
            this.tpDesign.Location = new System.Drawing.Point(4, 4);
            this.tpDesign.Name = "tpDesign";
            this.tpDesign.Padding = new System.Windows.Forms.Padding(3);
            this.tpDesign.Size = new System.Drawing.Size(595, 438);
            this.tpDesign.TabIndex = 0;
            this.tpDesign.Text = "…Ëº∆";
            this.tpDesign.UseVisualStyleBackColor = true;
            // 
            // tabContent
            // 
            this.tabContent.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabContent.Controls.Add(this.tpDesign);
            this.tabContent.Controls.Add(this.tpCode);
            this.tabContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabContent.Location = new System.Drawing.Point(0, 4);
            this.tabContent.Name = "tabContent";
            this.tabContent.SelectedIndex = 0;
            this.tabContent.Size = new System.Drawing.Size(603, 464);
            this.tabContent.TabIndex = 2;
            // 
            // DesignWorkbench
            // 
            this.ClientSize = new System.Drawing.Size(603, 468);
            this.Controls.Add(this.tabContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DesignWorkbench";
            this.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.Load += new System.EventHandler(this.DesignWorkbench_Load);
     
            this.tabContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage tpCode;
        private System.Windows.Forms.TabPage tpDesign;
        private System.Windows.Forms.TabControl tabContent;
    }
}