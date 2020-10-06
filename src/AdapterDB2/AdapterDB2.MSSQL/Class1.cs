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
      Version version2 = Assembly.GetAssembly(typeof(log4net.Config.BasicConfigurator)).GetName().Version;

      return $"AdapterDB2.MSSQL Ver={fvi.FileVersion}" +
            $"{Environment.NewLine}Using EXTERNAL MSSQLClientVer {version.ToString()}" + 
            $"{Environment.NewLine}Using EXTERNAL Log4Net {version2.ToString()}";
    }
  }
}
