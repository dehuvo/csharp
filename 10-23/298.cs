using System;
using System.Data.OleDb;

class CommandExam {
  static OleDbConnection cn;

  public static void Main() {
    OleCn();
    cn.Open();
    Output("The Original Table");

    Adding(); 
    Output("Added Table");

    Modifying(); 
    Output("Modified Table");

    Deleting(); 
    Output("Deleted Table");
    cn.Close();
  }

  public static void OleCn() {
    cn = new OleDbConnection(@"Provider=OraOLEDB.Oracle;
                               data source=topcredu;
                               User ID = scott; Password = tiger");
  }

  public static void Output(string title) {
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

  public static void Adding() {
    try {
      string sql = "INSERT INTO emp (empno, ename) VALUES (888, 'OJC')";
      int rowsadded = new OleDbCommand(sql, cn).ExecuteNonQuery();
      Console.WriteLine("Number of rows added: " + rowsadded);
    } catch (Exception e) {
      Console.WriteLine(e);
    }
  }

  public static void Modifying() {
    try {
      string sql = "UPDATE emp SET ename = '오닷넷' WHERE empno = 888";
      int rows = new OleDbCommand(sql, cn).ExecuteNonQuery();
      Console.WriteLine("Number of rows modified: " + rows);
    } catch (Exception e) {
      Console.WriteLine(e);
    }
  }

  public static void Deleting() {
    try {
      string sql = "DELETE FROM emp WHERE empno = 888 ";
      int rows = new OleDbCommand(sql, cn).ExecuteNonQuery();
      Console.WriteLine("Number of rows deleted: " + rows);
    } catch (Exception e) {
      Console.WriteLine(e);
    }
  }
}