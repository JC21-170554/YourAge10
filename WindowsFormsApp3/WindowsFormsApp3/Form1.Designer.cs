namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblguukei = new System.Windows.Forms.Label();
            this.lblkikei = new System.Windows.Forms.Label();
            this.lblguuko = new System.Windows.Forms.Label();
            this.lblkiko = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 19);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "追加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(61, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "偶数　　合計";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(61, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "奇数　　合計";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // lblguukei
            // 
            this.lblguukei.AutoSize = true;
            this.lblguukei.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.lblguukei.Location = new System.Drawing.Point(191, 199);
            this.lblguukei.Name = "lblguukei";
            this.lblguukei.Size = new System.Drawing.Size(0, 16);
            this.lblguukei.TabIndex = 4;
            // 
            // lblkikei
            // 
            this.lblkikei.AutoSize = true;
            this.lblkikei.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.lblkikei.Location = new System.Drawing.Point(162, 240);
            this.lblkikei.Name = "lblkikei";
            this.lblkikei.Size = new System.Drawing.Size(0, 16);
            this.lblkikei.TabIndex = 5;
            // 
            // lblguuko
            // 
            this.lblguuko.AutoSize = true;
            this.lblguuko.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.lblguuko.Location = new System.Drawing.Point(260, 198);
            this.lblguuko.Name = "lblguuko";
            this.lblguuko.Size = new System.Drawing.Size(0, 16);
            this.lblguuko.TabIndex = 6;
            this.lblguuko.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lblkiko
            // 
            this.lblkiko.AutoSize = true;
            this.lblkiko.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.lblkiko.Location = new System.Drawing.Point(243, 241);
            this.lblkiko.Name = "lblkiko";
            this.lblkiko.Size = new System.Drawing.Size(0, 16);
            this.lblkiko.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(315, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "個";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(315, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "個";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 320);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblkiko);
            this.Controls.Add(this.lblguuko);
            this.Controls.Add(this.lblkikei);
            this.Controls.Add(this.lblguukei);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblguukei;
        private System.Windows.Forms.Label lblkikei;
        private System.Windows.Forms.Label lblguuko;
        private System.Windows.Forms.Label lblkiko;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

