using FastColoredTextBoxNS;
using SourceCodeEditor.AppearenceConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeEditor
{
    public class LanguageConfig
    {
        public MainForm MainForm { get; set; }
        public LanguageConfig(MainForm form) 
        {
            MainForm = form;
        }
        public void LoadLanguages()
        {
            foreach (var item in Enum.GetNames<Language>())
            {
                MainForm.syntaxToolStripMenuItem.DropDownItems.Add(item.ToString());
            }
            SetLanguagesEvents();
        }

        private void SetLanguagesEvents()
        {
            foreach (ToolStripDropDownItem item in MainForm.syntaxToolStripMenuItem.DropDownItems)
            {
                item.Click += LanguageItem_Click;
            }
        }

        private void LanguageItem_Click(object? sender, EventArgs e)
        {
            var item = (ToolStripDropDownItem)sender!;

            switch (item.Text)
            {
                case "Custom":
                    {
                        MainForm.MainTextField.Language = Language.Custom;
                    }
                    break;
                case "CSharp":
                    {
                        MainForm.MainTextField.Language = Language.CSharp;
                    }
                    break;
                case "Lua":
                    {
                        MainForm.MainTextField.Language = Language.Lua;
                    }
                    break;
                case "JS":
                    {
                        MainForm.MainTextField.Language = Language.JS;
                    }
                    break;
                case "XML":
                    {
                        MainForm.MainTextField.Language = Language.XML;
                    }
                    break;
                case "SQL":
                    {
                        MainForm.MainTextField.Language = Language.SQL;
                    }
                    break;
                case "VB":
                    {
                        MainForm.MainTextField.Language = Language.VB;
                    }
                    break;
                case "HTML":
                    {
                        MainForm.MainTextField.Language = Language.HTML;
                    }
                    break;
                case "PHP":
                    {
                        MainForm.MainTextField.Language = Language.PHP;
                    }
                    break;
            }
            new ThemeChanger(MainForm, MainForm.CurrentTheme, MainForm.MainHeader, MainForm.MainTextField, MainForm.MainFooter, MainForm.GetLabelsFromForm()).ChangeTheme();
        }
    }
}
