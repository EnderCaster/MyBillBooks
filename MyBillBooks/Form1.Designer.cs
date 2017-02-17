namespace MyBillBooks
{
    partial class Form_MayBeAFakeForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MayBeAFakeForm));
            this.button_AddItem = new System.Windows.Forms.Button();
            this.button_SelectItem = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this._Hint = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_AddItem
            // 
            resources.ApplyResources(this.button_AddItem, "button_AddItem");
            this.button_AddItem.Name = "button_AddItem";
            this.button_AddItem.UseVisualStyleBackColor = true;
            // 
            // button_SelectItem
            // 
            resources.ApplyResources(this.button_SelectItem, "button_SelectItem");
            this.button_SelectItem.Name = "button_SelectItem";
            this.button_SelectItem.UseVisualStyleBackColor = true;
            // 
            // button_Exit
            // 
            resources.ApplyResources(this.button_Exit, "button_Exit");
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // _Hint
            // 
            resources.ApplyResources(this._Hint, "_Hint");
            this._Hint.Name = "_Hint";
            this._Hint.ReadOnly = true;
            // 
            // Form_MayBeAFakeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._Hint);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_SelectItem);
            this.Controls.Add(this.button_AddItem);
            this.Name = "Form_MayBeAFakeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_AddItem;
        private System.Windows.Forms.Button button_SelectItem;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox _Hint;
    }
}

