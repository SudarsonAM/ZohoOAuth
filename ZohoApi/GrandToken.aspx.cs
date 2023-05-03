using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ZohoApi
{
    public partial class GrandToken : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        public async void GetToken(object sender, EventArgs e)
        {
            
            string code= Request.QueryString["code"];

            var client = new HttpClient();
            string url = "https://accounts.zoho.in/oauth/v2/token?code=" + code + "&scope=ZohoBooks.fullaccess.all&client_id=1000.IISO9SI16PL5BNUE3XTCRGG7VPY9SY&client_secret=ec271eb0f2d874e60c748f0f94dd3b8dd79e6ac2a5&redirect_uri=https://localhost:44378/GrandToken&grant_type=authorization_code";
            var request = new HttpRequestMessage(HttpMethod.Post, url );
            request.Headers.Add("Cookie", "stk=b8125c5d6b700215b360951a1f12f196; 6e73717622=0a441c9555fcf55880092cb5b73efff1; _zcsr_tmp=1eded720-88f7-4da3-b79e-6e794f44af85; iamcsr=1eded720-88f7-4da3-b79e-6e794f44af85");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string jsonResponse=await response.Content.ReadAsStringAsync();
            dynamic responseObj = JsonConvert.DeserializeObject<dynamic>(jsonResponse);
            string accessToken = responseObj.access_token;

            //Response.Write(code);
            //Response.Write("\n" + accessToken);
            ans1.Text=code;
            ans2.Text=accessToken;
            ans3.Text = jsonResponse;
        }
    }
}