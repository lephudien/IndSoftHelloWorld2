using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerChildText2
{
  public class LogText
  {
    public static string GetMyVersion()
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      return $"LoggerChildText Ver={fvi.FileVersion}{Environment.NewLine}Using {AdapterFile2.Text.TextRW.GetMyVersion()}";
    }
  }
}
