using System;
using System.Data.OleDb;

class CommandExam {
  static OleDbConnection cn;

  public static void Main() {
    cn = new OleDbConnection(@"Provider=OraOLEDB.Oracle;
                               data source=topcredu;
                               User ID = scott; Password = tiger");
    cn.Open();
    Output("The Original Table");

    try {
      string sql = "INSERT INTO emp (empno, ename) VALUES (888, 'OJC')";
      int rowsadded = new OleDbCommand(sql, cn).ExecuteNonQuery();
      Console.WriteLine("Number of rows added: " + rowsadded);
      Output("Added Table");
    } catch (Exception e) {
      Console.WriteLine(e);
    }
   
    try {
      string sql = "UPDATE emp SET ename = '오닷넷' WHERE empno = 888";
      int rows = new OleDbCommand(sql, cn).ExecuteNonQuery();
      Console.WriteLine("Number of rows modified: " + rows);
      Output("Modified Table");
    } catch (Exception e) {
      Console.WriteLine(e);
    }

    try {
      string sql = "DELETE FROM emp WHERE empno = 888 ";
      int rows = new OleDbCommand(sql, cn).ExecuteNonQuery();
      Console.WriteLine("Number of rows deleted: " + rows);
      Output("Deleted Table");
    } catch (Exception e) {
      Console.WriteLine(e);
    }
    
    cn.Close();
  }

  static void Output(string title) {
    string sql = "SELECT empno id, ename name FROM emp order by id";
    OleDbDataReader dr = new OleDbCommand(sql, cn).ExecuteReader();
    Console.WriteLine(title + ":");
    while (dr.Read()) {
      Console.WriteLine("{0, -10}\t{1, -10}",
                        dr[0].ToString().Trim(), dr[1].ToString().Trim());
    }
    Console.WriteLine();
    dr.Close();
  }
}