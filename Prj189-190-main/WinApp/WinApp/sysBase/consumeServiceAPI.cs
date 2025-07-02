using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System.Web.Script.Serialization;

namespace WinApp.sysBase
{
    public class consumeServiceAPI
    {
        public DataTable dt = new DataTable();

        public static DataTable ConvertJsonToDatatableLinq(string jsonString)
        {
            var jsonLinq = JObject.Parse(jsonString);

            // Find the first array using Linq
            var linqArray = jsonLinq.Descendants().Where(x => x is JArray).First();
            var jsonArray = new JArray();
            foreach (JObject row in linqArray.Children<JObject>())
            {
                var createRow = new JObject();
                foreach (JProperty column in row.Properties())
                {
                    // Only include JValue types
                    if (column.Value is JValue)
                        createRow.Add(column.Name, column.Value);
                }
                jsonArray.Add(createRow);
            }

            return JsonConvert.DeserializeObject<DataTable>(jsonArray.ToString());
        }

        public string PostReleasesList(string url, string session, string arg)
        {
            dt.Reset();
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.ContentType = "application/json";
            request.Method = "POST";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    uid = session,
                    pwd = arg
                });
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            var content = string.Empty;
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        content = sr.ReadToEnd();
                    }
                }
            }
            if (content != "" || content != string.Empty)
            {
                dt = ConvertJsonToDatatableLinq(content);
            }
            return content;
        }

        public string GetReleases(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            var content = string.Empty;
            using (var response = (HttpWebResponse)request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    using (var sr = new StreamReader(stream))
                    {
                        content = sr.ReadToEnd();
                    }
                }
            }
            return content;
        }

    }
}
