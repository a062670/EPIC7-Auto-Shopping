namespace epic7
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_times = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_times = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_bookmark = new System.Windows.Forms.Label();
            this.lb_medals = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_check_page = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_bind_window = new System.Windows.Forms.Button();
            this.btn_find_medals = new System.Windows.Forms.Button();
            this.btn_find_bookmark = new System.Windows.Forms.Button();
            this.btn_scroll = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_capture_x1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_capture_y1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_capture_x2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_capture_y2 = new System.Windows.Forms.TextBox();
            this.btn_capture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_start.Location = new System.Drawing.Point(62, 50);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 50);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "開始";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_stop.Location = new System.Drawing.Point(143, 50);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 50);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "停止";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "設定次數";
            // 
            // tb_times
            // 
            this.tb_times.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb_times.Location = new System.Drawing.Point(118, 5);
            this.tb_times.Name = "tb_times";
            this.tb_times.Size = new System.Drawing.Size(100, 35);
            this.tb_times.TabIndex = 3;
            this.tb_times.Text = "333";
            this.tb_times.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "執行次數";
            // 
            // lb_times
            // 
            this.lb_times.AutoSize = true;
            this.lb_times.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_times.Location = new System.Drawing.Point(118, 103);
            this.lb_times.Name = "lb_times";
            this.lb_times.Size = new System.Drawing.Size(25, 28);
            this.lb_times.TabIndex = 2;
            this.lb_times.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "聖約書簽";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "神秘獎牌";
            // 
            // lb_bookmark
            // 
            this.lb_bookmark.AutoSize = true;
            this.lb_bookmark.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_bookmark.Location = new System.Drawing.Point(118, 131);
            this.lb_bookmark.Name = "lb_bookmark";
            this.lb_bookmark.Size = new System.Drawing.Size(25, 28);
            this.lb_bookmark.TabIndex = 2;
            this.lb_bookmark.Text = "0";
            // 
            // lb_medals
            // 
            this.lb_medals.AutoSize = true;
            this.lb_medals.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_medals.Location = new System.Drawing.Point(118, 159);
            this.lb_medals.Name = "lb_medals";
            this.lb_medals.Size = new System.Drawing.Size(25, 28);
            this.lb_medals.TabIndex = 2;
            this.lb_medals.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(109, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "第七史詩-彩虹彼岸";
            // 
            // btn_check_page
            // 
            this.btn_check_page.Location = new System.Drawing.Point(96, 239);
            this.btn_check_page.Name = "btn_check_page";
            this.btn_check_page.Size = new System.Drawing.Size(75, 24);
            this.btn_check_page.TabIndex = 5;
            this.btn_check_page.Text = "確認商店";
            this.btn_check_page.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(15, 268);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 24);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "立即更新";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_bind_window
            // 
            this.btn_bind_window.Location = new System.Drawing.Point(15, 239);
            this.btn_bind_window.Name = "btn_bind_window";
            this.btn_bind_window.Size = new System.Drawing.Size(75, 24);
            this.btn_bind_window.TabIndex = 7;
            this.btn_bind_window.Text = "綁定視窗";
            this.btn_bind_window.UseVisualStyleBackColor = true;
            this.btn_bind_window.Click += new System.EventHandler(this.btn_bind_window_Click);
            // 
            // btn_find_medals
            // 
            this.btn_find_medals.Location = new System.Drawing.Point(15, 297);
            this.btn_find_medals.Name = "btn_find_medals";
            this.btn_find_medals.Size = new System.Drawing.Size(75, 24);
            this.btn_find_medals.TabIndex = 8;
            this.btn_find_medals.Text = "找獎牌";
            this.btn_find_medals.UseVisualStyleBackColor = true;
            this.btn_find_medals.Click += new System.EventHandler(this.btn_find_medals_Click);
            // 
            // btn_find_bookmark
            // 
            this.btn_find_bookmark.Location = new System.Drawing.Point(96, 297);
            this.btn_find_bookmark.Name = "btn_find_bookmark";
            this.btn_find_bookmark.Size = new System.Drawing.Size(75, 24);
            this.btn_find_bookmark.TabIndex = 9;
            this.btn_find_bookmark.Text = "找書籤";
            this.btn_find_bookmark.UseVisualStyleBackColor = true;
            this.btn_find_bookmark.Click += new System.EventHandler(this.btn_find_bookmark_Click);
            // 
            // btn_scroll
            // 
            this.btn_scroll.Location = new System.Drawing.Point(96, 268);
            this.btn_scroll.Name = "btn_scroll";
            this.btn_scroll.Size = new System.Drawing.Size(75, 24);
            this.btn_scroll.TabIndex = 10;
            this.btn_scroll.Text = "往下滾滾";
            this.btn_scroll.UseVisualStyleBackColor = true;
            this.btn_scroll.Click += new System.EventHandler(this.btn_scroll_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "測試區，要先綁定視窗";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "抓圖";
            // 
            // tb_capture_x1
            // 
            this.tb_capture_x1.Location = new System.Drawing.Point(40, 339);
            this.tb_capture_x1.Name = "tb_capture_x1";
            this.tb_capture_x1.Size = new System.Drawing.Size(51, 22);
            this.tb_capture_x1.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "X1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "Y1";
            // 
            // tb_capture_y1
            // 
            this.tb_capture_y1.Location = new System.Drawing.Point(120, 339);
            this.tb_capture_y1.Name = "tb_capture_y1";
            this.tb_capture_y1.Size = new System.Drawing.Size(51, 22);
            this.tb_capture_y1.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "X2";
            // 
            // tb_capture_x2
            // 
            this.tb_capture_x2.Location = new System.Drawing.Point(39, 367);
            this.tb_capture_x2.Name = "tb_capture_x2";
            this.tb_capture_x2.Size = new System.Drawing.Size(51, 22);
            this.tb_capture_x2.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 12);
            this.label11.TabIndex = 11;
            this.label11.Text = "Y2";
            // 
            // tb_capture_y2
            // 
            this.tb_capture_y2.Location = new System.Drawing.Point(119, 367);
            this.tb_capture_y2.Name = "tb_capture_y2";
            this.tb_capture_y2.Size = new System.Drawing.Size(51, 22);
            this.tb_capture_y2.TabIndex = 12;
            // 
            // btn_capture
            // 
            this.btn_capture.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_capture.Location = new System.Drawing.Point(177, 339);
            this.btn_capture.Name = "btn_capture";
            this.btn_capture.Size = new System.Drawing.Size(41, 51);
            this.btn_capture.TabIndex = 1;
            this.btn_capture.Text = "截圖";
            this.btn_capture.UseVisualStyleBackColor = true;
            this.btn_capture.Click += new System.EventHandler(this.btn_capture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 402);
            this.Controls.Add(this.tb_capture_y2);
            this.Controls.Add(this.tb_capture_y1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_capture_x2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_capture_x1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_scroll);
            this.Controls.Add(this.btn_find_bookmark);
            this.Controls.Add(this.btn_find_medals);
            this.Controls.Add(this.btn_bind_window);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_check_page);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_times);
            this.Controls.Add(this.lb_medals);
            this.Controls.Add(this.lb_bookmark);
            this.Controls.Add(this.lb_times);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_capture);
            this.Controls.Add(this.btn_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "第七史詩-刷商店購買書籤獎牌";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_times;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_times;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_bookmark;
        private System.Windows.Forms.Label lb_medals;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_check_page;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_bind_window;
        private System.Windows.Forms.Button btn_find_medals;
        private System.Windows.Forms.Button btn_find_bookmark;
        private System.Windows.Forms.Button btn_scroll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_capture_x1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_capture_y1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_capture_x2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_capture_y2;
        private System.Windows.Forms.Button btn_capture;
    }
}

