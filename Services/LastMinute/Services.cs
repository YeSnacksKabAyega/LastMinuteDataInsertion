using Models.Helper;
using Models.LastMinute;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.LastMinute
{
    public class Services : IServices
    {
        Helper helper = new Helper();
        public BaseJsonResponse SaveSearch(List<Search> searchList)
        {
            BaseJsonResponse baseJsonResponse = new BaseJsonResponse();
            try
            {
                if (searchList.Count() > 0)
                {
                    DataTable Dt = helper.ToDataTable(searchList);
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["lastMinuteConString"].ConnectionString);

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "InsertStudentDetails";//sp name 
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@DetailInsersion", Dt);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    baseJsonResponse.IsSucess = true;
                    baseJsonResponse.statuscode = "200";
                    baseJsonResponse.message = "Serach Not Found";
                }
                
            }
            catch(Exception ex)
            {
                baseJsonResponse.IsSucess = false;
                baseJsonResponse.statuscode = "404";
                baseJsonResponse.message = ex.Message;
            }
            return baseJsonResponse;
        }
    }
}
