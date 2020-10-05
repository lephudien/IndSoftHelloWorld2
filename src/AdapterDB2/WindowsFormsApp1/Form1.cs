using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

      //var test = new Oracle.ManagedDataAccess.Client.OracleConnection();
      //var assemblies = System.Reflection.Assembly.GetExecutingAssembly().GetReferencedAssemblies();
      Version version = Assembly.GetAssembly(typeof(Oracle.ManagedDataAccess.Client.OracleConnection)).GetName().Version;

      System.Windows.Forms.MessageBox.Show($"TestNuget3Ver: {fvi.FileVersion}{Environment.NewLine}Using Oracle version: {version.ToString()}");
    }
  }
}
