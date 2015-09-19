using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AutocompleteMenuNS;

namespace Tester
{
    public partial class DynamicMenuSample : Form
    {
        public DynamicMenuSample()
        {
            InitializeComponent();

            autocompleteMenu1.SetAutocompleteItems(new DynamicCollection(tb));
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            //forcibly shows menu
            if (e.Control && e.KeyCode == Keys.Space)
                autocompleteMenu1.Show(tb, true);
        }
    }

    internal class DynamicCollection : IEnumerable<AutocompleteItem>
    {
        private TextBoxBase tb;

        public DynamicCollection(TextBoxBase tb)
        {
            this.tb = tb;
        }

        public IEnumerator<AutocompleteItem> GetEnumerator()
        {
            return BuildList().GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerable<AutocompleteItem> BuildList()
        {
            //find all words of the text
            var words = new Dictionary<string, string>();
            foreach (Match m in Regex.Matches(tb.Text, @"\b\w+\b"))
                words[m.Value] = m.Value;

            //return autocomplete items
            foreach(var word in words.Keys)
                yield return new AutocompleteItem(word);
        }
    }
}
