﻿namespace HomotorDepotMgr
{
    partial class CaseMgrSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseMgrSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchNum = new System.Windows.Forms.TextBox();
            this.btnSearchOK = new System.Windows.Forms.Button();
            this.btnSearchCancel = new System.Windows.Forms.Button();
            this.btnAlphabet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 20);
            this.label1.Text = "请输入查找的箱号：";
            // 
            // txtSearchNum
            // 
            this.txtSearchNum.Location = new System.Drawing.Point(16, 44);
            this.txtSearchNum.Name = "txtSearchNum";
            this.txtSearchNum.Size = new System.Drawing.Size(203, 23);
            this.txtSearchNum.TabIndex = 0;
            // 
            // btnSearchOK
            // 
            this.btnSearchOK.Location = new System.Drawing.Point(32, 104);
            this.btnSearchOK.Name = "btnSearchOK";
            this.btnSearchOK.Size = new System.Drawing.Size(72, 20);
            this.btnSearchOK.TabIndex = 2;
            this.btnSearchOK.Text = "确定";
            this.btnSearchOK.Click += new System.EventHandler(this.btnSearchOK_Click);
            // 
            // btnSearchCancel
            // 
            this.btnSearchCancel.Location = new System.Drawing.Point(124, 104);
            this.btnSearchCancel.Name = "btnSearchCancel";
            this.btnSearchCancel.Size = new System.Drawing.Size(72, 20);
            this.btnSearchCancel.TabIndex = 3;
            this.btnSearchCancel.Text = "取消";
            this.btnSearchCancel.Click += new System.EventHandler(this.btnSearchCancel_Click);
            // 
            // btnAlphabet
            // 
            this.btnAlphabet.Location = new System.Drawing.Point(32, 72);
            this.btnAlphabet.Name = "btnAlphabet";
            this.btnAlphabet.Size = new System.Drawing.Size(164, 28);
            this.btnAlphabet.TabIndex = 5;
            this.btnAlphabet.Text = "字母键盘";
            this.btnAlphabet.Click += new System.EventHandler(this.btnAlphabet_Click);
            // 
            // CaseMgrSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(238, 138);
            this.Controls.Add(this.btnAlphabet);
            this.Controls.Add(this.btnSearchCancel);
            this.Controls.Add(this.btnSearchOK);
            this.Controls.Add(this.txtSearchNum);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaseMgrSearch";
            this.Text = "箱号搜索";
            this.GotFocus += new System.EventHandler(this.CaseMgrSearch_GotFocus);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchNum;
        private System.Windows.Forms.Button btnSearchOK;
        private System.Windows.Forms.Button btnSearchCancel;
        private System.Windows.Forms.Button btnAlphabet;
    }
}