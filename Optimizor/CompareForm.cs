using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optimizor
{
  public partial class CompareForm : Form
  {
    public CompareForm()
    {
      InitializeComponent();
    }
    MainForm mainForm = new MainForm();
    private void CompareForm_Load(object sender, EventArgs e)
    {
      chart1.Series["Series1"].Points.AddXY("Used Space", mainForm.usedSpaceBeforeOpti);
      chart1.Series["Series1"].Points.AddXY("Free Space", mainForm.freeSpaceBeforeOpti);

      chart2.Series["Series1"].Points.AddXY("Used Space", mainForm.usedSpaceAfterOpti);
      chart2.Series["Series1"].Points.AddXY("Free Space", mainForm.freeSpaceAfterOpti);
    }
  }
}
