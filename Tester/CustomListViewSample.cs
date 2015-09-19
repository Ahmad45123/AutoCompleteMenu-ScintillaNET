using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AutocompleteMenuNS;

namespace Tester
{
    public partial class CustomListViewSample : Form
    {
        public CustomListViewSample()
        {
            InitializeComponent();

            //attach custom listview
            autocompleteMenu1.ListView = myListView1;

            //build menu
            for (int i = 0; i < 1000; i++)
                autocompleteMenu1.AddItem(new AutocompleteItem(string.Format("{0:000}", i), i % 4));
        }
    }

    /// <summary>
    /// Custom control, derived from ListView. 
    /// It is implements IAutocompleteListView interface.
    /// </summary>
    public class MyListView : ListView, IAutocompleteListView
    {
        #region IAutocompleteListView

        public int SelectedItemIndex
        {
            get { 
                var ind = this.SelectedIndices;
                if (ind.Count > 0)
                    return ind[0];
                else
                    return -1;
            }
            set
            {
                if (value >= 0 && value < Items.Count)
                {
                    Items[value].Selected = true;
                    EnsureVisible(value);
                    Invalidate();
                }
            }
        }

        private IList<AutocompleteItem> visibleItems;

        public IList<AutocompleteItem> VisibleItems
        {
            get { return visibleItems; }
            set
            {
                visibleItems = value;
                BeginUpdate();
                Items.Clear();
                if (visibleItems != null)
                foreach(var item in visibleItems)
                {
                    var listViewItem = new ListViewItem(item.ToString(), item.ImageIndex);
                    Items.Add(listViewItem);
                }
                EndUpdate();
            }
        }

        public event EventHandler ItemSelected;

        public event EventHandler<HoveredEventArgs> ItemHovered;

        public ImageList ImageList
        {
            get { return this.LargeImageList; }
            set { this.LargeImageList = value; }
        }

        public Rectangle GetItemRectangle(int itemIndex)
        {
            return GetItemRect(itemIndex);
        }

        public Colors Colors { get; set; }

        #endregion

        public MyListView()
        {
            Colors = new Colors();
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            OnItemSelected();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                OnItemSelected();
            base.OnKeyPress(e);
        }

        private void OnItemSelected()
        {
            if (ItemSelected != null)
                ItemSelected(this, EventArgs.Empty);
        }


        public int ToolTipDuration
        {
            get
            {
                return 3000;
            }
            set
            {
                ;
            }
        }

        public void ShowToolTip(AutocompleteItem autocompleteItem, Control control = null)
        {
        }


        public int HighlightedItemIndex
        {
            get { return -1; }
            set { }
        }
    }
}
