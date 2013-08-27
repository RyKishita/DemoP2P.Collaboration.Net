namespace DemoP2P_Collaboration
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
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonPeerScopeNone = new System.Windows.Forms.RadioButton();
            this.radioButtonPeerScopeNearMe = new System.Windows.Forms.RadioButton();
            this.radioButtonPeerScopeInternet = new System.Windows.Forms.RadioButton();
            this.radioButtonPeerScopeAll = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.buttonStartOrUpdate = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.listViewLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkBoxAutoScroll = new System.Windows.Forms.CheckBox();
            this.checkBoxShowSystemLog = new System.Windows.Forms.CheckBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            this.groupBoxLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "ネットワークの範囲";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.radioButtonPeerScopeNone);
            this.panel2.Controls.Add(this.radioButtonPeerScopeNearMe);
            this.panel2.Controls.Add(this.radioButtonPeerScopeInternet);
            this.panel2.Controls.Add(this.radioButtonPeerScopeAll);
            this.panel2.Location = new System.Drawing.Point(125, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 88);
            this.panel2.TabIndex = 7;
            // 
            // radioButtonPeerScopeNone
            // 
            this.radioButtonPeerScopeNone.AutoSize = true;
            this.radioButtonPeerScopeNone.Location = new System.Drawing.Point(3, 69);
            this.radioButtonPeerScopeNone.Name = "radioButtonPeerScopeNone";
            this.radioButtonPeerScopeNone.Size = new System.Drawing.Size(42, 16);
            this.radioButtonPeerScopeNone.TabIndex = 3;
            this.radioButtonPeerScopeNone.Text = "なし";
            this.radioButtonPeerScopeNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonPeerScopeNearMe
            // 
            this.radioButtonPeerScopeNearMe.AutoSize = true;
            this.radioButtonPeerScopeNearMe.Checked = true;
            this.radioButtonPeerScopeNearMe.Location = new System.Drawing.Point(3, 47);
            this.radioButtonPeerScopeNearMe.Name = "radioButtonPeerScopeNearMe";
            this.radioButtonPeerScopeNearMe.Size = new System.Drawing.Size(100, 16);
            this.radioButtonPeerScopeNearMe.TabIndex = 2;
            this.radioButtonPeerScopeNearMe.TabStop = true;
            this.radioButtonPeerScopeNearMe.Text = "同じサブネット内";
            this.radioButtonPeerScopeNearMe.UseVisualStyleBackColor = true;
            // 
            // radioButtonPeerScopeInternet
            // 
            this.radioButtonPeerScopeInternet.AutoSize = true;
            this.radioButtonPeerScopeInternet.Location = new System.Drawing.Point(3, 25);
            this.radioButtonPeerScopeInternet.Name = "radioButtonPeerScopeInternet";
            this.radioButtonPeerScopeInternet.Size = new System.Drawing.Size(84, 16);
            this.radioButtonPeerScopeInternet.TabIndex = 1;
            this.radioButtonPeerScopeInternet.Text = "インターネット";
            this.radioButtonPeerScopeInternet.UseVisualStyleBackColor = true;
            // 
            // radioButtonPeerScopeAll
            // 
            this.radioButtonPeerScopeAll.AutoSize = true;
            this.radioButtonPeerScopeAll.Location = new System.Drawing.Point(3, 3);
            this.radioButtonPeerScopeAll.Name = "radioButtonPeerScopeAll";
            this.radioButtonPeerScopeAll.Size = new System.Drawing.Size(52, 16);
            this.radioButtonPeerScopeAll.TabIndex = 0;
            this.radioButtonPeerScopeAll.Text = "すべて";
            this.radioButtonPeerScopeAll.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "データ";
            // 
            // textBoxData
            // 
            this.textBoxData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxData.Location = new System.Drawing.Point(122, 106);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(331, 19);
            this.textBoxData.TabIndex = 11;
            // 
            // buttonStartOrUpdate
            // 
            this.buttonStartOrUpdate.Location = new System.Drawing.Point(125, 131);
            this.buttonStartOrUpdate.Name = "buttonStartOrUpdate";
            this.buttonStartOrUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonStartOrUpdate.TabIndex = 12;
            this.buttonStartOrUpdate.Text = "開始";
            this.buttonStartOrUpdate.UseVisualStyleBackColor = true;
            this.buttonStartOrUpdate.Click += new System.EventHandler(this.buttonStartOrUpdate_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(206, 131);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "停止";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // listViewLog
            // 
            this.listViewLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewLog.FullRowSelect = true;
            this.listViewLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewLog.Location = new System.Drawing.Point(6, 18);
            this.listViewLog.MultiSelect = false;
            this.listViewLog.Name = "listViewLog";
            this.listViewLog.Size = new System.Drawing.Size(427, 179);
            this.listViewLog.TabIndex = 0;
            this.listViewLog.UseCompatibleStateImageBehavior = false;
            this.listViewLog.View = System.Windows.Forms.View.Details;
            // 
            // checkBoxAutoScroll
            // 
            this.checkBoxAutoScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAutoScroll.AutoSize = true;
            this.checkBoxAutoScroll.Checked = true;
            this.checkBoxAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoScroll.Location = new System.Drawing.Point(208, 207);
            this.checkBoxAutoScroll.Name = "checkBoxAutoScroll";
            this.checkBoxAutoScroll.Size = new System.Drawing.Size(94, 16);
            this.checkBoxAutoScroll.TabIndex = 6;
            this.checkBoxAutoScroll.Text = "自動スクロール";
            this.checkBoxAutoScroll.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowSystemLog
            // 
            this.checkBoxShowSystemLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShowSystemLog.AutoSize = true;
            this.checkBoxShowSystemLog.Checked = true;
            this.checkBoxShowSystemLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowSystemLog.Location = new System.Drawing.Point(319, 207);
            this.checkBoxShowSystemLog.Name = "checkBoxShowSystemLog";
            this.checkBoxShowSystemLog.Size = new System.Drawing.Size(114, 16);
            this.checkBoxShowSystemLog.TabIndex = 7;
            this.checkBoxShowSystemLog.Text = "システムログの表示";
            this.checkBoxShowSystemLog.UseVisualStyleBackColor = true;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoad.Location = new System.Drawing.Point(6, 203);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(124, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "最新の情報に更新";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLog.Controls.Add(this.listViewLog);
            this.groupBoxLog.Controls.Add(this.buttonLoad);
            this.groupBoxLog.Controls.Add(this.checkBoxAutoScroll);
            this.groupBoxLog.Controls.Add(this.checkBoxShowSystemLog);
            this.groupBoxLog.Location = new System.Drawing.Point(14, 160);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(439, 232);
            this.groupBoxLog.TabIndex = 14;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "ログ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 404);
            this.Controls.Add(this.groupBoxLog);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonStartOrUpdate);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "P2Pデモ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxLog.ResumeLayout(false);
            this.groupBoxLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonPeerScopeNearMe;
        private System.Windows.Forms.RadioButton radioButtonPeerScopeInternet;
        private System.Windows.Forms.RadioButton radioButtonPeerScopeAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button buttonStartOrUpdate;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListView listViewLog;
        private System.Windows.Forms.CheckBox checkBoxAutoScroll;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.CheckBox checkBoxShowSystemLog;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.RadioButton radioButtonPeerScopeNone;
    }
}

