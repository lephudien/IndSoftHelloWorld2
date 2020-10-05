using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CommModule2Core
{
  public class CommCore
  {
    public static string GetMyVersion()
    {
      //int a = Common.Constants.CONSTANTY.C_NEJAKA_VERZE;
      //var test = new Oracle.ManagedDataAccess.Client.OracleConnection();
      //Debug.Assert(test == null);
      //var test2 = new NUnit.Framework.Constraints.AndOperator();

      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      Version version = Assembly.GetAssembly(typeof(SimpleTCP.Server.TcpListenerEx)).GetName().Version;

      return $"AdapterDB.Oracle Ver={fvi.FileVersion}{Environment.NewLine}Using EXTERNAL SimpleTCP Ver{version.ToString()}";
    }
  }
}
