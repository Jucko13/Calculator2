namespace Calculator2
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.FastCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.FastCalculation = new FastColoredTextBoxNS.FastColoredTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TableButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button45 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button42 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button47 = new System.Windows.Forms.Button();
            this.button41 = new System.Windows.Forms.Button();
            this.button49 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button48 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.button50 = new System.Windows.Forms.Button();
            this.button51 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.button33 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button44 = new System.Windows.Forms.Button();
            this.button43 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.FastResult = new FastColoredTextBoxNS.FastColoredTextBox();
            this.CustomTabControl = new Calculator2.VisualStudioTabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.customMenuStrip1 = new Calculator2.CustomMenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openScriptsFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openLibrariesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeCalculationOnSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLibrariesLoaded = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCalculationTime = new System.Windows.Forms.ToolStripMenuItem();
            this.TableButtonExtraLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FastCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FastCalculation)).BeginInit();
            this.TableButtonLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FastResult)).BeginInit();
            this.CustomTabControl.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.customMenuStrip1.SuspendLayout();
            this.TableButtonExtraLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // FastCode
            // 
            this.FastCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FastCode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.FastCode.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.FastCode.AutoScrollMinSize = new System.Drawing.Size(53, 24);
            this.FastCode.BackBrush = null;
            this.FastCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.FastCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FastCode.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.FastCode.CaretBlinking = false;
            this.FastCode.CaretColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FastCode.CharHeight = 14;
            this.FastCode.CharWidth = 8;
            this.FastCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FastCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.FastCode.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FastCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FastCode.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.FastCode.IsReplaceMode = false;
            this.FastCode.Language = FastColoredTextBoxNS.Language.JS;
            this.FastCode.LeftBracket = '(';
            this.FastCode.LeftBracket2 = '{';
            this.FastCode.LineNumberColor = System.Drawing.Color.Gray;
            this.FastCode.Location = new System.Drawing.Point(0, -1);
            this.FastCode.Margin = new System.Windows.Forms.Padding(0);
            this.FastCode.Name = "FastCode";
            this.FastCode.Paddings = new System.Windows.Forms.Padding(5);
            this.FastCode.ReservedCountOfLineNumberChars = 3;
            this.FastCode.RightBracket = ')';
            this.FastCode.RightBracket2 = '}';
            this.FastCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(38)))), ((int)(((byte)(79)))), ((int)(((byte)(120)))));
            this.FastCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("FastCode.ServiceColors")));
            this.FastCode.ServiceLinesColor = System.Drawing.SystemColors.WindowFrame;
            this.FastCode.ShowFoldingLines = true;
            this.FastCode.Size = new System.Drawing.Size(552, 374);
            this.FastCode.TabIndex = 0;
            this.FastCode.Zoom = 100;
            // 
            // FastCalculation
            // 
            this.FastCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FastCalculation.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.FastCalculation.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.FastCalculation.AutoScrollMinSize = new System.Drawing.Size(22, 34);
            this.FastCalculation.BackBrush = null;
            this.FastCalculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.FastCalculation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FastCalculation.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.FastCalculation.CaretBlinking = false;
            this.FastCalculation.CaretColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FastCalculation.CharHeight = 14;
            this.FastCalculation.CharWidth = 8;
            this.FastCalculation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FastCalculation.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.FastCalculation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FastCalculation.IsReplaceMode = false;
            this.FastCalculation.Language = FastColoredTextBoxNS.Language.JS;
            this.FastCalculation.LeftBracket = '(';
            this.FastCalculation.LeftBracket2 = '{';
            this.FastCalculation.Location = new System.Drawing.Point(4, 24);
            this.FastCalculation.Margin = new System.Windows.Forms.Padding(1);
            this.FastCalculation.Multiline = false;
            this.FastCalculation.Name = "FastCalculation";
            this.FastCalculation.Paddings = new System.Windows.Forms.Padding(10);
            this.FastCalculation.RightBracket = ')';
            this.FastCalculation.RightBracket2 = '}';
            this.FastCalculation.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.FastCalculation.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("FastCalculation.ServiceColors")));
            this.FastCalculation.ShowCaretWhenInactive = true;
            this.FastCalculation.ShowLineNumbers = false;
            this.FastCalculation.ShowScrollBars = false;
            this.FastCalculation.Size = new System.Drawing.Size(905, 38);
            this.FastCalculation.TabIndex = 1;
            this.FastCalculation.Zoom = 100;
            this.FastCalculation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FastCalculation_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button1.Location = new System.Drawing.Point(152, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TableButtonLayout
            // 
            this.TableButtonLayout.ColumnCount = 7;
            this.TableButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.TableButtonLayout.Controls.Add(this.button29, 1, 1);
            this.TableButtonLayout.Controls.Add(this.button30, 2, 1);
            this.TableButtonLayout.Controls.Add(this.button23, 0, 1);
            this.TableButtonLayout.Controls.Add(this.button15, 0, 4);
            this.TableButtonLayout.Controls.Add(this.button25, 0, 3);
            this.TableButtonLayout.Controls.Add(this.button26, 1, 3);
            this.TableButtonLayout.Controls.Add(this.button28, 2, 3);
            this.TableButtonLayout.Controls.Add(this.button27, 2, 2);
            this.TableButtonLayout.Controls.Add(this.button24, 1, 2);
            this.TableButtonLayout.Controls.Add(this.button21, 0, 2);
            this.TableButtonLayout.Controls.Add(this.button36, 0, 0);
            this.TableButtonLayout.Controls.Add(this.button37, 1, 0);
            this.TableButtonLayout.Controls.Add(this.button9, 3, 1);
            this.TableButtonLayout.Controls.Add(this.button45, 4, 1);
            this.TableButtonLayout.Controls.Add(this.button7, 3, 3);
            this.TableButtonLayout.Controls.Add(this.button4, 4, 3);
            this.TableButtonLayout.Controls.Add(this.button5, 4, 4);
            this.TableButtonLayout.Controls.Add(this.button1, 3, 4);
            this.TableButtonLayout.Controls.Add(this.button22, 1, 4);
            this.TableButtonLayout.Controls.Add(this.button6, 2, 4);
            this.TableButtonLayout.Controls.Add(this.button8, 6, 0);
            this.TableButtonLayout.Controls.Add(this.button42, 2, 0);
            this.TableButtonLayout.Controls.Add(this.button38, 3, 0);
            this.TableButtonLayout.Controls.Add(this.button39, 4, 0);
            this.TableButtonLayout.Controls.Add(this.button47, 5, 0);
            this.TableButtonLayout.Controls.Add(this.button41, 3, 2);
            this.TableButtonLayout.Controls.Add(this.button49, 4, 2);
            this.TableButtonLayout.Controls.Add(this.button3, 5, 1);
            this.TableButtonLayout.Controls.Add(this.button2, 6, 1);
            this.TableButtonLayout.Controls.Add(this.button48, 5, 2);
            this.TableButtonLayout.Controls.Add(this.button20, 6, 2);
            this.TableButtonLayout.Controls.Add(this.button40, 6, 3);
            this.TableButtonLayout.Controls.Add(this.button50, 5, 3);
            this.TableButtonLayout.Controls.Add(this.button51, 5, 4);
            this.TableButtonLayout.Location = new System.Drawing.Point(2, 136);
            this.TableButtonLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TableButtonLayout.Name = "TableButtonLayout";
            this.TableButtonLayout.RowCount = 5;
            this.TableButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TableButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TableButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TableButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TableButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TableButtonLayout.Size = new System.Drawing.Size(351, 251);
            this.TableButtonLayout.TabIndex = 3;
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button29.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button29.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.button29.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button29.Location = new System.Drawing.Point(52, 52);
            this.button29.Margin = new System.Windows.Forms.Padding(2);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(40, 34);
            this.button29.TabIndex = 30;
            this.button29.Text = "8";
            this.button29.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button30.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button30.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.button30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button30.Location = new System.Drawing.Point(102, 52);
            this.button30.Margin = new System.Windows.Forms.Padding(2);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(40, 34);
            this.button30.TabIndex = 31;
            this.button30.Text = "9";
            this.button30.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button23.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button23.Location = new System.Drawing.Point(2, 52);
            this.button23.Margin = new System.Windows.Forms.Padding(2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(40, 34);
            this.button23.TabIndex = 24;
            this.button23.Text = "7";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button15.Location = new System.Drawing.Point(2, 202);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(40, 34);
            this.button15.TabIndex = 16;
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button25.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button25.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.button25.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button25.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button25.Location = new System.Drawing.Point(2, 152);
            this.button25.Margin = new System.Windows.Forms.Padding(2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(40, 34);
            this.button25.TabIndex = 26;
            this.button25.Text = "1";
            this.button25.UseVisualStyleBackColor = false;
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button26.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button26.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button26.Location = new System.Drawing.Point(52, 152);
            this.button26.Margin = new System.Windows.Forms.Padding(2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(40, 34);
            this.button26.TabIndex = 27;
            this.button26.Text = "2";
            this.button26.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button28.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button28.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.button28.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button28.Location = new System.Drawing.Point(102, 152);
            this.button28.Margin = new System.Windows.Forms.Padding(2);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(40, 34);
            this.button28.TabIndex = 29;
            this.button28.Text = "3";
            this.button28.UseVisualStyleBackColor = false;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button27.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button27.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.button27.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button27.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button27.Location = new System.Drawing.Point(102, 102);
            this.button27.Margin = new System.Windows.Forms.Padding(2);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(40, 34);
            this.button27.TabIndex = 28;
            this.button27.Text = "6";
            this.button27.UseVisualStyleBackColor = false;
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button24.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button24.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.button24.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button24.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button24.Location = new System.Drawing.Point(52, 102);
            this.button24.Margin = new System.Windows.Forms.Padding(2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(40, 34);
            this.button24.TabIndex = 25;
            this.button24.Text = "5";
            this.button24.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button21.Location = new System.Drawing.Point(2, 102);
            this.button21.Margin = new System.Windows.Forms.Padding(2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(40, 34);
            this.button21.TabIndex = 22;
            this.button21.Text = "4";
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button36
            // 
            this.button36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button36.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button36.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.button36.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button36.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button36.Location = new System.Drawing.Point(2, 2);
            this.button36.Margin = new System.Windows.Forms.Padding(2);
            this.button36.Name = "button36";
            this.button36.Size = new System.Drawing.Size(40, 34);
            this.button36.TabIndex = 37;
            this.button36.Text = "<-";
            this.button36.UseVisualStyleBackColor = false;
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button37.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button37.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.button37.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button37.Location = new System.Drawing.Point(52, 2);
            this.button37.Margin = new System.Windows.Forms.Padding(2);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(40, 34);
            this.button37.TabIndex = 38;
            this.button37.Text = "C";
            this.button37.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button9.Location = new System.Drawing.Point(152, 52);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 34);
            this.button9.TabIndex = 10;
            this.button9.Text = "[";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button45
            // 
            this.button45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button45.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button45.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button45.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button45.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button45.Location = new System.Drawing.Point(202, 52);
            this.button45.Margin = new System.Windows.Forms.Padding(2);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(40, 34);
            this.button45.TabIndex = 46;
            this.button45.Text = "]";
            this.button45.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button7.Location = new System.Drawing.Point(152, 152);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 34);
            this.button7.TabIndex = 8;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button4.Location = new System.Drawing.Point(202, 152);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button5.Location = new System.Drawing.Point(202, 202);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "/";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button22.Location = new System.Drawing.Point(52, 202);
            this.button22.Margin = new System.Windows.Forms.Padding(2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(40, 34);
            this.button22.TabIndex = 23;
            this.button22.Text = ".";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button6.Location = new System.Drawing.Point(102, 202);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 34);
            this.button6.TabIndex = 7;
            this.button6.Text = ",";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button8.Location = new System.Drawing.Point(302, 2);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 34);
            this.button8.TabIndex = 9;
            this.button8.Text = "⎵";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button42
            // 
            this.button42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button42.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button42.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.button42.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.button42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button42.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button42.Location = new System.Drawing.Point(102, 2);
            this.button42.Margin = new System.Windows.Forms.Padding(2);
            this.button42.Name = "button42";
            this.button42.Size = new System.Drawing.Size(40, 34);
            this.button42.TabIndex = 52;
            this.button42.Text = "<<";
            this.button42.UseVisualStyleBackColor = false;
            // 
            // button38
            // 
            this.button38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button38.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button38.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.button38.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.button38.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button38.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button38.Location = new System.Drawing.Point(152, 2);
            this.button38.Margin = new System.Windows.Forms.Padding(2);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(40, 34);
            this.button38.TabIndex = 39;
            this.button38.Text = "<";
            this.button38.UseVisualStyleBackColor = false;
            // 
            // button39
            // 
            this.button39.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button39.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button39.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.button39.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.button39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button39.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button39.Location = new System.Drawing.Point(202, 2);
            this.button39.Margin = new System.Windows.Forms.Padding(2);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(40, 34);
            this.button39.TabIndex = 40;
            this.button39.Text = ">";
            this.button39.UseVisualStyleBackColor = false;
            // 
            // button47
            // 
            this.button47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button47.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button47.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.button47.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.button47.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button47.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button47.Location = new System.Drawing.Point(252, 2);
            this.button47.Margin = new System.Windows.Forms.Padding(2);
            this.button47.Name = "button47";
            this.button47.Size = new System.Drawing.Size(40, 34);
            this.button47.TabIndex = 53;
            this.button47.Text = ">>";
            this.button47.UseVisualStyleBackColor = false;
            // 
            // button41
            // 
            this.button41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button41.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button41.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button41.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button41.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button41.Location = new System.Drawing.Point(152, 102);
            this.button41.Margin = new System.Windows.Forms.Padding(2);
            this.button41.Name = "button41";
            this.button41.Size = new System.Drawing.Size(40, 34);
            this.button41.TabIndex = 51;
            this.button41.Text = "!";
            this.button41.UseVisualStyleBackColor = false;
            // 
            // button49
            // 
            this.button49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button49.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button49.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button49.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button49.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button49.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button49.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button49.Location = new System.Drawing.Point(202, 102);
            this.button49.Margin = new System.Windows.Forms.Padding(2);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(40, 34);
            this.button49.TabIndex = 55;
            this.button49.Tag = "=|";
            this.button49.Text = "=";
            this.button49.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button3.Location = new System.Drawing.Point(252, 52);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "(";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button2.Location = new System.Drawing.Point(302, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = ")";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button48
            // 
            this.button48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button48.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button48.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button48.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button48.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button48.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button48.Location = new System.Drawing.Point(252, 102);
            this.button48.Margin = new System.Windows.Forms.Padding(2);
            this.button48.Name = "button48";
            this.button48.Size = new System.Drawing.Size(40, 34);
            this.button48.TabIndex = 54;
            this.button48.Text = "\" \"";
            this.button48.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button20.Location = new System.Drawing.Point(302, 102);
            this.button20.Margin = new System.Windows.Forms.Padding(2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(45, 34);
            this.button20.TabIndex = 50;
            this.button20.Tag = "(|)";
            this.button20.Text = "( )";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button40.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.button40.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.button40.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(52)))));
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.button40.Location = new System.Drawing.Point(302, 152);
            this.button40.Margin = new System.Windows.Forms.Padding(2);
            this.button40.Name = "button40";
            this.TableButtonLayout.SetRowSpan(this.button40, 2);
            this.button40.Size = new System.Drawing.Size(45, 34);
            this.button40.TabIndex = 41;
            this.button40.Tag = "";
            this.button40.Text = "=";
            this.button40.UseVisualStyleBackColor = false;
            // 
            // button50
            // 
            this.button50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button50.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button50.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button50.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button50.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button50.Location = new System.Drawing.Point(252, 152);
            this.button50.Margin = new System.Windows.Forms.Padding(2);
            this.button50.Name = "button50";
            this.button50.Size = new System.Drawing.Size(40, 34);
            this.button50.TabIndex = 56;
            this.button50.Text = "|";
            this.button50.UseVisualStyleBackColor = false;
            // 
            // button51
            // 
            this.button51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button51.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button51.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button51.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button51.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button51.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button51.Location = new System.Drawing.Point(252, 202);
            this.button51.Margin = new System.Windows.Forms.Padding(2);
            this.button51.Name = "button51";
            this.button51.Size = new System.Drawing.Size(40, 34);
            this.button51.TabIndex = 57;
            this.button51.Tag = "&|";
            this.button51.Text = "&&";
            this.button51.UseVisualStyleBackColor = false;
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button34, 2);
            this.button34.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button34.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button34.Location = new System.Drawing.Point(212, 2);
            this.button34.Margin = new System.Windows.Forms.Padding(2);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(66, 29);
            this.button34.TabIndex = 35;
            this.button34.Tag = "Math.ceil(|)";
            this.button34.Text = "ceil";
            this.button34.UseVisualStyleBackColor = false;
            // 
            // button46
            // 
            this.button46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button46, 2);
            this.button46.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button46.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button46.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button46.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button46.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button46.Location = new System.Drawing.Point(142, 39);
            this.button46.Margin = new System.Windows.Forms.Padding(2);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(66, 29);
            this.button46.TabIndex = 47;
            this.button46.Tag = "Math.abs(|)";
            this.button46.Text = "abs";
            this.button46.UseVisualStyleBackColor = false;
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button33, 2);
            this.button33.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button33.Location = new System.Drawing.Point(212, 39);
            this.button33.Margin = new System.Windows.Forms.Padding(2);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(66, 29);
            this.button33.TabIndex = 34;
            this.button33.Tag = "Math.floor(|)";
            this.button33.Text = "floor";
            this.button33.UseVisualStyleBackColor = false;
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button35, 2);
            this.button35.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button35.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button35.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button35.Location = new System.Drawing.Point(2, 113);
            this.button35.Margin = new System.Windows.Forms.Padding(2);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(40, 33);
            this.button35.TabIndex = 36;
            this.button35.Tag = "Math.sin(|)";
            this.button35.Text = "PI";
            this.button35.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button31, 2);
            this.button31.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button31.Location = new System.Drawing.Point(282, 2);
            this.button31.Margin = new System.Windows.Forms.Padding(2);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(66, 29);
            this.button31.TabIndex = 32;
            this.button31.Tag = "Math.round(|)";
            this.button31.Text = "Round";
            this.button31.UseVisualStyleBackColor = false;
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button32, 2);
            this.button32.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button32.Location = new System.Drawing.Point(282, 39);
            this.button32.Margin = new System.Windows.Forms.Padding(2);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(66, 29);
            this.button32.TabIndex = 33;
            this.button32.Tag = " + \"|\" + ";
            this.button32.Text = "+\" \"+";
            this.button32.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button18, 2);
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button18.Location = new System.Drawing.Point(72, 113);
            this.button18.Margin = new System.Windows.Forms.Padding(2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(40, 33);
            this.button18.TabIndex = 49;
            this.button18.Tag = "Math.Log10(|)";
            this.button18.Text = "Log10";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button11, 2);
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button11.Location = new System.Drawing.Point(2, 2);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(66, 29);
            this.button11.TabIndex = 12;
            this.button11.Tag = "Math.sin(|)";
            this.button11.Text = "Sin";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button14, 2);
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(52)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.button14.Location = new System.Drawing.Point(282, 76);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(66, 30);
            this.button14.TabIndex = 48;
            this.button14.Tag = ".toString(2)|";
            this.button14.Text = "Bin";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button44
            // 
            this.button44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button44, 2);
            this.button44.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.button44.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.button44.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(52)))));
            this.button44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button44.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.button44.Location = new System.Drawing.Point(212, 76);
            this.button44.Margin = new System.Windows.Forms.Padding(2);
            this.button44.Name = "button44";
            this.button44.Size = new System.Drawing.Size(66, 30);
            this.button44.TabIndex = 45;
            this.button44.Tag = ".toString(8)|";
            this.button44.Text = "Oct";
            this.button44.UseVisualStyleBackColor = false;
            // 
            // button43
            // 
            this.button43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button43, 2);
            this.button43.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.button43.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.button43.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(52)))));
            this.button43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button43.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.button43.Location = new System.Drawing.Point(142, 76);
            this.button43.Margin = new System.Windows.Forms.Padding(2);
            this.button43.Name = "button43";
            this.button43.Size = new System.Drawing.Size(66, 30);
            this.button43.TabIndex = 44;
            this.button43.Tag = ".toString(16)|";
            this.button43.Text = "Hex";
            this.button43.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button16, 2);
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button16.Location = new System.Drawing.Point(72, 2);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(66, 29);
            this.button16.TabIndex = 17;
            this.button16.Tag = "Math.asin(|)";
            this.button16.Text = "aSin";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button13, 2);
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button13.Location = new System.Drawing.Point(142, 2);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(66, 29);
            this.button13.TabIndex = 14;
            this.button13.Tag = "Math.sin(|)";
            this.button13.Text = "Sqrt";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button12, 2);
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button12.Location = new System.Drawing.Point(2, 39);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(66, 29);
            this.button12.TabIndex = 13;
            this.button12.Tag = "Math.cos(|)";
            this.button12.Text = "Cos";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button17, 2);
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button17.Location = new System.Drawing.Point(72, 39);
            this.button17.Margin = new System.Windows.Forms.Padding(2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(66, 29);
            this.button17.TabIndex = 18;
            this.button17.Tag = "Math.acos(|)";
            this.button17.Text = "aCos";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button10, 2);
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button10.Location = new System.Drawing.Point(2, 76);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(66, 30);
            this.button10.TabIndex = 11;
            this.button10.Tag = "Math.tan(|)";
            this.button10.Text = "Tan";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonExtraLayout.SetColumnSpan(this.button19, 2);
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button19.Location = new System.Drawing.Point(72, 76);
            this.button19.Margin = new System.Windows.Forms.Padding(2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(66, 30);
            this.button19.TabIndex = 20;
            this.button19.Tag = "Math.atan(|)";
            this.button19.Text = "aTan";
            this.button19.UseVisualStyleBackColor = false;
            // 
            // FastResult
            // 
            this.FastResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FastResult.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.FastResult.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n";
            this.FastResult.AutoScrollMinSize = new System.Drawing.Size(22, 34);
            this.FastResult.BackBrush = null;
            this.FastResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.FastResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FastResult.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.FastResult.CaretBlinking = false;
            this.FastResult.CaretColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FastResult.CharHeight = 14;
            this.FastResult.CharWidth = 8;
            this.FastResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FastResult.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.FastResult.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FastResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FastResult.IsReplaceMode = false;
            this.FastResult.Language = FastColoredTextBoxNS.Language.JS;
            this.FastResult.LeftBracket = '(';
            this.FastResult.LeftBracket2 = '{';
            this.FastResult.Location = new System.Drawing.Point(4, 66);
            this.FastResult.Margin = new System.Windows.Forms.Padding(1);
            this.FastResult.Name = "FastResult";
            this.FastResult.Paddings = new System.Windows.Forms.Padding(10);
            this.FastResult.RightBracket = ')';
            this.FastResult.RightBracket2 = '}';
            this.FastResult.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.FastResult.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("FastResult.ServiceColors")));
            this.FastResult.ShowLineNumbers = false;
            this.FastResult.Size = new System.Drawing.Size(905, 67);
            this.FastResult.TabIndex = 4;
            this.FastResult.Zoom = 100;
            // 
            // CustomTabControl
            // 
            this.CustomTabControl.ActiveColor = System.Drawing.SystemColors.MenuHighlight;
            this.CustomTabControl.AllowDrop = true;
            this.CustomTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomTabControl.BackTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.CustomTabControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.CustomTabControl.ClosingButtonColor = System.Drawing.Color.WhiteSmoke;
            this.CustomTabControl.ClosingMessage = null;
            this.CustomTabControl.Controls.Add(this.TabPage1);
            this.CustomTabControl.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CustomTabControl.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.CustomTabControl.HeaderPadding = new System.Windows.Forms.Padding(-2, 0, -2, 0);
            this.CustomTabControl.HorizontalLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.CustomTabControl.ItemSize = new System.Drawing.Size(240, 20);
            this.CustomTabControl.Location = new System.Drawing.Point(352, 136);
            this.CustomTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.CustomTabControl.Name = "CustomTabControl";
            this.CustomTabControl.Padding = new System.Drawing.Point(6, 0);
            this.CustomTabControl.SelectedIndex = 0;
            this.CustomTabControl.SelectedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomTabControl.ShowClosingButton = false;
            this.CustomTabControl.ShowClosingMessage = false;
            this.CustomTabControl.Size = new System.Drawing.Size(560, 401);
            this.CustomTabControl.TabIndex = 5;
            this.CustomTabControl.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CustomTabControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.visualStudioTabControl1_MouseDoubleClick);
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TabPage1.Controls.Add(this.FastCode);
            this.TabPage1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabPage1.Location = new System.Drawing.Point(4, 24);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(552, 373);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "BigInteger.min.js";
            // 
            // customMenuStrip1
            // 
            this.customMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.ToolStripMenuItemLibrariesLoaded,
            this.helpToolStripMenuItem,
            this.ToolStripMenuItemCalculationTime});
            this.customMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.customMenuStrip1.Name = "customMenuStrip1";
            this.customMenuStrip1.Size = new System.Drawing.Size(912, 24);
            this.customMenuStrip1.TabIndex = 6;
            this.customMenuStrip1.Text = "customMenuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveScriptsToolStripMenuItem,
            this.reloadScriptsToolStripMenuItem,
            this.openScriptsFolderToolStripMenuItem,
            this.openLibrariesFolderToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveScriptsToolStripMenuItem
            // 
            this.saveScriptsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveScriptsToolStripMenuItem.Image = global::Calculator2.Properties.Resources.Save_16x;
            this.saveScriptsToolStripMenuItem.Name = "saveScriptsToolStripMenuItem";
            this.saveScriptsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveScriptsToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.saveScriptsToolStripMenuItem.Text = "Save Scripts";
            this.saveScriptsToolStripMenuItem.Click += new System.EventHandler(this.saveScriptsToolStripMenuItem_Click);
            // 
            // reloadScriptsToolStripMenuItem
            // 
            this.reloadScriptsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reloadScriptsToolStripMenuItem.Image = global::Calculator2.Properties.Resources.Refresh_16x;
            this.reloadScriptsToolStripMenuItem.Name = "reloadScriptsToolStripMenuItem";
            this.reloadScriptsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reloadScriptsToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.reloadScriptsToolStripMenuItem.Text = "Reload Scripts and Libraries";
            this.reloadScriptsToolStripMenuItem.Click += new System.EventHandler(this.reloadScriptsToolStripMenuItem_Click);
            // 
            // openScriptsFolderToolStripMenuItem
            // 
            this.openScriptsFolderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openScriptsFolderToolStripMenuItem.Image = global::Calculator2.Properties.Resources.OpenFolder_16x;
            this.openScriptsFolderToolStripMenuItem.Name = "openScriptsFolderToolStripMenuItem";
            this.openScriptsFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openScriptsFolderToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.openScriptsFolderToolStripMenuItem.Text = "Open Scripts Folder";
            this.openScriptsFolderToolStripMenuItem.Click += new System.EventHandler(this.openScriptsFolderToolStripMenuItem_Click);
            // 
            // openLibrariesFolderToolStripMenuItem
            // 
            this.openLibrariesFolderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.openLibrariesFolderToolStripMenuItem.Image = global::Calculator2.Properties.Resources.OpenFolder_16x;
            this.openLibrariesFolderToolStripMenuItem.Name = "openLibrariesFolderToolStripMenuItem";
            this.openLibrariesFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.openLibrariesFolderToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.openLibrariesFolderToolStripMenuItem.Text = "Open Libraries Folder";
            this.openLibrariesFolderToolStripMenuItem.Click += new System.EventHandler(this.openLibrariesFolderToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeCalculationOnSaveToolStripMenuItem});
            this.preferencesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // executeCalculationOnSaveToolStripMenuItem
            // 
            this.executeCalculationOnSaveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.executeCalculationOnSaveToolStripMenuItem.Name = "executeCalculationOnSaveToolStripMenuItem";
            this.executeCalculationOnSaveToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.executeCalculationOnSaveToolStripMenuItem.Text = "Execute Calculation on Save";
            this.executeCalculationOnSaveToolStripMenuItem.Click += new System.EventHandler(this.executeCalculationOnSaveToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemLibrariesLoaded
            // 
            this.ToolStripMenuItemLibrariesLoaded.ForeColor = System.Drawing.Color.White;
            this.ToolStripMenuItemLibrariesLoaded.Name = "ToolStripMenuItemLibrariesLoaded";
            this.ToolStripMenuItemLibrariesLoaded.Size = new System.Drawing.Size(105, 20);
            this.ToolStripMenuItemLibrariesLoaded.Text = "Libraries Loaded";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem1,
            this.toolStripMenuItem2});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // githubToolStripMenuItem1
            // 
            this.githubToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.githubToolStripMenuItem1.Image = global::Calculator2.Properties.Resources.github_logo2;
            this.githubToolStripMenuItem1.Name = "githubToolStripMenuItem1";
            this.githubToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.githubToolStripMenuItem1.Text = "Github";
            this.githubToolStripMenuItem1.Click += new System.EventHandler(this.githubToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Image = global::Calculator2.Properties.Resources.InformationSymbol_16x;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem2.Text = "About";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemCalculationTime
            // 
            this.ToolStripMenuItemCalculationTime.Enabled = false;
            this.ToolStripMenuItemCalculationTime.Name = "ToolStripMenuItemCalculationTime";
            this.ToolStripMenuItemCalculationTime.Size = new System.Drawing.Size(53, 20);
            this.ToolStripMenuItemCalculationTime.Text = "0.0 ms";
            // 
            // TableButtonExtraLayout
            // 
            this.TableButtonExtraLayout.ColumnCount = 10;
            this.TableButtonExtraLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.Controls.Add(this.button11, 0, 0);
            this.TableButtonExtraLayout.Controls.Add(this.button12, 0, 1);
            this.TableButtonExtraLayout.Controls.Add(this.button10, 0, 2);
            this.TableButtonExtraLayout.Controls.Add(this.button16, 1, 0);
            this.TableButtonExtraLayout.Controls.Add(this.button17, 1, 1);
            this.TableButtonExtraLayout.Controls.Add(this.button19, 1, 2);
            this.TableButtonExtraLayout.Controls.Add(this.button18, 1, 3);
            this.TableButtonExtraLayout.Controls.Add(this.button35, 0, 3);
            this.TableButtonExtraLayout.Controls.Add(this.button43, 2, 2);
            this.TableButtonExtraLayout.Controls.Add(this.button44, 3, 2);
            this.TableButtonExtraLayout.Controls.Add(this.button14, 4, 2);
            this.TableButtonExtraLayout.Controls.Add(this.button32, 4, 1);
            this.TableButtonExtraLayout.Controls.Add(this.button31, 4, 0);
            this.TableButtonExtraLayout.Controls.Add(this.button13, 2, 0);
            this.TableButtonExtraLayout.Controls.Add(this.button34, 3, 0);
            this.TableButtonExtraLayout.Controls.Add(this.button33, 3, 1);
            this.TableButtonExtraLayout.Controls.Add(this.button46, 2, 1);
            this.TableButtonExtraLayout.Location = new System.Drawing.Point(2, 388);
            this.TableButtonExtraLayout.Name = "TableButtonExtraLayout";
            this.TableButtonExtraLayout.RowCount = 10;
            this.TableButtonExtraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TableButtonExtraLayout.Size = new System.Drawing.Size(351, 370);
            this.TableButtonExtraLayout.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(912, 537);
            this.Controls.Add(this.TableButtonExtraLayout);
            this.Controls.Add(this.CustomTabControl);
            this.Controls.Add(this.FastResult);
            this.Controls.Add(this.FastCalculation);
            this.Controls.Add(this.TableButtonLayout);
            this.Controls.Add(this.customMenuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.customMenuStrip1;
            this.MinimumSize = new System.Drawing.Size(488, 571);
            this.Name = "FrmMain";
            this.Text = "Calculator 2 - Ricardo de Roode";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.FastCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FastCalculation)).EndInit();
            this.TableButtonLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FastResult)).EndInit();
            this.CustomTabControl.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.customMenuStrip1.ResumeLayout(false);
            this.customMenuStrip1.PerformLayout();
            this.TableButtonExtraLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FastColoredTextBoxNS.FastColoredTextBox FastCode;
        private FastColoredTextBoxNS.FastColoredTextBox FastCalculation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel TableButtonLayout;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button button36;
        private System.Windows.Forms.Button button37;
        private System.Windows.Forms.Button button38;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private FastColoredTextBoxNS.FastColoredTextBox FastResult;
        private System.Windows.Forms.Button button43;
        private System.Windows.Forms.Button button44;
        private System.Windows.Forms.Button button45;
        private VisualStudioTabControl CustomTabControl;
        private System.Windows.Forms.TabPage TabPage1;
        private CustomMenuStrip customMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveScriptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadScriptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openScriptsFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button41;
        private System.Windows.Forms.Button button42;
        private System.Windows.Forms.Button button47;
        private System.Windows.Forms.Button button48;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.Button button50;
        private System.Windows.Forms.Button button51;
        private System.Windows.Forms.TableLayoutPanel TableButtonExtraLayout;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCalculationTime;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLibrariesLoaded;
        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.ToolStripMenuItem openLibrariesFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeCalculationOnSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

