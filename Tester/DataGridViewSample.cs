using System.Windows.Forms;
using AutocompleteMenuNS;

namespace Tester
{
    public partial class DataGridViewSample : Form
    {
        public DataGridViewSample()
        {
            InitializeComponent();

            for (int i = 0; i < 100; i++)
                dgv.Rows.Add();
        }

        private Control editControl;

        private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            autocompleteMenu1.TargetControlWrapper = null;
            autocompleteMenu1.SetAutocompleteMenu(editControl, null);
        }

        private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            editControl = e.Control;
            autocompleteMenu1.SetAutocompleteMenu(e.Control, autocompleteMenu1);
        }
    }

     /*
    internal class NoArrowNavigateDataGridView : DataGridView
    {
        public bool DisableArrowNavigationMode { get; set; }

        public NoArrowNavigateDataGridView()
        {
            DisableArrowNavigationMode = true;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (DisableArrowNavigationMode)
            if (EditingControl != null)
                if (keyData == Keys.Enter)
                    return false;
            return base.ProcessDialogKey(keyData);
        }

        protected override bool ProcessDataGridViewKey(KeyEventArgs e)
        {
            if (DisableArrowNavigationMode)
            if (EditingControl != null)
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || e.KeyCode == Keys.Enter)
                return false;
            return base.ProcessDataGridViewKey(e);
        }
    }*/
}
