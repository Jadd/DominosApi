using System;
using System.Windows.Forms;
using DominosApi.Wrapper.Service;

namespace DominosApi.Client.Forms {
    public partial class StoreSelectorForm : Form {

        public Store SelectedStore { get; private set; }

        public StoreSelectorForm() {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e) {
            SelectedStore = StoreFinder.SelectedStore;
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            SelectedStore = null;
            DialogResult = DialogResult.Cancel;
        }

    }
}
