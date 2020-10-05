using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdapterFile2.Binary
{
  public class BinaryRW
  {
    public static string GetMyVersion()
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      Version version = Assembly.GetAssembly(typeof(Google.Apis.Logging.ConsoleLogger)).GetName().Version;

      //return $"AdapterDB.OracleVer={fvi.FileVersion}{Environment.NewLine}Using EXTERNAL OracleVer{version.ToString()}";

      
      return $"AdapterFile.Binary Ver={fvi.FileVersion}{Environment.NewLine}Using EXTERNAL Google.Apis Ver{version.ToString()}";
    }
  }
}
