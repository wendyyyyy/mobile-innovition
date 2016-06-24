namespace CefSharp.WinForms.Example.Minimal
{
    partial class TabulationDemoForm3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabulationDemoForm3));
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.grpBrowser = new System.Windows.Forms.GroupBox();
            this.txtDummy = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtURL.Location = new System.Drawing.Point(3, 24);
            this.txtURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(1724, 28);
            this.txtURL.TabIndex = 0;
            this.txtURL.Text = "https://itunes.apple.com/en/app/messenger/id284882215";
            this.txtURL.Enter += new System.EventHandler(this.TxtUrlEnter);
            this.txtURL.Leave += new System.EventHandler(this.TxtUrlLeave);
            // 
            // btnGO
            // 
            this.btnGO.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGO.Location = new System.Drawing.Point(1727, 24);
            this.btnGO.Margin = new System.Windows.Forms.Padding(4);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(65, 28);
            this.btnGO.TabIndex = 1;
            this.btnGO.Text = "go";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.BtnGoClick);
            // 
            // grpBrowser
            // 
            this.grpBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBrowser.Location = new System.Drawing.Point(0, 55);
            this.grpBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.grpBrowser.Name = "grpBrowser";
            this.grpBrowser.Padding = new System.Windows.Forms.Padding(4);
            this.grpBrowser.Size = new System.Drawing.Size(1513, 1097);
            this.grpBrowser.TabIndex = 2;
            this.grpBrowser.TabStop = false;
            this.grpBrowser.Text = "form";
            this.grpBrowser.Enter += new System.EventHandler(this.grpBrowser_Enter);
            // 
            // txtDummy
            // 
            this.txtDummy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDummy.Location = new System.Drawing.Point(0, 1152);
            this.txtDummy.Margin = new System.Windows.Forms.Padding(4);
            this.txtDummy.Multiline = true;
            this.txtDummy.Name = "txtDummy";
            this.txtDummy.Size = new System.Drawing.Size(1795, 70);
            this.txtDummy.TabIndex = 3;
            this.txtDummy.Text = "log";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.inputText);
            this.groupBox1.Controls.Add(this.outputText);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(1513, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 1097);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "test";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(171, 391);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 34);
            this.button9.TabIndex = 10;
            this.button9.Text = "copy";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(171, 351);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 34);
            this.button8.TabIndex = 9;
            this.button8.Text = "clear";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(10, 351);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(136, 34);
            this.button7.TabIndex = 8;
            this.button7.Text = "query";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // inputText
            // 
            this.inputText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.inputText.Location = new System.Drawing.Point(3, 442);
            this.inputText.Margin = new System.Windows.Forms.Padding(4);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(276, 340);
            this.inputText.TabIndex = 6;
            this.inputText.Text = "id284882215\r\nid506627515\r\nid454638411\r\nid442012681\r\nid487119327\r\nid544007664\r\nid8" +
    "77207891\r\nid359917414";
            this.inputText.WordWrap = false;
            // 
            // outputText
            // 
            this.outputText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputText.Location = new System.Drawing.Point(3, 782);
            this.outputText.Margin = new System.Windows.Forms.Padding(4);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(276, 312);
            this.outputText.TabIndex = 5;
            this.outputText.WordWrap = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtURL);
            this.groupBox2.Controls.Add(this.btnGO);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1795, 55);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "guide";
            // 
            // TabulationDemoForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1795, 1222);
            this.Controls.Add(this.grpBrowser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtDummy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TabulationDemoForm3";
            this.Text = "Test";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.GroupBox grpBrowser;
        private System.Windows.Forms.TextBox txtDummy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}