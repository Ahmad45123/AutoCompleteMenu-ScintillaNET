using System.Windows.Forms;
using AutocompleteMenuNS;

namespace Tester
{
    public partial class MultiColumnSample : Form
    {
        public MultiColumnSample()
        {
            InitializeComponent();

            autocompleteMenu1.MaximumSize = new System.Drawing.Size(250, 200);
            var columnWidth = new int[] { 50, 200 };

            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "001", "Mr. Adam Smith" }, "Adam Smith") {ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "002", "Ms. Eva Smith" }, "Eva Smith") { ColumnWidth = columnWidth, ImageIndex = 1 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "007", "Mr. Bond, James Bond" }, "James Bond") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "666", "Mr. Sam, Serios Sam" }, "Serios Sam") { ColumnWidth = columnWidth, ImageIndex = 0 });
        }
    }
}
