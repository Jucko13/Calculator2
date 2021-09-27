using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator2.AutoCompleteItems;
using Esprima;
using Esprima.Ast;
using FastColoredTextBoxNS;
using Jint;
using Jint.Native;
using Jint.Runtime;
using Range = FastColoredTextBoxNS.Range;

namespace Calculator2
{
    public partial class FrmMain : Form
    {

        private Jint.Engine engine = null;


        private string scriptFolder = "";


        public FrmMain()
        {
            InitializeComponent();

            scriptFolder = AppDomain.CurrentDomain.BaseDirectory + "\\Scripts\\";
        }

        //private TextStyle keywordStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);


        private string globalJavascriptKeywords = @"Math|RegExp";
        private string arrayKeywords = @"map|filter|indexOf|pop|push|keys|join
|reduce|reduceRight|reverse|shift|slice|some|sort|splice|toString|unshift|values|forEach|flat
|findIndex|find|every|entries|concat|copyWithin";
        private string stringKeywords = @"charAt|charCodeAt|concat|fromCharcode|indexOf|lastIndexOf|replace|search|slice|split|substr|substring|toLowerCase|toUpperCase|includes|endsWith|repeat|valueOf|trim";

        private List<TextStyle> textStyles = new List<TextStyle>()
        {
            new TextStyle(new SolidBrush(Color.FromArgb(87,166,74)), null, FontStyle.Regular),
            new TextStyle(new SolidBrush(Color.FromArgb(60, 140, 255)), null, FontStyle.Regular),
            new TextStyle(new SolidBrush(Color.FromArgb(255, 126, 0)), null, FontStyle.Regular),
            new TextStyle(new SolidBrush(Color.FromArgb(67,129,181)), null, FontStyle.Regular),
            new TextStyle(new SolidBrush(Color.FromArgb(191, 112, 0)), null, FontStyle.Regular),
            new TextStyle(new SolidBrush(Color.FromArgb(170, 98, 255)), null, FontStyle.Regular),
            new TextStyle(new SolidBrush(Color.FromArgb(0, 200, 242)), null, FontStyle.Regular),
            new TextStyle(new SolidBrush(Color.FromArgb(220,220,170)), null, FontStyle.Regular),
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
            Color.FromArgb(65,105,225  ),
            Color.FromArgb(0,206,209   ),
            Color.FromArgb(0,128,0     ),
            Color.FromArgb(220,20,60   ),
            Color.FromArgb(105,105,105 ),
        }).Select(x => new TextStyle(new SolidBrush(x), null, FontStyle.Bold)).ToList();


        private MarkerStyle bracketMarkerStyle = new MarkerStyle(new SolidBrush(Color.FromArgb(50, 255, 255, 255)));

        private List<string> customFunctionNames = new List<string>();


        private void FrmMain_Load(object sender, EventArgs e)
        {
            engine = new Jint.Engine();

            foreach (Button button in TableButtonLayout.Controls.OfType<Button>())
            {
                button.Dock = DockStyle.Fill;
                button.Click += TableButton_Click;
                button.Font = new Font("Cascadia Mono Light", 10.0f, FontStyle.Regular);
                button.Padding = Padding.Empty;
                button.Margin = new Padding(2);
            }

            InitializeAutoComplete();

            InitializeTextBox(FastCode, true);
            InitializeTextBox(FastResult, false);
            InitializeTextBox(FastCalculation, false);

            //FastCalculation.Text = @"[1,2,3].join("" | "")";
            FastCalculation.Text = @"bla2()";

            FilePage filePage = new FilePage()
            {
                Page = TabPage1,
                Name = "ScriptCode",
                Contents = "",
                TextBox = FastCode,
            };

            fileContents.Add(filePage);

            FastCode.TextChangedDelayed += (_, __) =>
            {
                filePage.CodeLineLength = filePage.TextBox.LinesCount;
            };


            FastCalculation.MouseWheel += FastCalculation_MouseWheel;

            operatorRegex = new Regex(@"[\*\+\/\=\-\,]", RegexOptions.Compiled);

            LoadFiles();
        }

