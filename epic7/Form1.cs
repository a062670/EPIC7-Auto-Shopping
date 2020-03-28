using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace epic7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        CDmSoft dm;
        bool stop = true;

        int input_times = 333;
        int times = 0;
        int bookmark = 0;
        int medals = 0;

        Thread th;

        private bool bind_window()
        {
            int hwnd = dm.FindWindow("LDPlayerMainFrame", "雷電模擬器");
            hwnd = Int32.Parse(dm.EnumWindow(hwnd, "TheRender", "RenderWindow", 4));
            //hwnd = Int32.Parse(dm.EnumWindow(hwnd, "sub", "subWin", 4));

            int dm_ret = dm.BindWindowEx(hwnd, "gdi", "windows", "windows", "", 0);
            //int dm_ret = dm.BindWindow(hwnd, "normal", "normal", "dx", 0);
            if (dm_ret != 1)
            {
                MessageBox.Show("我找不到模擬器！");
                return false;
            }

            return true;
        }


        private void Run()
        {
            reset();
            stop = false;

            // 確認商店、非停止、未到達限制次數
            while (step_check_page() && !stop && times < input_times) {
                step_check_all();
                // 更新
                step_update();
                times++;
                lb_times.Text = times.ToString();
            }
            step_check_all();

            //MessageBox.Show("結束");
            stop = true;
        }

        private void step_check_all()
        {
            // 書籤
            step_find_bookmark();
            // 獎牌
            step_find_medals();
            // 往下拉
            step_scroll();
            // 書籤
            step_find_bookmark();
            // 獎牌
            step_find_medals();
        }
        // 確認是否在商店
        private bool step_check_page()
        {
            object X = 0;
            object Y = 0;
            dm.FindPic(0, 0, 960, 540, "update.bmp", "000000", 0.9, 0, out X, out Y);

            int x = (int)X;
            int y = (int)Y;
            if (x < 0 && y < 0)
            {
                MessageBox.Show("請前往商店");
                return false;
            }
            return true;
        }

        // 尋找購買書籤
        private void step_find_bookmark()
        {
            Thread.Sleep(1000);
            object X = 0;
            object Y = 0;
            dm.FindPic(0, 0, 960, 540, "bookmarkText.bmp", "444444", 0.7, 0, out X, out Y);

            if ((int)X < 0 || (int)Y < 0) {
                dm.FindPic(0, 0, 960, 540, "bookmarkText2.bmp", "444444", 0.7, 0, out X, out Y);
            }

            int x = (int)X;
            int y = (int)Y;
            //MessageBox.Show(x.ToString() + "," + y.ToString());
            if (x >= 0 && y >= 0)
            {
                dm.MoveTo(x + 380, y + 40);
                dm.LeftClick();
                Thread.Sleep(1000);
                dm.MoveTo(550, 375);
                dm.LeftClick();
                bookmark++;
                lb_bookmark.Text = bookmark.ToString();
            }
        }

        // 尋找購買獎牌
        private void step_find_medals()
        {
            Thread.Sleep(1000);
            object X = 0;
            object Y = 0;
            dm.FindPic(0, 0, 960, 540, "medalsText.bmp", "444444", 0.7, 0, out X, out Y);

            int x = (int)X;
            int y = (int)Y;
            //MessageBox.Show(x.ToString() + "," + y.ToString());
            if (x >= 0 && y >= 0)
            {
                dm.MoveTo(x + 380, y + 40);
                dm.LeftClick();
                Thread.Sleep(1000);
                dm.MoveTo(550, 375);
                dm.LeftClick();
                medals++;
                lb_medals.Text = medals.ToString();
            }
        }

        // 更新商店
        private void step_update()
        {
            Thread.Sleep(1000);
            dm.MoveTo(190, 495);
            dm.LeftClick();
            Thread.Sleep(2000);
            dm.MoveTo(560, 330);
            dm.LeftClick();
            Thread.Sleep(1000);
        }

        // 往下捲
        private void step_scroll()
        {
            Thread.Sleep(1000);
            dm.MoveTo(610, 320);
            dm.LeftDown();
            dm.MoveTo(610, 120);
            dm.LeftUp();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            dm = new CDmSoft();

            if (!bind_window())
            {
                return;
            }

            input_times = Int32.Parse(tb_times.Text);

            th = new Thread(() =>
            {
                Run();
            });
            th.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            if (!stop)
            {
                th.Abort();
            }
            stop = true;
        }

        private void reset()
        {
            times = 0;
            bookmark = 0;
            medals = 0;
            lb_times.Text = times.ToString();
            lb_bookmark.Text = bookmark.ToString();
            lb_medals.Text = medals.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            step_update();
        }

        private void btn_bind_window_Click(object sender, EventArgs e)
        {
            dm = new CDmSoft();
            if (bind_window()) {
                MessageBox.Show("OK");
            }
        }

        private void btn_find_medals_Click(object sender, EventArgs e)
        {
            step_find_medals();
        }

        private void btn_scroll_Click(object sender, EventArgs e)
        {
            step_scroll();
        }

        private void btn_find_bookmark_Click(object sender, EventArgs e)
        {
            step_find_bookmark();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!stop) { 
                th.Abort();
            }
            stop = true;
        }

        private void btn_capture_Click(object sender, EventArgs e)
        {
            int x1 = Int32.Parse(tb_capture_x1.Text);
            int y1 = Int32.Parse(tb_capture_y1.Text);
            int x2 = Int32.Parse(tb_capture_x2.Text);
            int y2 = Int32.Parse(tb_capture_y2.Text);
            dm.Capture(x1, y1, x2, y2, "capture.bmp");
            MessageBox.Show("Capture");
        }
    }
}
