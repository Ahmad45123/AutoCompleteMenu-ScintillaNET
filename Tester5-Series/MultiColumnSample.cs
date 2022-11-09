using System.Drawing;
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
            var alig = new[] { StringAlignment.Near, StringAlignment.Far };

            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "001", "Mr. Adam Smith" }, "Adam Smith") {Alignments = alig, ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "002", "Ms. Eva Smith" }, "Eva Smith") { Alignments = alig,ColumnWidth = columnWidth, ImageIndex = 1 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "003", "Mr. Ollie Craig" }, "Ollie Craig") {Alignments = alig, ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "004", "Mr. Tim Beauvais" }, "Tim Beauvais") {Alignments = alig, ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "005", "Ms. Caitlin Zambrano" }, "Caitlin Zambrano") {Alignments = alig, ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "006", "Ms. Mao Brune" }, "Mao Brune") {Alignments = alig, ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "007", "Ms. Tianna Nemitz" }, "Tianna Nemitz") {Alignments = alig, ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "008", "Ms. Kaylene Wang" }, "Kaylene Wang") {Alignments = alig, ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "009", "Ms. Estell Cavazos" }, "Estell Cavazos") { Alignments = alig,ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "010", "Ms. Denna Villalta" }, "Denna Villalta") {Alignments = alig, ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "011", "Ms. Fernanda Rosso" }, "Fernanda Rosso") {Alignments = alig, ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "012", "Ms. Zina Shealy" }, "Zina Shealy") { Alignments = alig,ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "013", "Ms. Shavon Ocampo" }, "Shavon Ocampo") {Alignments = alig, ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "014", "Mr. Forest Giguere" }, "Forest Giguere") {Alignments = alig, ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "015", "Mr. Eusebio Bealer" }, "Eusebio Bealer") {Alignments = alig, ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "016", "Mr. Erin Winkel" }, "Erin Winkel") { Alignments = alig,ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "017", "Mr. Clinton Duclos" }, "Clinton Duclos") {Alignments = alig, ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "018", "Mr. Gavin Ricotta" }, "Gavin Ricotta") {Alignments = alig, ColumnWidth = columnWidth, ImageIndex = 0 });
            autocompleteMenu1.AddItem(new MulticolumnAutocompleteItem(new[] { "019", "Mr. Jackie Julien" }, "Jackie Julien") {Alignments = alig, ColumnWidth = columnWidth, ImageIndex = 0 });
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
