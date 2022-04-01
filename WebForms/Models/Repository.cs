using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace WebForms.Models
{
    public class Repository
    {
        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;


        public static bool ProvjeraUspjesnostiLogiranja(string email, string lozinka)
        {

            try
            {
                DataRow row = SqlHelper.ExecuteDataset(cs, "CheckLogin", email, lozinka).Tables[0].Rows[0];
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }
    }
}