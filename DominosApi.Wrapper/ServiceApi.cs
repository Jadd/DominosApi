using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace DominosApi.Wrapper {

    public class Message {
        public string Code;
        public string Type;
        public string Text;

        internal Message() { }
    }

    public class MediaItem {
        public string Role;
        public string Tag;
        public string Text;
        public string Uri;

        internal MediaItem() { }
    }

    public class RequestKey {
        public string Country = "AU";
        public string Culture = "en";
        public string Application = "androidWrapper";   // Can be anything but empty.
        public string Version = "1.0";                  // Can be anything but empty.
        
        // Unused fields:
        // public string Resolution;
        // public string SessionId;

        internal RequestKey() { }
    }

    public abstract class ServiceApi {
        private const string _apiURI =
            "http://services.dominos.com.au/OnlineOrdering/v22/{0}.svc/json/{1}";

        public abstract string Endpoint { get; }
        
        protected T Post<T>(string method, object data) where T : class {
            var request = WebRequest.Create(String.Format(_apiURI, Endpoint, method));
            request.Method = "POST";
            request.ContentType = "application/json";
            
            var bytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));
            request.ContentLength = bytes.Length;

            using (var stream = request.GetRequestStream())
                stream.Write(bytes, 0, bytes.Length);

            try {
                using (var response = request.GetResponse()) {
                    var responseStream = response.GetResponseStream();
                    if (responseStream == null)
                        throw new EndOfStreamException();

                    var result = new StreamReader(responseStream).ReadToEnd();
                    return JsonConvert.DeserializeObject<T>(result);
                }
            }
            catch { return null; }
        }
    }

}
