namespace MyBillBooks
{
    partial class ItemInsertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemInsertForm));
            this.label_ItemName = new System.Windows.Forms.Label();
            this.label_ItemPrice = new System.Windows.Forms.Label();
            this.label_Remark = new System.Windows.Forms.Label();
            this.textBox_ItemPrice = new System.Windows.Forms.TextBox();
            this.textBox_ItemName = new System.Windows.Forms.TextBox();
            this.textBox_Remark = new System.Windows.Forms.TextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.InsertDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label_ItemName
            // 
            this.label_ItemName.AutoSize = true;
            this.label_ItemName.Location = new System.Drawing.Point(72, 62);
            this.label_ItemName.Name = "label_ItemName";
            this.label_ItemName.Size = new System.Drawing.Size(53, 12);
            this.label_ItemName.TabIndex = 6;
            this.label_ItemName.Text = "消费项：";
            // 
            // label_ItemPrice
            // 
            this.label_ItemPrice.AutoSize = true;
            this.label_ItemPrice.Location = new System.Drawing.Point(72, 107);
            this.label_ItemPrice.Name = "label_ItemPrice";
            this.label_ItemPrice.Size = new System.Drawing.Size(77, 12);
            this.label_ItemPrice.TabIndex = 7;
            this.label_ItemPrice.Text = "价格（元）：";
            // 
            // label_Remark
            // 
            this.label_Remark.AutoSize = true;
            this.label_Remark.Location = new System.Drawing.Point(72, 152);
            this.label_Remark.Name = "label_Remark";
            this.label_Remark.Size = new System.Drawing.Size(41, 12);
            this.label_Remark.TabIndex = 8;
            this.label_Remark.Text = "备注：";
            // 
            // textBox_ItemPrice
            // 
            this.textBox_ItemPrice.Location = new System.Drawing.Point(155, 104);
            this.textBox_ItemPrice.Name = "textBox_ItemPrice";
            this.textBox_ItemPrice.Size = new System.Drawing.Size(200, 21);
            this.textBox_ItemPrice.TabIndex = 2;
            // 
            // textBox_ItemName
            // 
            this.textBox_ItemName.Location = new System.Drawing.Point(155, 59);
            this.textBox_ItemName.Name = "textBox_ItemName";
            this.textBox_ItemName.Size = new System.Drawing.Size(200, 21);
            this.textBox_ItemName.TabIndex = 1;
            // 
            // textBox_Remark
            // 
            this.textBox_Remark.Location = new System.Drawing.Point(155, 149);
            this.textBox_Remark.Multiline = true;
            this.textBox_Remark.Name = "textBox_Remark";
            this.textBox_Remark.Size = new System.Drawing.Size(200, 105);
            this.textBox_Remark.TabIndex = 3;
            // 
            // button_Submit
            // 
            this.button_Submit.Location = new System.Drawing.Point(74, 271);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(130, 41);
            this.button_Submit.TabIndex = 4;
            this.button_Submit.Text = "提交";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(225, 271);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(130, 41);
            this.button_Reset.TabIndex = 13;
            this.button_Reset.Text = "清空";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // InsertDatePicker
            // 
            this.InsertDatePicker.Location = new System.Drawing.Point(13, 13);
            this.InsertDatePicker.Name = "InsertDatePicker";
            this.InsertDatePicker.Size = new System.Drawing.Size(200, 21);
            this.InsertDatePicker.TabIndex = 14;
            // 
            // ItemInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 324);
            this.Controls.Add(this.InsertDatePicker);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.textBox_Remark);
            this.Controls.Add(this.textBox_ItemName);
            this.Controls.Add(this.textBox_ItemPrice);
            this.Controls.Add(this.label_Remark);
            this.Controls.Add(this.label_ItemPrice);
            this.Controls.Add(this.label_ItemName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "ItemInsertForm";
            this.Text = "我怎么就管不住自己的手呢";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_ItemName;
        private System.Windows.Forms.Label label_ItemPrice;
        private System.Windows.Forms.Label label_Remark;
        private System.Windows.Forms.TextBox textBox_ItemPrice;
        private System.Windows.Forms.TextBox textBox_ItemName;
        private System.Windows.Forms.TextBox textBox_Remark;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.DateTimePicker InsertDatePicker;
    }
}