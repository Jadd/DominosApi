using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DominosApi.Wrapper.Service;

namespace DominosApi.Client.Forms {
    public partial class MainForm : Form {

        private Store _selectedStore;
        private readonly List<Tuple<Thread, PricingService>> _couponScanners =
            new List<Tuple<Thread, PricingService>>();

        private readonly object _lockObject = new object();
        private readonly ManualResetEvent _resetEvent = new ManualResetEvent(false);
        private int _currentCode = 1;
        private int _requests;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            var storeSelectorForm = new StoreSelectorForm();
            if (storeSelectorForm.ShowDialog(this) != DialogResult.OK) {
                MessageBox.Show("You must select a store before running the application!",
                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Close();
                return;
            }

            _selectedStore = storeSelectorForm.SelectedStore;
            StatusStrip_StoreLabel.Text =
                $"Store: {_selectedStore.DisplayString} ({_selectedStore.StoreNumber})";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            _resetEvent.Set();
        }

        private void AddVoucherEntry(Voucher voucher) {
            if (voucher == null)
                return;

            if (InvokeRequired) {
                Invoke((Action<Voucher>) AddVoucherEntry, voucher);
                return;
            }
            
            var description = "";
            var disclaimer = "";

            if (voucher.MediaItems != null) {
                foreach (var mediaItem in voucher.MediaItems) {
                    if (mediaItem.Role == "Description")
                        description = mediaItem.Text;
                    else if (mediaItem.Role == "Disclaimer")
                        disclaimer = mediaItem.Text;
                }
            }

            var listItem = new ListViewItem(description);
            listItem.SubItems.Add(voucher.VoucherCode);
            listItem.SubItems.Add(disclaimer);
            
            CouponList.Items.Add(listItem);
        }

        private void StartButton_Click(object sender, EventArgs e) {
            StartCodeNumeric.Enabled = false;
            EndCodeNumeric.Enabled = false;
            ThreadsNumeric.Enabled = false;
            StartButton.Enabled = false;

            _currentCode = (int) StartCodeNumeric.Value;

            for (var i = 0; i < ThreadsNumeric.Value; i++) {
                var thread = new Thread(ThreadLoop);
                var pricingService = new PricingService();

                _couponScanners.Add(Tuple.Create(thread, pricingService));
                thread.Start(pricingService);
            }

            UpdateRequestsTimer.Enabled = true;
        }

        private void UpdateRequestsTimer_Tick(object sender, EventArgs e) {
            lock (_lockObject) {
                StatusStrip_RequestsLabel.Text = $"Requests: {_requests}/sec";
                StatusStrip_CurrentVoucherId.Text = $"Checking: {_currentCode}";
                _requests = 0;
            }
        }

        private void ThreadLoop(object state) {
            var pricingService = (PricingService) state;
            var storeId = _selectedStore.StoreNumber;
            var retry = false;
            var code = 0;

            while (!_resetEvent.WaitOne(100)) {
                if (!retry) {
                    lock (_lockObject) {
                        code = _currentCode++;
                        ++_requests;
                    }
                }

                if (_currentCode >= EndCodeNumeric.Value) {
                    Debug.WriteLine("Done! " + DateTime.Now);
                    break;
                }

                var response = pricingService.GetVoucher(storeId, code);
                retry = response == null;

                if (response != null)
                    AddVoucherEntry(response.Voucher);
                else
                    Debug.WriteLine(code + " failed!");
            }
        }

    }
}
