namespace Optimizor
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanelCreds = new System.Windows.Forms.TableLayoutPanel();
      this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
      this.picBoxAccess = new System.Windows.Forms.PictureBox();
      this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.lblAccessGranted = new System.Windows.Forms.Label();
      this.lblUserNameFound = new System.Windows.Forms.Label();
      this.btnValidate = new System.Windows.Forms.Button();
      this.textBoxUsername = new System.Windows.Forms.TextBox();
      this.picBoxUsername = new System.Windows.Forms.PictureBox();
      this.labelUsername = new System.Windows.Forms.Label();
      this.advancedDataGridViewDriveStatus = new Zuby.ADGV.AdvancedDataGridView();
      this.buttonDriveDetails = new System.Windows.Forms.Button();
      this.tableLayoutPanelTasks = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanelAction = new System.Windows.Forms.TableLayoutPanel();
      this.buttonKill = new System.Windows.Forms.Button();
      this.checkBoxRestart = new System.Windows.Forms.CheckBox();
      this.checkBoxRecycleBin = new System.Windows.Forms.CheckBox();
      this.buttonOptimize = new System.Windows.Forms.Button();
      this.buttonRefresh = new System.Windows.Forms.Button();
      this.advancedDataGridViewTasks = new Zuby.ADGV.AdvancedDataGridView();
      this.tableLayoutPanelStatus = new System.Windows.Forms.TableLayoutPanel();
      this.picBoxStatus = new System.Windows.Forms.PictureBox();
      this.buttonCompareResults = new System.Windows.Forms.Button();
      this.richTextBoxStatus = new System.Windows.Forms.RichTextBox();
      this.toolTipUsername = new System.Windows.Forms.ToolTip(this.components);
      this.backgroundWorkerTaskKiller = new System.ComponentModel.BackgroundWorker();
      this.backgroundWorkerCacheKiller = new System.ComponentModel.BackgroundWorker();
      this.buttonClearCache = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanelCreds.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBoxAccess)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBoxUsername)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridViewDriveStatus)).BeginInit();
      this.tableLayoutPanelTasks.SuspendLayout();
      this.tableLayoutPanelAction.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridViewTasks)).BeginInit();
      this.tableLayoutPanelStatus.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picBoxStatus)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.SystemColors.HotTrack;
      this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(1148, 25);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.35213F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.64787F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 276F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelCreds, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelTasks, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelStatus, 2, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(1148, 542);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // tableLayoutPanelCreds
      // 
      this.tableLayoutPanelCreds.ColumnCount = 2;
      this.tableLayoutPanelCreds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.66667F));
      this.tableLayoutPanelCreds.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.33333F));
      this.tableLayoutPanelCreds.Controls.Add(this.pictureBoxSearch, 1, 0);
      this.tableLayoutPanelCreds.Controls.Add(this.picBoxAccess, 1, 4);
      this.tableLayoutPanelCreds.Controls.Add(this.chart2, 0, 7);
      this.tableLayoutPanelCreds.Controls.Add(this.lblAccessGranted, 0, 4);
      this.tableLayoutPanelCreds.Controls.Add(this.lblUserNameFound, 0, 3);
      this.tableLayoutPanelCreds.Controls.Add(this.btnValidate, 0, 2);
      this.tableLayoutPanelCreds.Controls.Add(this.textBoxUsername, 0, 1);
      this.tableLayoutPanelCreds.Controls.Add(this.picBoxUsername, 1, 3);
      this.tableLayoutPanelCreds.Controls.Add(this.labelUsername, 0, 0);
      this.tableLayoutPanelCreds.Controls.Add(this.advancedDataGridViewDriveStatus, 0, 6);
      this.tableLayoutPanelCreds.Controls.Add(this.buttonDriveDetails, 0, 5);
      this.tableLayoutPanelCreds.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanelCreds.Location = new System.Drawing.Point(5, 5);
      this.tableLayoutPanelCreds.Margin = new System.Windows.Forms.Padding(4);
      this.tableLayoutPanelCreds.Name = "tableLayoutPanelCreds";
      this.tableLayoutPanelCreds.RowCount = 8;
      this.tableLayoutPanelCreds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307F));
      this.tableLayoutPanelCreds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.391608F));
      this.tableLayoutPanelCreds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.361305F));
      this.tableLayoutPanelCreds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.624708F));
      this.tableLayoutPanelCreds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.082706F));
      this.tableLayoutPanelCreds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.827068F));
      this.tableLayoutPanelCreds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.91729F));
      this.tableLayoutPanelCreds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.69464F));
      this.tableLayoutPanelCreds.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanelCreds.Size = new System.Drawing.Size(220, 532);
      this.tableLayoutPanelCreds.TabIndex = 0;
      // 
      // pictureBoxSearch
      // 
      this.pictureBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.pictureBoxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
      this.pictureBoxSearch.InitialImage = global::Optimizor.Properties.Resources.load;
      this.pictureBoxSearch.Location = new System.Drawing.Point(131, 3);
      this.pictureBoxSearch.Margin = new System.Windows.Forms.Padding(2);
      this.pictureBoxSearch.Name = "pictureBoxSearch";
      this.pictureBoxSearch.Size = new System.Drawing.Size(39, 34);
      this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBoxSearch.TabIndex = 14;
      this.pictureBoxSearch.TabStop = false;
      this.pictureBoxSearch.Click += new System.EventHandler(this.buttonFindUsername_Click);
      // 
      // picBoxAccess
      // 
      this.picBoxAccess.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.picBoxAccess.InitialImage = global::Optimizor.Properties.Resources.load;
      this.picBoxAccess.Location = new System.Drawing.Point(131, 161);
      this.picBoxAccess.Margin = new System.Windows.Forms.Padding(2);
      this.picBoxAccess.Name = "picBoxAccess";
      this.picBoxAccess.Size = new System.Drawing.Size(42, 39);
      this.picBoxAccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picBoxAccess.TabIndex = 9;
      this.picBoxAccess.TabStop = false;
      // 
      // chart2
      // 
      chartArea1.Area3DStyle.Enable3D = true;
      chartArea1.Area3DStyle.Inclination = 45;
      chartArea1.Area3DStyle.IsClustered = true;
      chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
      chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
      chartArea1.Name = "ChartArea1";
      this.chart2.ChartAreas.Add(chartArea1);
      this.tableLayoutPanelCreds.SetColumnSpan(this.chart2, 2);
      this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
      legend1.Alignment = System.Drawing.StringAlignment.Center;
      legend1.BorderColor = System.Drawing.Color.White;
      legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
      legend1.IsTextAutoFit = false;
      legend1.Name = "Legend1";
      legend1.TitleForeColor = System.Drawing.Color.DimGray;
      this.chart2.Legends.Add(legend1);
      this.chart2.Location = new System.Drawing.Point(4, 327);
      this.chart2.Margin = new System.Windows.Forms.Padding(4);
      this.chart2.Name = "chart2";
      this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
      this.chart2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Yellow};
      series1.BackSecondaryColor = System.Drawing.Color.Transparent;
      series1.BorderColor = System.Drawing.Color.Gray;
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
      series1.Color = System.Drawing.Color.Black;
      series1.CustomProperties = "MinimumRelativePieSize=20, PieLineColor=Black, CollectedColor=White";
      series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
      series1.IsValueShownAsLabel = true;
      series1.IsXValueIndexed = true;
      series1.LabelBorderWidth = 2;
      series1.Legend = "Legend1";
      series1.MarkerColor = System.Drawing.Color.White;
      series1.Name = "Series1";
      this.chart2.Series.Add(series1);
      this.chart2.Size = new System.Drawing.Size(212, 201);
      this.chart2.TabIndex = 4;
      this.chart2.Text = "chart2";
      title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      title1.Name = "title1";
      title1.Text = "C Drive (in GB)";
      this.chart2.Titles.Add(title1);
      // 
      // lblAccessGranted
      // 
      this.lblAccessGranted.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblAccessGranted.AutoSize = true;
      this.lblAccessGranted.Location = new System.Drawing.Point(2, 172);
      this.lblAccessGranted.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblAccessGranted.Name = "lblAccessGranted";
      this.lblAccessGranted.Size = new System.Drawing.Size(88, 16);
      this.lblAccessGranted.TabIndex = 8;
      this.lblAccessGranted.Text = "Access Granted";
      // 
      // lblUserNameFound
      // 
      this.lblUserNameFound.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.lblUserNameFound.AutoSize = true;
      this.lblUserNameFound.Location = new System.Drawing.Point(2, 128);
      this.lblUserNameFound.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblUserNameFound.Name = "lblUserNameFound";
      this.lblUserNameFound.Size = new System.Drawing.Size(96, 16);
      this.lblUserNameFound.TabIndex = 6;
      this.lblUserNameFound.Text = "Username Found";
      // 
      // btnValidate
      // 
      this.btnValidate.BackColor = System.Drawing.SystemColors.HotTrack;
      this.btnValidate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.tableLayoutPanelCreds.SetColumnSpan(this.btnValidate, 2);
      this.btnValidate.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnValidate.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnValidate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.btnValidate.Location = new System.Drawing.Point(2, 87);
      this.btnValidate.Margin = new System.Windows.Forms.Padding(2);
      this.btnValidate.Name = "btnValidate";
      this.btnValidate.Size = new System.Drawing.Size(216, 24);
      this.btnValidate.TabIndex = 5;
      this.btnValidate.Text = "Validate";
      this.btnValidate.UseVisualStyleBackColor = false;
      this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
      // 
      // textBoxUsername
      // 
      this.tableLayoutPanelCreds.SetColumnSpan(this.textBoxUsername, 2);
      this.textBoxUsername.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxUsername.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxUsername.Location = new System.Drawing.Point(2, 43);
      this.textBoxUsername.Margin = new System.Windows.Forms.Padding(2);
      this.textBoxUsername.Multiline = true;
      this.textBoxUsername.Name = "textBoxUsername";
      this.textBoxUsername.Size = new System.Drawing.Size(216, 40);
      this.textBoxUsername.TabIndex = 4;
      this.textBoxUsername.Text = "Enter the Username";
      this.toolTipUsername.SetToolTip(this.textBoxUsername, "Type the username if you know else click on the \"Search\" Icon.");
      // 
      // picBoxUsername
      // 
      this.picBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.picBoxUsername.InitialImage = global::Optimizor.Properties.Resources.load;
      this.picBoxUsername.Location = new System.Drawing.Point(131, 116);
      this.picBoxUsername.Margin = new System.Windows.Forms.Padding(2);
      this.picBoxUsername.Name = "picBoxUsername";
      this.picBoxUsername.Size = new System.Drawing.Size(42, 39);
      this.picBoxUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picBoxUsername.TabIndex = 7;
      this.picBoxUsername.TabStop = false;
      // 
      // labelUsername
      // 
      this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.labelUsername.AutoSize = true;
      this.labelUsername.Location = new System.Drawing.Point(4, 12);
      this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelUsername.Name = "labelUsername";
      this.labelUsername.Size = new System.Drawing.Size(59, 16);
      this.labelUsername.TabIndex = 0;
      this.labelUsername.Text = "Username";
      this.toolTipUsername.SetToolTip(this.labelUsername, "Type the username if you know else click on the \"Search\" Icon.");
      // 
      // advancedDataGridViewDriveStatus
      // 
      this.advancedDataGridViewDriveStatus.AllowUserToAddRows = false;
      this.advancedDataGridViewDriveStatus.AllowUserToDeleteRows = false;
      this.advancedDataGridViewDriveStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.advancedDataGridViewDriveStatus.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.advancedDataGridViewDriveStatus.BackgroundColor = System.Drawing.Color.White;
      this.advancedDataGridViewDriveStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.tableLayoutPanelCreds.SetColumnSpan(this.advancedDataGridViewDriveStatus, 2);
      this.advancedDataGridViewDriveStatus.Dock = System.Windows.Forms.DockStyle.Fill;
      this.advancedDataGridViewDriveStatus.FilterAndSortEnabled = true;
      this.advancedDataGridViewDriveStatus.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
      this.advancedDataGridViewDriveStatus.Location = new System.Drawing.Point(4, 237);
      this.advancedDataGridViewDriveStatus.Margin = new System.Windows.Forms.Padding(4);
      this.advancedDataGridViewDriveStatus.MaxFilterButtonImageHeight = 23;
      this.advancedDataGridViewDriveStatus.Name = "advancedDataGridViewDriveStatus";
      this.advancedDataGridViewDriveStatus.ReadOnly = true;
      this.advancedDataGridViewDriveStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.advancedDataGridViewDriveStatus.RowHeadersVisible = false;
      this.advancedDataGridViewDriveStatus.Size = new System.Drawing.Size(212, 82);
      this.advancedDataGridViewDriveStatus.SortStringChangedInvokeBeforeDatasourceUpdate = true;
      this.advancedDataGridViewDriveStatus.TabIndex = 12;
      // 
      // buttonDriveDetails
      // 
      this.buttonDriveDetails.AutoEllipsis = true;
      this.buttonDriveDetails.BackColor = System.Drawing.SystemColors.HotTrack;
      this.tableLayoutPanelCreds.SetColumnSpan(this.buttonDriveDetails, 2);
      this.buttonDriveDetails.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonDriveDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonDriveDetails.ForeColor = System.Drawing.Color.White;
      this.buttonDriveDetails.Location = new System.Drawing.Point(4, 206);
      this.buttonDriveDetails.Margin = new System.Windows.Forms.Padding(4);
      this.buttonDriveDetails.Name = "buttonDriveDetails";
      this.buttonDriveDetails.Size = new System.Drawing.Size(212, 23);
      this.buttonDriveDetails.TabIndex = 13;
      this.buttonDriveDetails.Text = "Drive Details";
      this.toolTipUsername.SetToolTip(this.buttonDriveDetails, "Shows the details of the Drives in the system.");
      this.buttonDriveDetails.UseVisualStyleBackColor = false;
      this.buttonDriveDetails.Click += new System.EventHandler(this.buttonDriveDetails_Click);
      // 
      // tableLayoutPanelTasks
      // 
      this.tableLayoutPanelTasks.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.tableLayoutPanelTasks.ColumnCount = 1;
      this.tableLayoutPanelTasks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanelTasks.Controls.Add(this.tableLayoutPanelAction, 0, 1);
      this.tableLayoutPanelTasks.Controls.Add(this.advancedDataGridViewTasks, 0, 0);
      this.tableLayoutPanelTasks.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanelTasks.Location = new System.Drawing.Point(234, 5);
      this.tableLayoutPanelTasks.Margin = new System.Windows.Forms.Padding(4);
      this.tableLayoutPanelTasks.Name = "tableLayoutPanelTasks";
      this.tableLayoutPanelTasks.RowCount = 2;
      this.tableLayoutPanelTasks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.75701F));
      this.tableLayoutPanelTasks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.24299F));
      this.tableLayoutPanelTasks.Size = new System.Drawing.Size(631, 532);
      this.tableLayoutPanelTasks.TabIndex = 3;
      // 
      // tableLayoutPanelAction
      // 
      this.tableLayoutPanelAction.ColumnCount = 6;
      this.tableLayoutPanelAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.00393F));
      this.tableLayoutPanelAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.32417F));
      this.tableLayoutPanelAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.59332F));
      this.tableLayoutPanelAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanelAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanelAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
      this.tableLayoutPanelAction.Controls.Add(this.buttonClearCache, 3, 0);
      this.tableLayoutPanelAction.Controls.Add(this.checkBoxRestart, 1, 0);
      this.tableLayoutPanelAction.Controls.Add(this.checkBoxRecycleBin, 0, 0);
      this.tableLayoutPanelAction.Controls.Add(this.buttonOptimize, 5, 0);
      this.tableLayoutPanelAction.Controls.Add(this.buttonKill, 4, 0);
      this.tableLayoutPanelAction.Controls.Add(this.buttonRefresh, 2, 0);
      this.tableLayoutPanelAction.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanelAction.Location = new System.Drawing.Point(5, 496);
      this.tableLayoutPanelAction.Margin = new System.Windows.Forms.Padding(4);
      this.tableLayoutPanelAction.Name = "tableLayoutPanelAction";
      this.tableLayoutPanelAction.RowCount = 1;
      this.tableLayoutPanelAction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanelAction.Size = new System.Drawing.Size(621, 31);
      this.tableLayoutPanelAction.TabIndex = 0;
      this.tableLayoutPanelAction.Visible = false;
      this.tableLayoutPanelAction.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelAction_Paint);
      // 
      // buttonKill
      // 
      this.buttonKill.BackColor = System.Drawing.SystemColors.HotTrack;
      this.buttonKill.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonKill.ForeColor = System.Drawing.Color.White;
      this.buttonKill.Location = new System.Drawing.Point(411, 4);
      this.buttonKill.Margin = new System.Windows.Forms.Padding(4);
      this.buttonKill.Name = "buttonKill";
      this.buttonKill.Size = new System.Drawing.Size(94, 23);
      this.buttonKill.TabIndex = 5;
      this.buttonKill.Text = "Kill Selected";
      this.buttonKill.UseVisualStyleBackColor = false;
      this.buttonKill.Click += new System.EventHandler(this.buttonKill_Click);
      // 
      // checkBoxRestart
      // 
      this.checkBoxRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.checkBoxRestart.AutoSize = true;
      this.checkBoxRestart.Location = new System.Drawing.Point(120, 5);
      this.checkBoxRestart.Margin = new System.Windows.Forms.Padding(4);
      this.checkBoxRestart.Name = "checkBoxRestart";
      this.checkBoxRestart.Size = new System.Drawing.Size(62, 20);
      this.checkBoxRestart.TabIndex = 1;
      this.checkBoxRestart.Text = "Restart";
      this.checkBoxRestart.UseVisualStyleBackColor = true;
      // 
      // checkBoxRecycleBin
      // 
      this.checkBoxRecycleBin.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.checkBoxRecycleBin.AutoSize = true;
      this.checkBoxRecycleBin.Location = new System.Drawing.Point(4, 5);
      this.checkBoxRecycleBin.Margin = new System.Windows.Forms.Padding(4);
      this.checkBoxRecycleBin.Name = "checkBoxRecycleBin";
      this.checkBoxRecycleBin.Size = new System.Drawing.Size(104, 20);
      this.checkBoxRecycleBin.TabIndex = 0;
      this.checkBoxRecycleBin.Text = "Empty Recycle Bin";
      this.checkBoxRecycleBin.UseVisualStyleBackColor = true;
      // 
      // buttonOptimize
      // 
      this.buttonOptimize.BackColor = System.Drawing.SystemColors.HotTrack;
      this.buttonOptimize.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonOptimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonOptimize.ForeColor = System.Drawing.Color.White;
      this.buttonOptimize.Location = new System.Drawing.Point(513, 4);
      this.buttonOptimize.Margin = new System.Windows.Forms.Padding(4);
      this.buttonOptimize.Name = "buttonOptimize";
      this.buttonOptimize.Size = new System.Drawing.Size(104, 23);
      this.buttonOptimize.TabIndex = 3;
      this.buttonOptimize.Text = "Optimize All";
      this.buttonOptimize.UseVisualStyleBackColor = false;
      this.buttonOptimize.Click += new System.EventHandler(this.buttonOptimize_Click);
      // 
      // buttonRefresh
      // 
      this.buttonRefresh.BackColor = System.Drawing.SystemColors.HotTrack;
      this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonRefresh.ForeColor = System.Drawing.Color.White;
      this.buttonRefresh.Location = new System.Drawing.Point(194, 4);
      this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
      this.buttonRefresh.Name = "buttonRefresh";
      this.buttonRefresh.Size = new System.Drawing.Size(107, 23);
      this.buttonRefresh.TabIndex = 4;
      this.buttonRefresh.Text = "Refresh";
      this.buttonRefresh.UseVisualStyleBackColor = false;
      this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
      // 
      // advancedDataGridViewTasks
      // 
      this.advancedDataGridViewTasks.AllowUserToAddRows = false;
      this.advancedDataGridViewTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.advancedDataGridViewTasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.advancedDataGridViewTasks.BackgroundColor = System.Drawing.Color.White;
      this.advancedDataGridViewTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.advancedDataGridViewTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
      this.advancedDataGridViewTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.advancedDataGridViewTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.advancedDataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.advancedDataGridViewTasks.DefaultCellStyle = dataGridViewCellStyle2;
      this.advancedDataGridViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
      this.advancedDataGridViewTasks.EnableHeadersVisualStyles = false;
      this.advancedDataGridViewTasks.FilterAndSortEnabled = true;
      this.advancedDataGridViewTasks.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
      this.advancedDataGridViewTasks.GridColor = System.Drawing.SystemColors.HotTrack;
      this.advancedDataGridViewTasks.Location = new System.Drawing.Point(5, 5);
      this.advancedDataGridViewTasks.Margin = new System.Windows.Forms.Padding(4);
      this.advancedDataGridViewTasks.MaxFilterButtonImageHeight = 23;
      this.advancedDataGridViewTasks.Name = "advancedDataGridViewTasks";
      this.advancedDataGridViewTasks.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.advancedDataGridViewTasks.RowHeadersVisible = false;
      this.advancedDataGridViewTasks.Size = new System.Drawing.Size(621, 482);
      this.advancedDataGridViewTasks.SortStringChangedInvokeBeforeDatasourceUpdate = true;
      this.advancedDataGridViewTasks.TabIndex = 1;
      this.advancedDataGridViewTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advancedDataGridViewTasks_CellClick);
      // 
      // tableLayoutPanelStatus
      // 
      this.tableLayoutPanelStatus.ColumnCount = 1;
      this.tableLayoutPanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanelStatus.Controls.Add(this.picBoxStatus, 0, 1);
      this.tableLayoutPanelStatus.Controls.Add(this.buttonCompareResults, 0, 1);
      this.tableLayoutPanelStatus.Controls.Add(this.richTextBoxStatus, 0, 0);
      this.tableLayoutPanelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanelStatus.Location = new System.Drawing.Point(874, 5);
      this.tableLayoutPanelStatus.Margin = new System.Windows.Forms.Padding(4);
      this.tableLayoutPanelStatus.Name = "tableLayoutPanelStatus";
      this.tableLayoutPanelStatus.RowCount = 2;
      this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.79487F));
      this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.91142F));
      this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.060606F));
      this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
      this.tableLayoutPanelStatus.Size = new System.Drawing.Size(269, 532);
      this.tableLayoutPanelStatus.TabIndex = 4;
      this.tableLayoutPanelStatus.Visible = false;
      // 
      // picBoxStatus
      // 
      this.picBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.picBoxStatus.InitialImage = global::Optimizor.Properties.Resources.load;
      this.picBoxStatus.Location = new System.Drawing.Point(82, 386);
      this.picBoxStatus.Margin = new System.Windows.Forms.Padding(4);
      this.picBoxStatus.Name = "picBoxStatus";
      this.picBoxStatus.Size = new System.Drawing.Size(105, 108);
      this.picBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picBoxStatus.TabIndex = 16;
      this.picBoxStatus.TabStop = false;
      // 
      // buttonCompareResults
      // 
      this.buttonCompareResults.AutoEllipsis = true;
      this.buttonCompareResults.BackColor = System.Drawing.SystemColors.HotTrack;
      this.tableLayoutPanelStatus.SetColumnSpan(this.buttonCompareResults, 2);
      this.buttonCompareResults.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonCompareResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonCompareResults.ForeColor = System.Drawing.Color.White;
      this.buttonCompareResults.Location = new System.Drawing.Point(4, 502);
      this.buttonCompareResults.Margin = new System.Windows.Forms.Padding(4);
      this.buttonCompareResults.Name = "buttonCompareResults";
      this.buttonCompareResults.Size = new System.Drawing.Size(261, 26);
      this.buttonCompareResults.TabIndex = 14;
      this.buttonCompareResults.Text = "Compare Result";
      this.toolTipUsername.SetToolTip(this.buttonCompareResults, "Compare the Disc space after executing Application ");
      this.buttonCompareResults.UseVisualStyleBackColor = false;
      this.buttonCompareResults.Click += new System.EventHandler(this.buttonCompareResults_Click);
      // 
      // richTextBoxStatus
      // 
      this.richTextBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.richTextBoxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
      this.richTextBoxStatus.Location = new System.Drawing.Point(4, 4);
      this.richTextBoxStatus.Margin = new System.Windows.Forms.Padding(4);
      this.richTextBoxStatus.Name = "richTextBoxStatus";
      this.richTextBoxStatus.Size = new System.Drawing.Size(261, 374);
      this.richTextBoxStatus.TabIndex = 3;
      this.richTextBoxStatus.Text = "";
      // 
      // toolTipUsername
      // 
      this.toolTipUsername.AutomaticDelay = 5008;
      this.toolTipUsername.AutoPopDelay = 50000;
      this.toolTipUsername.InitialDelay = 50;
      this.toolTipUsername.IsBalloon = true;
      this.toolTipUsername.OwnerDraw = true;
      this.toolTipUsername.ReshowDelay = 1001;
      this.toolTipUsername.ShowAlways = true;
      this.toolTipUsername.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
      this.toolTipUsername.ToolTipTitle = "Click Info";
      this.toolTipUsername.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTipUsername_Popup);
      // 
      // backgroundWorkerTaskKiller
      // 
      this.backgroundWorkerTaskKiller.WorkerReportsProgress = true;
      this.backgroundWorkerTaskKiller.WorkerSupportsCancellation = true;
      this.backgroundWorkerTaskKiller.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTaskKiller_DoWork);
      this.backgroundWorkerTaskKiller.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerTaskKiller_ProgressChanged);
      this.backgroundWorkerTaskKiller.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerTaskKiller_RunWorkerCompleted);
      // 
      // backgroundWorkerCacheKiller
      // 
      this.backgroundWorkerCacheKiller.WorkerReportsProgress = true;
      this.backgroundWorkerCacheKiller.WorkerSupportsCancellation = true;
      this.backgroundWorkerCacheKiller.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCacheKiller_DoWork);
      this.backgroundWorkerCacheKiller.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerCacheKiller_ProgressChanged);
      this.backgroundWorkerCacheKiller.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCacheKiller_RunWorkerCompleted);
      // 
      // buttonClearCache
      // 
      this.buttonClearCache.BackColor = System.Drawing.SystemColors.HotTrack;
      this.buttonClearCache.Dock = System.Windows.Forms.DockStyle.Fill;
      this.buttonClearCache.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonClearCache.ForeColor = System.Drawing.Color.White;
      this.buttonClearCache.Location = new System.Drawing.Point(309, 4);
      this.buttonClearCache.Margin = new System.Windows.Forms.Padding(4);
      this.buttonClearCache.Name = "buttonClearCache";
      this.buttonClearCache.Size = new System.Drawing.Size(94, 23);
      this.buttonClearCache.TabIndex = 6;
      this.buttonClearCache.Text = "Clear Caches";
      this.buttonClearCache.UseVisualStyleBackColor = false;
      this.buttonClearCache.Click += new System.EventHandler(this.buttonClearCache_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1148, 567);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Optimizor";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanelCreds.ResumeLayout(false);
      this.tableLayoutPanelCreds.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBoxAccess)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.picBoxUsername)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridViewDriveStatus)).EndInit();
      this.tableLayoutPanelTasks.ResumeLayout(false);
      this.tableLayoutPanelAction.ResumeLayout(false);
      this.tableLayoutPanelAction.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridViewTasks)).EndInit();
      this.tableLayoutPanelStatus.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.picBoxStatus)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCreds;
    private System.Windows.Forms.PictureBox picBoxAccess;
    private System.Windows.Forms.Label lblAccessGranted;
    private System.Windows.Forms.Label lblUserNameFound;
    private System.Windows.Forms.Button btnValidate;
    private System.Windows.Forms.TextBox textBoxUsername;
    private System.Windows.Forms.PictureBox picBoxUsername;
    private System.Windows.Forms.Label labelUsername;
    private System.Windows.Forms.ToolTip toolTipUsername;
    private System.ComponentModel.BackgroundWorker backgroundWorkerTaskKiller;
    private System.ComponentModel.BackgroundWorker backgroundWorkerCacheKiller;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTasks;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAction;
    private System.Windows.Forms.CheckBox checkBoxRestart;
    private System.Windows.Forms.CheckBox checkBoxRecycleBin;
    private System.Windows.Forms.Button buttonOptimize;
    private Zuby.ADGV.AdvancedDataGridView advancedDataGridViewTasks;
    private Zuby.ADGV.AdvancedDataGridView advancedDataGridViewDriveStatus;
    private System.Windows.Forms.Button buttonDriveDetails;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStatus;
    private System.Windows.Forms.RichTextBox richTextBoxStatus;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    private System.Windows.Forms.Button buttonCompareResults;
    private System.Windows.Forms.Button buttonRefresh;
    private System.Windows.Forms.PictureBox picBoxStatus;
    private System.Windows.Forms.PictureBox pictureBoxSearch;
    private System.Windows.Forms.Button buttonKill;
    private System.Windows.Forms.Button buttonClearCache;
  }
}

