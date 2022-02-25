using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculator2
{

    //class downloaded from https://github.com/alaabenfatma/VisualStudioTabControl/blob/master/VisualStudioTabControl/VisualStudioTabControl.cs
    public class VisualStudioTabControl : TabControl
    {
        /// <summary>
        ///     Format of the title of the TabPage
        /// </summary>
        private readonly StringFormat CenterSringFormat = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center,
            FormatFlags = StringFormatFlags.NoWrap,
        };

        /// <summary>
        ///     The color of the active tab header
        /// </summary>
        private Color activeColor = Color.FromArgb(0, 122, 204);

        /// <summary>
        ///     The color of the background of the Tab
        /// </summary>
        private Color backTabColor = Color.FromArgb(28, 28, 28);

        /// <summary>
        ///     The color of the border of the control
        /// </summary>
        private Color borderColor = Color.FromArgb(30, 30, 30);

        /// <summary>
        ///     Color of the closing button
        /// </summary>
        private Color closingButtonColor = Color.WhiteSmoke;

        /// <summary>
        ///     Message for the user before losing
        /// </summary>
        private string closingMessage;

        /// <summary>
        ///     The color of the tab header
        /// </summary>
        private Color headerColor = Color.FromArgb(45, 45, 48);

        /// <summary>
        ///     The color of the horizontal line which is under the headers of the tab pages
        /// </summary>
        private Color horizLineColor = Color.FromArgb(0, 122, 204);

        /// <summary>
        ///     A random page will be used to store a tab that will be deplaced in the run-time
        /// </summary>
        private TabPage predraggedTab;

        /// <summary>
        ///     The color of the text
        /// </summary>
        private Color textColor = Color.FromArgb(255, 255, 255);

        ///<summary>
        /// Shows closing buttons
        /// </summary> 
        public bool ShowClosingButton { get; set; }

        /// <summary>
        /// Selected tab text color
        /// </summary>
        public Color selectedTextColor = Color.FromArgb(255, 255, 255);
        /// <summary>
        ///     Init
        /// </summary>
        public VisualStudioTabControl()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true); //ControlStyles.AllPaintingInWmPaint |
            DoubleBuffered = true;
            //SizeMode = TabSizeMode.Normal;
            ItemSize = new Size(240, 16);
            AllowDrop = true;
        }

        [Category("Colors"), Browsable(true), Description("The color of the selected page")]
        public Color ActiveColor
        {
            get
            {
                return this.activeColor;
            }

            set
            {
                this.activeColor = value;
                Invalidate();
            }
        }

        [Category("Colors"), Browsable(true), Description("The color of the background of the tab")]
        public Color BackTabColor
        {
            get
            {
                return this.backTabColor;
            }

            set
            {
                this.backTabColor = value;
                Invalidate();
            }
        }

        [Category("Colors"), Browsable(true), Description("The color of the border of the control")]
        public Color BorderColor
        {
            get
            {
                return this.borderColor;
            }

            set
            {
                this.borderColor = value;
                Invalidate();
            }
        }

        /// <summary>
        ///     The color of the closing button
        /// </summary>
        [Category("Colors"), Browsable(true), Description("The color of the closing button")]
        public Color ClosingButtonColor
        {
            get
            {
                return this.closingButtonColor;
            }

            set
            {
                this.closingButtonColor = value;
                Invalidate();
            }
        }

        /// <summary>
        ///     The message that will be shown before closing.
        /// </summary>
        [Category("Options"), Browsable(true), Description("The message that will be shown before closing.")]
        public string ClosingMessage
        {
            get
            {
                return this.closingMessage;
            }

            set
            {
                this.closingMessage = value;
                Invalidate();
            }
        }

        [Category("Colors"), Browsable(true), Description("The color of the header.")]
        public Color HeaderColor
        {
            get
            {
                return this.headerColor;
            }

            set
            {
                this.headerColor = value;
                Invalidate();
            }
        }

        [Category("Colors"), Browsable(true),
         Description("The color of the horizontal line which is located under the headers of the pages.")]
        public Color HorizontalLineColor
        {
            get
            {
                return this.horizLineColor;
            }

            set
            {
                this.horizLineColor = value;
                Invalidate();
            }
        }

        /// <summary>
        ///     Show a Yes/No message before closing?
        /// </summary>
        [Category("Options"), Browsable(true), Description("Show a Yes/No message before closing?")]
        public bool ShowClosingMessage { get; set; }

        [Category("Colors"), Browsable(true), Description("The color of the title of the page")]
        public Color SelectedTextColor
        {
            get
            {
                return this.selectedTextColor;
            }

            set
            {
                this.selectedTextColor = value;
                Invalidate();
            }
        }

        [Category("Colors"), Browsable(true), Description("The color of the title of the page")]
        public Color TextColor
        {
            get
            {
                return this.textColor;
            }

            set
            {
                this.textColor = value;
                Invalidate();
            }
        }


        [Category("Options"), Browsable(true), Description("Padding of the header")]
        public Padding HeaderPadding
        {
            get
            {
                return this.headerPadding;
            }

            set
            {
                this.headerPadding = value;
                Invalidate();
            }
        }
        private Padding headerPadding;

        /// <summary>
        ///     Sets the Tabs on the top
        /// </summary>
        protected override void CreateHandle()
        {
            base.CreateHandle();
            Alignment = TabAlignment.Top;
        }

        /// <summary>
        ///     Drags the selected tab
        /// </summary>
        /// <param name="drgevent"></param>
        protected override void OnDragOver(DragEventArgs drgevent)
        {
            var draggedTab = (TabPage)drgevent.Data.GetData(typeof(TabPage));
            var pointedTab = getPointedTab();

            if (ReferenceEquals(draggedTab, predraggedTab) && pointedTab != null)
            {
                drgevent.Effect = DragDropEffects.Move;

                if (!ReferenceEquals(pointedTab, draggedTab))
                {
                    this.ReplaceTabPages(draggedTab, pointedTab);
                }
            }

            base.OnDragOver(drgevent);
        }

        private Point dragStart = new Point();
        /// <summary>
        ///     Handles the selected tab|closes the selected page if wanted.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            predraggedTab = getPointedTab();
            dragStart = e.Location;

            var p = e.Location;
            if (!this.ShowClosingButton)
            {
            }
            else
            {
                for (var i = 0; i < this.TabCount; i++)
                {
                    var r = this.GetTabRect(i);
                    r.Offset(r.Width - 15, 2);
                    r.Width = 10;
                    r.Height = 10;
                    if (!r.Contains(p))
                    {
                        continue;
                    }

                    if (this.ShowClosingMessage)
                    {
                        if (DialogResult.Yes == MessageBox.Show(this.ClosingMessage, "Close", MessageBoxButtons.YesNo))
                        {
                            this.TabPages.RemoveAt(i);
                        }
                    }
                    else
                    {
                        this.TabPages.RemoveAt(i);
                    }
                }
            }

            base.OnMouseDown(e);
        }

        /// <summary>
        ///     Holds the selected page until it sets down
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && predraggedTab != null && dragStart != e.Location)
            {
                this.DoDragDrop(predraggedTab, DragDropEffects.Move);
            }

            base.OnMouseMove(e);
        }

        /// <summary>
        ///     Abondons the selected tab
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            predraggedTab = null;
            base.OnMouseUp(e);
        }

        


        /// <summary>
        ///     Draws the control
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            
            //g.SmoothingMode = SmoothingMode.HighQuality;
            //g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            //g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.Clear(this.headerColor);


            for (var i = 0; i < TabCount; i++)
            {
                Rectangle tabRectangle = GetTabRect(i);
                tabRectangle = new Rectangle(tabRectangle.X - headerPadding.Left, tabRectangle.Y - headerPadding.Top, tabRectangle.Width + headerPadding.Left + headerPadding.Right, tabRectangle.Height + headerPadding.Top + headerPadding.Bottom);

                if(TabPages[i] == SelectedTab)
                {
                    TabPages[i].BorderStyle = BorderStyle.None;
                }

                //var Header = new Rectangle(
                //    new Point(.Location.X + 2, GetTabRect(i).Location.Y),
                //    new Size(GetTabRect(i).Width, GetTabRect(i).Height));

                using Brush ClosingColorBrush = new SolidBrush(this.closingButtonColor);

                if (i == SelectedIndex)
                {
                    // Draws the back of the header 
                    g.FillRectangle(new SolidBrush(this.headerColor), tabRectangle);

                    // Draws the back of the color when it is selected
                    Brush activeBrush = new SolidBrush(this.activeColor);

                    g.FillRectangle(
                        activeBrush,
                        tabRectangle);

                    // Draws the title of the page
                    Brush selectedTextColorBrush = new SolidBrush(this.selectedTextColor);
                    g.DrawString(
                        TabPages[i].Text,
                        Font,
                        selectedTextColorBrush,
                        tabRectangle,
                        this.CenterSringFormat);

                    // Draws the closing button
                    if (this.ShowClosingButton)
                    {
                        e.Graphics.DrawString("X", Font, ClosingColorBrush, tabRectangle.Right - 17, 3);
                    }
                }
                else
                {   
                    // Simply draws the header when it is not selected
                    g.DrawString(
                        TabPages[i].Text,
                        Font,
                        new SolidBrush(this.textColor),
                        tabRectangle,
                        this.CenterSringFormat);
                }
            }

            // Draws the horizontal line
            using Pen horizontalLinePen = new Pen(this.horizLineColor, 5);

            g.DrawLine(horizontalLinePen, new Point(-headerPadding.Left + 2, this.ItemSize.Height + 3), new Point(Width + headerPadding.Right + headerPadding.Left, this.ItemSize.Height + 3));

            // Draws the background of the tab control
            using Brush backgroundBrush = new SolidBrush(this.backTabColor);

            //Drawer.FillRectangle(backgroundBrush, new Rectangle(headerPadding.Left, this.ItemSize.Height + 4, Width - headerPadding.Left - headerPadding.Right, Height - this.ItemSize.Height + 4));
            //g.FillRectangle(backgroundBrush, tabRectangle);




            // Draws the border of the TabControl
            using Pen borderBen = new Pen(this.borderColor, 2);
            g.DrawRectangle(borderBen, new Rectangle(0, 0, Width, Height));
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }



        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.OnFontChanged(EventArgs.Empty);
        }



        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        private const int WM_SETFONT = 0x30;
        private const int WM_FONTCHANGE = 0x1d;


        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            IntPtr hFont = this.Font.ToHfont();
            SendMessage(this.Handle, WM_SETFONT, hFont, (IntPtr)(-1));
            SendMessage(this.Handle, WM_FONTCHANGE, IntPtr.Zero, IntPtr.Zero);
            this.UpdateStyles();
        }




        /// <summary>
        ///     Gets the pointed tab
        /// </summary>
        /// <returns></returns>
        private TabPage getPointedTab()
        {
            for (var i = 0; i <= this.TabPages.Count - 1; i++)
            {
                if (this.GetTabRect(i).Contains(this.PointToClient(Cursor.Position)))
                {
                    return this.TabPages[i];
                }
            }

            return null;
        }

        /// <summary>
        ///     Swaps the two tabs
        /// </summary>
        /// <param name="Source"></param>
        /// <param name="Destination"></param>
        private void ReplaceTabPages(TabPage Source, TabPage Destination)
        {
            var SourceIndex = this.TabPages.IndexOf(Source);
            var DestinationIndex = this.TabPages.IndexOf(Destination);

            this.TabPages[DestinationIndex] = Source;
            this.TabPages[SourceIndex] = Destination;

            if (this.SelectedIndex == SourceIndex)
            {
                this.SelectedIndex = DestinationIndex;
            }
            else if (this.SelectedIndex == DestinationIndex)
            {
                this.SelectedIndex = SourceIndex;
            }

            this.Refresh();
        }

    }
}
