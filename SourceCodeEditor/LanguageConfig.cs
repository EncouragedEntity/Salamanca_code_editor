﻿using FastColoredTextBoxNS;
using SourceCodeEditor.AppearenceConfig;

namespace SourceCodeEditor
{
    public class LanguageConfig
    {
        public MainForm? MainForm { get; set; }
        public LanguageConfig(MainForm? form)
        {
            MainForm = form;
        }
        public LanguageConfig() : this(null) { }

        public string[] GetLanguages()
        {
            return Enum.GetNames(typeof(Language));
        }
        public void LoadLanguages()
        {
            foreach (var lang in GetLanguages())
            {
                MainForm.syntaxToolStripMenuItem.DropDownItems.Add(lang);
            }
            SetLanguagesEvents();
            var firtsItem = MainForm.syntaxToolStripMenuItem.DropDownItems[0] as ToolStripMenuItem;
            firtsItem!.Checked = true;
        }
        private void SetLanguagesEvents()
        {
            foreach (ToolStripDropDownItem item in MainForm.syntaxToolStripMenuItem.DropDownItems)
            {
                item.Click += LanguageItem_Click;
            }
        }
        private void RemoveCheckFromOtherItems()
        {
            foreach (ToolStripMenuItem item in MainForm.syntaxToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }
        }
        /// <summary>
        /// Change language of MainTextField
        /// </summary>
        /// <param name="lang">Language to change</param>
        /// <returns>
        /// true, if language was already applied before
        /// and  false, if language succesfully applied</returns>
        private bool ChangeLanguage(Language lang)
        {
            if (MainForm.MainTextField.Language == lang)
            {
                return true;
            }

            MainForm.MainTextField.Language = lang;
            return false;
        }
        private async void LanguageItem_Click(object? sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender!;
            var status = MainForm.syntaxLabel;
            RemoveCheckFromOtherItems();
            item.Checked = true;

            switch (item.Text)
            {
                case "Custom":
                    {   //DO NOT REMOVE ANY OF THOSE CHECKINGS
                        //(program crashes)
                        if (ChangeLanguage(Language.Custom))
                            return;
                    }
                    break;
                case "CSharp":
                    {
                        if (ChangeLanguage(Language.CSharp))
                            return;
                    }
                    break;
                case "Lua":
                    {
                        if (ChangeLanguage(Language.Lua))
                            return;
                    }
                    break;
                case "JS":
                    {
                        if (ChangeLanguage(Language.JS))
                            return;
                    }
                    break;
                case "XML":
                    {
                        if (ChangeLanguage(Language.XML))
                            return;
                    }
                    break;
                case "SQL":
                    {
                        if (ChangeLanguage(Language.SQL))
                            return;
                    }
                    break;
                case "VB":
                    {
                        if (ChangeLanguage(Language.VB))
                            return;
                    }
                    break;
                case "HTML":
                    {
                        if (ChangeLanguage(Language.HTML))
                            return;
                    }
                    break;
                case "PHP":
                    {
                        if (ChangeLanguage(Language.PHP))
                            return;
                    }
                    break;
            }
            status.Text = $"Syntax: {item.Text}";
            new ThemeChanger(MainForm).ChangeSyntaxHighlithing();

            File.Delete("TextFieldContent.bin");
        }
    }
}