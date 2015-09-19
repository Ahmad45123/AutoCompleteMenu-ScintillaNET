using System;
using System.Windows.Forms;
using AutocompleteMenuNS;

namespace Tester
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SimplestSample().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ExtraLargeSample().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AdvancedSample().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new CustomItemSample().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new ComboboxSample().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new MultiColumnSample().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new CustomListViewSample().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new DynamicMenuSample().Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new DataGridViewSample().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new DynamicTooltipSample().Show();
        }

        private void MainForm_DoubleClick(object sender, EventArgs e)
        {
            new Sandbox().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new ScintillaSample().Show();
        }
    }
}
