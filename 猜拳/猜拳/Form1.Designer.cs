namespace 猜拳
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.lp = new System.Windows.Forms.Label();
            this.la = new System.Windows.Forms.Label();
            this.tp = new System.Windows.Forms.TextBox();
            this.ta = new System.Windows.Forms.TextBox();
            this.tresult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(103, 504);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(93, 40);
            this.b1.TabIndex = 0;
            this.b1.Text = "石头";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.b2.Location = new System.Drawing.Point(322, 504);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(91, 40);
            this.b2.TabIndex = 0;
            this.b2.Text = "剪刀";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b1_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(582, 504);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(80, 40);
            this.b3.TabIndex = 0;
            this.b3.Text = "布";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b1_Click);
            // 
            // lp
            // 
            this.lp.AutoSize = true;
            this.lp.Location = new System.Drawing.Point(100, 153);
            this.lp.Name = "lp";
            this.lp.Size = new System.Drawing.Size(62, 18);
            this.lp.TabIndex = 1;
            this.lp.Text = "player";
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(467, 156);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(26, 18);
            this.la.TabIndex = 1;
            this.la.Text = "ai";
            // 
            // tp
            // 
            this.tp.Location = new System.Drawing.Point(179, 146);
            this.tp.Name = "tp";
            this.tp.Size = new System.Drawing.Size(117, 28);
            this.tp.TabIndex = 2;
            // 
            // ta
            // 
            this.ta.Location = new System.Drawing.Point(557, 153);
            this.ta.Name = "ta";
            this.ta.Size = new System.Drawing.Size(100, 28);
            this.ta.TabIndex = 2;
            // 
            // tresult
            // 
            this.tresult.Location = new System.Drawing.Point(322, 319);
            this.tresult.Name = "tresult";
            this.tresult.Size = new System.Drawing.Size(100, 28);
            this.tresult.TabIndex = 2;
            this.tresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 673);
            this.Controls.Add(this.tresult);
            this.Controls.Add(this.ta);
            this.Controls.Add(this.tp);
            this.Controls.Add(this.la);
            this.Controls.Add(this.lp);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Label lp;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.TextBox tp;
        private System.Windows.Forms.TextBox ta;
        private System.Windows.Forms.TextBox tresult;
    }
}

