namespace SystemInfo1
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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.系统信息 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listVie = new System.Windows.Forms.ListView();
            this.Dit = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.系统信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.进程信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.确定复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘帖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.命令广播ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.系统信息.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 320);
            this.label1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.系统信息);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(373, 480);
            this.tabControl1.TabIndex = 8;
            // 
            // 系统信息
            // 
            this.系统信息.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.系统信息.Controls.Add(this.label1);
            this.系统信息.Location = new System.Drawing.Point(4, 23);
            this.系统信息.Name = "系统信息";
            this.系统信息.Padding = new System.Windows.Forms.Padding(3);
            this.系统信息.Size = new System.Drawing.Size(365, 453);
            this.系统信息.TabIndex = 0;
            this.系统信息.Text = "系统信息显示";
            this.系统信息.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(365, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "进程信息显示";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(249, 410);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 30);
            this.button7.TabIndex = 3;
            this.button7.Text = "结束进程";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(353, 398);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "进程ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "进程名称";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "物理内存";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "进程起始时间";
            this.Column4.Name = "Column4";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.listVie);
            this.tabPage1.Controls.Add(this.Dit);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(365, 453);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "文件管理界面";
            // 
            // listVie
            // 
            this.listVie.Location = new System.Drawing.Point(6, 217);
            this.listVie.Name = "listVie";
            this.listVie.Size = new System.Drawing.Size(340, 230);
            this.listVie.TabIndex = 2;
            this.listVie.UseCompatibleStateImageBehavior = false;
            this.listVie.View = System.Windows.Forms.View.List;
            this.listVie.SelectedIndexChanged += new System.EventHandler(this.listVie_SelectedIndexChanged);
            // 
            // Dit
            // 
            this.Dit.CheckBoxes = true;
            this.Dit.Location = new System.Drawing.Point(6, 6);
            this.Dit.Name = "Dit";
            this.Dit.Size = new System.Drawing.Size(340, 205);
            this.Dit.TabIndex = 5;
            this.Dit.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Dit_AfterSelect);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(365, 453);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "命令界面";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "执行程序";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "截屏";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "远程关机";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "远程重启";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统信息ToolStripMenuItem,
            this.进程信息ToolStripMenuItem,
            this.文件管理ToolStripMenuItem,
            this.命令广播ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(801, 24);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 系统信息ToolStripMenuItem
            // 
            this.系统信息ToolStripMenuItem.Name = "系统信息ToolStripMenuItem";
            this.系统信息ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.系统信息ToolStripMenuItem.Text = "系统信息";
            this.系统信息ToolStripMenuItem.Click += new System.EventHandler(this.系统信息ToolStripMenuItem_Click);
            // 
            // 进程信息ToolStripMenuItem
            // 
            this.进程信息ToolStripMenuItem.Name = "进程信息ToolStripMenuItem";
            this.进程信息ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.进程信息ToolStripMenuItem.Text = "进程信息";
            this.进程信息ToolStripMenuItem.Click += new System.EventHandler(this.进程信息ToolStripMenuItem_Click);
            // 
            // 文件管理ToolStripMenuItem
            // 
            this.文件管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.确定复制ToolStripMenuItem,
            this.粘帖ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.文件管理ToolStripMenuItem.Name = "文件管理ToolStripMenuItem";
            this.文件管理ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.文件管理ToolStripMenuItem.Text = "文件管理";
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 确定复制ToolStripMenuItem
            // 
            this.确定复制ToolStripMenuItem.Name = "确定复制ToolStripMenuItem";
            this.确定复制ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.确定复制ToolStripMenuItem.Text = "确定复制";
            this.确定复制ToolStripMenuItem.Click += new System.EventHandler(this.确定复制ToolStripMenuItem_Click_1);
            // 
            // 粘帖ToolStripMenuItem
            // 
            this.粘帖ToolStripMenuItem.Name = "粘帖ToolStripMenuItem";
            this.粘帖ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.粘帖ToolStripMenuItem.Text = "粘帖";
            this.粘帖ToolStripMenuItem.Click += new System.EventHandler(this.粘帖ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 命令广播ToolStripMenuItem
            // 
            this.命令广播ToolStripMenuItem.Name = "命令广播ToolStripMenuItem";
            this.命令广播ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.命令广播ToolStripMenuItem.Text = "命令广播";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(457, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "目标机IP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(527, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 21);
            this.textBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(457, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "上线端口";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(530, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 21);
            this.textBox2.TabIndex = 14;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(460, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 24);
            this.button5.TabIndex = 15;
            this.button5.Text = "连接";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(561, 214);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 24);
            this.button6.TabIndex = 16;
            this.button6.Text = "断开";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(551, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 21);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(801, 532);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "控制器";
            this.tabControl1.ResumeLayout(false);
            this.系统信息.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private string name;
        private string FileName;
        private string SourceFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage 系统信息;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 系统信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 进程信息ToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem 文件管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘帖ToolStripMenuItem;
        private System.Windows.Forms.ListView listVie;
        private System.Windows.Forms.TreeView Dit;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem 命令广播ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem 确定复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
    }
}

