using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using Jint.Native;
using Jint.Runtime;
using Range = FastColoredTextBoxNS.Range;

namespace Calculator2
{
    public partial class FrmMain : Form
    {

        private Jint.Engine engine = null;

        public FrmMain()
        {
            InitializeComponent();

        }

        //private TextStyle keywordStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);

        private List<TextStyle> textStyles = new List<TextStyle>()
        {
            new TextStyle(new SolidBrush(Color.FromArgb(60, 140, 255)), null, FontStyle.Regular),
            new TextStyle(new SolidBrush(Color.FromArgb(255, 126, 0)), null, FontStyle.Regular),
            new TextStyle(new SolidBrush(Color.FromArgb(67,129,181)), null, FontStyle.Regular),
            new TextStyle(new SolidBrush(Color.FromArgb(191, 112, 0)), null, FontStyle.Regular),
            new TextStyle(new SolidBrush(Color.FromArgb(170, 98, 255)), null, FontStyle.Regular),
            new TextStyle(new SolidBrush(Color.FromArgb(0, 200, 242)), null, FontStyle.Regular),
            new TextStyle(new SolidBrush(Color.FromArgb(114,218,137)), null, FontStyle.Regular),
            new TextStyle(new SolidBrush(Color.FromArgb(128,128,128)), null, FontStyle.Regular),
            new TextStyle(new SolidBrush(Color.FromArgb(240,71,71)), null, FontStyle.Regular),

        };

        private WavyLineStyle criteriaStyleWavyLine = new WavyLineStyle(255, Color.Red);

        private List<TextStyle> criteriaStyleRainbow = (new Color[] { 
            //Color.Blue, Color.Maroon, Color.YellowGreen, Color.Firebrick, Color.DarkGreen, Color.DarkViolet, Color.Red, Color.Black, Color.Gold
            //Color.Red, Color.Yellow, Color.Green, Color.Cyan, Color.Blue, Color.Magenta
            Color.FromArgb(255,20,147  ),
            Color.FromArgb(154,205,50  ),
            Color.FromArgb(148,0,211   ),
            Color.FromArgb(105,105,105 ),
            Color.FromArgb(65,105,225  ),
            Color.FromArgb(220,20,60   ),
            Color.FromArgb(0,206,209   ),
            Color.FromArgb(0,128,0     )
        }).Select(x => new TextStyle(new SolidBrush(x), null, FontStyle.Bold)).ToList();


