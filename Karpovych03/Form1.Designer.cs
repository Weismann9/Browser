namespace Karpovych03
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.forwardButton = new System.Windows.Forms.ToolStripButton();
            this.reloadButton = new System.Windows.Forms.ToolStripButton();
            this.urlTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.showDevTools = new System.Windows.Forms.ToolStripButton();
            this.historyButton = new System.Windows.Forms.ToolStripSplitButton();
            this.showHistoryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryButton = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksButton = new System.Windows.Forms.ToolStripButton();
            this.settingsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabNew = new System.Windows.Forms.TabPage();
            this.tabToolStrip = new System.Windows.Forms.ToolStrip();
            this.closeTab = new System.Windows.Forms.ToolStripButton();
            this.addBookmark = new System.Windows.Forms.ToolStripButton();
            this.bookmarksStrip = new System.Windows.Forms.ToolStrip();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStrip.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.forwardButton,
            this.reloadButton,
            this.urlTextBox,
            this.showDevTools,
            this.historyButton,
            this.bookmarksButton,
            this.settingsButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1023, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Layout += new System.Windows.Forms.LayoutEventHandler(this.HandleToolStripLayout);
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Image = global::Karpovych03.Properties.Resources.nav_left_green;
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 22);
            this.backButton.Text = "Back";
            this.backButton.ToolTipText = "Click to go back";
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardButton.Image = global::Karpovych03.Properties.Resources.nav_right_green;
            this.forwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(23, 22);
            this.forwardButton.Text = "Forward";
            this.forwardButton.ToolTipText = "Click to go forward";
            this.forwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // reloadButton
            // 
            this.reloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.reloadButton.Image = global::Karpovych03.Properties.Resources.reload;
            this.reloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reloadButton.Name = "reloadButton";
            this.reloadButton.Size = new System.Drawing.Size(23, 22);
            this.reloadButton.Text = "Reload";
            this.reloadButton.ToolTipText = "Reload this page";
            this.reloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.urlTextBox.Size = new System.Drawing.Size(470, 25);
            this.urlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrlTextBox_KeyDown);
            // 
            // showDevTools
            // 
            this.showDevTools.Image = global::Karpovych03.Properties.Resources.dev_tools;
            this.showDevTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showDevTools.Name = "showDevTools";
            this.showDevTools.Size = new System.Drawing.Size(78, 22);
            this.showDevTools.Text = "Dev Tools";
            this.showDevTools.Click += new System.EventHandler(this.ShowDevTools_Click);
            // 
            // historyButton
            // 
            this.historyButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHistoryButton,
            this.clearHistoryButton});
            this.historyButton.Image = ((System.Drawing.Image)(resources.GetObject("historyButton.Image")));
            this.historyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(77, 22);
            this.historyButton.Text = "History";
            this.historyButton.ButtonClick += new System.EventHandler(this.ShowHistory_Click);
            // 
            // showHistoryButton
            // 
            this.showHistoryButton.Name = "showHistoryButton";
            this.showHistoryButton.Size = new System.Drawing.Size(103, 22);
            this.showHistoryButton.Text = "Show";
            this.showHistoryButton.Click += new System.EventHandler(this.ShowHistory_Click);
            // 
            // clearHistoryButton
            // 
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.Size = new System.Drawing.Size(103, 22);
            this.clearHistoryButton.Text = "Clear";
            this.clearHistoryButton.Click += new System.EventHandler(this.ClearHistoryButton_Click);
            // 
            // bookmarksButton
            // 
            this.bookmarksButton.Image = global::Karpovych03.Properties.Resources.bookmarks;
            this.bookmarksButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmarksButton.Name = "bookmarksButton";
            this.bookmarksButton.Size = new System.Drawing.Size(86, 22);
            this.bookmarksButton.Text = "Bookmarks";
            this.bookmarksButton.Click += new System.EventHandler(this.BookmarksButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Image = global::Karpovych03.Properties.Resources.settings;
            this.settingsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(69, 22);
            this.settingsButton.Text = "Settings";
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.tabControl);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(999, 425);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer.LeftToolStripPanel
            // 
            this.toolStripContainer.LeftToolStripPanel.Controls.Add(this.tabToolStrip);
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(1023, 450);
            this.toolStripContainer.TabIndex = 4;
            this.toolStripContainer.Text = "toolStripContainer2";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.bookmarksStrip);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabHome);
            this.tabControl.Controls.Add(this.tabNew);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(999, 425);
            this.tabControl.TabIndex = 2;
            this.tabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabControl_Selecting);
            // 
            // tabHome
            // 
            this.tabHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabHome.Size = new System.Drawing.Size(991, 399);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home tab";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // tabNew
            // 
            this.tabNew.Location = new System.Drawing.Point(4, 22);
            this.tabNew.Name = "tabNew";
            this.tabNew.Padding = new System.Windows.Forms.Padding(3);
            this.tabNew.Size = new System.Drawing.Size(991, 399);
            this.tabNew.TabIndex = 1;
            this.tabNew.Text = "Add new tab";
            this.tabNew.UseVisualStyleBackColor = true;
            // 
            // tabToolStrip
            // 
            this.tabToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.tabToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tabToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeTab,
            this.addBookmark});
            this.tabToolStrip.Location = new System.Drawing.Point(0, 3);
            this.tabToolStrip.Name = "tabToolStrip";
            this.tabToolStrip.Size = new System.Drawing.Size(24, 48);
            this.tabToolStrip.TabIndex = 0;
            // 
            // closeTab
            // 
            this.closeTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeTab.Image = ((System.Drawing.Image)(resources.GetObject("closeTab.Image")));
            this.closeTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeTab.Name = "closeTab";
            this.closeTab.Size = new System.Drawing.Size(22, 20);
            this.closeTab.Text = "Close tab";
            this.closeTab.Click += new System.EventHandler(this.CloseTab_Click);
            // 
            // addBookmark
            // 
            this.addBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addBookmark.Image = ((System.Drawing.Image)(resources.GetObject("addBookmark.Image")));
            this.addBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBookmark.Name = "addBookmark";
            this.addBookmark.Size = new System.Drawing.Size(22, 20);
            this.addBookmark.Text = "Add to bookmarks";
            this.addBookmark.Click += new System.EventHandler(this.AddBookmark_Click);
            // 
            // bookmarksStrip
            // 
            this.bookmarksStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bookmarksStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bookmarksStrip.Location = new System.Drawing.Point(3, 25);
            this.bookmarksStrip.Name = "bookmarksStrip";
            this.bookmarksStrip.Size = new System.Drawing.Size(102, 25);
            this.bookmarksStrip.TabIndex = 1;
            this.bookmarksStrip.Visible = false;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(800, 430);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabToolStrip.ResumeLayout(false);
            this.tabToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ToolStripButton forwardButton;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripButton showDevTools;
        private System.Windows.Forms.ToolStripTextBox urlTextBox;
        private System.Windows.Forms.TabPage tabNew;
        private System.Windows.Forms.ToolStrip tabToolStrip;
        private System.Windows.Forms.ToolStripButton closeTab;
        private System.Windows.Forms.ToolStripButton addBookmark;
        private System.Windows.Forms.ToolStripSplitButton historyButton;
        private System.Windows.Forms.ToolStripMenuItem showHistoryButton;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryButton;
        private System.Windows.Forms.ToolStripButton bookmarksButton;
        private System.Windows.Forms.ToolStrip bookmarksStrip;
        private System.Windows.Forms.ToolStripButton reloadButton;
        private System.Windows.Forms.ToolStripButton settingsButton;
        private System.Windows.Forms.TabPage tabHome;
    }
}

