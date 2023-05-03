using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZohoApi
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void SwitchPlaces(object sender, EventArgs e)
        {
            Submit.Visible = false;

            Response.Redirect("https://accounts.zoho.in/oauth/v2/auth?scope=ZohoBooks.fullaccess.all&client_id=1000.IISO9SI16PL5BNUE3XTCRGG7VPY9SY&response_type=code&redirect_uri=https://localhost:44378/GrandToken");
        }
    }
}