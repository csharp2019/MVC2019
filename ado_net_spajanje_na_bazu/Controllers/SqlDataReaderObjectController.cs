using ado_net_spajanje_na_bazu.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using System.m

namespace ado_net_spajanje_na_bazu.Controllers
{
    public class SqlDataReaderObjectController : Controller
    {
        // GET: SqlDataReaderObject
        public ActionResult Index()
        {
            // Prvo kreiramo conn string
            // string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";
            string connString = ConfigurationManager.ConnectionStrings["dbAlgebraConnString"].ConnectionString;

            // pripremimi praznu listu tecajeva
            List<Tecaj> lstTecaj = new List<Tecaj>();


            // Nakon toga instanca Sqlconnection
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdTxt = "";
                cmdTxt += "SELECT * FROM [dbo].[tbltecajevi] ";

                SqlCommand cmd = new SqlCommand(cmdTxt, conn);
                cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Tecaj t1 = new Tecaj();

                        t1.Id = (int)reader["id"];
                        t1.Naziv = (string)reader["naziv"];
                        t1.Opis = (string)reader["opis"];

                        lstTecaj.Add(t1);
                    }
                    
                }
                else
                {
                    ViewBag.Message = "Zapis nije pronadjen ili nije izmjenjen";
                }
            }
            return View("Index",lstTecaj);
        }
    }
}