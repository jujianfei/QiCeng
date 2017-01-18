namespace WindowsFormsApplication1
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtId1 = new System.Windows.Forms.TextBox();
            this.txtId2 = new System.Windows.Forms.TextBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.txtDepName2 = new System.Windows.Forms.TextBox();
            this.txtDepName1 = new System.Windows.Forms.TextBox();
            this.txtDepId2 = new System.Windows.Forms.TextBox();
            this.txtDepId1 = new System.Windows.Forms.TextBox();
            this.btnGetDep = new System.Windows.Forms.Button();
            this.btnAddDep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(103, 143);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增用户";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(294, 143);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(100, 23);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "得到用户";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtId1
            // 
            this.txtId1.Location = new System.Drawing.Point(103, 60);
            this.txtId1.Name = "txtId1";
            this.txtId1.Size = new System.Drawing.Size(100, 21);
            this.txtId1.TabIndex = 2;
            // 
            // txtId2
            // 
            this.txtId2.Location = new System.Drawing.Point(294, 60);
            this.txtId2.Name = "txtId2";
            this.txtId2.Size = new System.Drawing.Size(100, 21);
            this.txtId2.TabIndex = 3;
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(103, 102);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(100, 21);
            this.txtName1.TabIndex = 4;
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(294, 102);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(100, 21);
            this.txtName2.TabIndex = 5;
            // 
            // txtDepName2
            // 
            this.txtDepName2.Location = new System.Drawing.Point(294, 236);
            this.txtDepName2.Name = "txtDepName2";
            this.txtDepName2.Size = new System.Drawing.Size(100, 21);
            this.txtDepName2.TabIndex = 11;
            // 
            // txtDepName1
            // 
            this.txtDepName1.Location = new System.Drawing.Point(103, 236);
            this.txtDepName1.Name = "txtDepName1";
            this.txtDepName1.Size = new System.Drawing.Size(100, 21);
            this.txtDepName1.TabIndex = 10;
            // 
            // txtDepId2
            // 
            this.txtDepId2.Location = new System.Drawing.Point(294, 194);
            this.txtDepId2.Name = "txtDepId2";
            this.txtDepId2.Size = new System.Drawing.Size(100, 21);
            this.txtDepId2.TabIndex = 9;
            // 
            // txtDepId1
            // 
            this.txtDepId1.Location = new System.Drawing.Point(103, 194);
            this.txtDepId1.Name = "txtDepId1";
            this.txtDepId1.Size = new System.Drawing.Size(100, 21);
            this.txtDepId1.TabIndex = 8;
            // 
            // btnGetDep
            // 
            this.btnGetDep.Location = new System.Drawing.Point(294, 277);
            this.btnGetDep.Name = "btnGetDep";
            this.btnGetDep.Size = new System.Drawing.Size(100, 24);
            this.btnGetDep.TabIndex = 7;
            this.btnGetDep.Text = "得到部门";
            this.btnGetDep.UseVisualStyleBackColor = true;
            // 
            // btnAddDep
            // 
            this.btnAddDep.Location = new System.Drawing.Point(103, 277);
            this.btnAddDep.Name = "btnAddDep";
            this.btnAddDep.Size = new System.Drawing.Size(100, 24);
            this.btnAddDep.TabIndex = 6;
            this.btnAddDep.Text = "新增部门";
            this.btnAddDep.UseVisualStyleBackColor = true;
            this.btnAddDep.Click += new System.EventHandler(this.btnAddDep_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 360);
            this.Controls.Add(this.txtDepName2);
            this.Controls.Add(this.txtDepName1);
            this.Controls.Add(this.txtDepId2);
            this.Controls.Add(this.txtDepId1);
            this.Controls.Add(this.btnGetDep);
            this.Controls.Add(this.btnAddDep);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.txtId2);
            this.Controls.Add(this.txtId1);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "七层登录主窗体";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtId1;
        private System.Windows.Forms.TextBox txtId2;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.TextBox txtDepName2;
        private System.Windows.Forms.TextBox txtDepName1;
        private System.Windows.Forms.TextBox txtDepId2;
        private System.Windows.Forms.TextBox txtDepId1;
        private System.Windows.Forms.Button btnGetDep;
        private System.Windows.Forms.Button btnAddDep;
    }
}

