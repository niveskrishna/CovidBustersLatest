using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace Hackathon.Models
{
    public interface ILoginHelper
    {
         int RegisterUser(string userName, string Password);
        Boolean AuthenticateUser(string userName, string password);
    }

    public class LoginHelper: ILoginHelper
    {
        private OleDbConnection _oleDbConnection;
        private OleDbCommand _oleDbCommand;
        public LoginHelper()
        {
            _oleDbConnection = new OleDbConnection();
        }

        public int RegisterUser(string userName,string password)
        {
            try
            {
                // _oleDbConnection.ConnectionString = "jdbc:db2://dashdb-txn-sbox-yp-lon02-02.services.eu-gb.bluemix.net:50001/BLUDB:user=vnj78638;;sslConnection=true;provider=IBMDADB2;";
                _oleDbConnection.ConnectionString = "Provider=DB2OLEDB;Network Transport Library=TCPIP;Network Address=159.122.202.228;Initial Catalog=BLUDB;Package Collection=MyPkgCol;Default Schema=VNJ78638;User ID=vnj78638;Password=Tanenbaum@1991;";


                _oleDbConnection.Open();
                _oleDbCommand = _oleDbConnection.CreateCommand();
                _oleDbCommand.CommandType = CommandType.Text;
                _oleDbCommand.CommandTimeout = 300;
                _oleDbCommand.CommandText = "";
                _oleDbCommand.CommandText = "INSERT INTO Login ( USERNAME, PASSWORD) VALUES (@USERNAME,@PASSWORD)";
                _oleDbCommand.Parameters.AddWithValue("@USERNAME", userName);
                _oleDbCommand.Parameters.AddWithValue("@PASSWORD",password);
                return  _oleDbCommand.ExecuteNonQuery();

                
            }
            catch (Exception ex)
            {
                return -1;
            }

            finally 
            {
                _oleDbCommand.Dispose();
                _oleDbConnection.Dispose();
            }

        }


        public Boolean AuthenticateUser(string userName,string password)
        {
            return false;
        }
    
    
    }
}
