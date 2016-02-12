using System;

namespace DominosApi.Wrapper.Service {

    /* http://services.dominos.com.au/OnlineOrdering/v22/Store.svc/json/help */

    #region Field structures
    public class Store {
        public int StoreNumber;
        public string StoreName;
        public string DisplayString;
        public string PhoneNo;
        public string Email;
        public Address Address;
        public bool OnlineOrderingEnabled;
        public GeoCoordinates GeoCoordinates;
        public string[] OrderChannels;
        public string StoreImageUrl;
        public DateTime CurrentTime;
        public int TimeZoneOffset;
        public OpeningHours[] OpeningHours;
        public Closures[] Closures;
        public bool WebSiteEnabled;

        internal Store() { }
    }

    public class Address {
        public string PostalCode;
        public string State;
        public string StreetName;
        public string StreetNo;
        public string Suburb;
        public string UnitNo;

        internal Address() { }
    }

    public class GeoCoordinates {
        public float Latitude;
        public float Longitude;

        internal GeoCoordinates() { }
    }

    public class OpeningHours {
        public DateTime Open;
        public DateTime Close;

        internal OpeningHours() { }
    }

    public class Closures {
        public DateTime Close;
        public DateTime Reopen;
        public MediaItem[] MediaItems;

        internal Closures() { }
    }
    #endregion

    #region Request structures
    public class GetStoreByIdRequest {
        public RequestKey RequestKey = new RequestKey();
        public int StoreNumber;
        
        internal GetStoreByIdRequest() { }
    }

    public class GetStoresByRegionRequest {
        public RequestKey RequestKey = new RequestKey();
        public string Region;
        
        internal GetStoresByRegionRequest() { }
    }
    #endregion

    #region Response structures
    public class GetStoreByIdResponse {
        public Message[] Messages;
        public Store Store;

        internal GetStoreByIdResponse() { }
    }

    public class GetStoresByRegionResponse {
        public Message[] Messages;
        public Store[] Stores;

        internal GetStoresByRegionResponse() { }
    }
    #endregion

    public sealed class StoreService : ServiceApi {
        public override string Endpoint => "Store";
        
        public GetStoreByIdResponse GetStoreById(int storeNumber) {
            return Post<GetStoreByIdResponse>("GetStoreById", new GetStoreByIdRequest {
                StoreNumber = storeNumber
            });
        }
        
        public GetStoresByRegionResponse GetStoresByRegion(LocalRegion region) {
            return GetStoresByRegion(Utility.GetRegionCode(region));
        }
        
        public GetStoresByRegionResponse GetStoresByRegion(string regionCode) {
            return Post<GetStoresByRegionResponse>("GetStoresByRegion", new GetStoresByRegionRequest {
                Region = regionCode
            });
        }
    }

}