        private MarkerStyle bracketMarkerStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(50,255,255,255)));

        private void FrmMain_Load(object sender, EventArgs e)
        {



            //JavascriptEvaluator.JavascriptEvaluator javascriptEvaluator = null;


            //javascriptEvaluator = new JavascriptEvaluator.JavascriptEvaluator();

            //engine = new ScriptEngine("{16d51579-a30b-4c8b-a276-0ff4dc41e755}");

            engine = new Jint.Engine();

            foreach (Button button in TableButtonLayout.Controls.OfType<Button>())
            {
                button.Dock = DockStyle.Fill;
                button.Click += TableButton_Click;
                button.Font = new Font("Cascadia Mono Light", 10.0f, FontStyle.Regular);
                button.Padding = Padding.Empty;
                button.Margin = new Padding(2);
            }

            FastColoredTextBox[] textBoxes = new FastColoredTextBox[]
            {
                FastCode, FastResult, FastCalculation
            };

            foreach (var box in textBoxes)
            {
                criteriaStyleRainbow.ForEach(x => box.AddStyle(x));
                textStyles.ForEach(x => box.AddStyle(x));


                box.SyntaxHighlighter.KeywordStyle = textStyles[4]; //done
                box.SyntaxHighlighter.StringStyle = textStyles[1]; //done
                box.SyntaxHighlighter.VariableStyle = textStyles[5]; //done, not sure
                box.SyntaxHighlighter.TypesStyle = textStyles[4];
                box.SyntaxHighlighter.FunctionsStyle = textStyles[2]; //done
                box.SyntaxHighlighter.ClassNameStyle = textStyles[3]; //done
                box.SyntaxHighlighter.CommentStyle = textStyles[7]; //done
                box.SyntaxHighlighter.NumberStyle = textStyles[8];

                box.BracketsStyle = bracketMarkerStyle;

                box.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;

                box.TextChangedDelayed += FastColoredTextBox_TextChangedDelayed;
                //box.MouseWheel += FastCode_MouseWheel;
            }



            FastCalculation.Text = @"[1,2,3].join("" | "")";


            var stringBuild = new StringBuilder();
            //            stringBuild.AppendLine("var JSON;JSON||(JSON={}),(function(){\"use strict\";function i(n){return n<10?\"0\"+n:n}function f(n){return o.lastIndex=0,o.test(n)?'\"'+n.replace(o,function(n){var t=s[n];return typeof t==\"string\"?t:\"\\\\u\"+(\"0000\"+n.charCodeAt(0).toString(16)).slice(-4)})+'\"':'\"'+n+'\"'}function r(i,e){var h,l,c,a,v=n,s,o=e[i];o&&typeof o==\"object\"&&typeof o.toJSON==\"function\"&&(o=o.toJSON(i)),typeof t==\"function\"&&(o=t.call(e,i,o));switch(typeof o){case\"string\":return f(o);case\"number\":return isFinite(o)?String(o):\"null\";case\"boolean\":case\"null\":return String(o);case\"object\":if(!o)return\"null\";n+=u,s=[];if(Object.prototype.toString.apply(o)===\"[object Array]\"){for(a=o.length,h=0;h<a;h+=1)s[h]=r(h,o)||\"null\";return c=s.length===0?\"[]\":n?\"[\\n\"+n+s.join(\",\\n\"+n)+\"\\n\"+v+\"]\":\"[\"+s.join(\",\")+\"]\",n=v,c}if(t&&typeof t==\"object\")for(a=t.length,h=0;h<a;h+=1)typeof t[h]==\"string\"&&(l=t[h],c=r(l,o),c&&s.push(f(l)+(n?\": \":\":\")+c));else for(l in o)Object.prototype.hasOwnProperty.call(o,l)&&(c=r(l,o),c&&s.push(f(l)+(n?\": \":\":\")+c));return c=s.length===0?\"{}\":n?\"{\\n\"+n+s.join(\",\\n\"+n)+\"\\n\"+v+\"}\":\"{\"+s.join(\",\")+\"}\",n=v,c}}typeof Date.prototype.toJSON!=\"function\"&&(Date.prototype.toJSON=function(){return isFinite(this.valueOf())?this.getUTCFullYear()+\"-\"+i(this.getUTCMonth()+1)+\"-\"+i(this.getUTCDate())+\"T\"+i(this.getUTCHours())+\":\"+i(this.getUTCMinutes())+\":\"+i(this.getUTCSeconds())+\"Z\":null},String.prototype.toJSON=Number.prototype.toJSON=Boolean.prototype.toJSON=function(){return this.valueOf()});var e=/[\\u0000\\u00ad\\u0600-\\u0604\\u070f\\u17b4\\u17b5\\u200c-\\u200f\\u2028-\\u202f\\u2060-\\u206f\\ufeff\\ufff0-\\uffff]/g,o=/[\\\\\\\"\\x00-\\x1f\\x7f-\\x9f\\u00ad\\u0600-\\u0604\\u070f\\u17b4\\u17b5\\u200c-\\u200f\\u2028-\\u202f\\u2060-\\u206f\\ufeff\\ufff0-\\uffff]/g,n,u,s={\"\\b\":\"\\\\b\",\"\\t\":\"\\\\t\",\"\\n\":\"\\\\n\",\"\\f\":\"\\\\f\",\"\\r\":\"\\\\r\",'\"':'\\\\\"',\"\\\\\":\"\\\\\\\\\"},t;typeof JSON.stringify!=\"function\"&&(JSON.stringify=function(i,f,e){var o;n=\"\",u=\"\";if(typeof e==\"number\")for(o=0;o<e;o+=1)u+=\" \";else typeof e==\"string\"&&(u=e);t=f;if(f&&typeof f!=\"function\"&&(typeof f!=\"object\"||typeof f.length!=\"number\"))throw new Error(\"JSON.stringify\");return r(\"\",{\"\":i})}),typeof JSON.parse!=\"function\"&&(JSON.parse=function(n,t){function r(n,i){var f,e,u=n[i];if(u&&typeof u==\"object\")for(f in u)Object.prototype.hasOwnProperty.call(u,f)&&(e=r(u,f),e!==undefined?u[f]=e:delete u[f]);return t.call(n,i,u)}var i;n=String(n),e.lastIndex=0,e.test(n)&&(n=n.replace(e,function(n){return\"\\\\u\"+(\"0000\"+n.charCodeAt(0).toString(16)).slice(-4)}));if(/^[\\],:{}\\s]*$/.test(n.replace(/\\\\(?:[\"\\\\\\/bfnrt]|u[0-9a-fA-F]{4})/g,\"@\").replace(/\"[^\"\\\\\\n\\r]*\"|true|false|null|-?\\d+(?:\\.\\d*)?(?:[eE][+\\-]?\\d+)?/g,\"]\").replace(/(?:^|:|,)(?:\\s*\\[)+/g,\"\")))return i=eval(\"(\"+n+\")\"),typeof t==\"function\"?r({\"\":i},\"\"):i;throw new SyntaxError(\"JSON.parse\");})})()");

            //            stringBuild.AppendLine(@"
            //if(test){
            //    for(var i = 0; i < 10; i++){
            //           Log(""Something {}"");
            //    }
            //}


            //");

            FastCode.Text = stringBuild.ToString();
        }

        private void FastCode_MouseWheel(object? sender, MouseEventArgs e)
        {
            //if((ModifierKeys & Keys.Shift ) == Keys.Shift)
            //{
            //    FastCode.HorizontalScroll.Value += e.Delta > 0 ? 1 : -1;
            //}
        }

        private void TableButton_Click(object? sender, EventArgs e)
        {
            if (sender is null) return;

            Button button = (Button)sender;

            switch (button.Text)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "+":
                case "-":
                case "*":
                case "/":
                case " + \"\" + ":
                    FastCalculation.InsertText(button.Text);
                    break;

                case "=":

                    ExecuteCode();

                    break;

                case "( )":
                    int selectStart = FastCalculation.SelectionStart;
                    int selectLength = FastCalculation.SelectionLength;
                    FastCalculation.SelectedText = "(" + FastCalculation.SelectedText + ")";
                    FastCalculation.SelectionStart = selectStart;
                    FastCalculation.SelectionLength = selectLength + 2;

                    break;

            }


        }

        private void ExecuteCode()
        {

            Stopwatch stopwatch = Stopwatch.StartNew();

            try
            {
                //object result = engine.Parse(
                //    FastCode.Text + "\r\n" +
                //    FastCalculation.Text);

                //if(result is null)
                //{
                //    FastResult.Text = $"[{engine.Site.LastException.Line}, {engine.Site.LastException.Column}]" + engine.Site.LastException.Description;
                //}
                //else
                //{
                //    FastResult.Text = result.ToString();
                //}

                JsValue result = engine.Evaluate(
                    FastCode.Text + "\r\n" +
                    "return JSON.stringify(" + FastCalculation.Text + ");");

                if (result is null)
                {

                    //FastResult.Text = $"[{engine.Site.LastException.Line}, {engine.Site.LastException.Column}]" + engine.Site.LastException.Description;
                }
                else
                {
                    FastResult.Text = result.ToString() + stopwatch.Elapsed.TotalMilliseconds.ToString(" | 0.## ms");

                }

            }
            catch (JavaScriptException jex)
            {
                FastResult.Text = $"[{jex.LineNumber}, {jex.Column}] {jex.Message}";
            }


            catch (Exception ex)
            {
                FastResult.Text = ex.Message;

            }
        }

        private void FastCalculation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                ExecuteCode();
            }
        }

        private void FastCode_Load(object sender, EventArgs e)
        {

        }

        private void FastCode_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void FastColoredTextBox_TextChangedDelayed(object? sender, TextChangedEventArgs e)
        {
            if (sender is null) return;

            FastColoredTextBox textBox = (FastColoredTextBox)sender;

            Range range = textBox.Range;



            range.ClearStyle(criteriaStyleRainbow.ToArray());

            FastColoredTextBoxNS.StyleIndex[] styleIndexes = criteriaStyleRainbow.Select(x => (FastColoredTextBoxNS.StyleIndex)textBox.GetStyleIndexMask(new FastColoredTextBoxNS.Style[] { x })).ToArray();

            FastColoredTextBoxNS.StyleIndex styleMask = textBox.GetStyleIndexMask(textStyles.ToArray());

            char[] openingChars = new char[] { '(', '{', '[' };
            char[] closingChars = new char[] { ')', '}', ']' };

            int depth = 0; // new int[openingChars.Length];

            int index = -1;


            int fromLine = Math.Min(range.End.iLine, range.Start.iLine);
            int toLine = Math.Max(range.End.iLine, range.Start.iLine);
            int fromChar = GetFromX(range);
            int toChar = GetToX(range);
            if (fromLine < 0) return;
            //
            for (int y = fromLine; y <= toLine; y++)
            {
                int fromX = y == fromLine ? fromChar : 0;
                int toX = y == toLine ? Math.Min(toChar - 1, textBox[y].Count - 1) : textBox[y].Count - 1;
                for (int x = fromX; x <= toX; x++)
                {
                    FastColoredTextBoxNS.Char c = textBox[y][x];

                    for (int i = 0; i < openingChars.Length; i++)
                    {

                        if (c.c == openingChars[i])
                        {
                            if ((c.style & styleMask) == 0)
                            {
                                c.style = styleIndexes[depth >= 0 ? depth % styleIndexes.Length : 0];
                                depth++;
                            }
                        }
                        else if (c.c == closingChars[i])
                        {
                            if ((c.style & styleMask) == 0)
                            {
                                depth--;
                                if (depth < 0) depth = 0;
                                c.style = styleIndexes[depth >= 0 ? depth % styleIndexes.Length : 0];
                            }
                        }
                    }


                    textBox[y][x] = c;
                }
            }


        }

        private static int GetFromX(Range range)
        {
            if (range.End.iLine < range.Start.iLine) return range.End.iChar;
            if (range.End.iLine > range.Start.iLine) return range.Start.iChar;
            return Math.Min(range.End.iChar, range.Start.iChar);
        }

        private static int GetToX(Range range)
        {
            if (range.End.iLine < range.Start.iLine) return range.Start.iChar;
            if (range.End.iLine > range.Start.iLine) return range.End.iChar;
            return Math.Max(range.End.iChar, range.Start.iChar);
        }

    }
}
