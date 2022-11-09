using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AutocompleteMenuNS;

namespace Tester
{
    public partial class ComboboxSample : Form
    {
        public ComboboxSample()
        {
            InitializeComponent();
            BuildAutocompleteMenu();
        }

        private void BuildAutocompleteMenu()
        {
            var items = new List<AutocompleteItem>();

            //get all classes and methods of Form's assembly
            foreach (var cl in Assembly.GetAssembly(typeof(Form)).GetTypes())
            {
                items.Add(new SubstringAutocompleteItem(cl.Name, false) {ImageIndex = 0});
                foreach(var method in cl.GetMethods())
                    items.Add(new SubstringAutocompleteItem(method.Name, false) { ImageIndex = 2, MenuText = cl.Name + "." + method.Name + "()" });
            }

            //set as autocomplete source
            autocompleteMenu1.SetAutocompleteItems(items);
        }
    }
}
