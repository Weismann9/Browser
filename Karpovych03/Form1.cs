using CefSharp;
using CefSharp.WinForms;
using CefSharp.WinForms.Internals;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Karpovych03
{
    public partial class Form1 : Form
    {
        private ChromiumWebBrowser browser;
        private ImageList myimg = new ImageList();
        private BindingList<History> historyList;
        private BindingSource historyBindingSource;
        private DataGridView historyDataGrid;

        private BindingList<Bookmark> bookmarksList;
        private BindingSource bookmarksBindingSource;
        private DataGridView bookmarksDataGrid;

        private BindingNavigator bookmarksBindingNavigator;

        private XmlSerializer historyFormatter;
        private XmlSerializer bookmarksFormatter;

        private String historyFile;
        private String bookmarksFile;

        public Form1()
        {
            InitializeComponent();
            Text = "Bowser";
            tabNew.Enter += OnEnterNewTab;

            InitializeHistoryPageComponents();
            InitializeBookmarksPageComponents();

            historyFormatter = new XmlSerializer(typeof(BindingList<History>));
            bookmarksFormatter = new XmlSerializer(typeof(BindingList<Bookmark>));

            historyFile = "history.xml";
            bookmarksFile = "bookmarks.xml";
        }
        private void InitializeHistoryPageComponents()
        {
            historyList = new BindingList<History>();
            historyBindingSource = new BindingSource()
            {
                DataSource = historyList
            };

            historyDataGrid = new DataGridView()
            {
                ReadOnly = true,
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                DataSource = historyBindingSource
            };

            historyDataGrid.CellDoubleClick += OnHistoryCellDoubleClick;
        }

        private void InitializeBookmarksPageComponents()
        {
            bookmarksList = new BindingList<Bookmark>();
            bookmarksBindingSource = new BindingSource()
            {
                DataSource = bookmarksList
            };

            bookmarksDataGrid = new DataGridView()
            {
                RowHeadersVisible = false,
                AllowUserToAddRows = false,
                DataSource = bookmarksBindingSource
            };

            bookmarksDataGrid.CellDoubleClick += OnBookmarksCellDoubleClick;

            bookmarksBindingNavigator = new BindingNavigator(true)
            {
                BindingSource = bookmarksBindingSource,
                RightToLeft = RightToLeft.No
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            browser = CreateNewBrowser("");

            if (File.Exists(historyFile))
            {
                using (FileStream fs = new FileStream(historyFile, FileMode.Open))
                {
                    historyList = (BindingList<History>)historyFormatter.Deserialize(fs);
                }
                historyBindingSource.DataSource = historyList;
            }

            if (File.Exists(bookmarksFile))
            {
                using (FileStream fs = new FileStream(bookmarksFile, FileMode.Open))
                {
                    bookmarksList = (BindingList<Bookmark>)bookmarksFormatter.Deserialize(fs);
                }
                bookmarksBindingSource.DataSource = bookmarksList;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (historyList.Count == 0)
            {
                File.Delete(historyFile);
            }
            else
            {
                using (FileStream fs = new FileStream(historyFile, FileMode.OpenOrCreate))
                {
                    historyFormatter.Serialize(fs, historyList);
                }
            }

            if (bookmarksList.Count == 0)
            {
                File.Delete(bookmarksFile);
            }
            else
            {
                using (FileStream fs = new FileStream(bookmarksFile, FileMode.OpenOrCreate))
                {
                    bookmarksFormatter.Serialize(fs, bookmarksList);
                }
            }

            browser.Dispose();
            Cef.Shutdown();
        }

        private ChromiumWebBrowser CreateNewBrowser(string url)
        {
            var browser = new ChromiumWebBrowser(url)
            {
                Parent = tabControl.SelectedTab,
                Dock = DockStyle.Fill
            };

            browser.LoadingStateChanged += OnLoadingStateChanged;
            browser.TitleChanged += OnTitleChanged;
            browser.AddressChanged += OnAddressChanged;

            return browser;
        }

        private void LoadUrl(string url)
        {
            if (Uri.IsWellFormedUriString(url, UriKind.RelativeOrAbsolute))
            {
                browser.Load(url);
            }
        }

        private void UrlTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            LoadUrl(urlTextBox.Text);
        }

        private void AddPage(TabPage tab)
        {
            tabControl.TabPages.Insert(tabControl.TabPages.Count - 1, tab);
            tabControl.SelectedIndex = tabControl.TabPages.Count - 2;
            urlTextBox.Clear();
        }

        private void AddPage(TabPage tab, Control control)
        {
            tabControl.TabPages.Insert(tabControl.TabPages.Count - 1, tab);
            tabControl.SelectedIndex = tabControl.TabPages.Count - 2;

            control.Parent = tab;
            control.Dock = DockStyle.Fill;
            control.RightToLeft = RightToLeft.No;
        }

        private void OnEnterNewTab(object sender, EventArgs args)
        {
            AddPage(new TabPage("New tab"));
        }

        private void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            if (current != null)
            {
                Text = "Bowser | " + current.Text;
                if ((current.Text != "History") && (current.Text != "Bookmarks"))
                {
                    if (current.Controls.Count == 0)
                    {
                        browser = CreateNewBrowser("");
                    }
                    else
                    {
                        browser = (ChromiumWebBrowser)current.Controls[0];
                        urlTextBox.Text = browser.Address;
                    }
                }
                else
                {
                    urlTextBox.Clear();
                }
            }
        }

        private void OnTitleChanged(object sender, TitleChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => Text = "Bowser | " + args.Title);
            this.InvokeOnUiThreadIfRequired(() => tabControl.SelectedTab.Text = args.Title);

            String url = urlTextBox.Text;

            if (historyList.ToList().Find(item => item.URL == url) == null)
            {
                this.InvokeOnUiThreadIfRequired(() => historyList.Add(new History(args.Title, url, DateTime.Now.ToString("hh:mm:ss yyyy-MM-dd ").ToString())));
            }
        }

        private void OnAddressChanged(object sender, AddressChangedEventArgs args)
        {
            this.InvokeOnUiThreadIfRequired(() => urlTextBox.Text = args.Address);
        }

        private void OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs args)
        {
            SetCanGoBack(args.CanGoBack);
            SetCanGoForward(args.CanGoForward);

            this.InvokeOnUiThreadIfRequired(() => SetIsLoading(!args.CanReload));

            //if (browser.Address.ToString() != "")
            //{
            //    this.InvokeOnUiThreadIfRequired(() => ChangeTabIcon());
            //}
        }

        private void SetCanGoBack(bool canGoBack)
        {
            this.InvokeOnUiThreadIfRequired(() => backButton.Enabled = canGoBack);
        }

        private void SetCanGoForward(bool canGoForward)
        {
            this.InvokeOnUiThreadIfRequired(() => goButton.Enabled = canGoForward);
        }

        private void SetIsLoading(bool isLoading)
        {
            goButton.Text = isLoading ? "Stop" : "Go";
            goButton.Image = isLoading ?
                Properties.Resources.nav_plain_red :
                Properties.Resources.nav_plain_green;

            HandleToolStripLayout();
        }
        private void ChangeTabIcon()
        {
            WebClient webClient = new WebClient();
            MemoryStream memorystream = new MemoryStream(webClient.DownloadData("https://" + browser.Address + "/favicon.ico"));
            Icon icon = new Icon(memorystream);
            string i = Convert.ToString(myimg.Images.Count);
            myimg.Images.Add(i, icon.ToBitmap());
            tabControl.ImageList = myimg;
            tabControl.SelectedTab.ImageIndex = myimg.Images.Count - 1;
        }

        private void HandleToolStripLayout(object sender, LayoutEventArgs e)
        {
            this.InvokeOnUiThreadIfRequired(() => HandleToolStripLayout());
        }

        private void HandleToolStripLayout()
        {
            //TODO: refactor top toolstrip resizing
            var width = toolStrip.Width;
            foreach (ToolStripItem item in toolStrip.Items)
            {
                if (item != urlTextBox)
                {
                    width -= item.Width - item.Margin.Horizontal;
                }
            }
            urlTextBox.Width = Math.Max(0, width - urlTextBox.Margin.Horizontal - 18);
        }


        private void GoButton_Click(object sender, EventArgs e)
        {
            LoadUrl(urlTextBox.Text);
        }

        private void ShowDevTools_Click(object sender, EventArgs e)
        {
            browser.ShowDevTools();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            browser.Back();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            browser.Forward();
        }

        private void CloseTab_Click(object sender, EventArgs e)
        {
            TabPage current = tabControl.SelectedTab;
            if (tabControl.TabPages.Count > 1 && current != null)
            {
                tabControl.SelectedIndex = tabControl.SelectedIndex - 1;
                tabControl.TabPages.Remove(current);
            }
        }

        private void ShowHistory_Click(object sender, EventArgs e)
        {
            TabPage historyTab = new TabPage("History");
            AddPage(historyTab, historyDataGrid);

            historyDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            historyDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            historyDataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            historyDataGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            historyDataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void OnHistoryCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell currentCell = (sender as DataGridView).CurrentCell;
            AddPage(new TabPage("New tab"));
            browser.Load(historyList[currentCell.RowIndex].URL);
        }

        private void ClearHistoryButton_Click(object sender, EventArgs e)
        {
            historyList.Clear();
        }

        private void BookmarksButton_Click(object sender, EventArgs e)
        {
            TabPage bookmarksTab = new TabPage("Bookmarks");
            AddPage(bookmarksTab, bookmarksDataGrid);

            bookmarksDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            bookmarksDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            bookmarksDataGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            bookmarksDataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            bookmarksBindingNavigator.Parent = bookmarksTab;
            bookmarksBindingNavigator.Dock = DockStyle.Top;
        }

        private void AddBookmark_Click(object sender, EventArgs e)
        {
            if (bookmarksList.ToList().Find(item => item.URL == browser.Address) == null)
            {
                bookmarksList.Add(new Bookmark(browser.Address, Text));
                MessageBox.Show("Added", "Bookmarks", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("This page is already added", "Bookmarks", MessageBoxButtons.OK);
            }

            //TODO: create bookmarks strip
            //toolStrip.Items.Add(new ToolStripButtonLink("Google","", "", "www.google.com"));
        }

        private void OnBookmarksCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell currentCell = (sender as DataGridView).CurrentCell;
            AddPage(new TabPage("New tab"));
            browser.Load(bookmarksList[currentCell.RowIndex].URL);
        }
    }
}
