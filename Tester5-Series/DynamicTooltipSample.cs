using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AutocompleteMenuNS;

namespace Tester
{
    public partial class DynamicTooltipSample : Form
    {
        public DynamicTooltipSample()
        {
            InitializeComponent();
        }

        private void autocompleteMenu1_Hovered(object sender, HoveredEventArgs e)
        {
            if (e.Item != null)
            {
                e.Item.ToolTipTitle = "Dynamic tooltip";
                e.Item.ToolTipText = "This tooltip was dynamically generated for item " + e.Item.ToString();
            }
        }
    }
}
