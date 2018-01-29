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
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "003", "Mr. Ollie Craig" }, "Ollie Craig") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "004", "Mr. Tim Beauvais" }, "Tim Beauvais") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "005", "Ms. Caitlin Zambrano" }, "Caitlin Zambrano") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "006", "Ms. Mao Brune" }, "Mao Brune") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "007", "Ms. Tianna Nemitz" }, "Tianna Nemitz") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "008", "Ms. Kaylene Wang" }, "Kaylene Wang") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "009", "Ms. Estell Cavazos" }, "Estell Cavazos") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "010", "Ms. Denna Villalta" }, "Denna Villalta") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "011", "Ms. Fernanda Rosso" }, "Fernanda Rosso") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "012", "Ms. Zina Shealy" }, "Zina Shealy") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "013", "Ms. Shavon Ocampo" }, "Shavon Ocampo") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "014", "Mr. Forest Giguere" }, "Forest Giguere") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "015", "Mr. Eusebio Bealer" }, "Eusebio Bealer") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "016", "Mr. Erin Winkel" }, "Erin Winkel") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "017", "Mr. Clinton Duclos" }, "Clinton Duclos") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "018", "Mr. Gavin Ricotta" }, "Gavin Ricotta") { ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "019", "Mr. Jackie Julien" }, "Jackie Julien") { ColumnWidth = columnWidth, ImageIndex = 0 });
        }

        private void MultiColumnSample_Load(object sender, System.EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox1.Checked)
                autocompleteMenu1.SetColumns(new[] { "ID", "Name" }, new[] { 50, 200 });
            else
                autocompleteMenu1.SetColumns(null);

        }
    }
}
