using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{

    [Serializable]
    public class ExtraButton
    {
        public string Text { get; set; } = "";
        public string Action { get; set; } = "";
        public int Colspan { get; set; } = 1;
        public string TooltipText { get; set; } = "";


        public class ColorWrapper
        {
            public Color Color { get; set; }
        }

        public ColorWrapper Color { get; set; } = new ExtraButton.ColorWrapper() { Color = System.Drawing.Color.White };

        public ExtraButton()
        {
        }

        public ExtraButton(string text, string action, int colspan, Color color, string tooltipText)
        {
            Text = text;
            Action = action;
            Colspan = colspan;
            Color = new ColorWrapper() { Color = color };
            TooltipText = tooltipText;
        }
    }
}
