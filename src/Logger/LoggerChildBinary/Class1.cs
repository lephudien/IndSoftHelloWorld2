using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChildBinary
{
  public class LogBinary
  {
    public static string GetMyVersion()
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      return $"LoggerChildBinary Ver={fvi.FileVersion}{Environment.NewLine}Using {AdapterFile2.Binary.BinaryRW.GetMyVersion()}";
    }
  }
}
