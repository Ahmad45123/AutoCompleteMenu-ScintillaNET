using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AutocompleteMenuNS;

namespace Tester
{
    public partial class CustomItemSample : Form
    {
        public CustomItemSample()
        {
            InitializeComponent();

            autocompleteMenu1.AddItem(new EmailSnippet("007@sis.gov.uk"));
            autocompleteMenu1.AddItem(new EmailSnippet("adam@god.gov"));
            autocompleteMenu1.AddItem(new EmailSnippet("eva@god.gov"));
            autocompleteMenu1.AddItem(new EmailSnippet("sheldon.cooper@moon.pie.com"));
            autocompleteMenu1.AddItem(new EmailSnippet("smith@yahoo.com"));
        }
    }

    internal class EmailSnippet : AutocompleteItem
    {
        public EmailSnippet(string email): base(email)
        {
            ImageIndex = 0;
            ToolTipTitle = "Insert email:";
            ToolTipText = email;
        }

        public override CompareResult Compare(string fragmentText)
        {
            if (fragmentText == Text)
                return CompareResult.VisibleAndSelected;
            if (fragmentText.Contains("@"))
                return CompareResult.Visible;
            return CompareResult.Hidden;
        }
    }
}
