﻿
namespace Hops
{
    partial class HopsAppSettingsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._serversTextBox = new System.Windows.Forms.TextBox();
            this._hideWorkerWindows = new System.Windows.Forms.CheckBox();
            this._launchWorkerAtStart = new System.Windows.Forms.CheckBox();
            this._btnClearMemCache = new System.Windows.Forms.Button();
            this._lblCacheCount = new System.Windows.Forms.Label();
            this._childComputeCount = new System.Windows.Forms.NumericUpDown();
            this._updateChildCountButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this._maxConcurrentRequestsTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._apiKeyTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this._childComputeCount)).BeginInit();
            this.SuspendLayout();
            // 
            // _serversTextBox
            // 
            this._serversTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._serversTextBox.Location = new System.Drawing.Point(2, 1);
            this._serversTextBox.Margin = new System.Windows.Forms.Padding(2);
            this._serversTextBox.Multiline = true;
            this._serversTextBox.Name = "_serversTextBox";
            this._serversTextBox.Size = new System.Drawing.Size(295, 49);
            this._serversTextBox.TabIndex = 1;
            // 
            // _hideWorkerWindows
            // 
            this._hideWorkerWindows.AutoSize = true;
            this._hideWorkerWindows.Location = new System.Drawing.Point(2, 128);
            this._hideWorkerWindows.Margin = new System.Windows.Forms.Padding(2);
            this._hideWorkerWindows.Name = "_hideWorkerWindows";
            this._hideWorkerWindows.Size = new System.Drawing.Size(207, 17);
            this._hideWorkerWindows.TabIndex = 5;
            this._hideWorkerWindows.Text = "Hide Rhino.Compute Console Window";
            this._hideWorkerWindows.UseVisualStyleBackColor = true;
            // 
            // _launchWorkerAtStart
            // 
            this._launchWorkerAtStart.AutoSize = true;
            this._launchWorkerAtStart.Location = new System.Drawing.Point(2, 150);
            this._launchWorkerAtStart.Margin = new System.Windows.Forms.Padding(2);
            this._launchWorkerAtStart.Name = "_launchWorkerAtStart";
            this._launchWorkerAtStart.Size = new System.Drawing.Size(204, 17);
            this._launchWorkerAtStart.TabIndex = 6;
            this._launchWorkerAtStart.Text = "Launch Local Rhino.Compute at Start";
            this._launchWorkerAtStart.UseVisualStyleBackColor = true;
            // 
            // _btnClearMemCache
            // 
            this._btnClearMemCache.Location = new System.Drawing.Point(2, 100);
            this._btnClearMemCache.Margin = new System.Windows.Forms.Padding(2);
            this._btnClearMemCache.Name = "_btnClearMemCache";
            this._btnClearMemCache.Size = new System.Drawing.Size(160, 22);
            this._btnClearMemCache.TabIndex = 4;
            this._btnClearMemCache.Text = "Clear Hops Memory Cache";
            this._btnClearMemCache.UseVisualStyleBackColor = true;
            // 
            // _lblCacheCount
            // 
            this._lblCacheCount.AutoSize = true;
            this._lblCacheCount.Location = new System.Drawing.Point(166, 105);
            this._lblCacheCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._lblCacheCount.Name = "_lblCacheCount";
            this._lblCacheCount.Size = new System.Drawing.Size(126, 13);
            this._lblCacheCount.TabIndex = 5;
            this._lblCacheCount.Text = "(1000000 items in cache)";
            // 
            // _childComputeCount
            // 
            this._childComputeCount.Location = new System.Drawing.Point(2, 173);
            this._childComputeCount.Margin = new System.Windows.Forms.Padding(2);
            this._childComputeCount.Name = "_childComputeCount";
            this._childComputeCount.Size = new System.Drawing.Size(60, 20);
            this._childComputeCount.TabIndex = 7;
            // 
            // _updateChildCountButton
            // 
            this._updateChildCountButton.Location = new System.Drawing.Point(68, 172);
            this._updateChildCountButton.Margin = new System.Windows.Forms.Padding(2);
            this._updateChildCountButton.Name = "_updateChildCountButton";
            this._updateChildCountButton.Size = new System.Drawing.Size(138, 22);
            this._updateChildCountButton.TabIndex = 8;
            this._updateChildCountButton.Text = "Child Process Count";
            this._updateChildCountButton.UseVisualStyleBackColor = true;
            // 
            // _maxConcurrentRequestsTextbox
            // 
            this._maxConcurrentRequestsTextbox.Location = new System.Drawing.Point(136, 76);
            this._maxConcurrentRequestsTextbox.Margin = new System.Windows.Forms.Padding(2);
            this._maxConcurrentRequestsTextbox.Name = "_maxConcurrentRequestsTextbox";
            this._maxConcurrentRequestsTextbox.Size = new System.Drawing.Size(42, 20);
            this._maxConcurrentRequestsTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Max Concurrent Requests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "API Key";
            // 
            // _apiKeyTextbox
            // 
            this._apiKeyTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._apiKeyTextbox.Location = new System.Drawing.Point(51, 53);
            this._apiKeyTextbox.Margin = new System.Windows.Forms.Padding(2);
            this._apiKeyTextbox.Name = "_apiKeyTextbox";
            this._apiKeyTextbox.Size = new System.Drawing.Size(246, 20);
            this._apiKeyTextbox.TabIndex = 2;
            // 
            // HopsAppSettingsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._apiKeyTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._maxConcurrentRequestsTextbox);
            this.Controls.Add(this._updateChildCountButton);
            this.Controls.Add(this._childComputeCount);
            this.Controls.Add(this._lblCacheCount);
            this.Controls.Add(this._btnClearMemCache);
            this.Controls.Add(this._launchWorkerAtStart);
            this.Controls.Add(this._hideWorkerWindows);
            this.Controls.Add(this._serversTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HopsAppSettingsUserControl";
            this.Size = new System.Drawing.Size(300, 202);
            ((System.ComponentModel.ISupportInitialize)(this._childComputeCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox _serversTextBox;
        private System.Windows.Forms.CheckBox _hideWorkerWindows;
        private System.Windows.Forms.CheckBox _launchWorkerAtStart;
        private System.Windows.Forms.Button _btnClearMemCache;
        private System.Windows.Forms.Label _lblCacheCount;
        private System.Windows.Forms.NumericUpDown _childComputeCount;
        private System.Windows.Forms.Button _updateChildCountButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox _maxConcurrentRequestsTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _apiKeyTextbox;
    }
}
