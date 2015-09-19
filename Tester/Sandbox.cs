using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AutocompleteMenuNS;

namespace Tester
{
    public partial class Sandbox : Form
    {
        AutocompleteMenu menu;
        List<AutocompleteItem> items;

        public Sandbox()
        {
            InitializeComponent();

            menu = new AutocompleteMenu();
            //triggers
            MyMethodItem.Triggers = new char[] {'.', ':'};
            menu.SearchPattern = @"[\w" + Regex.Escape(new string(MyMethodItem.Triggers)) + "]";

            //create items
            items = new List<AutocompleteItem>();
            items.Add(new MyMethodItem("ToString"));

            //assign items to the menu
            menu.SetAutocompleteItems(items);

            //
            var tb = new RichTextBox() { Parent = this, Dock = DockStyle.Fill };
            menu.SetAutocompleteMenu(tb, menu);

            var f = new Form();
            f.Show();
            (menu.ListView as Control).Parent.VisibleChanged += (o, e) => 
                { 
                    (menu.ListView as Control).Parent.Top = 100; 
                };
        }

        void Parent_VisibleChanged(object sender, EventArgs e)
        {
            (menu.ListView as Control).Parent.Top = 100;
        }
    }

    class MyMethodItem : AutocompleteItem
    {
        public static char[] Triggers = new char[]{'.'};
        string firstPart;
        string methodNameLowercase;
        private char trigger;

        public MyMethodItem(string methodName) : base(methodName)
        {
            this.methodNameLowercase = methodName.ToLower();
        }

        public override CompareResult Compare(string fragmentText)
        {
            int i = fragmentText.LastIndexOfAny(Triggers);

            if (i < 0)
                return CompareResult.Hidden;

            trigger = fragmentText[i];
            string lastPart = fragmentText.Substring(i + 1);
            firstPart = fragmentText.Substring(0, i);

            if (lastPart == "") return CompareResult.Visible;
            if (Text.StartsWith(lastPart, StringComparison.InvariantCultureIgnoreCase))
                return CompareResult.VisibleAndSelected;
            if (methodNameLowercase.Contains(lastPart.ToLower()))
                return CompareResult.Visible;

            return CompareResult.Hidden;
        }

        public override string GetTextForReplace()
        {
            return firstPart + trigger + Text;
        }
    }
}
