namespace AutoImplementedProperties_ex
{
    partial class Form1
    {
        /// <summary>
        /// 设计工具所需的变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的资源。
        /// </summary>
        /// <param name="disposing">如果应该处置 Managed 资源则为 true，否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 设计工具产生的程序码

        /// <summary>
        /// 此为设计工具支持所需的方法 - 请勿使用程序码编辑器修改这个方法的内容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(49, 47);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(149, 45);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "显示电脑信息";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 183);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "远程控制客户端";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
    }
}

