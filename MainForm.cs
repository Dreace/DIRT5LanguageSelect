using System.Reflection;

namespace DIRT5LanguageSelect
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitData();
        }
        private void InitData()
        {
            // 初始化列表
            languageListView.BeginUpdate();
            languageListView.Items.Clear();
            foreach (LanguageItem l in Language.languages)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = l.code;
                listViewItem.SubItems.Add(l.fullName);
                listViewItem.SubItems.Add(l.language);
                languageListView.Items.Add(listViewItem);
            }
            languageListView.EndUpdate();

            // 初始化下拉列表
            languageComboBox.Items.Clear();
            foreach (LanguageItem l in Language.languages)
            {
                languageComboBox.Items.Add(l.fullName + "/" + l.language);
            }
            languageComboBox.SelectedIndex = 0;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("game_release.exe"))
            {
                MessageBox.Show("当前目录找不到 game_release.exe\nThe current directory can not find game_release.exe", "文件不存在/File not Exists");
                return;
            }
            System.Diagnostics.Process.Start("game_release.exe", "-language " + Language.languages[languageComboBox.SelectedIndex].code);
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (languageListView.SelectedItems.Count > 0 && languageComboBox.SelectedIndex == languageListView.SelectedItems[0].Index)
            {
                // 已经选择的是同一个
                return;
            }
            if (languageComboBox.SelectedIndex <= languageListView.Items.Count)
            {

                languageListView.Items[languageComboBox.SelectedIndex].Selected = true;
            }
        }

        private void languageListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (languageListView.SelectedItems.Count > 0 && languageComboBox.SelectedIndex == languageListView.SelectedItems[0].Index)
            {
                // 已经选择的是同一个
                return;
            }
            if (languageListView.SelectedItems.Count > 0 && languageListView.SelectedItems[0].Index < languageComboBox.Items.Count)
            {
                languageComboBox.SelectedIndex = languageListView.SelectedItems[0].Index;
            }
        }

        private void createShortcutButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists("game_release.exe"))
            {
                MessageBox.Show("当前目录找不到 game_release.exe\nThe current directory can not find game_release.exe", "文件不存在/File not Exists");
                return;
            }
            var language = Language.languages[languageComboBox.SelectedIndex];
            var shell = new IWshRuntimeLibrary.WshShell();
            var shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(Path.Combine(saveToDesktopCheckBox.Checked ?
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop) :
                Directory.GetCurrentDirectory(), "DIRT 5 - " + language.language + ".lnk"));
            shortcut.TargetPath = Path.Combine(Directory.GetCurrentDirectory(), "game_release.exe");
            shortcut.Arguments = "-language " + language.code;
            shortcut.WorkingDirectory = Directory.GetCurrentDirectory();
            shortcut.Save();
        }
    }
}