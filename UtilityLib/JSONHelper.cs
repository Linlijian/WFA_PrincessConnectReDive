using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace UtilityLib
{
    public class JSONHelper
    {
        public FormState STATE;
        public string ERROR { get; set; }

        public JSONHelper()
        {
            STATE = new FormState();
            ERROR = string.Empty;
        }

        public void loadConfig()
        {
            try
            {
                WebClient client = new WebClient();
                Stream stream = client.OpenRead("https://raw.githubusercontent.com/Linlijian/WFA_PrincessConnectReDive/master/data/Data.json");

                using (StreamReader r = new StreamReader(stream))
                {
                    string json = r.ReadToEnd();
                    SessionHelper.SYS_JSON_FILE = JsonConvert.DeserializeObject<List<FormState>>(json);
                }

                client.Dispose();
                stream.Dispose();
            }
            catch { }
            

           
        }

        public void writeConfig(FormState state)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("config.xml"))
                {
                    STATE = state;
                    XmlSerializer ser = new XmlSerializer(typeof(FormState));
                    ser.Serialize(sw, STATE);
                }
            }
            catch(Exception e) { ERROR = "Can't save config: " + e.Message; }
            
        }

        public bool IsComplete()
        {
            return ERROR.IsNullOrEmpty() ? true : false;
        }
    }
}
