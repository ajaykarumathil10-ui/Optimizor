using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Zuby.ADGV;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Optimizor
{
  public partial class MainForm : Form
  {

    #region Declarations
    string usernameCreds = "";
    bool isValidated = false;
    string directoryPathTemp1 = "";
    string directoryPathTemp2 = @"C:\Windows\Temp\";
    string Prefetch = @"C:\Windows\Prefetch\";
    string WindowsUpdate = @"C:\Windows\SoftwareDistribution";
    string InternetFiles = "";
    string Thumbails = "";
    List<string> KillList = new List<string>();
    List<string> KilledProcess = new List<string>();
    List<string> DeleteList = new List<string>();
    public DriveInfo[] drives = DriveInfo.GetDrives();
    delegate void SetTextCallback(string text);
    bool ifblock = true;
    public double usedSpaceBeforeOpti;
    public double usedSpaceAfterOpti;
    public double freeSpaceBeforeOpti;
    public double freeSpaceAfterOpti;
    public bool onlyTask = false;
    public bool onlyCache = false;
    enum RecycleFlags : int
    {
      SHRB_NOCONFIRMATION = 0x00000001, // Don't ask for confirmation
      SHRB_NOPROGRESSUI = 0x00000001, // Don't show progress
      SHRB_NOSOUND = 0x00000004 // Don't make sound when the action is executed
    }

    [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
    static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);

    public enum SizeUnits
    {
      Byte, KB, MB, GB, TB, PB, EB, ZB, YB
    }

    #endregion
    public MainForm()
    {
      InitializeComponent();
      if (backgroundWorkerCacheKiller.IsBusy == true)
      {
        backgroundWorkerCacheKiller.CancelAsync();
        backgroundWorkerCacheKiller.Dispose();
      }
      if (backgroundWorkerTaskKiller.IsBusy == true)
      {
        backgroundWorkerTaskKiller.CancelAsync();
        backgroundWorkerTaskKiller.Dispose();
      }
      LoadDriveDetails(false);
      pictureBoxSearch.ImageLocation = Application.StartupPath + @"\search.png";
    }

    public string ConvertToSize(Int64 value, SizeUnits unit)
    {
      return (value / (double)Math.Pow(1024, (Int64)unit)).ToString("0.00");
    }
    private void toolTipUsername_Popup(object sender, PopupEventArgs e)
    {

    }
    public void LoadTasksGrid()
    {
      //string userName = "";
      DataTable dt = new DataTable();
      CheckBox checkBox;
      dt.Columns.Add("Task Window Name");
      dt.Columns.Add("Task Process Name");
      dt.Columns.Add("Task Memory Size in MB(Commited Size)",typeof(double));
      dt.Columns.Add("Task Memory Size in KB(Commited Size)", typeof(double));
      dt.Columns.Add("Stop");
      Process[] processList = Process.GetProcesses();
      foreach (Process process in processList)
      {
        for (int i = 0; i < process.StartInfo.Environment.Count; i++)
        {
          //if (process.StartInfo.Environment.ToList()[i].Key.ToString() == "USERNAME")
          //{
          //  userName = process.StartInfo.Environment.ToList()[i].Value.ToString();
          //}
        }
        //if (userName.ToLower() == usernameCreds.ToLower())
        //{
          if (!string.IsNullOrEmpty(process.MainWindowTitle))
          {
            dt.Rows.Add(process.MainWindowTitle, process.ProcessName, Convert.ToDouble(ConvertToSize(process.PagedMemorySize64, SizeUnits.MB)), Convert.ToDouble(ConvertToSize(process.PagedMemorySize64, SizeUnits.KB)));
            advancedDataGridViewTasks.DataSource = dt;
          }
          else
          {
          if(process.ProcessName== "msedge" || process.ProcessName == "chrome" || process.ProcessName == "msedgewebview2")
            dt.Rows.Add("--Background Process--", process.ProcessName, Convert.ToDouble(ConvertToSize(process.PagedMemorySize64, SizeUnits.MB)), Convert.ToDouble(ConvertToSize(process.PagedMemorySize64, SizeUnits.KB)));
            advancedDataGridViewTasks.DataSource = dt;
          }
        //}
      }
      advancedDataGridViewTasks.SortDESC(advancedDataGridViewTasks.Columns[2]);
    }
    public void LoadDriveDetails(bool refresh)
    {
      DataTable dt = new DataTable();
      dt.Columns.Add("Drive Name");
      dt.Columns.Add("Total Space");
      dt.Columns.Add("Used Space");
      dt.Columns.Add("Free Space");
      foreach (DriveInfo drive in drives)
      {
        if (drive.IsReady)
        {
          dt.Rows.Add(drive.Name, ConvertToSize(drive.TotalSize, SizeUnits.GB) + " GB", ConvertToSize((drive.TotalSize - drive.AvailableFreeSpace), SizeUnits.GB) + " GB", ConvertToSize(drive.AvailableFreeSpace, SizeUnits.GB) + " GB");
        }
        if (!refresh)
        {
          if (drive.Name.Contains("C:"))
          {
            chart2.Titles["title1"].Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chart2.Series["Series1"].Points.AddXY("Used Space", ConvertToSize((drive.TotalSize - drive.AvailableFreeSpace), SizeUnits.GB));
            chart2.Series["Series1"].Points.AddXY("Free Space", ConvertToSize(drive.AvailableFreeSpace, SizeUnits.GB));
          }
        }
        else
        {
          foreach (var series in chart2.Series)
          {
            series.Points.Clear();
          }
          chart2.Series["Series1"].Points.AddXY("Used Space", ConvertToSize((drive.TotalSize - drive.AvailableFreeSpace), SizeUnits.GB));
          chart2.Series["Series1"].Points.AddXY("Free Space", ConvertToSize(drive.AvailableFreeSpace, SizeUnits.GB));
        }
      }
      advancedDataGridViewDriveStatus.DataSource = dt;

      //foreach (DriveInfo drive in drives)
      //{
      //  if (drive.Name.Contains("C:"))
      //  {
      //    freeSpaceBeforeOpti = Convert.ToDouble(ConvertToSize(drive.AvailableFreeSpace, SizeUnits.GB));
      //    usedSpaceBeforeOpti = Convert.ToDouble(ConvertToSize((drive.TotalSize - drive.AvailableFreeSpace), SizeUnits.GB));
      //  }
      //}
    }
    private async void btnValidate_Click(object sender, EventArgs e)
    {
      if (!isValidated)
      {
        picBoxUsername.ImageLocation = Application.StartupPath + @"\load.gif";
        picBoxAccess.ImageLocation = Application.StartupPath + @"\load.gif";
        usernameCreds = textBoxUsername.Text;
        directoryPathTemp1 = @"C:\Users\" + usernameCreds + @"\AppData\Local\Temp\";
        InternetFiles = @"C:\Users\" + usernameCreds + @"\AppData\Local\Google\Chrome\User Data\Profile 1\Cache";
        Thumbails = @"C:\Users\" + usernameCreds + @"\AppData\Local\Microsoft\Windows\Explorer";
        if (Directory.Exists(directoryPathTemp1))
        {
          picBoxUsername.ImageLocation = Application.StartupPath + @"\tick.png";
          try
          {
            Directory.CreateDirectory(directoryPathTemp1 + "OptimizerTestFile");
            Directory.CreateDirectory(directoryPathTemp2 + "OptimizerTestFile");
            Directory.CreateDirectory(Prefetch + "OptimizerTestFile");
            await Task.Delay(1000);
            picBoxAccess.ImageLocation = Application.StartupPath + @"\tick.png";
              isValidated = true;
            tableLayoutPanelTasks.Visible = true;
            tableLayoutPanelStatus.Visible = true;
            picBoxStatus.ImageLocation = picBoxStatus.ImageLocation = Application.StartupPath + @"\trashInitial.jpg";
            LoadTasksGrid();
            tableLayoutPanelAction.Visible = true;
          }
          catch
          {
            picBoxAccess.ImageLocation = Application.StartupPath + @"\error.jpg";
            MessageBox.Show("Open the Application in Administrator Mode..!!");
            tableLayoutPanelTasks.Visible = false;
            tableLayoutPanelCreds.Enabled = true;
          }
        }
        else
        {
          picBoxUsername.ImageLocation = Application.StartupPath + @"\error.jpg";
          picBoxAccess.ImageLocation = Application.StartupPath + @"\error.jpg";
          tableLayoutPanelTasks.Visible = false;
          tableLayoutPanelCreds.Enabled = true;
          picBoxStatus.ImageLocation = picBoxStatus.ImageLocation = Application.StartupPath + @"\trashFull.jpg";
        }
      }
      else
      {
        MessageBox.Show("Already Validated..!! Close and reopen the application to validate.");
      }
    }

    private void buttonOptimize_Click(object sender, EventArgs e)
    {
      DriveInfo[] drives = DriveInfo.GetDrives();
      foreach (DriveInfo drive in drives)
      {
        if (drive.Name.Contains("C:"))
        {
          freeSpaceBeforeOpti = Convert.ToDouble(ConvertToSize(drive.AvailableFreeSpace, SizeUnits.GB));
          usedSpaceBeforeOpti = Convert.ToDouble(ConvertToSize((drive.TotalSize - drive.AvailableFreeSpace), SizeUnits.GB));
        }
      }
      advancedDataGridViewTasks.Enabled = false;
      backgroundWorkerTaskKiller.RunWorkerAsync();
    }

    private void backgroundWorkerTaskKiller_DoWork(object sender, DoWorkEventArgs e)
    {
      int count = 1;
      for (int i = 0; i < advancedDataGridViewTasks.Rows.Count; i++)
      {
        var cellValue = advancedDataGridViewTasks.Rows[i].Cells[1].Value.ToString();
        var stopValue = advancedDataGridViewTasks.Rows[i].Cells[4].Value.ToString();
        if (cellValue!="Optimizor" && stopValue=="Stop")
          KillList.Add(cellValue);
      }
      Process[] processList = Process.GetProcesses();
      foreach (var process in processList)
      {
        if (KillList.Contains(process.ProcessName))
        {
          if (process.ProcessName != "Optimizor")
          {
            process.Kill();
            backgroundWorkerTaskKiller.ReportProgress(count++);
          }
        }
      }
    }

    private void backgroundWorkerTaskKiller_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      try
      {
        SetTextToRichTextBox("\nTerminating Process: " + KillList[e.ProgressPercentage] + "");
      }
      catch
      {

      }
    }

    private void backgroundWorkerTaskKiller_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      SetTextToRichTextBox("\nTerminating Processes Completed...");
      if (!onlyTask)
      {
        SetTextToRichTextBox("\nInitiating Core Optimization...");
        backgroundWorkerCacheKiller.RunWorkerAsync(); 
      }
    }

    private void SetTextToRichTextBox(string text)
    {
      // InvokeRequired required compares the thread ID of the
      // calling thread to the thread ID of the creating thread.
      // If these threads are different, it returns true.
      try
      {
        if (!string.IsNullOrEmpty(text))
        {
          if (this.richTextBoxStatus.InvokeRequired)
          {
            SetTextCallback d = new SetTextCallback(SetTextToRichTextBox);
            this.Invoke(d, new object[] { text });
          }
          else
          {
            this.richTextBoxStatus.AppendText(text);
          }
        }
        else
        {
          this.richTextBoxStatus.Clear();
        }
      }
      catch (Exception e)
      {

      }
    }

    private void backgroundWorkerCacheKiller_DoWork(object sender, DoWorkEventArgs e)
    {
      int count = 1; 
      SetTextToRichTextBox(string.Empty);
      if (Directory.Exists(directoryPathTemp1)) //1
      {
        ifblock = true;
        try
        {
          Directory.Delete(directoryPathTemp1, true);
        }
        catch
        {
          SetTextToRichTextBox("Error occured in System Temp Files 1...\n");
        }
        backgroundWorkerCacheKiller.ReportProgress(count);
        count++;
      }
      else
      {
        ifblock = false;
        backgroundWorkerCacheKiller.ReportProgress(count);
        count++;
      }
      if (Directory.Exists(directoryPathTemp2)) //2
      {
        ifblock = true;
        SetTextToRichTextBox("Deleting System Temp Files...\n");
        try
        {
          Directory.Delete(directoryPathTemp2, true);
        }
        catch {
          SetTextToRichTextBox("Error occured in System Temp Files...\n");
        }
        SetTextToRichTextBox("System Temp Files Deleted...\n");

        backgroundWorkerCacheKiller.ReportProgress(count);
        count++;
      }
      else
      {
        ifblock = false;
        //SetTextToRichTextBox("System Temp Files Already Deleted...\n");
        backgroundWorkerCacheKiller.ReportProgress(count);
        count++;
      }
      if (Directory.Exists(Prefetch)) //3
      {
        ifblock = true;
        //SetTextToRichTextBox("Deleting Prefetch Files...\n");
        try
        {
          Directory.Delete(Prefetch, true);
        }
        catch {
          SetTextToRichTextBox("Error occured in Deleting Prefetch Files...\n");
        }
        //SetTextToRichTextBox("Deleting Prefetch Files...\n");
        //SetTextToRichTextBox("Prefetch Files Deleted...\n");

        backgroundWorkerCacheKiller.ReportProgress(count);
        count++;
      }
      else
      {
        ifblock = false;
        //SetTextToRichTextBox("Prefetch Files Already Deleted...\n");
        backgroundWorkerCacheKiller.ReportProgress(count);
        count++;
      }
      if (Directory.Exists(WindowsUpdate)) //4
      {
        ifblock = true;
        //SetTextToRichTextBox("Deleting Windows Chache Files...\n");
        try
        {
          Directory.Delete(WindowsUpdate, true);
        }
        catch {
          SetTextToRichTextBox("Error occured in Windows Chache Files...\n");
        }
        //SetTextToRichTextBox("Deleting Windows Chache Files...\n");
        //SetTextToRichTextBox("Windows Cache Files Deleted...\n");

        backgroundWorkerCacheKiller.ReportProgress(count);
        count++;
      }
      else
      {
        ifblock = false;
        //SetTextToRichTextBox("Windows Cache Already Deleted...\n");
        backgroundWorkerCacheKiller.ReportProgress(count);
        count++;
      }
      if (Directory.Exists(InternetFiles)) //5
      {
        ifblock = true;
        //SetTextToRichTextBox("Deleting Internet Cache Files...\n");
        try
        {
          Directory.Delete(InternetFiles, true);
        }
        catch {
          SetTextToRichTextBox("Error occured in Deleting Internet Cache Files...\n");
        }
        //SetTextToRichTextBox("Deleting Internet Cache Files...\n");
        //SetTextToRichTextBox("Internet Cache Files Deleted...\n");

        backgroundWorkerCacheKiller.ReportProgress(count);
        count++;
      }
      else
      {
        ifblock = false;
        // SetTextToRichTextBox("Windows Internet Already Deleted...\n");
        backgroundWorkerCacheKiller.ReportProgress(count);
        count++;
      }
      if (Directory.Exists(Thumbails)) //6
      {
        ifblock = true;
        // SetTextToRichTextBox("Deleting Thumbails Cache Files...\n");
        try
        {
          Directory.Delete(Thumbails, true);
        }
        catch { }
        //SetTextToRichTextBox("Deleting Thumbails Cache Files...\n");
        //SetTextToRichTextBox("Thumbails Chache Files Deleted...\n");

        backgroundWorkerCacheKiller.ReportProgress(count);
        count++;
      }
      else
      {
        ifblock = false;
        //SetTextToRichTextBox("Thumbails Chache Already Deleted...\n");
        backgroundWorkerCacheKiller.ReportProgress(count);
        count++;
      }
      if (checkBoxRecycleBin.Checked)  //7
      {
        //SetTextToRichTextBox("Clearing Recycle Bin...\n");
        try
        {
          SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
        }
        catch { }
        //SetTextToRichTextBox("Clearing Recycle Bin...\n");
        //SetTextToRichTextBox("Recycle Bin Files Cleared...\n");
        //SetTextToRichTextBox("Logged the update...\n");
        backgroundWorkerCacheKiller.ReportProgress(7);
      }
      if (checkBoxRestart.Checked)
      {
        ProcessStartInfo startinfo = new ProcessStartInfo("shutdown.exe", "-r");
        Process.Start(startinfo);
      }
    }

    private void backgroundWorkerCacheKiller_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      switch (e.ProgressPercentage)
      {
        case 0:
        case 1:
          if (ifblock)
          {
            SetTextToRichTextBox("\nDeleting User Temp Files...\n");
            SetTextToRichTextBox("\nUser Temp Files Deleted...\n");
          }
          else
            SetTextToRichTextBox("\nUser Temp Files Already Deleted...\n");
          picBoxStatus.ImageLocation = Application.StartupPath + @"\trashFull.jpg";
          break;
        case 2:
          if (ifblock)
          {
            SetTextToRichTextBox("\nDeleting System Temp Files...\n");
            SetTextToRichTextBox("\nSystem Temp Files Deleted...\n");
          }
          else
            SetTextToRichTextBox("\nSystem Temp Files Already Deleted...\n");
          picBoxStatus.ImageLocation = Application.StartupPath + @"\trashFull.jpg";
          break;
        case 3:
          if (ifblock)
          {
            SetTextToRichTextBox("\nDeleting Prefetch Files...\n");
            SetTextToRichTextBox("Prefetch Files Deleted...\n");
          }
          else
            SetTextToRichTextBox("\nPrefetch Files Already Deleted...\n");
          picBoxStatus.ImageLocation = Application.StartupPath + @"\trashSemi.jpg";
          break;
        case 4:
          if (ifblock)
          {
            SetTextToRichTextBox("\nDeleting Windows Chache Files...\n");
            SetTextToRichTextBox("Windows Cache Files Deleted...\n");
          }
          else
            SetTextToRichTextBox("\nWindows Cache Files Already Deleted...\n");
          picBoxStatus.ImageLocation = Application.StartupPath + @"\trashSemi.jpg";
          break;
        case 5:
          if (ifblock)
          {
            SetTextToRichTextBox("\nDeleting Internet Cache Files...\n");
            SetTextToRichTextBox("\nInternet Cache Files Deleted...\n");
          }
          else
            SetTextToRichTextBox("\nInternet Cache Files Already Deleted...\n");
          picBoxStatus.ImageLocation = Application.StartupPath + @"\trashSemi.jpg";
          break;
        case 6:
          if (ifblock)
          {
            SetTextToRichTextBox("\nDeleting Thumbails Cache Files...\n");
            SetTextToRichTextBox("\nThumbails Chache Files Deleted...\n");
          }
          else
            SetTextToRichTextBox("\nThumbails Cache Files Already Deleted...\n");
          picBoxStatus.ImageLocation = Application.StartupPath + @"\trashLow.jpg";
          break;
        case 7:
          SetTextToRichTextBox("\nClearing Recycle Bin...\n");
          SetTextToRichTextBox("\nRecycle Bin Files Cleared...\n");
          SetTextToRichTextBox("\nLogged the update...\n");
          picBoxStatus.ImageLocation = Application.StartupPath + @"\trashEmpty.jpg";
          break;
      }
    }

    private void backgroundWorkerCacheKiller_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      LoadDriveDetails(true);
      DriveInfo[] drives = DriveInfo.GetDrives();
      foreach (DriveInfo drive in drives)
      {
        if (drive.Name.Contains("C:"))
        {
          usedSpaceAfterOpti = Convert.ToDouble(ConvertToSize(drive.AvailableFreeSpace, SizeUnits.GB));
          usedSpaceAfterOpti = Convert.ToDouble(ConvertToSize((drive.TotalSize - drive.AvailableFreeSpace), SizeUnits.GB));
        }
      }
    }

    private void buttonCompareResults_Click(object sender, EventArgs e)
    {
      CompareForm compareForm = new CompareForm();
      compareForm.Show();
    }

    private void tableLayoutPanelAction_Paint(object sender, PaintEventArgs e)
    {

    }

    private void buttonRefresh_Click(object sender, EventArgs e)
    {
      advancedDataGridViewTasks.DataSource = null;
      advancedDataGridViewTasks.Rows.Clear();
      advancedDataGridViewTasks.CleanFilterAndSort();
      LoadTasksGrid();
    }

    private void buttonDriveDetails_Click(object sender, EventArgs e)
    {
      //UsernameFinderForm  usernameFinderForm  = new UsernameFinderForm();
      //usernameFinderForm.Show();
    }

    private void buttonFindUsername_Click(object sender, EventArgs e)
    {
      string userNameString = Environment.UserName;
      string domainName = "";
      string userName = "";
      string[] parts = userNameString.Split('\\');
      if (parts.Length > 1)
      {
         domainName = parts[0];
         userName = parts[1];
      }
      else
      {
         userName = parts[0];
      }
      textBoxUsername.Text = userName;
    }

    private void advancedDataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      // 1. Check if the click is on a valid row (not the header)
      if (e.RowIndex >= 0)
      {
        var rowDetail = advancedDataGridViewTasks.Rows[e.RowIndex];
        if (advancedDataGridViewTasks.Rows[e.RowIndex].Cells[4].Value == "Stop")
        {
          // Reference the specific cell that was clicked
          var clickedCell = advancedDataGridViewTasks.Rows[e.RowIndex].Cells[e.ColumnIndex];

          // 2. Change the background color
          rowDetail.DefaultCellStyle.BackColor = Color.White;
          rowDetail.DefaultCellStyle.SelectionBackColor = SystemColors.HotTrack;
          rowDetail.DefaultCellStyle.SelectionForeColor = Color.White;
          rowDetail.DefaultCellStyle.ForeColor = Color.Black;
          //clickedCell.Style.BackColor = Color.White;
          //clickedCell.Style.SelectionBackColor = Color.White; 

          // 3. Add text to the cell (Note: CheckBox columns don't show text, 
          // so we usually target a text column in the same row)
          // Let's say we put text in the first column (index 0)
          advancedDataGridViewTasks.Rows[e.RowIndex].Cells[4].Value = "";

        }
        else
        {
          // Reference the specific cell that was clicked
          var clickedCell = advancedDataGridViewTasks.Rows[e.RowIndex].Cells[e.ColumnIndex];
          // 2. Change the background color
          //clickedCell.Style.BackColor = Color.Purple;
          //clickedCell.Style.SelectionBackColor = Color.DarkRed; // Color when still selected
          //clickedCell.Style.ForeColor = Color.White; // Color when still selected

          // 3. Add text to the cell (Note: CheckBox columns don't show text, 
          // so we usually target a text column in the same row)
          // Let's say we put text in the first column (index 0)
          advancedDataGridViewTasks.Rows[e.RowIndex].Cells[4].Value = "Stop";
          rowDetail.DefaultCellStyle.BackColor = Color.Purple;
          rowDetail.DefaultCellStyle.SelectionForeColor = Color.White;
          rowDetail.DefaultCellStyle.SelectionBackColor = Color.Purple;
          rowDetail.DefaultCellStyle.ForeColor = Color.White;
        }
      }
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      AboutBox aboutBox = new AboutBox();
      aboutBox.Show();
    }

    private void buttonKill_Click(object sender, EventArgs e)
    {
      onlyTask = true;
      //advancedDataGridViewTasks.Enabled = false;
      backgroundWorkerTaskKiller.RunWorkerAsync();
    }

    private void buttonClearCache_Click(object sender, EventArgs e)
    {
      onlyCache = true;
      backgroundWorkerCacheKiller.RunWorkerAsync();
    }
  }
}
