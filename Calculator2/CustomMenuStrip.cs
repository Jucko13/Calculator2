using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{


    class MenuColorTable : ProfessionalColorTable
    {
        public MenuColorTable()
        {
            // see notes
            base.UseSystemColors = false;
        }

        public override Color MenuItemPressedGradientBegin => Color.FromArgb(31, 31, 31);
        public override Color MenuItemPressedGradientEnd => Color.FromArgb(31, 31, 31);
        public override Color MenuItemPressedGradientMiddle => Color.FromArgb(31, 31, 31);
        public override Color MenuBorder => Color.FromArgb(158, 158, 158);
        public override Color MenuItemBorder => Color.FromArgb(158, 158, 158);
        public override Color MenuItemSelected => Color.FromArgb(61, 61, 61);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(61, 61, 61);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(61, 61, 61);
        public override Color MenuStripGradientBegin => Color.FromArgb(31, 31, 31);
        public override Color MenuStripGradientEnd => Color.FromArgb(31, 31, 31);
        public override Color ToolStripDropDownBackground => Color.FromArgb(31, 31, 31);
        public override Color ImageMarginGradientBegin => Color.FromArgb(31, 31, 31);
        public override Color ImageMarginGradientEnd => Color.FromArgb(31, 31, 31);
        public override Color ImageMarginGradientMiddle => Color.FromArgb(31, 31, 31);


        public override Color CheckBackground => Color.FromArgb(61, 61, 61);
        public override Color CheckSelectedBackground => Color.FromArgb(61, 61, 61);

        public override Color ButtonCheckedHighlightBorder => Color.FromArgb(158, 158, 158);
        public override Color ButtonCheckedHighlight => Color.FromArgb(158, 158, 158);
        public override Color ButtonSelectedHighlightBorder => Color.FromArgb(158, 158, 158);
        public override Color ButtonSelectedBorder => Color.FromArgb(61, 61, 61);
        public override Color CheckPressedBackground => Color.FromArgb(100,100,100);
        
    }


    public class CustomMenuStrip : MenuStrip
    {

        //class downloaded and altered from https://www.c-sharpcorner.com/UploadFile/f5a10c/creating-custom-controls-in-C-Sharp/
        public CustomMenuStrip()
        {
            this.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
        }
    }

    //public class MyMenuRenderer : ToolStripRenderer
    //{

        
    //    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    //    {
            
    //        base.OnRenderMenuItemBackground(e);

    //        if (e.Item.Enabled)
    //        {
    //            if (e.Item.IsOnDropDown == false && e.Item.Selected)
    //            {
    //                var rect = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
    //                var rect2 = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
    //                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(61, 61, 61)), rect);
    //                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(158,158,158))), rect2);
    //                e.Item.ForeColor = Color.White;
    //            }
    //            else
    //            {
    //                e.Item.ForeColor = Color.White;
    //            }

    //            if (e.Item.IsOnDropDown && e.Item.Selected)
    //            {
    //                var rect = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
    //                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(61, 61, 61)), rect);
    //                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(158, 158, 158))), rect);
    //                e.Item.ForeColor = Color.White;
    //            }
    //            if (((ToolStripMenuItem)e.Item).DropDown.Visible && e.Item.IsOnDropDown == false)
    //            {
    //                var rect = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
    //                var rect2 = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
    //                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(20, 20, 20)), rect);
    //                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(158, 158, 158))), rect2);
    //                e.Item.ForeColor = Color.White;
    //            }
    //        }
    //    }
    //    protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
    //    {
    //        base.OnRenderSeparator(e);
    //        var DarkLine = new SolidBrush(Color.FromArgb(30, 30, 30));
    //        var rect = new Rectangle(30, 3, e.Item.Width - 30, 1);
    //        e.Graphics.FillRectangle(DarkLine, rect);
    //    }


    //    protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
    //    {
    //        base.OnRenderItemCheck(e);

    //        if (e.Item.Selected)
    //        {
    //            var rect = new Rectangle(4, 2, 18, 18);
    //            var rect2 = new Rectangle(5, 3, 16, 16);
    //            SolidBrush b = new SolidBrush(Color.FromArgb(158, 158, 158));
    //            SolidBrush b2 = new SolidBrush(Color.FromArgb(220, 220, 220));

    //            e.Graphics.FillRectangle(b, rect);
    //            e.Graphics.FillRectangle(b2, rect2);
    //            e.Graphics.DrawImage(e.Image, new Point(5, 3));
    //        }
    //        else
    //        {
    //            var rect = new Rectangle(4, 2, 18, 18);
    //            var rect2 = new Rectangle(5, 3, 16, 16);
    //            SolidBrush b = new SolidBrush(Color.White);
    //            SolidBrush b2 = new SolidBrush(Color.FromArgb(255, 80, 90, 90));

    //            e.Graphics.FillRectangle(b, rect);
    //            e.Graphics.FillRectangle(b2, rect2);
    //            e.Graphics.DrawImage(e.Image, new Point(5, 3));
    //        }
    //    }

    //    protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
    //    {
    //        base.OnRenderImageMargin(e);

    //        var rect = new Rectangle(0, 0, e.ToolStrip.Width, e.ToolStrip.Height);
    //        e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(20, 20, 20)), rect);

    //        var DarkLine = new SolidBrush(Color.FromArgb(20, 20, 20));
    //        var rect3 = new Rectangle(0, 0, 26, e.AffectedBounds.Height);
    //        e.Graphics.FillRectangle(DarkLine, rect3);

    //        e.Graphics.DrawLine(new Pen(new SolidBrush(Color.FromArgb(20, 20, 20))), 28, 0, 28, e.AffectedBounds.Height);

    //        var rect2 = new Rectangle(0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);
    //        e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), rect2);
    //    }
    //}

}

