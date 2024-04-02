using MovInfoService_CMD.MODEL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovInfoService_CMD
{
    public class DbOperation
    {
        public void Exec_mov_sp_check_udcDetail(string TrackingCode)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ItaltonContext"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand()) 
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "mov_sp_check_udcDetail";
                    //Parametri di input
                    cmd.Parameters.AddWithValue("@trackingcode", TrackingCode);
                    cmd.Parameters["@trackingcode"].Direction = ParameterDirection.Input;
                    //Parametri di output
                    cmd.Parameters.Add("@IdDettUDC", SqlDbType.Int);
                    cmd.Parameters["@IdDettUDC"].Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@errormsg", SqlDbType.VarChar, -1);
                    cmd.Parameters["@errormsg"].Direction = ParameterDirection.Output;

                    try
                    {
                        conn.Open();
                        int i = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore esecuzione store procedure mov_sp_check_udcDetail. Errore: {ex.Message}");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        public void Exec_mov_sp_insert_mov_tracking_udc(string trackingCode, int operazione, string cdl, int erpId, string opt1, string opt2,int qta)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ItaltonContext"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "mov_sp_insert_mov_tracking_udc";
                    //Parametri di input
                    cmd.Parameters.AddWithValue("@trackingcode", trackingCode);
                    cmd.Parameters["@trackingcode"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@Operazione", operazione);
                    cmd.Parameters["@Operazione"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@CdlOrigine", cdl);
                    cmd.Parameters["@CdlOrigine"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@ErpID", erpId);
                    cmd.Parameters["@ErpID"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@option1", opt1);
                    cmd.Parameters["@option1"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@option2", opt2);
                    cmd.Parameters["@option2"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@Qta", qta);
                    cmd.Parameters["@Qta"].Direction = ParameterDirection.Input;
                    cmd.Parameters.Add("@id", SqlDbType.Int);
                    //Parametri di output
                    cmd.Parameters.Add("@id", SqlDbType.Int);
                    cmd.Parameters["@id"].Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@errormsg", SqlDbType.VarChar, -1);
                    cmd.Parameters["@errormsg"].Direction = ParameterDirection.Output;

                    try
                    {
                        conn.Open();
                        int i = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore esecuzione store procedure mov_sp_insert_mov_tracking_udc. Errore: {ex.Message}");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        public void Exec_mov_sp_check_AckReceived(string TrackingCode/*, int Operazione*/)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ItaltonContext"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "mov_sp_check_AckReceived";
                    //Parametri di input
                    cmd.Parameters.AddWithValue("@trackingcode", TrackingCode);
                    cmd.Parameters["@trackingcode"].Direction = ParameterDirection.Input;
                    //cmd.Parameters.AddWithValue("@operazione", Operazione);
                    //cmd.Parameters["@operazione"].Direction = ParameterDirection.Input;
                    //Parametri di output
                    cmd.Parameters.Add("@errormsg", SqlDbType.VarChar, -1);
                    cmd.Parameters["@errormsg"].Direction = ParameterDirection.Output;
                    try
                    {
                        conn.Open();
                        int i = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore esecuzione store procedure mov_sp_check_AckReceived. Errore: {ex.Message}");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        public void Exec_mov_sp_check_udcDetail_flSing(string TrackingCode)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ItaltonContext"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "mov_sp_check_udcDetail_flSing";
                    //Parametri di input
                    cmd.Parameters.AddWithValue("@trackingcode", TrackingCode);
                    cmd.Parameters["@trackingcode"].Direction = ParameterDirection.Input;
                    //Parametri di output
                    cmd.Parameters.Add("@errormsg", SqlDbType.VarChar, -1);
                    cmd.Parameters["@errormsg"].Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@IdDettUDC", SqlDbType.Int);
                    cmd.Parameters["@IdDettUDC"].Direction = ParameterDirection.Output;
                    try
                    {
                        conn.Open();
                        int i = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore esecuzione store procedure mov_sp_check_udcDetail_flSing. Errore: {ex.Message}");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        public Tuple<int, string> Exec_sp_LabelPrinterRequest(string param, string printer)
        {
            int idLabel = 0;
            string error = "";
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["ItaltonContext"].ConnectionString;
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_LabelPrinterRequest";
                    //Parametri di input
                    cmd.Parameters.AddWithValue("@parametro", param);
                    cmd.Parameters["@parametro"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@PrinterName", printer);
                    cmd.Parameters["@PrinterName"].Direction = ParameterDirection.Input;
                    //Parametri di output
                    cmd.Parameters.Add("@idLabel", SqlDbType.Int);
                    cmd.Parameters["@idLabel"].Direction = ParameterDirection.InputOutput;
                    cmd.Parameters.Add("@errormsg", SqlDbType.VarChar, -1);
                    cmd.Parameters["@errormsg"].Direction = ParameterDirection.InputOutput;
                    try
                    {
                        conn.Open();
                        int i = cmd.ExecuteNonQuery();
                        idLabel = Convert.ToInt32(cmd.Parameters["@idLabel"].Value);
                        error = Convert.ToString(cmd.Parameters["@errormsg"].Value);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore esecuzione store procedure sp_LabelPrinterRequest. Errore: {ex.Message}");
                    }
                    finally
                    {
                        conn.Close();
                    }
                    return new Tuple<int, string>(idLabel, error);
                }
            }
        }


        #region STORE PROCEDURE NON UTLIZZATE
        public void Exec_mov_sp_check_udcMagDetail(string TrackingCode)
        {
            int IdDettUDC = 0;
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ItaltonContext"].ConnectionString;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "mov_sp_check_udcMagDetail";
            cmd.Parameters.AddWithValue("@trackingcode", TrackingCode);
            cmd.Parameters["@trackingcode"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@IdDettUDC", SqlDbType.Int);
            cmd.Parameters["@IdDettUDC"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("@errormsg", SqlDbType.VarChar, -1);
            cmd.Parameters["@errormsg"].Direction = ParameterDirection.Output;

            try
            {
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                if (cmd.Parameters["@IdDettUDC"].Value != DBNull.Value)
                    IdDettUDC = Convert.ToInt32(cmd.Parameters["@IdDettUDC"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore esecuzione store procedure mov_sp_check_udcMagDetail. Errore: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        public Tuple<int, string> Exec_sp_InfoService_Insert_mov_tracking_udc(string TrackingCode, int Operazione, string CDLOrigine, int ERPOrderID, int Qta)
        {
            int Id = 0;
            string error = "";
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["ItaltonContext"].ConnectionString;
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_InfoService_Insert_mov_tracking_udc";

            cmd.Parameters.AddWithValue("@trackingcode", TrackingCode);
            cmd.Parameters["@trackingcode"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Operazione", Operazione);
            cmd.Parameters["@Operazione"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@CdlOrigine", CDLOrigine);
            cmd.Parameters["@CdlOrigine"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@ErpOrderID", ERPOrderID);
            cmd.Parameters["@ErpOrderID"].Direction = ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@Qta", Qta);
            cmd.Parameters["@Qta"].Direction = ParameterDirection.Input;

            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Direction = ParameterDirection.InputOutput;
            cmd.Parameters.Add("@errormsg", SqlDbType.VarChar, -1);
            cmd.Parameters["@errormsg"].Direction = ParameterDirection.InputOutput;

            try
            {
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                Id = Convert.ToInt32(cmd.Parameters["@id"].Value);
                error = Convert.ToString(cmd.Parameters["@errormsg"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore esecuzione store procedure sp_InfoService_Insert_mov_tracking_udc. Errore: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
            return new Tuple<int, string>(Id, error);
        }

        public void SetProcessedMovUDCMagDetail(string TrackingCode)
        {
            using (var db = new ItaltonContext())
            {
                var MagUDCDet = db.mov_UDCMagDetail.FirstOrDefault(z => z.trackingcode == TrackingCode);
                MagUDCDet.DtProcessingDate = DateTime.Now;
                db.mov_UDCMagDetail.AddOrUpdate(MagUDCDet);
                db.SaveChanges();
            }
        }
        #endregion
    }
}
