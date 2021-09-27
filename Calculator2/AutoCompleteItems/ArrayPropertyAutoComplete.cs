using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2.AutoCompleteItems
{

    public class ArrayPropertyAutoComplete : AutocompleteItem
    {
        private string firstPart;

        private string lowercaseText;

        private string objectName;

        public ArrayPropertyAutoComplete(string text, string objectName = "") : base(text)
        {
            lowercaseText = Text.ToLower();
            this.objectName = objectName.ToLower();
        }


        public override CompareResult Compare(string fragmentText)
        {
            int num = fragmentText.LastIndexOf('.');
            if (num < 0)
            {
                return CompareResult.Hidden;
            }

            string text = fragmentText.Substring(num + 1);
            firstPart = fragmentText.Substring(0, num);

            string firstPartLower = firstPart.ToLower().Trim();


            if (text == "" && firstPartLower.EndsWith("]") && firstPartLower.StartsWith(objectName + "["))
            {
                return CompareResult.Visible;
            }

            if (Text.StartsWith(text, StringComparison.InvariantCultureIgnoreCase) && firstPartLower.EndsWith("]") && firstPartLower.StartsWith(objectName + "["))
            {
                return CompareResult.VisibleAndSelected;
            }

            if (lowercaseText.Contains(text.ToLower()) && firstPartLower.EndsWith("]") && firstPartLower.StartsWith(objectName + "["))
            {
                return CompareResult.Visible;
            }

            return CompareResult.Hidden;
        }

        public override string GetTextForReplace()
        {
            return firstPart + "." + Text;
        }
    }
}
