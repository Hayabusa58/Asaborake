namespace Asaborake
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.auth_button = new System.Windows.Forms.Button();
            this.menu_tab = new System.Windows.Forms.TabControl();
            this.account_tab_page = new System.Windows.Forms.TabPage();
            this.pin_input_button = new System.Windows.Forms.Button();
            this.input_pin_label = new System.Windows.Forms.Label();
            this.authed_account_label = new System.Windows.Forms.Label();
            this.current_account_label = new System.Windows.Forms.Label();
            this.current_acount_show_label = new System.Windows.Forms.Label();
            this.auth_complete_label = new System.Windows.Forms.Label();
            this.pin_textbox = new System.Windows.Forms.TextBox();
            this.push_authbutton_label = new System.Windows.Forms.Label();
            this.tweet_tab_page = new System.Windows.Forms.TabPage();
            this.tweet_textbox = new System.Windows.Forms.TextBox();
            this.tweet_button = new System.Windows.Forms.Button();
            this.current_account_show_label = new System.Windows.Forms.Label();
            this.tweet_textbox_label = new System.Windows.Forms.Label();
            this.menu_tab.SuspendLayout();
            this.account_tab_page.SuspendLayout();
            this.tweet_tab_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // auth_button
            // 
            this.auth_button.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auth_button.Location = new System.Drawing.Point(15, 26);
            this.auth_button.Name = "auth_button";
            this.auth_button.Size = new System.Drawing.Size(104, 29);
            this.auth_button.TabIndex = 2;
            this.auth_button.Text = "アカウント認証";
            this.auth_button.UseVisualStyleBackColor = true;
            this.auth_button.Click += new System.EventHandler(this.auth_button_Click);
            // 
            // menu_tab
            // 
            this.menu_tab.Controls.Add(this.account_tab_page);
            this.menu_tab.Controls.Add(this.tweet_tab_page);
            this.menu_tab.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_tab.Location = new System.Drawing.Point(12, 3);
            this.menu_tab.Name = "menu_tab";
            this.menu_tab.SelectedIndex = 0;
            this.menu_tab.Size = new System.Drawing.Size(404, 248);
            this.menu_tab.TabIndex = 7;
            // 
            // account_tab_page
            // 
            this.account_tab_page.Controls.Add(this.pin_input_button);
            this.account_tab_page.Controls.Add(this.input_pin_label);
            this.account_tab_page.Controls.Add(this.authed_account_label);
            this.account_tab_page.Controls.Add(this.current_account_label);
            this.account_tab_page.Controls.Add(this.current_acount_show_label);
            this.account_tab_page.Controls.Add(this.auth_complete_label);
            this.account_tab_page.Controls.Add(this.pin_textbox);
            this.account_tab_page.Controls.Add(this.push_authbutton_label);
            this.account_tab_page.Controls.Add(this.auth_button);
            this.account_tab_page.Location = new System.Drawing.Point(4, 22);
            this.account_tab_page.Name = "account_tab_page";
            this.account_tab_page.Padding = new System.Windows.Forms.Padding(3);
            this.account_tab_page.Size = new System.Drawing.Size(396, 222);
            this.account_tab_page.TabIndex = 0;
            this.account_tab_page.Text = "アカウント設定";
            this.account_tab_page.UseVisualStyleBackColor = true;
            this.account_tab_page.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // pin_input_button
            // 
            this.pin_input_button.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin_input_button.Location = new System.Drawing.Point(15, 116);
            this.pin_input_button.Name = "pin_input_button";
            this.pin_input_button.Size = new System.Drawing.Size(104, 29);
            this.pin_input_button.TabIndex = 14;
            this.pin_input_button.Text = "PIN入力完了";
            this.pin_input_button.UseVisualStyleBackColor = true;
            this.pin_input_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // input_pin_label
            // 
            this.input_pin_label.AutoSize = true;
            this.input_pin_label.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_pin_label.Location = new System.Drawing.Point(11, 67);
            this.input_pin_label.Name = "input_pin_label";
            this.input_pin_label.Size = new System.Drawing.Size(197, 21);
            this.input_pin_label.TabIndex = 13;
            this.input_pin_label.Text = "2. PINコードを入力してください";
            // 
            // authed_account_label
            // 
            this.authed_account_label.AutoSize = true;
            this.authed_account_label.Location = new System.Drawing.Point(181, 195);
            this.authed_account_label.Name = "authed_account_label";
            this.authed_account_label.Size = new System.Drawing.Size(37, 13);
            this.authed_account_label.TabIndex = 12;
            this.authed_account_label.Text = "label2";
            this.authed_account_label.Visible = false;
            // 
            // current_account_label
            // 
            this.current_account_label.AutoSize = true;
            this.current_account_label.Location = new System.Drawing.Point(181, 195);
            this.current_account_label.Name = "current_account_label";
            this.current_account_label.Size = new System.Drawing.Size(0, 13);
            this.current_account_label.TabIndex = 11;
            // 
            // current_acount_show_label
            // 
            this.current_acount_show_label.AutoSize = true;
            this.current_acount_show_label.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_acount_show_label.Location = new System.Drawing.Point(51, 195);
            this.current_acount_show_label.Name = "current_acount_show_label";
            this.current_acount_show_label.Size = new System.Drawing.Size(114, 13);
            this.current_acount_show_label.TabIndex = 10;
            this.current_acount_show_label.Text = "現在認証中のアカウント:";
            // 
            // auth_complete_label
            // 
            this.auth_complete_label.AutoSize = true;
            this.auth_complete_label.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auth_complete_label.Location = new System.Drawing.Point(49, 159);
            this.auth_complete_label.Name = "auth_complete_label";
            this.auth_complete_label.Size = new System.Drawing.Size(283, 30);
            this.auth_complete_label.TabIndex = 9;
            this.auth_complete_label.Text = "アカウントの認証を完了しました。";
            this.auth_complete_label.Visible = false;
            // 
            // pin_textbox
            // 
            this.pin_textbox.Location = new System.Drawing.Point(15, 90);
            this.pin_textbox.Name = "pin_textbox";
            this.pin_textbox.Size = new System.Drawing.Size(375, 22);
            this.pin_textbox.TabIndex = 8;
            // 
            // push_authbutton_label
            // 
            this.push_authbutton_label.AutoSize = true;
            this.push_authbutton_label.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.push_authbutton_label.Location = new System.Drawing.Point(11, 3);
            this.push_authbutton_label.Name = "push_authbutton_label";
            this.push_authbutton_label.Size = new System.Drawing.Size(327, 21);
            this.push_authbutton_label.TabIndex = 7;
            this.push_authbutton_label.Text = "1. 以下のアカウント認証ボタンをクリックしてください";
            // 
            // tweet_tab_page
            // 
            this.tweet_tab_page.Controls.Add(this.tweet_textbox);
            this.tweet_tab_page.Controls.Add(this.tweet_button);
            this.tweet_tab_page.Controls.Add(this.current_account_show_label);
            this.tweet_tab_page.Controls.Add(this.tweet_textbox_label);
            this.tweet_tab_page.Location = new System.Drawing.Point(4, 22);
            this.tweet_tab_page.Name = "tweet_tab_page";
            this.tweet_tab_page.Padding = new System.Windows.Forms.Padding(3);
            this.tweet_tab_page.Size = new System.Drawing.Size(396, 222);
            this.tweet_tab_page.TabIndex = 1;
            this.tweet_tab_page.Text = "ツイート画面";
            this.tweet_tab_page.UseVisualStyleBackColor = true;
            // 
            // tweet_textbox
            // 
            this.tweet_textbox.Location = new System.Drawing.Point(11, 44);
            this.tweet_textbox.Multiline = true;
            this.tweet_textbox.Name = "tweet_textbox";
            this.tweet_textbox.Size = new System.Drawing.Size(377, 133);
            this.tweet_textbox.TabIndex = 7;
            // 
            // tweet_button
            // 
            this.tweet_button.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tweet_button.Location = new System.Drawing.Point(293, 183);
            this.tweet_button.Name = "tweet_button";
            this.tweet_button.Size = new System.Drawing.Size(95, 33);
            this.tweet_button.TabIndex = 8;
            this.tweet_button.Text = "ツイートする";
            this.tweet_button.UseVisualStyleBackColor = true;
            this.tweet_button.Click += new System.EventHandler(this.tweet_button_Click);
            // 
            // current_account_show_label
            // 
            this.current_account_show_label.AutoSize = true;
            this.current_account_show_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.current_account_show_label.Location = new System.Drawing.Point(213, 16);
            this.current_account_show_label.Name = "current_account_show_label";
            this.current_account_show_label.Size = new System.Drawing.Size(0, 25);
            this.current_account_show_label.TabIndex = 6;
            // 
            // tweet_textbox_label
            // 
            this.tweet_textbox_label.AutoSize = true;
            this.tweet_textbox_label.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tweet_textbox_label.Location = new System.Drawing.Point(6, 16);
            this.tweet_textbox_label.Name = "tweet_textbox_label";
            this.tweet_textbox_label.Size = new System.Drawing.Size(68, 28);
            this.tweet_textbox_label.TabIndex = 5;
            this.tweet_textbox_label.Text = "ツイート";
            this.tweet_textbox_label.Click += new System.EventHandler(this.current_account_label_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 254);
            this.Controls.Add(this.menu_tab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Asaborake";
            this.menu_tab.ResumeLayout(false);
            this.account_tab_page.ResumeLayout(false);
            this.account_tab_page.PerformLayout();
            this.tweet_tab_page.ResumeLayout(false);
            this.tweet_tab_page.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button auth_button;
        private System.Windows.Forms.TabControl menu_tab;
        private System.Windows.Forms.TabPage account_tab_page;
        private System.Windows.Forms.Label auth_complete_label;
        private System.Windows.Forms.TextBox pin_textbox;
        private System.Windows.Forms.Label push_authbutton_label;
        private System.Windows.Forms.TabPage tweet_tab_page;
        private System.Windows.Forms.TextBox tweet_textbox;
        private System.Windows.Forms.Button tweet_button;
        private System.Windows.Forms.Label current_account_show_label;
        private System.Windows.Forms.Label tweet_textbox_label;
        private System.Windows.Forms.Label current_account_label;
        private System.Windows.Forms.Label current_acount_show_label;
        private System.Windows.Forms.Label authed_account_label;
        private System.Windows.Forms.Label input_pin_label;
        private System.Windows.Forms.Button pin_input_button;
    }
}

