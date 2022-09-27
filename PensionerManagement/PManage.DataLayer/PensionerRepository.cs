using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using PManage.Entities;


namespace PManage.DataLayer
{
    public class PensionerRepository

    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FinalDatabaseConn"].ConnectionString);
        SqlCommand command = null;
        public void AddPension(Pensioner pensioner)
        {
            try
            {

                command = new SqlCommand($"insert into Pensioner values({pensioner.PensionerID},'{pensioner.AadharID}','{pensioner.Names}',{pensioner.Age},'{pensioner.Gender}','{pensioner.Address}','{pensioner.MobileNo}','{pensioner.BankName}','{pensioner.AccountNumber}','{pensioner.PensionAmount}','{pensioner.Reason}')",connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }

        }
        public void DeletePensioner(int PensionerID)
        {
            try 
            {
                command = new SqlCommand($"Delete from Pensioner where PensionerID={PensionerID} ", connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }


        }
        public void UpdatePensioner(Pensioner pensioner)
        {

            try
            {
                command = new SqlCommand($"Update Pensioner set Names='{pensioner.Names}',Age='{pensioner.Age}',Gender='{pensioner.Gender}',Address='{pensioner.Address}',MobileNo='{pensioner.MobileNo}',PensionAmount='{pensioner.PensionAmount}',Reason='{pensioner.Reason}' where PensionerID={ pensioner.PensionerID} ", connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public Pensioner GetPensionerById(int PensionerID)
        {
            try
            {
                Pensioner pensioner = null;
                command = new SqlCommand($"select *from Pensioner where PensionerID={PensionerID}", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    pensioner = new Pensioner();
                    pensioner.PensionerID = (int)reader["PensionerID"];
                    pensioner.AadharID = reader["AadharID"].ToString();
                    pensioner.Names = reader["Names"].ToString();
                    pensioner.Age = (int)reader["Age"];
                    pensioner.Gender = reader["Gender"].ToString();
                    pensioner.Address = reader["Address"].ToString();
                    pensioner.MobileNo = reader["MobileNo"].ToString();
                    pensioner.BankName = reader["BankName"].ToString();
                    pensioner.AccountNumber = reader["AccountNumber"].ToString();
                    pensioner.PensionAmount = reader["PensionAmount"].ToString();
                    pensioner.Reason = reader["Reason"].ToString();

                }
                return pensioner;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Pensioner> GetAllPensioners()
        {
            try
            {
                List<Pensioner> pensioners = new List<Pensioner>();
                command=new SqlCommand($"select *from Pensioner",connection); 
                connection.Open();
                SqlDataReader reader=command.ExecuteReader();
                while(reader.Read())
                {
                    Pensioner pensioner = new Pensioner();
                    pensioner = new Pensioner();
                    pensioner.PensionerID = (int)reader["PensionerID"];
                    pensioner.AadharID = reader["AadharID"].ToString();
                    pensioner.Names = reader["Names"].ToString();
                    pensioner.Age = (int)reader["Age"];
                    pensioner.Gender = reader["Gender"].ToString();
                    pensioner.Address = reader["Address"].ToString();
                    pensioner.MobileNo = reader["MobileNo"].ToString();
                    pensioner.BankName = reader["BankName"].ToString();
                    pensioner.AccountNumber = reader["AccountNumber"].ToString();
                    pensioner.PensionAmount = reader["PensionAmount"].ToString();
                    pensioner.Reason = reader["Reason"].ToString();
                    pensioners.Add(pensioner);

                }
                return pensioners;


            }
            catch (Exception)
            {

                throw;
            }
        }

    }

}
