using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms
{
    public partial class ShowData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Uspjeh"] == null || (string) Session["Uspjeh"] == "Neuspjeh")
            {
                Response.Redirect("Login.aspx");
            }


            if (IsPostBack)
            {

                try
                {
                    int brojStranica = int.Parse(DropDownList3.SelectedValue);
                    GridView1.PageSize = brojStranica;

                }
                catch (Exception)
                {

                    GridView1.PageSize = 10;

                }

            }
        }
    }
}