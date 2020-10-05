using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChildDB
{
  public class LogDB
  {
    public static string GetMyVersion()
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      return $"LoggerChildDB Ver={fvi.FileVersion}{Environment.NewLine}Using {AdapterDB2.MSSQL.ReadFromDB.GetMyVersion()}{Environment.NewLine}Using {AdapterDB2.Oracle2.ReadFromDB.GetMyVersion()}";
    }
  }
}
