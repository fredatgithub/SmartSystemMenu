﻿using System;
using System.IO;
using System.Windows.Forms;
using SmartSystemMenu.Settings;

namespace SmartSystemMenu.Forms
{
    public partial class ProcessExclusionForm : Form
    {
        public string ProcessName { get; private set; }

        public ProcessExclusionForm(string processName, MenuLanguage menuLanguage)
        {
            _menuLanguage = menuLanguage;
            InitializeComponent();
            txtFileName.Text = processName;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            txtFileName.SelectAll();
            txtFileName.Focus();
        }

        private void ButtonBrowseFileClick(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog()
            {
                RestoreDirectory = false,
                Filter = _menuLanguage.GetStringValue("process_browse_file_filter")
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = Path.GetFileName(dialog.FileName);
            }
        }

        private void ButtonApplyClick(object sender, EventArgs e)
        {
            ProcessName = txtFileName.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void KeyDownClick(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ButtonApplyClick(sender, e);
            }

            if (e.KeyValue == 27)
            {
                Close();
            }
        }
    }
}
