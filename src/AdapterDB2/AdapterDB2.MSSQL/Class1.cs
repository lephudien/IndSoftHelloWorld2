using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDB2.MSSQL
{
  public class ReadFromDB
  {
    public static string GetMyVersion()
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      Version version = Assembly.GetAssembly(typeof(System.Data.SqlClient.SqlAuthenticationMethod)).GetName().Version;

      return $"AdapterDB.MSSQLVer={fvi.FileVersion}{Environment.NewLine}Using EXTERNAL MSSQLClientVer{version.ToString()}";
    }
  }
}
