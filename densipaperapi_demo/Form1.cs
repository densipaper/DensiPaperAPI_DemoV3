using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using System.Web.UI;
using System.Web.Script.Serialization;




namespace DensiPaperAPI_Demo
{

    public partial class Form1 : Form
    {
        public Cookie sessionID = null;
        public Form1()
        {
            InitializeComponent();
        }

        public class NameAndId
        {
            public string name { get; set; }
            public int id { get; set; }
        }
        public class AccountRecord
        {
            //public IList<IDictionary<string,string>> data{get;set;}

            public string status { get; set; }
            public string account { get; set; }
            public int company_id { get; set; }

        }
        public class ImageRecord
        {
            public string expires { get; set; }
            public int height { get; set; }
            public int id { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public int width { get; set; }



        }
        public class DeviceRecord
        {
            public string timezone { get; set; }
            public string serial { get; set; }
            public int id { get; set; }
            public string location { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string timer { get; set; }
        }
        public class GroupRecord
        {
            public int id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
        }
        public class TimerRecord
        {
            public int id { get; set; }
            public string name { get; set; }
            //public string success { get; set; }
            //public string failure { get; set; }

        }
        public class TemplateRecord
        {
            public string name { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int fontsize { get; set; }
            public string fontstyle { get; set; }
            public string align { get; set; }
        }
        public bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
        private String HttpPOST(String strURL, String strParams)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            byte[] bytes = Encoding.ASCII.GetBytes(strParams);
            request.ContentLength = bytes.Length;
            request.CookieContainer = new CookieContainer();
            if (sessionID != null)
            {
                request.CookieContainer.Add(sessionID);
            }
            CookieCollection cc = new CookieCollection();
            request.Method = WebRequestMethods.Http.Post;
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
            request.AllowWriteStreamBuffering = true;
            request.ProtocolVersion = HttpVersion.Version11;
            request.AllowAutoRedirect = false;   // Capturing sessionID needs disabling Auto Redirect 
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
            request.CookieContainer.Add(cc); //recover cookies First request
            String strResponse;
            try
            {
                using (Stream os = request.GetRequestStream())
                {
                    os.Write(bytes, 0, bytes.Length);
                }
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                //Retrieve your cookie that id's your session
                cc = response.Cookies;
                foreach (Cookie cookie in cc)
                {
                    System.Console.WriteLine("Cookie Name:" + cookie.Name + "Cookie Value:" + cookie.Value);
                    if (cookie.Name == "sessionid")
                    { sessionID = cookie; System.Console.WriteLine("SessionID is set"); }
                }
                StreamReader reader = new StreamReader(response.GetResponseStream());
                strResponse = reader.ReadToEnd();
                //Console.WriteLine(strResponse );
            }
            catch (Exception httpex)
            { strResponse = "[{ \"status\":\"" + httpex.Message + "\"}]"; }
            return strResponse;
        }
        private string HttpGET(string strURL)
        {
            string strResponse;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
            request.CookieContainer = new CookieContainer();
            if (sessionID != null)
                request.CookieContainer.Add(sessionID);
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                strResponse = reader.ReadToEnd();
            }
            catch (Exception httpex)
            {
                strResponse = "[{ \"status\":\"" + httpex.Message + "\"}]";
            }
            return strResponse;
        }
        private String login(String username, String password, String strURL)
        {
            /* Parameters:
             * username: <foraname initial><surname>@<account>
             * password
             * full URL should terminate with /
             */
            /*
            HttpWebRequest request =  (HttpWebRequest)WebRequest.Create(strURL);
            request.Method="POST";
            request.ContentType = "application/x-www-form-urlencoded";
             */
            string formParams = string.Format("username={0}&password={1}", username, password);
            String response = HttpPOST(strURL, formParams);
            //Console.WriteLine("Login:"+response);

            return response;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.lblStatus.Text = "";
            // Get Security Token for Login  
            String strURL = txbURL.Text + "/API/login/";
            Console.WriteLine("Before Login:" + CredentialCache.DefaultCredentials);
            var response = login(this.txbUser.Text, this.txbPassword.Text, strURL);
            Console.WriteLine("After Login:" + CredentialCache.DefaultCredentials);
            //Console.WriteLine("Button:" + response);
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            if (!response.Contains('['))
                response = "[" + response + "]"; // Deserializer does not like single record without []
            var responselist = serializer.Deserialize<List<AccountRecord>>(response);
            foreach (AccountRecord item in responselist)
            {
                this.Text = "Logged in: " + item.account;
            }
            // If Session_id cookie was provided then login was successful
            if (sessionID != null)
            { this.lblStatus.Text = "Login has been successful!"; }
            else
            { this.lblStatus.Text = "Login attempt has failed!"; }



        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            String strURL = txbURL.Text + "/API/logout";
            /*
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL);
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(sessionID);
            //Get the response from the server and save the cookies from the first request..
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
             */
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string response = HttpGET(strURL);
            sessionID = null;
            this.Text = "User has been logged out!";
            if (!response.Contains('['))
                response = "[" + response + "]"; // Deserializer does not like single record without []
            var responselist = serializer.Deserialize<List<AccountRecord>>(response);
            foreach (AccountRecord item in responselist)
            {
                this.lblStatus.Text = item.status;
                this.Text = "Not Logged In";
            }

        }
        private string FileUploadData(string filename)
        {
            string formData = "";
            return formData;
            /*
            //Identificate separator
            string boundary = "---------------------------" + DateTime.Now.Ticks.ToString("x");
            //Encoding
            byte[] boundarybytes = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "\r\n");

            //Creation and specification of the request
            HttpWebRequest wr = (HttpWebRequest)WebRequest.Create(url); //sVal is id for the webService
            wr.ContentType = "multipart/form-data; boundary=" + boundary;
            wr.Method = "POST";
            wr.KeepAlive = true;
            wr.Credentials = System.Net.CredentialCache.DefaultCredentials;

            string sAuthorization = "login:password";//AUTHENTIFICATION BEGIN
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(sAuthorization);
            string returnValue = System.Convert.ToBase64String(toEncodeAsBytes);
            wr.Headers.Add("Authorization: Basic " + returnValue); //AUTHENTIFICATION END
            Stream rs = wr.GetRequestStream();


            string formdataTemplate = "Content-Disposition: form-data; name=\"{0}\"\r\n\r\n{1}"; //For the POST's format

            //Writting of the file
            rs.Write(boundarybytes, 0, boundarybytes.Length);
            byte[] formitembytes = System.Text.Encoding.UTF8.GetBytes(Server.MapPath("questions.pdf"));
            rs.Write(formitembytes, 0, formitembytes.Length);

            rs.Write(boundarybytes, 0, boundarybytes.Length);

            string headerTemplate = "Content-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n";
            string header = string.Format(headerTemplate, "file", "questions.pdf", contentType);
            byte[] headerbytes = System.Text.Encoding.UTF8.GetBytes(header);
            rs.Write(headerbytes, 0, headerbytes.Length);

            FileStream fileStream = new FileStream(Server.MapPath("questions.pdf"), FileMode.Open, FileAccess.Read);
            byte[] buffer = new byte[4096];
            int bytesRead = 0;
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                rs.Write(buffer, 0, bytesRead);
            }
            fileStream.Close();

            byte[] trailer = System.Text.Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
            rs.Write(trailer, 0, trailer.Length);
            rs.Close();
            rs = null;

            WebResponse wresp = null;
            try
            {
                //Get the response
                wresp = wr.GetResponse();
                Stream stream2 = wresp.GetResponseStream();
                StreamReader reader2 = new StreamReader(stream2);
                string responseData = reader2.ReadToEnd();
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
            finally
            {
                if (wresp != null)
                {
                    wresp.Close();
                    wresp = null;
                }
                wr = null;
            }
             */ 
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Create an  image using template 9 (blank 7.4" Portrati)
            //Obtain Security token
            /*
            String strURL = txbURL.Text + "/accounts/image/create/10";
            Uri uriCreateImage = new Uri(strURL);
            HttpWebRequest request = (HttpWebRequest)WebRequest.CreateHttp(uriCreateImage);
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(sessionID);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            CookieCollection cookies = response.Cookies;
            Cookie csrf = cookies["csrftoken"];
            //Create image
            HttpWebRequest POSTRequest = (HttpWebRequest)WebRequest.CreateHttp(uriCreateImage);
            String postData = String.Format("area0={0}&csrfmiddlewaretoken={1}", this.txbMessage.Text, csrf.Value);
            Byte[] byteArray = Encoding.ASCII.GetBytes(postData);
            POSTRequest.ContentLength = byteArray.Length;
            POSTRequest.CookieContainer = new CookieContainer();
            POSTRequest.CookieContainer.Add(sessionID);
            POSTRequest.CookieContainer.Add(csrf);
            POSTRequest.Method = WebRequestMethods.Http.Post;
            POSTRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
            POSTRequest.AllowWriteStreamBuffering = true;
            POSTRequest.ProtocolVersion = HttpVersion.Version11;
            POSTRequest.AllowAutoRedirect = false;   // Capturing sessionID needs disabling Auto Redirect 
            POSTRequest.ContentType = "application/x-www-form-urlencoded";
            System.IO.Stream newStream = POSTRequest.GetRequestStream(); //open connection
            newStream.Write(byteArray, 0, byteArray.Length); // Send the data.
            newStream.Close();
            this.lblStatus.Text = "Image has been successfully Created";
             * */
        }
        private void tabCreate_MouseClick(object sender, MouseEventArgs e)
        {
            this.lblStatus.Text = "";
            this.lblStatus.Refresh();
        }
        private void Create() {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            String strURL;
            String response;
            // Collect Devices
            strURL = txbURL.Text + "/API/templates/";
            response = HttpGET(strURL);

            if (!response.Contains('['))
                response = "[" + response + "]"; // Deserializer does not like single record without []
            var responselist = serializer.Deserialize<List<NameAndId>>(response);
            lbxTemplates.DataSource = responselist;
            lbxTemplates.DisplayMember = "name";
            lbxTemplates.ValueMember = "id";
        }
        private void Send()
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            String strURL;
            String response;
            // Collect Devices
            strURL = txbURL.Text + "/API/userdevices/";
            response = HttpGET(strURL);

            if (!response.Contains('['))
                response = "[" + response + "]"; // Deserializer does not like single record without []
            var responselistD = serializer.Deserialize<List<DeviceRecord>>(response);
            lbxDevices.Items.Clear();
            lbxDevices.DataSource = responselistD;
            lbxDevices.DisplayMember = "name";
            lbxDevices.ValueMember = "id";
            foreach (DeviceRecord item in responselistD)
            {
                Console.WriteLine(item.location);
                //lbxDevices.Items.Add(item.name);
            }
           // Collect Groupes
            strURL = txbURL.Text + "/API/userdevicegroups/";
            response = HttpGET(strURL);

            if (!response.Contains('['))
                response = "[" + response + "]"; // Deserializer does not like single record without []
            var responselistG = serializer.Deserialize<List<GroupRecord>>(response);
            foreach (GroupRecord group in responselistG)
            {
                Console.WriteLine(group.name );
                group.name = "Group:" + group.name;
                DeviceRecord dr = new DeviceRecord();
                dr.name = group.name;
                dr.id = group.id;
                //lbxDevices.Items.Add(dr);

            }
            //lbxDevices.Items.Clear();
            
            //lbxDevices.DisplayMember = "name";
            //lbxDevices.ValueMember = "id";
 
            // Collect Images
            strURL = txbURL.Text + "/API/images/";
            response = HttpGET(strURL);

            if (!response.Contains('['))
                response = "[" + response + "]"; // Deserializer does not like single record without []
            var responselistI = serializer.Deserialize<List<ImageRecord>>(response);
            foreach (ImageRecord image in responselistI)
            {
                Console.WriteLine(image.location);
                image.name=(image.location).Split('_')[1];

            }
            lbxImages.DataSource = responselistI;
            lbxImages.DisplayMember = "name";
            lbxImages.ValueMember = "id";

            strURL = txbURL.Text + "/API/timers/";
            response = HttpGET(strURL);
            if (!response.Contains('['))
                response = "[" + response + "]"; // Deserializer does not like single record without []
            var responselistT = serializer.Deserialize<List<TimerRecord>>(response);
            foreach (TimerRecord timer in responselistT)
            {
                Console.WriteLine(timer.name);
                //lbxTimers.Items.Add(timer.name);

            }
            lbxTimers.DataSource = responselistT;
            lbxTimers.DisplayMember = "name";
            lbxTimers.ValueMember = "id";

        }
        private void tabStages_Selected(object sender, TabControlEventArgs e)
        {
            Console.WriteLine(e.TabPage.Name);
            if (sessionID == null) {
                tabAuth.Select();
                tabAuth.Show();
                tabAuth.Focus();
                tabAuth.BringToFront();
                tabAuth.Refresh();
                return;
            }
            switch (e.TabPage.Name)
            {
                case "tabCreate":
                    Create();
                    break;
                case "tabSend":
                    Send();
                    break;
                case "tabUpload":
                    // call Upload function;
                    break;
                default:
                    break;
            }
            return;
            if (e.TabPage.Name != "tabCreate") return;
            String strURL = txbURL.Text + "/API/templates/";
            Uri uriCreateImage = new Uri(strURL);
            Console.WriteLine(strURL);
            HttpWebRequest request = (HttpWebRequest)WebRequest.CreateHttp(uriCreateImage);
            Console.WriteLine("Request:" + request.Address);
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(sessionID);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Encoding enc = System.Text.Encoding.ASCII;

            System.IO.StreamReader rsr = new System.IO.StreamReader(response.GetResponseStream());
            string json = rsr.ReadToEnd();
            Console.WriteLine("Response:" + json);
            Dictionary<string, string> jsonlist = Json2List(json);
            String gotit = jsonlist["ablak"];
            Console.WriteLine("J2D:" + gotit);
        }
        private Dictionary<String, String> Json2List(String jsonstream)
        {

            Dictionary<String, String> result = new Dictionary<string, string>();
            String sPattern = "?(:name)" + Regex.Escape("{") + ".*" + Regex.Escape("}" + "!");
            Match match = Regex.Match(jsonstream, sPattern);
            int index = 0;
            List<string> jlist = new List<string>(10);
            while (match.Success)
            {
                jlist.Add(match.ToString());
                Console.WriteLine(jlist[index]);
                index++;
                match = match.NextMatch();

            }
            List<string> grouplist = new List<string>();
            grouplist = Regex.Matches(jsonstream, sPattern)
                                    .Cast<Match>()
                                    .Select(m => m.Groups[0].Value)
                                    .ToList();
            string[] strArray = new string[grouplist.Count];
            for (int i = 0; i < grouplist.Count; i++)
            {
                Console.Write(i);
                Console.WriteLine(grouplist[i]);
            }
            result.Add("ablak", "ajto");
            var emailAddress = "joe@sad.com; joe@happy.com; joe@elated.com";
            List<string> emails = new List<string>();
            emails = Regex.Matches(emailAddress, @"([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})")
                            .Cast<Match>()
                            .Select(m => m.Groups[0].Value)
                            .ToList();
            for (int i = 0; i < emails.Count; i++)
                Console.WriteLine(emails[i]);
            return (result);
        }
        private void lbxImages_Click(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Console.WriteLine(lb.SelectedValue.ToString());
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            String strURL = txbURL.Text + "/API/image/" + lb.SelectedValue.ToString()+"/";
            String response = HttpGET(strURL);
            if (!response.Contains('['))
                response = "[" + response + "]"; // Deserializer does not like single record without []
            var responselistI = serializer.Deserialize<List<ImageRecord>>(response);
            lblWidth.Text = responselistI[0].width.ToString();
            lblHeight.Text = responselistI[0].height.ToString();
            lblID.Text = responselistI[0].id.ToString();
            lblExpires.Text = responselistI[0].expires;
            lblName.Text=responselistI[0].location.Split('_')[1];
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbxDevices_MouseClick(object sender, MouseEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Console.WriteLine(lb.SelectedValue.ToString());
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            String strURL = txbURL.Text + "/API/userdevice/" + lb.SelectedValue.ToString() + "/";
            String response = HttpGET(strURL);
            if (response.IndexOf('[')!=0)
                response = "[" + response + "]"; // Deserializer does not like single record without []
            var responselistD = serializer.Deserialize<List<DeviceRecord>>(response);
            lblDeviceType.Text = responselistD[0].type.ToString();
            lblDeviceID.Text = responselistD[0].id.ToString();
            lblDeviceLocaton.Text = responselistD[0].location;
            lblTimeZone.Text = responselistD[0].timezone;
            lblTimer.Text = responselistD[0].timer;
            lblDeviceName.Text = responselistD[0].name ;
        }

        private void lbxTimers_Click(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            Console.WriteLine(lb.SelectedValue.ToString());
            /*
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            String strURL = txbURL.Text + "/API/userdevice/" + lb.SelectedValue.ToString() + "/";
            String response = HttpGET(strURL);
            if (response.IndexOf('[') != 0)
                response = "[" + response + "]"; // Deserializer does not like single record without []
            var responselistD = serializer.Deserialize<List<DeviceRecord>>(response);
             */
  
            lblTimerID.Text = lb.SelectedValue.ToString();
            TimerRecord selected = (TimerRecord)lb.SelectedItem;
            lblTimerName.Text = selected.name ;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string  strURL=this.txbURL.Text +"/API/send/";
            string formParams = string.Format("userdevice={0}&image={1}&timer={2}",lbxDevices.SelectedValue , lbxImages.SelectedValue,lbxTimers.SelectedValue);
            Console.WriteLine("Params:" + formParams);
            string response = HttpPOST(strURL, formParams);
            Console.WriteLine(response);
            lblStatus.Text = response;
        }

        private void lbxTemplates_MouseClick(object sender, MouseEventArgs e)
        {
            string strURL = this.txbURL.Text + "/API/create/"+lbxTemplates.SelectedValue.ToString()+"/";
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            String response = HttpGET(strURL);
            if (response.IndexOf('[') != 0)
                response = "[" + response + "]"; // Deserializer does not like single record without []
            var responselist = serializer.Deserialize<List<TemplateRecord>>(response);
            string name;
            int index;
            foreach (TemplateRecord area in responselist)
            {
                name = area.name;
                this.tabCreate.Controls.Add(new System.Windows.Forms.TextBox());
                Console.WriteLine(area.name);
                /*
                this.txbUser.Location = new System.Drawing.Point(69, 33);
                this.txbUser.Name = "txbUser";
                this.txbUser.Size = new System.Drawing.Size(100, 20);
                this.txbUser.TabIndex = 1;
                this.txbUser.Text = "clugosi@densipaper";
                */
            }
        }
}
    }