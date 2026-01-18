using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Optimizor
{
  public partial class UsernameFinderForm : Form
  {
    public UsernameFinderForm()
    {
      InitializeComponent();
    }
    MainForm mf = new MainForm();
    private void DriveDetailsForm_Load(object sender, EventArgs e)
    {

    }

    private void buttonPopulate_Click(object sender, EventArgs e)
    {

      string userNameString = Environment.UserName; 
      string[] parts = userNameString.Split('\\');
      if (parts.Length > 1)
      {
        string domainName = parts[0];
        string userName = parts[1];
      }
      else
      {
        string userName = parts[0];
      }
    }
  }
}
