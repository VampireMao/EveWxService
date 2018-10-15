using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace EveWxService
{
    public class HomeController : Controller
    {
        [HttpPost]
        public string Index(string name)
        {
            MessageClass mc = null;
            try
            {
                string sqlUrl = "https://www.asdfg.men/home/GetItem";

                WebClient wc = new WebClient();
                NameValueCollection nvc = new NameValueCollection();
                nvc.Add("name", name);
                var jsonBytes = wc.UploadValues(sqlUrl, "POST", nvc);

                var mcObj = JsonConvert.DeserializeObject<MessageClass>(Encoding.UTF8.GetString(jsonBytes));

                mc = mcObj;

                //GetGuangGao(a, GroupID);

            }
            catch (Exception ex)
            {
                mc = new MessageClass()
                {
                    MessageType = -1,
                    Message = ex.Message + ex.StackTrace
                };
            }

            return JsonConvert.SerializeObject(mc);
        }
    }
}