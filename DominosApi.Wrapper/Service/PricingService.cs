using System;
using System.IO;
using Newtonsoft.Json;

namespace DominosApi.Wrapper.Service {

    /* http://services.dominos.com.au/OnlineOrdering/v22/Pricing.svc/json/help */

    #region Field structures
    public class Voucher {
        public string VoucherCode;
        public bool Removable;
        public string ServiceMethod;
        public DateTime ReleaseDate;
        public DateTime ExpiresAt;
        public MediaItem[] MediaItems;
        public VoucherItem[] VoucherItems;

        internal Voucher() { }
    }

    public class CampaignVoucher : Voucher {
        public string CampaignType;
        public bool IsRestricted;
        public DateTime CampaignStartDate;
        public DateTime CampaignEndDate;
        public int[] ValidDays;
        public int ValidStartTime;
        public int ValidEndTime;
        public string CampaignVoucherDisplayType;
        public MediaItem CampaignVoucherMediaItem;

        internal CampaignVoucher() { }
    }

    public class VoucherItem {
        public int VoucherItemNo;
        public MediaItem[] MediaItems;
        public string[] FreeSwaps;
        public string[] SurchargedSwaps;
        public string ComponentRequirement;

        internal VoucherItem() { }
    }
    #endregion

    #region Request structures
    public class GetCampaignVouchersRequest {
        public RequestKey RequestKey = new RequestKey();
        public int StoreNumber;

        // Unused fields:
        // public string ServiceMethod = "Delivery"; // Not specified -> search as either type.
        // public string DeviceId;

        internal GetCampaignVouchersRequest() { }
    }

    public class GetVoucherRequest {
        public RequestKey RequestKey = new RequestKey();
        public int StoreNumber;
        public string VoucherCode;
        
        // Unused fields:
        // public DateTime OrderTime = DateTime.Now;
        // public string ServiceMethod = "Delivery"; // Not specified -> search as either type.
        // public string Email = "gaben@valvesoftware.com";

        internal GetVoucherRequest() { }
    }

    public class GetWebVouchersRequest {
        public RequestKey RequestKey = new RequestKey();
        public int StoreNumber;

        // Unused fields:
        // public DateTime OrderTime = DateTime.Now;
        // public string ServiceMethod = "Delivery"; // Not specified -> search as either type.

        internal GetWebVouchersRequest() { }
    }
    #endregion

    #region Response structures
    public class GetCampaignVouchersResponse {
        public Message[] Messages;
        public CampaignVoucher[] OffersVouchers;

        internal GetCampaignVouchersResponse() { }
    }

    public class GetVoucherResponse {
        public Message[] Messages;
        public Voucher Voucher;

        internal GetVoucherResponse() { }
    }

    public class GetWebVouchersResponse {
        public Message[] Messages;
        public Voucher[] Vouchers;

        internal GetWebVouchersResponse() { }
    }
    #endregion

    public sealed class PricingService : ServiceApi {
        public override string Endpoint => "Pricing";
        
        public GetCampaignVouchersResponse GetCampaignVouchers(int storeNumber) {
            return Post<GetCampaignVouchersResponse>("GetCampaignVouchers", new GetCampaignVouchersRequest {
                StoreNumber = storeNumber
            });
        }

        public GetVoucherResponse GetVoucher(int storeNumber, int voucherCode) {
            return Post<GetVoucherResponse>("GetVoucher", new GetVoucherRequest {
                StoreNumber = storeNumber,
                VoucherCode = voucherCode.ToString()
            });
        }

        public GetWebVouchersResponse GetWebVouchers(int storeNumber) {
            return Post<GetWebVouchersResponse>("GetWebVouchers", new GetWebVouchersRequest {
                StoreNumber = storeNumber
            });
        }
    }

}
