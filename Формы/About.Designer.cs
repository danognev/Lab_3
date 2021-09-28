
namespace Lab_3
{
  partial class About
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
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
      this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.labelProductName = new System.Windows.Forms.Label();
      this.labelCopyright = new System.Windows.Forms.Label();
      this.textBoxDescription = new System.Windows.Forms.TextBox();
      this.checkBox = new System.Windows.Forms.CheckBox();
      this.tableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel
      // 
      this.tableLayoutPanel.ColumnCount = 1;
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel.Controls.Add(this.labelProductName, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.labelCopyright, 0, 1);
      this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 0, 2);
      this.tableLayoutPanel.Controls.Add(this.checkBox, 0, 3);
      this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
      this.tableLayoutPanel.Name = "tableLayoutPanel";
      this.tableLayoutPanel.RowCount = 4;
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel.Size = new System.Drawing.Size(417, 105);
      this.tableLayoutPanel.TabIndex = 0;
      // 
      // labelProductName
      // 
      this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.labelProductName.Location = new System.Drawing.Point(6, 0);
      this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
      this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
      this.labelProductName.Name = "labelProductName";
      this.labelProductName.Size = new System.Drawing.Size(408, 17);
      this.labelProductName.TabIndex = 19;
      this.labelProductName.Text = "Название продукта: Построение графика Кубика Чирнгауза\r\n";
      this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // labelCopyright
      // 
      this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
      this.labelCopyright.Location = new System.Drawing.Point(6, 17);
      this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
      this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
      this.labelCopyright.Name = "labelCopyright";
      this.labelCopyright.Size = new System.Drawing.Size(408, 17);
      this.labelCopyright.TabIndex = 21;
      this.labelCopyright.Text = "Автор: Огнев Даниил, группа 494";
      this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // textBoxDescription
      // 
      this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
      this.textBoxDescription.Location = new System.Drawing.Point(6, 37);
      this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
      this.textBoxDescription.Multiline = true;
      this.textBoxDescription.Name = "textBoxDescription";
      this.textBoxDescription.ReadOnly = true;
      this.textBoxDescription.Size = new System.Drawing.Size(408, 42);
      this.textBoxDescription.TabIndex = 23;
      this.textBoxDescription.TabStop = false;
      this.textBoxDescription.Text = "Цель программы: построить график Кубика Чирнгауза с использованием WinForms\r\n";
      // 
      // checkBox
      // 
      this.checkBox.AutoSize = true;
      this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.checkBox.Location = new System.Drawing.Point(3, 85);
      this.checkBox.Name = "checkBox";
      this.checkBox.Size = new System.Drawing.Size(144, 17);
      this.checkBox.TabIndex = 25;
      this.checkBox.Text = "Больше не показывать";
      this.checkBox.UseVisualStyleBackColor = true;
      this.checkBox.CheckedChanged += new System.EventHandler(this.checkAbout_CheckedChanged);
      // 
      // About
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(435, 123);
      this.Controls.Add(this.tableLayoutPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "About";
      this.Padding = new System.Windows.Forms.Padding(9);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Информация о программе";
      this.tableLayoutPanel.ResumeLayout(false);
      this.tableLayoutPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.Label labelProductName;
    private System.Windows.Forms.Label labelCopyright;
    private System.Windows.Forms.TextBox textBoxDescription;
    private System.Windows.Forms.CheckBox checkBox;
  }
}
