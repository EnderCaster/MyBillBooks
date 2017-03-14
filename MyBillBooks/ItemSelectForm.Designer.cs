namespace MyBillBooks
{
    partial class ItemSelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSelectForm));
            this.SelectDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label_sum = new System.Windows.Forms.Label();
            this.label_sumNumber = new System.Windows.Forms.Label();
            this.button_DaySelect = new System.Windows.Forms.Button();
            this.button_MonthReport = new System.Windows.Forms.Button();
            this.button_YearReport = new System.Windows.Forms.Button();
            this.textBox_BillOfDay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SelectDatePicker
            // 
            this.SelectDatePicker.Location = new System.Drawing.Point(30, 30);
            this.SelectDatePicker.Name = "SelectDatePicker";
            this.SelectDatePicker.Size = new System.Drawing.Size(200, 21);
            this.SelectDatePicker.TabIndex = 0;
            // 
            // label_sum
            // 
            this.label_sum.AutoSize = true;
            this.label_sum.Location = new System.Drawing.Point(327, 36);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(29, 12);
            this.label_sum.TabIndex = 1;
            this.label_sum.Text = "总计";
            // 
            // label_sumNumber
            // 
            this.label_sumNumber.AutoSize = true;
            this.label_sumNumber.Location = new System.Drawing.Point(362, 36);
            this.label_sumNumber.Name = "label_sumNumber";
            this.label_sumNumber.Size = new System.Drawing.Size(29, 12);
            this.label_sumNumber.TabIndex = 2;
            this.label_sumNumber.Text = "  元";
            // 
            // button_DaySelect
            // 
            this.button_DaySelect.Location = new System.Drawing.Point(450, 60);
            this.button_DaySelect.Name = "button_DaySelect";
            this.button_DaySelect.Size = new System.Drawing.Size(80, 50);
            this.button_DaySelect.TabIndex = 3;
            this.button_DaySelect.Text = "按天查询";
            this.button_DaySelect.UseVisualStyleBackColor = true;
            this.button_DaySelect.Click += new System.EventHandler(this.button_DaySelect_Click);
            // 
            // button_MonthReport
            // 
            this.button_MonthReport.Location = new System.Drawing.Point(450, 140);
            this.button_MonthReport.Name = "button_MonthReport";
            this.button_MonthReport.Size = new System.Drawing.Size(80, 50);
            this.button_MonthReport.TabIndex = 4;
            this.button_MonthReport.Text = "打印月报表";
            this.button_MonthReport.UseVisualStyleBackColor = true;
            this.button_MonthReport.Click += new System.EventHandler(this.button_MonthReport_Click);
            // 
            // button_YearReport
            // 
            this.button_YearReport.Location = new System.Drawing.Point(450, 220);
            this.button_YearReport.Name = "button_YearReport";
            this.button_YearReport.Size = new System.Drawing.Size(80, 50);
            this.button_YearReport.TabIndex = 5;
            this.button_YearReport.Text = "打印年报表";
            this.button_YearReport.UseVisualStyleBackColor = true;
            this.button_YearReport.Click += new System.EventHandler(this.button_YearReport_Click);
            // 
            // textBox_BillOfDay
            // 
            this.textBox_BillOfDay.Location = new System.Drawing.Point(30, 60);
            this.textBox_BillOfDay.Multiline = true;
            this.textBox_BillOfDay.Name = "textBox_BillOfDay";
            this.textBox_BillOfDay.Size = new System.Drawing.Size(360, 209);
            this.textBox_BillOfDay.TabIndex = 6;
            // 
            // ItemSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 295);
            this.Controls.Add(this.textBox_BillOfDay);
            this.Controls.Add(this.button_YearReport);
            this.Controls.Add(this.button_MonthReport);
            this.Controls.Add(this.button_DaySelect);
            this.Controls.Add(this.label_sumNumber);
            this.Controls.Add(this.label_sum);
            this.Controls.Add(this.SelectDatePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ItemSelectForm";
            this.Text = "我怎么就控制不住自己的手呢";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SelectDatePicker;
        private System.Windows.Forms.Label label_sum;
        private System.Windows.Forms.Label label_sumNumber;
        private System.Windows.Forms.Button button_DaySelect;
        private System.Windows.Forms.Button button_MonthReport;
        private System.Windows.Forms.Button button_YearReport;
        private System.Windows.Forms.TextBox textBox_BillOfDay;
    }
}