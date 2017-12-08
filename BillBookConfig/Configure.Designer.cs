namespace BillBookConfig
{
    partial class Configure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configure));
            this.submitB = new System.Windows.Forms.Button();
            this.hostTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.portTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.hostL = new System.Windows.Forms.Label();
            this.portL = new System.Windows.Forms.Label();
            this.usernaemL = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.databaseL = new System.Windows.Forms.Label();
            this.databaseTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitB
            // 
            this.submitB.Location = new System.Drawing.Point(89, 249);
            this.submitB.Name = "submitB";
            this.submitB.Size = new System.Drawing.Size(75, 23);
            this.submitB.TabIndex = 0;
            this.submitB.Text = "提交";
            this.submitB.UseVisualStyleBackColor = true;
            this.submitB.Click += new System.EventHandler(this.SubmitB_Click);
            // 
            // hostTB
            // 
            this.hostTB.Location = new System.Drawing.Point(141, 32);
            this.hostTB.Name = "hostTB";
            this.hostTB.Size = new System.Drawing.Size(100, 21);
            this.hostTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(141, 152);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(100, 21);
            this.passwordTB.TabIndex = 2;
            // 
            // portTB
            // 
            this.portTB.Location = new System.Drawing.Point(141, 72);
            this.portTB.Name = "portTB";
            this.portTB.Size = new System.Drawing.Size(100, 21);
            this.portTB.TabIndex = 3;
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(141, 111);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(100, 21);
            this.usernameTB.TabIndex = 4;
            // 
            // hostL
            // 
            this.hostL.AutoSize = true;
            this.hostL.Location = new System.Drawing.Point(35, 35);
            this.hostL.Name = "hostL";
            this.hostL.Size = new System.Drawing.Size(89, 12);
            this.hostL.TabIndex = 5;
            this.hostL.Text = "账本所在服务器";
            // 
            // portL
            // 
            this.portL.AutoSize = true;
            this.portL.Location = new System.Drawing.Point(35, 75);
            this.portL.Name = "portL";
            this.portL.Size = new System.Drawing.Size(29, 12);
            this.portL.TabIndex = 6;
            this.portL.Text = "端口";
            // 
            // usernaemL
            // 
            this.usernaemL.AutoSize = true;
            this.usernaemL.Location = new System.Drawing.Point(35, 114);
            this.usernaemL.Name = "usernaemL";
            this.usernaemL.Size = new System.Drawing.Size(41, 12);
            this.usernaemL.TabIndex = 7;
            this.usernaemL.Text = "用户名";
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Location = new System.Drawing.Point(35, 155);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(29, 12);
            this.passwordL.TabIndex = 8;
            this.passwordL.Text = "密码";
            // 
            // databaseL
            // 
            this.databaseL.AutoSize = true;
            this.databaseL.Location = new System.Drawing.Point(35, 198);
            this.databaseL.Name = "databaseL";
            this.databaseL.Size = new System.Drawing.Size(53, 12);
            this.databaseL.TabIndex = 9;
            this.databaseL.Text = "数据库名";
            // 
            // databaseTB
            // 
            this.databaseTB.Location = new System.Drawing.Point(141, 195);
            this.databaseTB.Name = "databaseTB";
            this.databaseTB.Size = new System.Drawing.Size(100, 21);
            this.databaseTB.TabIndex = 10;
            // 
            // Configure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 292);
            this.Controls.Add(this.databaseTB);
            this.Controls.Add(this.databaseL);
            this.Controls.Add(this.passwordL);
            this.Controls.Add(this.usernaemL);
            this.Controls.Add(this.portL);
            this.Controls.Add(this.hostL);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.portTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.hostTB);
            this.Controls.Add(this.submitB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Configure";
            this.Text = "配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitB;
        private System.Windows.Forms.TextBox hostTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox portTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label hostL;
        private System.Windows.Forms.Label portL;
        private System.Windows.Forms.Label usernaemL;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.Label databaseL;
        private System.Windows.Forms.TextBox databaseTB;
    }
}

