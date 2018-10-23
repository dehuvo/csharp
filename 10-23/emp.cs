using System;
using Oracle.ManagedDataAccess.Client;

namespace ConsoleApplication7 {
  class Program {
    static void Main() {
      string str = @"data source=
        (DESCRIPTION =
          (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
          (CONNECT_DATA =
            (SERVER = DEDICATED)
            (SERVICE_NAME = topcredu)
          )
        ); user id=scott; password=tiger";
//      string str = "data source=topcredu;user id=scott; password=tiger";

      OracleCommand command = new OracleCommand();
      OracleConnection connection = command.Connection = new OracleConnection(str);
      try {
        connection.Open();
        command.CommandText = "SELECT ENAME FROM EMP";
        OracleDataReader reader = command.ExecuteReader();
        while (reader.Read()) {
          Console.WriteLine(reader.GetString(reader.GetOrdinal("ENAME")));
        }
      } catch (Exception e) {
        Console.WriteLine(e.ToString());
      } finally {
        connection.Close();
      }
    }
  }
}
// csc /r:%ORACLE_HOME%\ODP.NET\bin\2.x\Oracle.DataAccess.dll emp.cs