using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;
using ZLB_Zutai.HelperClass;
using ZLB_Zutai.Model;
using ZLB_Zutai.Services;
using ICSharpCode.TextEditor;
using ICSharpCode.TextEditor.Document;
using EventBindingService = ZLB_Zutai.Services.EventBindingService;

namespace ZLB_Zutai
{
    public partial class DummyPropertyWindow : ToolWindow
    {

        bool _ShouldUpdateSelectableObjects = false;
        bool inUpdate = false;
        
        IDesignerHost _host;
      public  PropertyGrid _propertyGrid;
        TextEditorControl _textEditor;

        ISelectionService _selectionService;
        CustomToolboxService _toolboxService;
        MenuCommandService _menuCommandService;

        Loader.CodeDomHostLoader _CodeDomHostLoader;
        private Form rootComponent = null;

        public DummyPropertyWindow()
        {
            InitializeComponent();

            #region Ìí¼ÓPropertyPad ÓÒ±ßÊôÐÔ±í


            _propertyGrid = new PropertyGrid { Dock = DockStyle.Fill };
            pnlPropertyGrid.Controls.Add(_propertyGrid);
            cmbControls.Sorted = true;
            cmbControls.DrawMode = DrawMode.OwnerDrawFixed;
            cmbControls.DrawItem += new DrawItemEventHandler(cmbControls_DrawItem);
            //if (GolableInstance.PageList().Count>0)
            //{
            //    PageMoel page = GolableInstance.PageList().First();
            //    _propertyGrid = page.propertyGrid;

            //}

            //_propertyGrid = new PropertyGrid { Dock = DockStyle.Fill };





            //if (null!=surface && (surface.ComponentContainer.Components.Count>0))
            //{
            //    _propertyGrid.SelectedObject = surface.ComponentContainer.Components[0];
            //    cmbControls.SelectedIndex = 0;
            //}


            #endregion


        }

        private void cmbControls_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= cmbControls.Items.Count)
            {
                return;
            }
            Graphics g = e.Graphics;
            Brush stringColor = SystemBrushes.ControlText;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                if ((e.State & DrawItemState.Focus) == DrawItemState.Focus)
                {
                    g.FillRectangle(SystemBrushes.Highlight, e.Bounds);
                    stringColor = SystemBrushes.HighlightText;
                }
                else
                {
                    g.FillRectangle(SystemBrushes.Window, e.Bounds);
                }
            }
            else
            {
                g.FillRectangle(SystemBrushes.Window, e.Bounds);
            }

            object item = cmbControls.Items[e.Index];
            int xPos = e.Bounds.X;

            if (item is IComponent)
            {
                ISite site = ((IComponent)item).Site;
                if (site != null)
                {
                    string name = site.Name;
                    using (Font f = new Font(cmbControls.Font, FontStyle.Bold))
                    {
                        g.DrawString(name, f, stringColor, xPos, e.Bounds.Y);
                        xPos += (int)g.MeasureString(name + "-", f).Width;
                    }
                }
            }

            string typeString = item.GetType().ToString();
            g.DrawString(typeString, cmbControls.Font, stringColor, xPos, e.Bounds.Y);
        }
    }
}