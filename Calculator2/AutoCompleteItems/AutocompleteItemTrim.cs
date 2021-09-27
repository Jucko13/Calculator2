using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Calculator2.AutoCompleteItems
{
    internal class AutocompleteItemTrim: AutocompleteItem
    {

        private string firstPart;


        public AutocompleteItemTrim(string text) : base(text)
        {

        }

        public override CompareResult Compare(string fragmentText)
        {
            string fragmentTextTrim = fragmentText.Trim();

            if (fragmentTextTrim != "") { 
                firstPart = fragmentText.Remove(fragmentText.IndexOf(fragmentTextTrim));
            }
            else
            {
                firstPart = fragmentText;
            }

            if (fragmentTextTrim != "" && Text.StartsWith(fragmentTextTrim, StringComparison.InvariantCultureIgnoreCase) && Text != fragmentTextTrim)
            {
                return CompareResult.VisibleAndSelected;
            }

            return CompareResult.Hidden;
        }

        public override string GetTextForReplace()
        {
            return firstPart + Text;
        }
    }
}
