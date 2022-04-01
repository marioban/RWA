﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms.Models;

namespace WebForms
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Uspjeh"] != null && (string)Session["Uspjeh"] == "Uspjeh")
            {
                Response.Redirect("ShowData.aspx");
            }

            if (IsPostBack)
            {

                var email = txtEmail.Value;
                var lozinka = txtPw.Value;

                if (Repository.ProvjeraUspjesnostiLogiranja(email, lozinka))
                {
                    lblUspjeh.InnerText = "Uspješno ste logirani!";
                    Session["Uspjeh"] = "Uspjeh";
                    Response.Redirect("ShowData.aspx");

                }
                else
                {
                    Session["Uspjeh"] = "Neuspjeh";
                    lblUspjeh.InnerText = "Pogrešni podaci!";

                }
            }
        }
    }
}