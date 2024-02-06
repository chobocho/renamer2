using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;

namespace renamer
{
    public partial class Renamer : Form
    {
        private List<FileName> _fileNames;
        const string _helpText = " [도움말]\n" +
                        " Ctrl+F: 찾을 문자\n" +
                        " Ctrl+H: 바꿀 문자\n" +
                        " Alt+C: 모두 지우기\n" +
                        " Ctrl+G: 파일 이름 바꾸기 실행\n";
        public Renamer()
        {
            _fileNames = new List<FileName>();
            InitializeComponent();
            filenameText.Text = _helpText;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            foreach (var file in _fileNames)
            {
                file.Revert();
            }
            UpdateNewFilenameList();
            newFilenameText.BackColor = SystemColors.Window;
        }

        
        private void applyButton_Click(object sender, EventArgs e)
        {
            applyChange();
        }

        private void applyChange()
        {
            if (_fileNames.Count == 0)
            {
                MessageBox.Show($"Nothing to update!", "ReNamer");
                return;
            }

            foreach (var file in _fileNames)
            {
                file.ApplyTempName();
            }

            foreach (var file in _fileNames)
            {
                if (!file.IsUpdate()) continue;
                try
                {
                    File.Move(file.getFullPath(), file.getFullNewPath());
                    file.Update();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Fail to change {file.name()} to {file.newName()}", "Error!");
                }
            }

            _fileNames.Sort((x, y) => String.Compare(x.name(), y.name()));
            updateOriginalFileList();
            UpdateNewFilenameList();
            MessageBox.Show($"Success!", "ReNamer");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchText.Text = string.Empty;
            replaceText.Text = string.Empty;
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            if (searchText.Text.Length == 0) return;
            if (replaceText.Text.Length == 0) return;
            foreach (var fileName in _fileNames)
            {
                fileName.Replace(searchText.Text, replaceText.Text);
            }
            UpdateNewFilenameList();
            searchText.Text = string.Empty;
            replaceText.Text = string.Empty;
            searchText.Focus();
        }

        void filenameText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void filenameText_DragDrop(object sender, DragEventArgs e)
        {
            _fileNames.Clear();
            
            var files = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (files == null || !File.Exists(files[0]))
            {
                filenameText.Text = $"{files[0]} 은 존재 하지 않는 파일이거나 폴더 입니다!";
                return;
            }
            
            foreach (var file in files)
            {
                _fileNames.Add(new FileName(file));
            }

            _fileNames.Sort((x, y) => string.Compare(x.name(), y.name()));

            updateOriginalFileList();
            UpdateNewFilenameList();
        }

        private void updateOriginalFileList()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var fileName in _fileNames)
            {
                sb.AppendLine(fileName.name());
            }

            filenameText.Text = sb.ToString();
            folderName.Text = _fileNames[0].path();
        }

        private void UpdateNewFilenameList()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var fileName in _fileNames)
            {
                sb.AppendLine(fileName.newName());
            }
            newFilenameText.Text = sb.ToString();
        }

        private void UpdateNewFilenameListWithTempName()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var fileName in _fileNames)
            {
                sb.AppendLine(fileName.tempName());
            }

            newFilenameText.Text = sb.ToString();
        }

        private void updateNewFileTextBG()
        {
            var isUpdate = false;
            foreach (var fileName in _fileNames)
            {
                if (fileName.IsColorUpdate())
                {
                    isUpdate = true;
                    break;
                }
            }
            newFilenameText.BackColor = isUpdate ? Color.Cornsilk : SystemColors.Window;
        }
        
        private void revertButton_Click(object sender, EventArgs e)
        {

        }

        private void AllClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            _fileNames.Clear();
            filenameText.Text = _helpText;
            folderName.Clear();
            newFilenameText.Clear();
            newFilenameText.BackColor = SystemColors.Window;
            searchText.Clear();
            replaceText.Clear();
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            if (searchText.Text.Length == 0) return;
            if (replaceText.Text.Length == 0) return;
            foreach (var fileName in _fileNames)
            {
                fileName.GetExpect(searchText.Text, replaceText.Text);
            }
            UpdateNewFilenameListWithTempName();
            updateNewFileTextBG();
        }

        private void replaceText_TextChanged(object sender, EventArgs e)
        {
            replaceText.Text = Regex.Replace(replaceText.Text, "[*:/\"<>|]", "");
            replaceText.SelectionStart = replaceText.Text.Length;
            if (searchText.Text.Length == 0) return;
            if (replaceText.Text.Length == 0) return;
            foreach (var fileName in _fileNames)
            {
                fileName.GetExpect(searchText.Text, replaceText.Text);
            }
            UpdateNewFilenameListWithTempName();
            updateNewFileTextBG();
        }

        private void replaceText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                replaceButton_Click(sender, e);
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Control | Keys.F):
                case (Keys.Control | Keys.R):
                    searchText.Focus();
                    break;
                case (Keys.Control | Keys.H):  
                    replaceText.Focus();
                    break;
                case (Keys.Control | Keys.G):
                    applyChange();
                    break;
                case (Keys.Alt | Keys.C):
                    clearAll();
                    break;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
            return true;
        }
    }
}
