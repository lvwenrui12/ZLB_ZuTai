namespace ZLB_Zutai
{
    partial class DummyPropertyWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DummyPropertyWindow));
            this.cmbControls = new System.Windows.Forms.ComboBox();
            this.pnlPropertyGrid = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cmbControls
            // 
            this.cmbControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbControls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbControls.FormattingEnabled = true;
            this.cmbControls.Items.AddRange(new object[] {
            "Form1 System.Windows.Forms"});
            this.cmbControls.Location = new System.Drawing.Point(0, 3);
            this.cmbControls.Name = "cmbControls";
            this.cmbControls.Size = new System.Drawing.Size(289, 20);
            this.cmbControls.TabIndex = 2;
            // 
            // pnlPropertyGrid
            // 
            this.pnlPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPropertyGrid.Location = new System.Drawing.Point(0, 3);
            this.pnlPropertyGrid.Name = "pnlPropertyGrid";
            this.pnlPropertyGrid.Size = new System.Drawing.Size(289, 487);
            this.pnlPropertyGrid.TabIndex = 3;
            // 
            // DummyPropertyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(289, 493);
            this.Controls.Add(this.cmbControls);
            this.Controls.Add(this.pnlPropertyGrid);
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DummyPropertyWindow";
            this.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockRight;
            this.TabText = "Properties";
            this.Text = "Properties";
            this.ResumeLayout(false);

        }
        #endregion

        public System.Windows.Forms.ComboBox cmbControls;
        private System.Windows.Forms.Panel pnlPropertyGrid;
    }
}