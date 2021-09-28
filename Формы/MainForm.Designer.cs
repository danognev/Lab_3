namespace Lab_3
{
  partial class MainForm
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.label = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.btnDraw = new System.Windows.Forms.Button();
      this.Abox = new System.Windows.Forms.NumericUpDown();
      this.Xstart = new System.Windows.Forms.NumericUpDown();
      this.Xend = new System.Windows.Forms.NumericUpDown();
      this.StepBox = new System.Windows.Forms.NumericUpDown();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.table = new System.Windows.Forms.TableLayoutPanel();
      this.ClearBtn = new System.Windows.Forms.Button();
      this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.исходныеДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.результатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveFileResultDialog = new System.Windows.Forms.SaveFileDialog();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Abox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Xstart)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Xend)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.StepBox)).BeginInit();
      this.statusStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // graph
      // 
      this.graph.BackColor = System.Drawing.Color.Transparent;
      chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
      chartArea1.AxisX.MajorGrid.Interval = 0D;
      chartArea1.AxisX.MajorGrid.IntervalOffset = 0D;
      chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
      chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
      chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
      chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
      chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
      chartArea1.AxisY.MajorGrid.Interval = 0D;
      chartArea1.AxisY.MajorGrid.IntervalOffset = 0D;
      chartArea1.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
      chartArea1.AxisY.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
      chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
      chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
      chartArea1.BackColor = System.Drawing.Color.Transparent;
      chartArea1.Name = "ChartArea1";
      this.graph.ChartAreas.Add(chartArea1);
      this.graph.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.graph.Location = new System.Drawing.Point(-11, 39);
      this.graph.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
      this.graph.Name = "graph";
      this.graph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
      series1.ChartArea = "ChartArea1";
      series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series1.IsVisibleInLegend = false;
      series1.Legend = "Legend1";
      series1.MarkerColor = System.Drawing.Color.Red;
      series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
      series1.Name = "Series1";
      series2.ChartArea = "ChartArea1";
      series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series2.MarkerColor = System.Drawing.Color.Maroon;
      series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
      series2.Name = "Series2";
      this.graph.Series.Add(series1);
      this.graph.Series.Add(series2);
      this.graph.Size = new System.Drawing.Size(608, 381);
      this.graph.TabIndex = 0;
      this.graph.Text = "graph";
      // 
      // label
      // 
      this.label.AutoSize = true;
      this.label.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label.Location = new System.Drawing.Point(206, 33);
      this.label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label.Name = "label";
      this.label.Size = new System.Drawing.Size(0, 25);
      this.label.TabIndex = 1;
      this.label.UseMnemonic = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(582, 74);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(40, 25);
      this.label2.TabIndex = 3;
      this.label2.Text = "a =";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(582, 112);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(72, 25);
      this.label3.TabIndex = 3;
      this.label3.Text = "Xнач =";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(582, 150);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(73, 25);
      this.label4.TabIndex = 3;
      this.label4.Text = "Хкон =";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(582, 188);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(63, 25);
      this.label5.TabIndex = 3;
      this.label5.Text = "Шаг =";
      // 
      // btnDraw
      // 
      this.btnDraw.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDraw.Location = new System.Drawing.Point(587, 226);
      this.btnDraw.Name = "btnDraw";
      this.btnDraw.Size = new System.Drawing.Size(193, 53);
      this.btnDraw.TabIndex = 4;
      this.btnDraw.Text = "Построить";
      this.btnDraw.UseVisualStyleBackColor = true;
      this.btnDraw.Click += new System.EventHandler(this.BtnDraw_Click);
      // 
      // Abox
      // 
      this.Abox.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.Abox.DecimalPlaces = 1;
      this.Abox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Abox.ForeColor = System.Drawing.SystemColors.MenuText;
      this.Abox.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
      this.Abox.Location = new System.Drawing.Point(660, 74);
      this.Abox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.Abox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
      this.Abox.Name = "Abox";
      this.Abox.Size = new System.Drawing.Size(120, 32);
      this.Abox.TabIndex = 5;
      this.Abox.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
      // 
      // Xstart
      // 
      this.Xstart.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.Xstart.DecimalPlaces = 1;
      this.Xstart.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Xstart.ForeColor = System.Drawing.SystemColors.MenuText;
      this.Xstart.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
      this.Xstart.Location = new System.Drawing.Point(660, 112);
      this.Xstart.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.Xstart.Name = "Xstart";
      this.Xstart.Size = new System.Drawing.Size(120, 32);
      this.Xstart.TabIndex = 5;
      // 
      // Xend
      // 
      this.Xend.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.Xend.DecimalPlaces = 1;
      this.Xend.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Xend.ForeColor = System.Drawing.SystemColors.MenuText;
      this.Xend.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
      this.Xend.Location = new System.Drawing.Point(660, 150);
      this.Xend.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.Xend.Name = "Xend";
      this.Xend.Size = new System.Drawing.Size(120, 32);
      this.Xend.TabIndex = 5;
      this.Xend.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
      // 
      // StepBox
      // 
      this.StepBox.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.StepBox.DecimalPlaces = 1;
      this.StepBox.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.StepBox.ForeColor = System.Drawing.SystemColors.MenuText;
      this.StepBox.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
      this.StepBox.Location = new System.Drawing.Point(660, 188);
      this.StepBox.Name = "StepBox";
      this.StepBox.Size = new System.Drawing.Size(120, 32);
      this.StepBox.TabIndex = 5;
      this.StepBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
      // 
      // statusStrip1
      // 
      this.statusStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
      this.statusStrip1.Location = new System.Drawing.Point(0, 572);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(839, 22);
      this.statusStrip1.TabIndex = 6;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // statusLabel
      // 
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(243, 17);
      this.statusLabel.Text = "Введите значения для построения графика";
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.информацияToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(839, 24);
      this.menuStrip1.TabIndex = 7;
      this.menuStrip1.Text = "menuStrip";
      // 
      // файлToolStripMenuItem
      // 
      this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьКакToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.файлToolStripMenuItem.Text = "Файл";
      // 
      // сохранитьКакToolStripMenuItem
      // 
      this.сохранитьКакToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.исходныеДанныеToolStripMenuItem,
            this.результатToolStripMenuItem});
      this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
      this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
      // 
      // загрузитьToolStripMenuItem
      // 
      this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
      this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.загрузитьToolStripMenuItem.Text = "Загрузить";
      this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.ЗагрузитьToolStripMenuItem_Click);
      // 
      // информацияToolStripMenuItem
      // 
      this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
      this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
      this.информацияToolStripMenuItem.Text = "Информация";
      this.информацияToolStripMenuItem.Click += new System.EventHandler(this.ИнформацияToolStripMenuItem_Click);
      // 
      // table
      // 
      this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.table.AutoScroll = true;
      this.table.AutoScrollMargin = new System.Drawing.Size(1, 1);
      this.table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
      this.table.ColumnCount = 1;
      this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.table.Location = new System.Drawing.Point(41, 411);
      this.table.Name = "table";
      this.table.RowCount = 1;
      this.table.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.table.Size = new System.Drawing.Size(543, 111);
      this.table.TabIndex = 1;
      this.table.Visible = false;
      // 
      // ClearBtn
      // 
      this.ClearBtn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ClearBtn.Location = new System.Drawing.Point(587, 285);
      this.ClearBtn.Name = "ClearBtn";
      this.ClearBtn.Size = new System.Drawing.Size(193, 53);
      this.ClearBtn.TabIndex = 4;
      this.ClearBtn.Text = "Сброс";
      this.ClearBtn.UseVisualStyleBackColor = true;
      this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
      // 
      // saveFileDialog
      // 
      this.saveFileDialog.FileName = "Безымянный";
      this.saveFileDialog.Filter = "text files | *.txt";
      this.saveFileDialog.Title = "Сохранить как";
      this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
      // 
      // openFileDialog
      // 
      this.openFileDialog.Filter = "text files | *.txt";
      this.openFileDialog.Title = "Загрузить файл";
      this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
      // 
      // исходныеДанныеToolStripMenuItem
      // 
      this.исходныеДанныеToolStripMenuItem.Name = "исходныеДанныеToolStripMenuItem";
      this.исходныеДанныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.исходныеДанныеToolStripMenuItem.Text = "Исходные данные";
      this.исходныеДанныеToolStripMenuItem.Click += new System.EventHandler(this.исходныеДанныеToolStripMenuItem_Click);
      // 
      // результатToolStripMenuItem
      // 
      this.результатToolStripMenuItem.Enabled = false;
      this.результатToolStripMenuItem.Name = "результатToolStripMenuItem";
      this.результатToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.результатToolStripMenuItem.Text = "Результат";
      this.результатToolStripMenuItem.Click += new System.EventHandler(this.результатToolStripMenuItem_Click);
      // 
      // saveFileResultDialog
      // 
      this.saveFileResultDialog.FileName = "Безымянный";
      this.saveFileResultDialog.Filter = "Excel Files | *.xls";
      this.saveFileResultDialog.Title = "Сохранить как";
      this.saveFileResultDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileResultDialog_FileOk);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Lab_3.Properties.Resources.func;
      this.pictureBox1.Location = new System.Drawing.Point(211, 27);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(254, 31);
      this.pictureBox1.TabIndex = 8;
      this.pictureBox1.TabStop = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.SystemColors.WindowFrame;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.ClientSize = new System.Drawing.Size(839, 594);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.table);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.StepBox);
      this.Controls.Add(this.Xend);
      this.Controls.Add(this.Xstart);
      this.Controls.Add(this.Abox);
      this.Controls.Add(this.ClearBtn);
      this.Controls.Add(this.btnDraw);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label);
      this.Controls.Add(this.graph);
      this.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Кубика Чирнгауза";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Abox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Xstart)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Xend)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.StepBox)).EndInit();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataVisualization.Charting.Chart graph;
    private System.Windows.Forms.Label label;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btnDraw;
    private System.Windows.Forms.NumericUpDown Abox;
    private System.Windows.Forms.NumericUpDown Xstart;
    private System.Windows.Forms.NumericUpDown Xend;
    private System.Windows.Forms.NumericUpDown StepBox;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
    public System.Windows.Forms.TableLayoutPanel table;
    private System.Windows.Forms.Button ClearBtn;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
    public System.Windows.Forms.SaveFileDialog saveFileDialog;
    public System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.ToolStripMenuItem исходныеДанныеToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem результатToolStripMenuItem;
    public System.Windows.Forms.SaveFileDialog saveFileResultDialog;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

