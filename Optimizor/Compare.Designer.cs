namespace Optimizor
{
  partial class Compare
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.groupBoxAfterOpti = new System.Windows.Forms.GroupBox();
      this.groupBoxBeforeOpti = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.tableLayoutPanelMain.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.groupBoxAfterOpti.SuspendLayout();
      this.groupBoxBeforeOpti.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanelMain
      // 
      this.tableLayoutPanelMain.ColumnCount = 1;
      this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
      this.tableLayoutPanelMain.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
      this.tableLayoutPanelMain.RowCount = 2;
      this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.345733F));
      this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.65427F));
      this.tableLayoutPanelMain.Size = new System.Drawing.Size(732, 457);
      this.tableLayoutPanelMain.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.groupBoxAfterOpti, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.groupBoxBeforeOpti, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 32);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 422);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // groupBoxAfterOpti
      // 
      this.groupBoxAfterOpti.Controls.Add(this.chart1);
      this.groupBoxAfterOpti.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBoxAfterOpti.Location = new System.Drawing.Point(366, 3);
      this.groupBoxAfterOpti.Name = "groupBoxAfterOpti";
      this.groupBoxAfterOpti.Size = new System.Drawing.Size(357, 416);
      this.groupBoxAfterOpti.TabIndex = 1;
      this.groupBoxAfterOpti.TabStop = false;
      this.groupBoxAfterOpti.Text = "Drive details after Optimization";
      // 
      // groupBoxBeforeOpti
      // 
      this.groupBoxBeforeOpti.Controls.Add(this.chart2);
      this.groupBoxBeforeOpti.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBoxBeforeOpti.Location = new System.Drawing.Point(3, 3);
      this.groupBoxBeforeOpti.Name = "groupBoxBeforeOpti";
      this.groupBoxBeforeOpti.Size = new System.Drawing.Size(357, 416);
      this.groupBoxBeforeOpti.TabIndex = 0;
      this.groupBoxBeforeOpti.TabStop = false;
      this.groupBoxBeforeOpti.Text = "Drive details before Optimization";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(717, 26);
      this.label1.TabIndex = 2;
      this.label1.Text = "The Optimization is carried out on the drive where WINDOWS is installed .Hence he" +
    " below comparison is for the drive where the WINDOWS is installed.\r\n";
      // 
      // chart2
      // 
      chartArea2.Name = "ChartArea1";
      this.chart2.ChartAreas.Add(chartArea2);
      legend2.Name = "Legend1";
      this.chart2.Legends.Add(legend2);
      this.chart2.Location = new System.Drawing.Point(29, 64);
      this.chart2.Name = "chart2";
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
      series2.IsValueShownAsLabel = true;
      series2.IsXValueIndexed = true;
      series2.Legend = "Legend1";
      series2.Name = "Series1";
      this.chart2.Series.Add(series2);
      this.chart2.Size = new System.Drawing.Size(300, 300);
      this.chart2.TabIndex = 1;
      this.chart2.Text = "chart2";
      // 
      // chart1
      // 
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(28, 58);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
      series1.IsValueShownAsLabel = true;
      series1.IsXValueIndexed = true;
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(300, 300);
      this.chart1.TabIndex = 2;
      this.chart1.Text = "chart1";
      // 
      // Compare
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanelMain);
      this.Name = "Compare";
      this.Size = new System.Drawing.Size(732, 457);
      this.tableLayoutPanelMain.ResumeLayout(false);
      this.tableLayoutPanelMain.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.groupBoxAfterOpti.ResumeLayout(false);
      this.groupBoxBeforeOpti.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.GroupBox groupBoxAfterOpti;
    private System.Windows.Forms.GroupBox groupBoxBeforeOpti;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
  }
}
