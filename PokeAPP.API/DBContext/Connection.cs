using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
namespace PokeAPP.API.DBContext
{
	public class Connection
	{
        string connectionString = "User Id=pokeuser;Password=Asdf1234aa__;Data Source=jhckgtvr8s8pz86s_high;"
                          + "Connection Timeout=30;";

        public Connection()
        {
            OracleConfiguration.TnsAdmin = @"Wallet";
            OracleConfiguration.WalletLocation = OracleConfiguration.TnsAdmin;
        }

        public Connection(string conn)
        {
            this.connectionString = conn;
        }

        public DataTable Execute(string SQL)
        {
            using (OracleConnection con = new OracleConnection(this.connectionString))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        con.Open();
                        Console.WriteLine("Successfully connected to Oracle Autonomous Database");
                        Console.WriteLine();

                        cmd.CommandText = SQL;
                        OracleDataReader reader = cmd.ExecuteReader();
                        var dt = new DataTable();
                        dt.Load(reader);
                        con.Close();
                        return dt;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    con.Close();
                    return new DataTable();
                }
            }
        }


	}
}