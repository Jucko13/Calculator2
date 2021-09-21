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
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button36 = new System.Windows.Forms.Button();
            this.button37 = new System.Windows.Forms.Button();
            this.button38 = new System.Windows.Forms.Button();
            this.button39 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.FastResult = new FastColoredTextBoxNS.FastColoredTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FastCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FastCalculation)).BeginInit();
            this.TableButtonLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FastResult)).BeginInit();
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
            this.FastCode.AutoScrollMinSize = new System.Drawing.Size(37, 24);
            this.FastCode.BackBrush = null;
            this.FastCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.FastCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FastCode.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.FastCode.CharHeight = 14;
            this.FastCode.CharWidth = 8;
            this.FastCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FastCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.FastCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FastCode.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.FastCode.IsReplaceMode = false;
            this.FastCode.Language = FastColoredTextBoxNS.Language.JS;
            this.FastCode.LeftBracket = '(';
            this.FastCode.LeftBracket2 = '{';
            this.FastCode.LineNumberColor = System.Drawing.Color.Gray;
            this.FastCode.Location = new System.Drawing.Point(426, 119);
            this.FastCode.Margin = new System.Windows.Forms.Padding(0);
            this.FastCode.Name = "FastCode";
            this.FastCode.Paddings = new System.Windows.Forms.Padding(5);
            this.FastCode.RightBracket = ')';
            this.FastCode.RightBracket2 = '}';
            this.FastCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.FastCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("FastCode.ServiceColors")));
            this.FastCode.Size = new System.Drawing.Size(370, 327);
            this.FastCode.TabIndex = 0;
            this.FastCode.Zoom = 100;
            this.FastCode.Load += new System.EventHandler(this.FastCode_Load);
            this.FastCode.VisibleChanged += new System.EventHandler(this.FastCode_VisibleChanged);
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
            this.FastCalculation.AutoScrollMinSize = new System.Drawing.Size(294, 34);
            this.FastCalculation.BackBrush = null;
            this.FastCalculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.FastCalculation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FastCalculation.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.FastCalculation.CharHeight = 14;
            this.FastCalculation.CharWidth = 8;
            this.FastCalculation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FastCalculation.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.FastCalculation.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FastCalculation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FastCalculation.IsReplaceMode = false;
            this.FastCalculation.Language = FastColoredTextBoxNS.Language.JS;
            this.FastCalculation.LeftBracket = '(';
            this.FastCalculation.LeftBracket2 = '{';
            this.FastCalculation.Location = new System.Drawing.Point(4, 4);
            this.FastCalculation.Margin = new System.Windows.Forms.Padding(1);
            this.FastCalculation.Multiline = false;
            this.FastCalculation.Name = "FastCalculation";
            this.FastCalculation.Paddings = new System.Windows.Forms.Padding(10);
            this.FastCalculation.RightBracket = ')';
            this.FastCalculation.RightBracket2 = '}';
            this.FastCalculation.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.FastCalculation.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("FastCalculation.ServiceColors")));
            this.FastCalculation.ShowLineNumbers = false;
            this.FastCalculation.ShowScrollBars = false;
            this.FastCalculation.Size = new System.Drawing.Size(792, 38);
            this.FastCalculation.TabIndex = 1;
            this.FastCalculation.Text = "JSON.stringify([1,2,3].join(\"|\"));";
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
            this.button1.Location = new System.Drawing.Point(182, 125);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TableButtonLayout
            // 
            this.TableButtonLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.TableButtonLayout.Controls.Add(this.button33, 4, 0);
            this.TableButtonLayout.Controls.Add(this.button34, 5, 0);
            this.TableButtonLayout.Controls.Add(this.button35, 6, 0);
            this.TableButtonLayout.Controls.Add(this.button23, 0, 1);
            this.TableButtonLayout.Controls.Add(this.button9, 3, 0);
            this.TableButtonLayout.Controls.Add(this.button7, 3, 1);
            this.TableButtonLayout.Controls.Add(this.button5, 3, 2);
            this.TableButtonLayout.Controls.Add(this.button1, 3, 3);
            this.TableButtonLayout.Controls.Add(this.button4, 3, 4);
            this.TableButtonLayout.Controls.Add(this.button8, 4, 1);
            this.TableButtonLayout.Controls.Add(this.button6, 4, 2);
            this.TableButtonLayout.Controls.Add(this.button2, 4, 3);
            this.TableButtonLayout.Controls.Add(this.button3, 4, 4);
            this.TableButtonLayout.Controls.Add(this.button10, 0, 5);
            this.TableButtonLayout.Controls.Add(this.button11, 1, 5);
            this.TableButtonLayout.Controls.Add(this.button12, 2, 5);
            this.TableButtonLayout.Controls.Add(this.button13, 3, 5);
            this.TableButtonLayout.Controls.Add(this.button14, 4, 5);
            this.TableButtonLayout.Controls.Add(this.button20, 4, 6);
            this.TableButtonLayout.Controls.Add(this.button18, 3, 6);
            this.TableButtonLayout.Controls.Add(this.button17, 2, 6);
            this.TableButtonLayout.Controls.Add(this.button16, 1, 6);
            this.TableButtonLayout.Controls.Add(this.button19, 0, 6);
            this.TableButtonLayout.Controls.Add(this.button22, 2, 4);
            this.TableButtonLayout.Controls.Add(this.button15, 0, 4);
            this.TableButtonLayout.Controls.Add(this.button25, 0, 3);
            this.TableButtonLayout.Controls.Add(this.button26, 1, 3);
            this.TableButtonLayout.Controls.Add(this.button28, 2, 3);
            this.TableButtonLayout.Controls.Add(this.button27, 2, 2);
            this.TableButtonLayout.Controls.Add(this.button24, 1, 2);
            this.TableButtonLayout.Controls.Add(this.button21, 0, 2);
            this.TableButtonLayout.Controls.Add(this.button36, 0, 0);
            this.TableButtonLayout.Controls.Add(this.button37, 1, 0);
            this.TableButtonLayout.Controls.Add(this.button38, 5, 5);
            this.TableButtonLayout.Controls.Add(this.button39, 6, 5);
            this.TableButtonLayout.Controls.Add(this.button31, 5, 1);
            this.TableButtonLayout.Controls.Add(this.button32, 5, 2);
            this.TableButtonLayout.Controls.Add(this.button40, 5, 3);
            this.TableButtonLayout.Location = new System.Drawing.Point(2, 115);
            this.TableButtonLayout.Margin = new System.Windows.Forms.Padding(0);
            this.TableButtonLayout.Name = "TableButtonLayout";
            this.TableButtonLayout.RowCount = 8;
            this.TableButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableButtonLayout.Size = new System.Drawing.Size(422, 333);
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
            this.button29.Location = new System.Drawing.Point(62, 43);
            this.button29.Margin = new System.Windows.Forms.Padding(2);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(56, 34);
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
            this.button30.Location = new System.Drawing.Point(122, 43);
            this.button30.Margin = new System.Windows.Forms.Padding(2);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(56, 34);
            this.button30.TabIndex = 31;
            this.button30.Text = "9";
            this.button30.UseVisualStyleBackColor = false;
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button33.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button33.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button33.Location = new System.Drawing.Point(242, 2);
            this.button33.Margin = new System.Windows.Forms.Padding(2);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(56, 34);
            this.button33.TabIndex = 34;
            this.button33.Text = "fix";
            this.button33.UseVisualStyleBackColor = false;
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button34.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button34.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button34.Location = new System.Drawing.Point(302, 2);
            this.button34.Margin = new System.Windows.Forms.Padding(2);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(56, 34);
            this.button34.TabIndex = 35;
            this.button34.Text = "Ceil";
            this.button34.UseVisualStyleBackColor = false;
            // 
            // button35
            // 
            this.button35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button35.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button35.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button35.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button35.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button35.Location = new System.Drawing.Point(362, 2);
            this.button35.Margin = new System.Windows.Forms.Padding(2);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(56, 34);
            this.button35.TabIndex = 36;
            this.button35.Text = "PI";
            this.button35.UseVisualStyleBackColor = false;
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
            this.button23.Location = new System.Drawing.Point(2, 43);
            this.button23.Margin = new System.Windows.Forms.Padding(2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(56, 34);
            this.button23.TabIndex = 24;
            this.button23.Text = "7";
            this.button23.UseVisualStyleBackColor = false;
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
            this.button9.Location = new System.Drawing.Point(182, 2);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 34);
            this.button9.TabIndex = 10;
            this.button9.Text = "^";
            this.button9.UseVisualStyleBackColor = false;
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
            this.button7.Location = new System.Drawing.Point(182, 43);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(56, 34);
            this.button7.TabIndex = 8;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = false;
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
            this.button5.Location = new System.Drawing.Point(182, 84);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 34);
            this.button5.TabIndex = 6;
            this.button5.Text = "/";
            this.button5.UseVisualStyleBackColor = false;
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
            this.button4.Location = new System.Drawing.Point(182, 166);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(50)))), ((int)(((byte)(105)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(67)))), ((int)(((byte)(182)))));
            this.button8.Location = new System.Drawing.Point(242, 43);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(56, 34);
            this.button8.TabIndex = 9;
            this.button8.Text = "_";
            this.button8.UseVisualStyleBackColor = false;
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
            this.button6.Location = new System.Drawing.Point(242, 84);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 34);
            this.button6.TabIndex = 7;
            this.button6.Text = ",";
            this.button6.UseVisualStyleBackColor = false;
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
            this.button2.Location = new System.Drawing.Point(242, 125);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = ")";
            this.button2.UseVisualStyleBackColor = false;
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
            this.button3.Location = new System.Drawing.Point(242, 166);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "(";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button10.Location = new System.Drawing.Point(2, 207);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 34);
            this.button10.TabIndex = 11;
            this.button10.Text = "Tan";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button11.Location = new System.Drawing.Point(62, 207);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 34);
            this.button11.TabIndex = 12;
            this.button11.Text = "Sin";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button12.Location = new System.Drawing.Point(122, 207);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(56, 34);
            this.button12.TabIndex = 13;
            this.button12.Text = "Cos";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button13.Location = new System.Drawing.Point(182, 207);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(56, 34);
            this.button13.TabIndex = 14;
            this.button13.Text = "Sqrt";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button14.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button14.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button14.Location = new System.Drawing.Point(242, 207);
            this.button14.Margin = new System.Windows.Forms.Padding(2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(56, 34);
            this.button14.TabIndex = 15;
            this.button14.Text = "PI";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonLayout.SetColumnSpan(this.button20, 2);
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button20.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button20.Location = new System.Drawing.Point(242, 248);
            this.button20.Margin = new System.Windows.Forms.Padding(2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(61, 34);
            this.button20.TabIndex = 21;
            this.button20.Text = "Rad";
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button18.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button18.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button18.Location = new System.Drawing.Point(182, 248);
            this.button18.Margin = new System.Windows.Forms.Padding(2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(56, 34);
            this.button18.TabIndex = 19;
            this.button18.Text = "Deg";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button17.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button17.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button17.Location = new System.Drawing.Point(122, 248);
            this.button17.Margin = new System.Windows.Forms.Padding(2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(56, 34);
            this.button17.TabIndex = 18;
            this.button17.Text = "aCs";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button16.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button16.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button16.Location = new System.Drawing.Point(62, 248);
            this.button16.Margin = new System.Windows.Forms.Padding(2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(56, 34);
            this.button16.TabIndex = 17;
            this.button16.Text = "aSn";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.button19.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button19.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button19.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button19.Location = new System.Drawing.Point(2, 248);
            this.button19.Margin = new System.Windows.Forms.Padding(2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(56, 34);
            this.button19.TabIndex = 20;
            this.button19.Text = "aTn";
            this.button19.UseVisualStyleBackColor = false;
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
            this.button22.Location = new System.Drawing.Point(122, 166);
            this.button22.Margin = new System.Windows.Forms.Padding(2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(56, 34);
            this.button22.TabIndex = 23;
            this.button22.Text = ".";
            this.button22.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonLayout.SetColumnSpan(this.button15, 2);
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.button15.Location = new System.Drawing.Point(2, 166);
            this.button15.Margin = new System.Windows.Forms.Padding(2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(61, 34);
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
            this.button25.Location = new System.Drawing.Point(2, 125);
            this.button25.Margin = new System.Windows.Forms.Padding(2);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(56, 34);
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
            this.button26.Location = new System.Drawing.Point(62, 125);
            this.button26.Margin = new System.Windows.Forms.Padding(2);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(56, 34);
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
            this.button28.Location = new System.Drawing.Point(122, 125);
            this.button28.Margin = new System.Windows.Forms.Padding(2);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(56, 34);
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
            this.button27.Location = new System.Drawing.Point(122, 84);
            this.button27.Margin = new System.Windows.Forms.Padding(2);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(56, 34);
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
            this.button24.Location = new System.Drawing.Point(62, 84);
            this.button24.Margin = new System.Windows.Forms.Padding(2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(56, 34);
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
            this.button21.Location = new System.Drawing.Point(2, 84);
            this.button21.Margin = new System.Windows.Forms.Padding(2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(56, 34);
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
            this.button36.Size = new System.Drawing.Size(56, 34);
            this.button36.TabIndex = 37;
            this.button36.Text = "<-";
            this.button36.UseVisualStyleBackColor = false;
            // 
            // button37
            // 
            this.button37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonLayout.SetColumnSpan(this.button37, 2);
            this.button37.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button37.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(39)))));
            this.button37.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.button37.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button37.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button37.Location = new System.Drawing.Point(62, 2);
            this.button37.Margin = new System.Windows.Forms.Padding(2);
            this.button37.Name = "button37";
            this.button37.Size = new System.Drawing.Size(56, 34);
            this.button37.TabIndex = 38;
            this.button37.Text = "Clear";
            this.button37.UseVisualStyleBackColor = false;
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
            this.button38.Location = new System.Drawing.Point(302, 207);
            this.button38.Margin = new System.Windows.Forms.Padding(2);
            this.button38.Name = "button38";
            this.button38.Size = new System.Drawing.Size(56, 34);
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
            this.button39.Location = new System.Drawing.Point(362, 207);
            this.button39.Margin = new System.Windows.Forms.Padding(2);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(56, 34);
            this.button39.TabIndex = 40;
            this.button39.Text = ">";
            this.button39.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonLayout.SetColumnSpan(this.button31, 2);
            this.button31.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button31.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button31.Location = new System.Drawing.Point(302, 43);
            this.button31.Margin = new System.Windows.Forms.Padding(2);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(56, 34);
            this.button31.TabIndex = 32;
            this.button31.Text = "Round";
            this.button31.UseVisualStyleBackColor = false;
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonLayout.SetColumnSpan(this.button32, 2);
            this.button32.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button32.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(68)))), ((int)(((byte)(37)))));
            this.button32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(44)))), ((int)(((byte)(24)))));
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(166)))), ((int)(((byte)(26)))));
            this.button32.Location = new System.Drawing.Point(302, 84);
            this.button32.Margin = new System.Windows.Forms.Padding(2);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(56, 34);
            this.button32.TabIndex = 33;
            this.button32.Text = " + \" \" + ";
            this.button32.UseVisualStyleBackColor = false;
            // 
            // button40
            // 
            this.button40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.TableButtonLayout.SetColumnSpan(this.button40, 2);
            this.button40.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.button40.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(108)))), ((int)(((byte)(80)))));
            this.button40.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(70)))), ((int)(((byte)(52)))));
            this.button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button40.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(181)))), ((int)(((byte)(129)))));
            this.button40.Location = new System.Drawing.Point(302, 125);
            this.button40.Margin = new System.Windows.Forms.Padding(2);
            this.button40.Name = "button40";
            this.TableButtonLayout.SetRowSpan(this.button40, 2);
            this.button40.Size = new System.Drawing.Size(56, 34);
            this.button40.TabIndex = 41;
            this.button40.Text = "=";
            this.button40.UseVisualStyleBackColor = false;
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
            this.FastResult.CharHeight = 14;
            this.FastResult.CharWidth = 8;
            this.FastResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FastResult.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.FastResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FastResult.IsReplaceMode = false;
            this.FastResult.Language = FastColoredTextBoxNS.Language.JS;
            this.FastResult.LeftBracket = '(';
            this.FastResult.LeftBracket2 = '{';
            this.FastResult.Location = new System.Drawing.Point(4, 47);
            this.FastResult.Margin = new System.Windows.Forms.Padding(1);
            this.FastResult.Name = "FastResult";
            this.FastResult.Paddings = new System.Windows.Forms.Padding(10);
            this.FastResult.RightBracket = ')';
            this.FastResult.RightBracket2 = '}';
            this.FastResult.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.FastResult.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("FastResult.ServiceColors")));
            this.FastResult.ShowLineNumbers = false;
            this.FastResult.Size = new System.Drawing.Size(792, 67);
            this.FastResult.TabIndex = 4;
            this.FastResult.Zoom = 100;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FastResult);
            this.Controls.Add(this.FastCode);
            this.Controls.Add(this.FastCalculation);
            this.Controls.Add(this.TableButtonLayout);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmMain";
            this.Text = "Calculator 2 - Ricardo de Roode";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FastCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FastCalculation)).EndInit();
            this.TableButtonLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FastResult)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button20;
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
    }
}

