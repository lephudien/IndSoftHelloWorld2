using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerClientComm
{
  public class ServerClientComm
  {
    public static string GetMyVersion()
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      return "ServerClientComm2 Ver=" + fvi.FileVersion;
    }
  }
}