        private void FastCalculation_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                FastCalculation.SelectionStart--;
                FastCalculation.SelectionLength = 0;
            }
            else
            {
                FastCalculation.SelectionStart++;
                FastCalculation.SelectionLength = 0;
            }
        }

        private Regex JScriptKeywordRegex = null;
        private Regex operatorRegex = null;


        private void InitializeTextBox(FastColoredTextBox textBox, bool multiline = false)
        {
            if (multiline)
            {
                textBox.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right);
                textBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
                textBox.AutoScrollMinSize = new Size(53, 24);
                textBox.BackBrush = null;
                textBox.BackColor = Color.FromArgb(46, 49, 54);
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;
                textBox.CaretBlinking = false;
                textBox.CaretColor = Color.FromArgb(224, 224, 224);
                textBox.CharHeight = 14;
                textBox.CharWidth = 8;
                textBox.IndentBackColor = Color.FromArgb(30, 33, 36);
                textBox.Location = new Point(0, -1);
                textBox.Paddings = new Padding(5);

            }

            textBox.ShowFoldingLines = multiline;
            textBox.LeftBracket = '(';
            textBox.LeftBracket2 = '{';
            textBox.LineNumberColor = Color.Gray;
            textBox.Margin = new Padding(0);
            textBox.ReservedCountOfLineNumberChars = 3;
            textBox.RightBracket = ')';
            textBox.RightBracket2 = '}';
            textBox.SelectionColor = Color.FromArgb(60, 0, 0, 255);
            textBox.ServiceLinesColor = SystemColors.WindowFrame;
            textBox.TabIndex = 0;
            textBox.Zoom = 100;

            textBox.Font = new Font("Cascadia Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.ForeColor = Color.FromArgb(224, 224, 224);
            textBox.AutoCompleteBracketsList = new char[] { '(', ')', '{', '}', '[', ']', '\"', '\"', '\'', '\'' };
            textBox.IsReplaceMode = false;
            textBox.Language = Language.JS;


            criteriaStyleRainbow.ForEach(x => textBox.AddStyle(x));
            textStyles.ForEach(x => textBox.AddStyle(x));

            textBox.AddStyle(criteriaStyleWavyLine);

            textBox.SyntaxHighlighter.KeywordStyle = textStyles[3]; //done
            textBox.SyntaxHighlighter.StringStyle = textStyles[2]; //done
            textBox.SyntaxHighlighter.VariableStyle = textStyles[6]; //done, not sure
            textBox.SyntaxHighlighter.TypesStyle = textStyles[3]; //done
            textBox.SyntaxHighlighter.FunctionsStyle = textStyles[3]; //done
            textBox.SyntaxHighlighter.ClassNameStyle = textStyles[4]; //done
            textBox.SyntaxHighlighter.CommentStyle = textStyles[0]; //done
            textBox.SyntaxHighlighter.NumberStyle = textStyles[9];

            textBox.BracketsStyle = bracketMarkerStyle;
            textBox.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;
            textBox.TextChangedDelayed += FastColoredTextBox_TextChangedDelayed;

            textBox.ServiceColors.ExpandMarkerBackColor = Color.FromArgb(30, 33, 36);
            textBox.ServiceColors.CollapseMarkerBackColor = Color.FromArgb(30, 33, 36);

            AutocompleteMenu autocompleteMenu = new AutocompleteMenu(textBox)
            {
                MinFragmentLength = 1,
                AllowTabKey = true,
                AppearInterval = 1,
                SearchPattern = @"([\w\.\[\], ])",
                MinimumSize = new Size(200, 200),
                AlwaysShowTooltip = true,
                ToolTipDuration = 1000000,
            };

            autocompleteMenu.Items.SetAutocompleteItems(autocompleteItems);
        }


        private class FilePage
        {
            public string Contents { get; set; }
            public string Name { get; set; }
            public TabPage Page { get; set; }

            public FastColoredTextBox TextBox { get; set; }

            public int CodeLineLength { get; set; }
        }

        private List<FilePage> fileContents = new List<FilePage>();


        private void LoadFiles()
        {


            if (!Directory.Exists(scriptFolder))
            {
                Directory.CreateDirectory(scriptFolder);
            }

            string[] files = Directory.GetFiles(scriptFolder, "*.js");

            for (int i = fileContents.Count - 1; i > 0; i--)
            {
                CustomTabControl.TabPages.Remove(fileContents[i].Page);
                fileContents[i].Page.Controls.Remove(fileContents[i].TextBox);
                fileContents[i].TextBox.Dispose();
                fileContents[i].Page.Dispose();
                fileContents.RemoveAt(i);
            }

            int itemCount = fileContents.Count - 1;
            int index = 0;

            foreach (var file in files)
            {
                if (index > itemCount)
                {
                    TabPage page = new TabPage();
                    FastColoredTextBox fastColoredTextBox = new FastColoredTextBox();
                    FilePage filePage = new FilePage()
                    {
                        Page = page,
                        Name = Path.GetFileName(file),
                        Contents = File.ReadAllText(file),
                        TextBox = fastColoredTextBox,
                    };

                    page.Text = filePage.Name;

                    InitializeTextBox(fastColoredTextBox, true);

                    fileContents.Add(filePage);

                    page.Controls.Add(fastColoredTextBox);
                    fastColoredTextBox.Bounds = new Rectangle(0, -1, page.Width, page.Height + 1);
                    fastColoredTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left;

                    CustomTabControl.TabPages.Add(page);

                    fastColoredTextBox.TextChangedDelayed += (_, __) =>
                    {
                        filePage.CodeLineLength = filePage.TextBox.LinesCount;
                    };
                }
                else
                {
                    fileContents[index].Name = Path.GetFileName(file);
                    fileContents[index].Contents = File.ReadAllText(file);
                    fileContents[index].Page.Text = fileContents[index].Name;
                }

                fileContents[index].TextBox.Text = fileContents[index].Contents;

                index++;
            }


            CalculateFunctionNames();

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


            int selectStart;
            int selectLength;
            string selectedText;

            Button button = (Button)sender;

            if (button.Tag != null && button.Tag is string s && s.Length > 0)
            {
                string[] tagParts = s.Split('|');
                if (tagParts.Length != 2)
                {
                    MessageBox.Show("Button Tag should have a single '|' character!");

                    FastCalculation.Focus();
                    return;
                }
                selectStart = FastCalculation.SelectionStart;
                selectedText = FastCalculation.SelectedText;
                FastCalculation.SelectedText = tagParts[0] + FastCalculation.SelectedText + tagParts[1];

                FastCalculation.SelectionStart = selectStart + tagParts[0].Length + selectedText.Length;
                FastCalculation.SelectionLength = 0;
                FastCalculation.Refresh();

                FastCalculation.Focus();

                return;
            }

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
                case ".":
                case ",":
                case "+":
                case "-":
                case "*":
                case "/":
                case " + \"\" + ":
                case "(":
                case ")":
                case "[":
                case "]":
                case "!":
                case "&":
                case "|":
                    FastCalculation.InsertText(button.Text);
                    break;

                case "⎵":
                    FastCalculation.InsertText(" ");
                    break;

                case "=":
                    ExecuteCode();
                    break;

                case "( )":
                case "[ ]":
                case "\" \"":
                    selectStart = FastCalculation.SelectionStart;
                    selectLength = FastCalculation.SelectionLength;
                    selectedText = FastCalculation.SelectedText;
                    FastCalculation.SelectedText = button.Text.First() + selectedText + button.Text.Last();
                    if (selectLength > 0)
                    {
                        FastCalculation.SelectionStart = selectStart;
                        FastCalculation.SelectionLength = selectLength + 2;
                    }
                    else
                    {
                        FastCalculation.SelectionStart = selectStart + 2 + selectedText.Length;
                        FastCalculation.SelectionLength = 0;
                    }
                    FastCalculation.Refresh();
                    break;

                case "<-":
                    FastCalculation.InsertText("\b");
                    //FastCalculation.HotkeysMapping.Add(Keys.Back, FCTBAction.);
                    FastCalculation.Refresh();
                    break;

                case "Clear":
                    FastCalculation.Text = "";
                    break;

                case "<":
                    FastCalculation.SelectionStart--;
                    FastCalculation.Refresh();
                    break;

                case ">":
                    FastCalculation.SelectionStart++;
                    FastCalculation.Refresh();
                    break;

                case "<<":
                    FastCalculation.SelectionStart = 0;
                    FastCalculation.Refresh();
                    break;

                case ">>":
                    FastCalculation.SelectionStart = FastCalculation.Lines[0].Length;
                    FastCalculation.Refresh();
                    break;

            }


            FastCalculation.Focus();

        }


        private void CalculateFunctionNames()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (FilePage filePage in fileContents)
            {
                filePage.CodeLineLength = filePage.TextBox.LinesCount;
                stringBuilder.AppendLine(filePage.TextBox.Text);
                filePage.TextBox.Range.ClearStyle(criteriaStyleWavyLine);
            }

            var parser = new JavaScriptParser($"{stringBuilder} return JSON.stringify({FastCalculation.Text});");

            try
            {
                var script = parser.ParseScript();

                var newCustomFunctionNames = script.ChildNodes.OfType<FunctionDeclaration>().Select(x => x.Id?.Name).Where(x => x != null).OrderBy(x => x).ToList();

                //keep track of the array objects and add some functionality to the autocomplete menu
                string arrayObjects = string.Join('|', script.ChildNodes.OfType<VariableDeclaration>().Where(x => (((VariableDeclarator)x.ChildNodes[0]).Init?.Type ?? Nodes.WhileStatement) == Nodes.ArrayExpression).Select(x => ((Identifier)((VariableDeclarator)x.ChildNodes[0]).Id).Name ?? "").ToArray());
                autocompleteArrayObjects.ForEach(x => x.SetObjectText(arrayObjects));


                //we have a new function or something got renamed, now we need to refresh the regex for the user functions and refresh the textboxes
                if (!Enumerable.SequenceEqual(newCustomFunctionNames, customFunctionNames))
                {
                    JScriptKeywordRegex = new Regex(@"\b(" + stringKeywords + "|" + globalJavascriptKeywords + "|" + arrayKeywords + (newCustomFunctionNames.Count == 0 ? "" : "|" + string.Join('|', newCustomFunctionNames)) + @")\b", RegexOptions.Compiled);
                    foreach (var filePage in fileContents)
                    {
                        filePage.TextBox.OnTextChanged();
                    }
                    FastResult.OnTextChanged();
                    FastCalculation.OnTextChanged();
                }

            }
            catch (Exception ex)
            {
                return;
            }

        }


        private void ExecuteCode()
        {

            Stopwatch stopwatch = Stopwatch.StartNew();

            int lineStart = 0;
            int lineEnd = 0;
            int columnStart = 0;
            int columnEnd = 0;
            string errorMessage = "";

            try
            {
                StringBuilder stringBuilder = new StringBuilder();

                foreach (FilePage filePage in fileContents)
                {
                    filePage.CodeLineLength = filePage.TextBox.LinesCount;
                    stringBuilder.AppendLine(filePage.TextBox.Text);
                    filePage.TextBox.Range.ClearStyle(criteriaStyleWavyLine);
                }

                JsValue result = engine.Evaluate($"{stringBuilder} return JSON.stringify({FastCalculation.Text});");

                //JsValue result = engine.Evaluate(script);

                if (result is null)
                {
                    //FastResult.Text = $"[{engine.Site.LastException.Line}, {engine.Site.LastException.Column}]" + engine.Site.LastException.Description;
                }
                else
                {
                    FastResult.Text = result.ToString() + stopwatch.Elapsed.TotalMilliseconds.ToString(" | 0.## ms");

                }

                return;

            }
            catch (JavaScriptException jex)
            {
                lineStart = jex.Location.Start.Line;
                lineEnd = jex.Location.End.Line;
                columnStart = jex.Location.Start.Column;
                columnEnd = jex.Location.End.Column;
                errorMessage = jex.Message;
            }
            catch (ParserException pex)
            {
                lineStart = pex.LineNumber;
                lineEnd = pex.LineNumber;
                columnStart = pex.Column;
                columnEnd = pex.Column + 1;
                errorMessage = pex.Description ?? "";
            }
            catch (Exception ex)
            {
                FastResult.Text = $"[Error] {ex.Message}";
                return;
            }


            int lineOffset = 0;

            for (int i = 0; i < fileContents.Count; i++)
            {
                if (lineStart - lineOffset < fileContents[i].CodeLineLength)
                {
                    new Range(fileContents[i].TextBox, columnStart, lineStart - lineOffset - 1, columnEnd, lineEnd - lineOffset - 1).SetStyle(criteriaStyleWavyLine);
                    FastResult.Text = $"[Error at {fileContents[i].Name}:{lineStart - lineOffset}, {columnStart}] {errorMessage}";

                    return;
                }

                lineOffset += fileContents[i].CodeLineLength;
            }

            new Range(FastCalculation, columnStart, lineStart - lineOffset - 1, columnEnd, lineEnd - lineOffset - 1).SetStyle(criteriaStyleWavyLine);
            FastResult.Text = $"[Error at {lineStart - lineOffset}, {columnStart}] {errorMessage}";
        }

        private void FastCalculation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                ExecuteCode();
            }
        }


        private void FastColoredTextBox_TextChangedDelayed(object? sender, TextChangedEventArgs e)
        {
            if (sender is null) return;

            FastColoredTextBox textBox = (FastColoredTextBox)sender;

            Range range = textBox.Range;

            if (JScriptKeywordRegex != null) range.SetStyle(textStyles[7], JScriptKeywordRegex);


            range.SetStyle(textStyles[9], operatorRegex);
            range.ClearStyle(criteriaStyleRainbow.ToArray());



            StyleIndex[] styleIndexes = criteriaStyleRainbow.Select(x => textBox.GetStyleIndexMask(new Style[] { x })).ToArray();

            StyleIndex styleMask = textBox.GetStyleIndexMask(textStyles.ToArray());

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

        private void visualStudioTabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void FastCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                e.Handled = true;

                SaveFiles();
            }
        }

        private void SaveFiles()
        {
            foreach (FilePage filePage in fileContents)
            {
                filePage.Contents = filePage.TextBox.Text;

                try
                {
                    File.WriteAllText(scriptFolder + filePage.Name, filePage.Contents);
                }
                catch (Exception ex)
                {
                    PrintResult($"Could not save {filePage.Name}", ex);
                }
            }

            CalculateFunctionNames();
        }


        private void PrintResult(string text, Exception ex)
        {
            if (ex == null)
            {
                FastResult.Text = text;
            }
            else
            {
                FastResult.Text = $"Error: {ex.Message}: {text}";
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"This calculator is made by Ricardo de Roode.

This code may be used for your own projects, but you may not sell the program, or parts of it, without permission of the owner of this software. 

When using it for your own projects, make sure to give proper credit where needed.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "https://github.com/Jucko13/Calculator2",
                UseShellExecute = true
            };
            Process.Start(psi);

        }


        private List<AutocompleteItem> autocompleteItems = null;
        private List<ObjectPropertyAutoComplete> autocompleteArrayObjects = null;
        private void InitializeAutoComplete()
        {

            autocompleteItems = new List<AutocompleteItem>
            {
                new AutocompleteItemTrim("JSON.Stringify()")
                {
                    ToolTipText = "Converts any object to a readable string",
                    ToolTipTitle = "JSON.Stringify(value: object) : " + typeof(string).Name
                }
            };

            new List<string> { "PI", "E", "LN2", "LN10", "LOG2E", "LOG10E", "SQRT1_2", "SQRT2", "abs()", "acos()", "acosh()", "asinh()", "atan()", "atanh()", "atan2()",
                "cbrt()", "ceil()", "clz32()", "cos()", "cosh()", "exp()", "expm1()", "floor()", "fround()", "hypot()", "imul()", "log()", "log1p()", "log10()",
                "log2()", "max()", "min()", "pow()", "random()", "round()", "sign()", "sin()", "sinh()", "sqrt()", "tan()", "tanh()", "trunc()"}
            .ForEach(x => autocompleteItems.Add(new ObjectPropertyAutoComplete(x, "Math"))); //x.Replace("()", "")


            autocompleteArrayObjects = new List<ObjectPropertyAutoComplete>();

            autocompleteArrayObjects.AddRange(arrayKeywords.Split('|').Select(y => new ObjectPropertyAutoComplete(y, @"\/")));

            //autocompleteArrayObjects.AddRange(arrayKeywords.Split('|').SelectMany(x =>
            //{
            //    return ;
            //}));

            autocompleteItems.AddRange(autocompleteArrayObjects);

            autocompleteItems = autocompleteItems.OrderBy(x => x.ToolTipTitle).ToList();
        }

        private void saveScriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFiles();
        }

        private void reloadScriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFiles();
        }

        private void FrmMain_Resize(object sender, EventArgs e)
        {
            CustomTabControl.Visible = CustomTabControl.Width > 20;
        }
    }
}
