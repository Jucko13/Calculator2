using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace Calculator2
{
    public partial class FrmMain : Form
    {

        private ScriptEngine engine = null;

        public FrmMain()
        {
            InitializeComponent();

        }

        private TextStyle keywordStyle = new TextStyle(Brushes.Red, null, FontStyle.Regular);

        private void FrmMain_Load(object sender, EventArgs e)
        {

            //JavascriptEvaluator.JavascriptEvaluator javascriptEvaluator = null;


            //javascriptEvaluator = new JavascriptEvaluator.JavascriptEvaluator();

            engine = new ScriptEngine("{16d51579-a30b-4c8b-a276-0ff4dc41e755}");

            foreach (Button button in TableButtonLayout.Controls.OfType<Button>())
            {
                button.Dock = DockStyle.Fill;
                button.Click += TableButton_Click;
            }

            FastCode.SyntaxHighlighter.KeywordStyle = keywordStyle;

            FastCode.Text = "var JSON;JSON||(JSON={}),(function(){\"use strict\";function i(n){return n<10?\"0\"+n:n}function f(n){return o.lastIndex=0,o.test(n)?'\"'+n.replace(o,function(n){var t=s[n];return typeof t==\"string\"?t:\"\\\\u\"+(\"0000\"+n.charCodeAt(0).toString(16)).slice(-4)})+'\"':'\"'+n+'\"'}function r(i,e){var h,l,c,a,v=n,s,o=e[i];o&&typeof o==\"object\"&&typeof o.toJSON==\"function\"&&(o=o.toJSON(i)),typeof t==\"function\"&&(o=t.call(e,i,o));switch(typeof o){case\"string\":return f(o);case\"number\":return isFinite(o)?String(o):\"null\";case\"boolean\":case\"null\":return String(o);case\"object\":if(!o)return\"null\";n+=u,s=[];if(Object.prototype.toString.apply(o)===\"[object Array]\"){for(a=o.length,h=0;h<a;h+=1)s[h]=r(h,o)||\"null\";return c=s.length===0?\"[]\":n?\"[\\n\"+n+s.join(\",\\n\"+n)+\"\\n\"+v+\"]\":\"[\"+s.join(\",\")+\"]\",n=v,c}if(t&&typeof t==\"object\")for(a=t.length,h=0;h<a;h+=1)typeof t[h]==\"string\"&&(l=t[h],c=r(l,o),c&&s.push(f(l)+(n?\": \":\":\")+c));else for(l in o)Object.prototype.hasOwnProperty.call(o,l)&&(c=r(l,o),c&&s.push(f(l)+(n?\": \":\":\")+c));return c=s.length===0?\"{}\":n?\"{\\n\"+n+s.join(\",\\n\"+n)+\"\\n\"+v+\"}\":\"{\"+s.join(\",\")+\"}\",n=v,c}}typeof Date.prototype.toJSON!=\"function\"&&(Date.prototype.toJSON=function(){return isFinite(this.valueOf())?this.getUTCFullYear()+\"-\"+i(this.getUTCMonth()+1)+\"-\"+i(this.getUTCDate())+\"T\"+i(this.getUTCHours())+\":\"+i(this.getUTCMinutes())+\":\"+i(this.getUTCSeconds())+\"Z\":null},String.prototype.toJSON=Number.prototype.toJSON=Boolean.prototype.toJSON=function(){return this.valueOf()});var e=/[\\u0000\\u00ad\\u0600-\\u0604\\u070f\\u17b4\\u17b5\\u200c-\\u200f\\u2028-\\u202f\\u2060-\\u206f\\ufeff\\ufff0-\\uffff]/g,o=/[\\\\\\\"\\x00-\\x1f\\x7f-\\x9f\\u00ad\\u0600-\\u0604\\u070f\\u17b4\\u17b5\\u200c-\\u200f\\u2028-\\u202f\\u2060-\\u206f\\ufeff\\ufff0-\\uffff]/g,n,u,s={\"\\b\":\"\\\\b\",\"\\t\":\"\\\\t\",\"\\n\":\"\\\\n\",\"\\f\":\"\\\\f\",\"\\r\":\"\\\\r\",'\"':'\\\\\"',\"\\\\\":\"\\\\\\\\\"},t;typeof JSON.stringify!=\"function\"&&(JSON.stringify=function(i,f,e){var o;n=\"\",u=\"\";if(typeof e==\"number\")for(o=0;o<e;o+=1)u+=\" \";else typeof e==\"string\"&&(u=e);t=f;if(f&&typeof f!=\"function\"&&(typeof f!=\"object\"||typeof f.length!=\"number\"))throw new Error(\"JSON.stringify\");return r(\"\",{\"\":i})}),typeof JSON.parse!=\"function\"&&(JSON.parse=function(n,t){function r(n,i){var f,e,u=n[i];if(u&&typeof u==\"object\")for(f in u)Object.prototype.hasOwnProperty.call(u,f)&&(e=r(u,f),e!==undefined?u[f]=e:delete u[f]);return t.call(n,i,u)}var i;n=String(n),e.lastIndex=0,e.test(n)&&(n=n.replace(e,function(n){return\"\\\\u\"+(\"0000\"+n.charCodeAt(0).toString(16)).slice(-4)}));if(/^[\\],:{}\\s]*$/.test(n.replace(/\\\\(?:[\"\\\\\\/bfnrt]|u[0-9a-fA-F]{4})/g,\"@\").replace(/\"[^\"\\\\\\n\\r]*\"|true|false|null|-?\\d+(?:\\.\\d*)?(?:[eE][+\\-]?\\d+)?/g,\"]\").replace(/(?:^|:|,)(?:\\s*\\[)+/g,\"\")))return i=eval(\"(\"+n+\")\"),typeof t==\"function\"?r({\"\":i},\"\"):i;throw new SyntaxError(\"JSON.parse\");})})()";
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
                    FastCalculation.InsertText(button.Text);
                    break;

                case "=":

                    ExecuteCode();

                    break;



                //case "":

                //    break;
                //case "":

                //    break;
                //case "":

                //    break;
                //case "":

                //    break;
                //case "":

                //    break;
                //case "":

                //    break;
                //case "":

                //    break;
                //case "":

                //    break;
                //case "":

                //    break;
                //case "":

                //    break;
                //case "":

                //    break;
                //case "":

                //    break;


            }


        }

        private void ExecuteCode()
        {
            try
            {
                FastResult.Text = engine.Eval(
                    FastCode.Text + "\r\n" +
                    FastCalculation.Text
                    ).ToString();

            }
            catch (Exception ex)
            {
                FastResult.Text = engine.Site.LastException.Message;
            }
        }

        private void FastCalculation_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
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
    }
}
