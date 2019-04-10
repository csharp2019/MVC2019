using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ado_net_spajanje_na_bazu.Controllers
{
    public class SqlCommandObjektController : Controller
    {
        // GET: SqlCommandObjekt
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            // Prvo kreiramo conn string
            // string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";
            string connString = ConfigurationManager.ConnectionStrings["dbAlgebraConnString"].ConnectionString;
            // Nakon toga instanca Sqlconnection
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdTxt = "";
                cmdTxt += "INSERT INTO [dbo].[tbltecajevi] ( [naziv], [opis]) " +
                    "VALUES ('Web design','Naucite kreirati web stranice')";

                SqlCommand cmd = new SqlCommand(cmdTxt, conn);
                cmd.Connection.Open();

                int brojRedaka = cmd.ExecuteNonQuery();

                if (brojRedaka > 0)
                {
                    ViewBag.Message = "Zapis je u bazi!";
                }
                else
                {
                    ViewBag.Message = "Zapis je u bazi!";
                }
            }
            return View("Index");
        }
        public ActionResult Edit()
        {
            // Prvo kreiramo conn string
            // string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";
            string connString = ConfigurationManager.ConnectionStrings["dbAlgebraConnString"].ConnectionString;
            // Nakon toga instanca Sqlconnection
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdTxt = "";
                cmdTxt += "UPDATE [dbo].[tbltecajevi] "
                    +"  SET " 
                    +"[naziv] = 'Web Dev',"
                    +"[opis] ='Web development' "
                    + " WHERE [dbo].[tbltecajevi].id=1";

                SqlCommand cmd = new SqlCommand(cmdTxt, conn);
                cmd.Connection.Open();

                int brojRedaka = cmd.ExecuteNonQuery();

                if (brojRedaka > 0)
                {
                    ViewBag.Message = "Zapis je izmjenjen u bazi!";
                }
                else
                {
                    ViewBag.Message = "Zapis nije pronadjen ili nije izmjenjen";
                }
            }
            return View("Index");
        }
        public ActionResult Delete()
        {
            // Prvo kreiramo conn string
            // string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";
            string connString = ConfigurationManager.ConnectionStrings["dbAlgebraConnString"].ConnectionString;
            // Nakon toga instanca Sqlconnection
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdTxt = "";
                cmdTxt += "DELETE FROM [dbo].[tbltecajevi] "
                    + " WHERE [dbo].[tbltecajevi].id=2";

                SqlCommand cmd = new SqlCommand(cmdTxt, conn);
                cmd.Connection.Open();

                int brojRedaka = cmd.ExecuteNonQuery();

                if (brojRedaka > 0)
                {
                    ViewBag.Message = "Zapis je obrisan u bazi!";
                }
                else
                {
                    ViewBag.Message = "Zapis nije pronadjen ili nije obrisan";
                }
            }
            return View("Index");
        }
        public ActionResult Count()
        {
            // Prvo kreiramo conn string
            // string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlgebra;Integrated Security=True";
            string connString = ConfigurationManager.ConnectionStrings["dbAlgebraConnString"].ConnectionString;
            // Nakon toga instanca Sqlconnection
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string cmdTxt = "";
                cmdTxt += "SELECT count(*) FROM [dbo].[tbltecajevi] ";

                SqlCommand cmd = new SqlCommand(cmdTxt, conn);
                cmd.Connection.Open();

                // vraća prvi redak, u ovom slucaju samo broj zapisa
                int brojRedaka = (int)cmd.ExecuteScalar();

                if (brojRedaka > 0)
                {
                    ViewBag.Message = "U tablici se nalazi "+ brojRedaka+" zapisa";
                }
                else
                {
                    ViewBag.Message = "Tablica je prazna";
                }
            }
            return View("Index");
        }
    }
}