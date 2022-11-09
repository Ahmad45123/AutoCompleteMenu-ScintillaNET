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
    public partial class ExtraLargeSample : Form
    {
        public ExtraLargeSample()
        {
            InitializeComponent();
            
            //build autocomplete menu
            List<string> list = new List<string>();
            for (int i = 1; i <= 1000000; i++)
                list.Add(i.ToString());

            autocompleteMenu1.SetAutocompleteItems(list);
        }
    }
}
