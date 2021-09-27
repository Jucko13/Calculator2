using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator2.AutoCompleteItems
{
    public class ObjectPropertyAutoComplete : AutocompleteItem
    {
        private string firstPart;

        private string lowercaseText;

        //private string objectText;

        private string lastPart;

        private Regex objectText;

        public ObjectPropertyAutoComplete(string text, string objectText)
            : base(text)
        {
            SetObjectText(objectText);
            lowercaseText = Text.ToLower();
        }

        public void SetObjectText(string objectText)
        {
            this.objectText = new Regex("\\b(" + objectText + ")", RegexOptions.Compiled);
        }

        public override CompareResult Compare(string fragmentText)
        {
            int num = fragmentText.LastIndexOf('.');
            if (num < 0)
            {
                return CompareResult.Hidden;
            }

            string text = fragmentText.Substring(num + 1);
            string textTrim = text.Trim();

            if (textTrim != "")
            {
                lastPart = text.Remove(0, textTrim.Length);
            }
            else
            {
                lastPart = text;
            }

            firstPart = fragmentText.Substring(0, num);

            string firstPartLower = firstPart.ToLower().Trim();

            bool objectIsMatch = objectText.IsMatch(firstPartLower);

            if (textTrim == "" && objectIsMatch)
            {
                return CompareResult.Visible;
            }

            if (Text.StartsWith(textTrim, StringComparison.InvariantCultureIgnoreCase) && objectIsMatch)
            {
                return CompareResult.VisibleAndSelected;
            }

            if (lowercaseText.Contains(textTrim.ToLower()) && objectIsMatch)
            {
                return CompareResult.Visible;
            }

            return CompareResult.Hidden;
        }

        public override string GetTextForReplace()
        {
            return firstPart + "." + Text + lastPart;
        }
    }
}
