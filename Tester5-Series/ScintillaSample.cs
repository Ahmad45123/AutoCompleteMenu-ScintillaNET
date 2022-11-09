using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tester
{
    public partial class ScintillaSample : Form
    {
        public ScintillaSample()
        {
            InitializeComponent();
        }

        private void ScintillaSample_Load(object sender, EventArgs e)
        {
            AutoComplete.TargetControlWrapper = new ScintillaWrapper(scintilla1);
        }
    }
}
