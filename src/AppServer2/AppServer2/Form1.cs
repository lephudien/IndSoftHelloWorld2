using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppServer2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

      System.Windows.Forms.MessageBox.Show($"AppServer2 Ver={fvi.FileVersion}{Environment.NewLine}Using {ServerClientComm.ServerClientComm.GetMyVersion()}" +
                                          $"{Environment.NewLine}Using {LoggerChildDB.LogDB.GetMyVersion()}" +
                                          $"{Environment.NewLine}Using {LoggerChildBinary.LogBinary.GetMyVersion()}" +
                                          $"{Environment.NewLine}Using {CommModule2Core.CommCore.GetMyVersion()}");
    }
  }
}
