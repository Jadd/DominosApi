using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DominosApi.Runtime;
using DominosApi.Wrapper;
using DominosApi.Wrapper.Service;

namespace DominosApi.Client.Controls {
    public partial class StoreFinderControl : UserControl {
        
        public Store SelectedStore { get; private set; }

        private readonly Dictionary<ListViewItem, Store> _storeCache =
            new Dictionary<ListViewItem, Store>();

        public StoreFinderControl() {
            InitializeComponent();

            // Add the region groups to the filter combobox.
            for (var i = LocalRegion.None; i <= LocalRegion.WesternAustralia; i++)
                RegionFilterComboBox.Items.Add(i.ToString());
        }

        private void StoreList_SelectedIndexChanged(object sender, EventArgs e) {
            SelectedStore = StoreList.SelectedItems.Count == 1 ?
                _storeCache[StoreList.SelectedItems[0]] : null;
        }

        private void RegionFilterComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (RegionFilterComboBox.SelectedIndex != -1)
                LoadStoresForRegion((LocalRegion) RegionFilterComboBox.SelectedIndex);
        }

        private void LoadStoresForRegion(LocalRegion region) {
            if (InvokeRequired) {
                Invoke((Action<LocalRegion>) LoadStoresForRegion, region);
                return;
            }

            StoreList.Items.Clear();
            _storeCache.Clear();

            var response = Singleton<StoreService>.Instance.GetStoresByRegion(region);
            if (response?.Stores == null) {
                MessageBox.Show(this, "An error occurred while loading the store list.",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var store in response.Stores) {
                var listItem = new ListViewItem(store.DisplayString);
                listItem.SubItems.Add(store.StoreNumber.ToString());

                StoreList.Items.Add(listItem);
                _storeCache.Add(listItem, store);
            }
        }

    }
}
