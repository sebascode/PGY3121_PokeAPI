using Oracle.ManagedDataAccess.Client;

// See https://aka.ms/new-console-template for more information

string conString = "User Id=pokeuser;Password=Asdf1234aa__;Data Source=jhckgtvr8s8pz86s_high;"
                          + "Connection Timeout=30;";

OracleConfiguration.TnsAdmin = "/Users/scode/Projects/PokeAPP/PokeAPP.Consola/Wallet";
OracleConfiguration.WalletLocation = OracleConfiguration.TnsAdmin;

OracleConnection connection = new OracleConnection(conString);
OracleCommand command = connection.CreateCommand();

connection.Open();

Console.WriteLine("La base de datos de virus ha sido actualizada.");

command.CommandText = "SELECT id_ataque, nombre FROM ataque";OracleXmlCommandType-

OracleDataReader reader = command.ExecuteReader();
while (reader.Read())
    Console.WriteLine(
        reader.GetInt32(0) + " - " + reader.GetString(1)
        );

Console.WriteLine("Comando ejecutado;");

connection.Close();