// Copyright © 2010-2016 The CefSharp Authors. All rights reserved.
//
// Use of this source code is governed by a BSD-style license that can be found in the LICENSE file.

using CefSharp;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace CefSharp.WinForms.Example.Minimal
{
    public partial class TabulationDemoForm3 : Form
    {
        private readonly ChromiumWebBrowser chromiumWebBrowser;
        private readonly Color focusColor = Color.Yellow;
        private readonly Color nonFocusColor = Color.White;

        public TabulationDemoForm3()
        {
            InitializeComponent();
            chromiumWebBrowser = new ChromiumWebBrowser(txtURL.Text) { Dock = DockStyle.Fill };

            var userControl = new UserControl { Dock = DockStyle.Fill };
            userControl.Enter += UserControlEnter;
            userControl.Leave += UserControlLeave;
            userControl.Controls.Add(chromiumWebBrowser);
            txtURL.GotFocus += TxtUrlGotFocus;
            txtURL.LostFocus += TxtUrlLostFocus;

            grpBrowser.Controls.Add(userControl);

        }

        private void TxtUrlLostFocus(object sender, EventArgs e)
        {
            // Uncomment this if you want the address bar to go white
            // during deactivation:
            //UpdateUrlColor(nonFocusColor);
        }

        private void TxtUrlGotFocus(object sender, EventArgs e)
        {
            // Ensure the control turns yellow on form
            // activation (since Enter events don't fire then)
            UpdateUrlColor(focusColor);
        }

        private void UpdateUrlColor(Color color)
        {
            if (txtURL.BackColor != color)
            {
                txtURL.BackColor = color;
            }
        }

        private void UserControlLeave(object sender, EventArgs e)
        {
            txtDummy.Text = "UserControl OnLeave";
        }

        private void UserControlEnter(object sender, EventArgs e)
        {
            txtDummy.Text = "UserControl OnEnter";
        }

        private void BtnGoClick(object sender, EventArgs e)
        {
            chromiumWebBrowser.Load(txtURL.Text);
        }

        private void TxtUrlLeave(object sender, EventArgs e)
        {
            UpdateUrlColor(nonFocusColor);
        }

        private void TxtUrlEnter(object sender, EventArgs e)
        {
            UpdateUrlColor(focusColor);
        }

        private void grpBrowser_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser.ViewSource();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var htmlSource = await chromiumWebBrowser.GetSourceAsync();

            Clipboard.SetText(htmlSource);
            txtDummy.Text = "HTML Source copied to clipboard";

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string data = await getBodyHTML();

            Clipboard.SetText(data);
            txtDummy.Text = "BODY Source copied to clipboard";
        }


        private async void button4_Click(object sender, EventArgs e)
        {           
            await setValueByID("kw", "测试");
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            await clickByID("su");
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            string[] aS = inputText.Text.Split('\n');

            for(int i = 0; i < aS.Length; i++) {
                string s1 = aS[i].Replace('\r', ' ');

                // 1 gbqfq 赋值，搜索
                await setValueByID("gbqfq", s1);

                // 2 gbqfb 点击
                await clickByID("gbqfb");
                Thread.Sleep(2000);

                // 3 获取链接
                string res = await getFirstByTagTag("href=\"/store/apps/details?id=", "\"", 6);

                // 4 转到页面
                await gotoURL("https://play.google.com"+res);
                Thread.Sleep(2000);

                // 5 获取版本的例子
                string ver = await getFirstByTagTag("softwareVersion\">", "<", 17);
                outputText.Text += s1 + "=" + ver + " : "+ res + "\r\n";

                // 调试时，可以中断
                //break;
            }
        }

        // 根据起始字符串和结束字符串获取第一个匹配内容
        private async System.Threading.Tasks.Task<string> getFirstByTagTag(string beg, string end, int offset)
        {
            string res = "";

            // 获取 body 部分 html 代码
            string data = await getBodyHTML();

            int i = data.IndexOf(beg);
            if (i >= 0)
            {
                data = data.Substring(i + offset);
                res  = data.Remove(data.IndexOf(end));
            }

            return res;
        }

        // 根据起始字符串和结束字符串获取匹配内容
        private async System.Threading.Tasks.Task<string> getByTagTag(string beg, string end, int offset)
        {
            string res = "";

            // 获取 body 部分 html 代码
            string data = await getBodyHTML();

            int i = data.IndexOf(beg);
            while (i >= 0)
            {
                data = data.Substring(i + offset);
                res += data.Remove(data.IndexOf(end)) + "\r\n";
                i = data.IndexOf(beg);
            }

            return res;
        }


        // 根据起始字符串和结束字符串获取匹配内容
        private async System.Threading.Tasks.Task<string> get2ByTagTag(string beg1, string end1, int offset1, string beg2, string end2, int offset2)
        {
            string res = "";

            // 获取 body 部分 html 代码
            string data = await getBodyHTML();

            int i = data.IndexOf(beg1);
            while (i >= 0)
            {

                data = data.Substring(i + offset1);
                res += data.Remove(data.IndexOf(end1)) + "$";

                i = data.IndexOf(beg2);
                data = data.Substring(i + offset2);
                res += data.Remove(data.IndexOf(end2)) + "\r\n";

                i = data.IndexOf(beg1);

            }

            return res;
        }


        // 根据 ID 点击
        private async System.Threading.Tasks.Task gotoURL(string url)
        {
            var script =
               @"(function () {
                    window.location.href='##URL##';
                    return s;
                })();";
            script = Regex.Replace(script, "##URL##", url);
            await chromiumWebBrowser.EvaluateScriptAsync(script);
        }

        // 根据 ID 点击
        private async System.Threading.Tasks.Task clickByID(string id)
        {
            var script =
               @"(function () {
                    var elem = document.getElementById('##ID##');
                    elem.click();
                    return s;
                })();";
            script = Regex.Replace(script, "##ID##", id);
            await chromiumWebBrowser.EvaluateScriptAsync(script);
        }

        // 根据 ID 赋值
        private async System.Threading.Tasks.Task setValueByID(string id,string val)
        {
            var script =
               @"(function () {
                    var elem = document.getElementById('##ID##');
                    elem.value = '##VAL##';
                    return s;
                })();";
            script = Regex.Replace(script, "##ID##", id);
            script = Regex.Replace(script, "##VAL##", val);
            await chromiumWebBrowser.EvaluateScriptAsync(script);
        }

        // 获取 Body 部分的 HTML 源码
        private async System.Threading.Tasks.Task<string> getBodyHTML()
        {
            var script =
                @"(function () {
                    var s = document.body.innerHTML; 
                    return s;
                })();";
            var response = await chromiumWebBrowser.EvaluateScriptAsync(script);
            if (!response.Success)
            {
                throw new Exception(response.Message);
            }

            return (string)response.Result;
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            string[] aS = inputText.Text.Split('\n');

            for (int i = 0; i < aS.Length; i++)
            {
                // 0 获取 app 名称
                string s1 = aS[i].Replace('\r', ' ').Trim();

                if (s1.Length > 0)
                {
                    // 1 gbqfq 赋值，搜索
                    await gotoURL("https://itunes.apple.com/en/app/messenger/" + s1);

                    // 2 gbqfb 点击
                    Thread.Sleep(3000);

                    // 3 获取链接中的 ID
                    string res = await getFirstByTagTag("h1 itemprop=\"name\"", "</h2>", 19);
                    outputText.Text += s1 + "=" + res + "\r\n";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputText.Text = "";
            outputText.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(outputText.Text.Length > 0)
            {
                Clipboard.SetText(outputText.Text);
            }
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            //amount - pay">- 1000.00<
            //string res = await getByTagTag("amount-pay\">", "<", 12);
            string res = await get2ByTagTag("amount-pay\">", "<", 12, "status\">", "</",8);
            outputText.Text += res + "\r\n";
        }
    }
}
