using SourceCodeEditor.AppearenceConfig;
using SourceCodeEditor.Enums;
using SourceCodeEditor.UserControls;
using SourceCodeEditor.UserControls.Options;

namespace SourceCodeEditor.Forms
{
    public partial class OptionsForm : Form
    {
        private UserControl? _currentControl = null;
        
        private MainForm? mainForm = null;

        public bool ColorsChanged { get; set; } = false;

        public OptionsForm(MainForm? mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        /// <summary>
        /// Change size of dataGrid and its column according to options form
        /// </summary>
        private void ValidateSize()
        {
            dataGridView1.Width = this.Width / 4;
            dataGridView1.Columns[0].Width = dataGridView1.Width-3;
        }

        /// <summary>
        /// Set list of dataGrid buttons
        /// </summary>
        private void SetDataGridItems()
        {
            dataGridView1.Rows.Add("General");
            dataGridView1.Rows.Add("Theme");
            dataGridView1.Rows.Add("HotKeys");
            dataGridView1.Rows.Add("Colors");
        }

        /// <summary>
        /// Enable scrolls on control
        /// </summary>
        private void EnableScrollingOnControl(UserControl control)
        {
            control.AutoScroll = true;
            control.VerticalScroll.Enabled = true;
            control.VerticalScroll.Visible = true;
        }

        /// <summary>
        /// Show user control on WorkPanel panel
        /// </summary>
        /// <param name="controlToShow">Control that needs to be shown</param>
        private void LoadUserControl(UserControl controlToShow)
        {
            if (_currentControl is not null)
            {
                WorkPanel.Controls.Remove(_currentControl);
            }
            controlToShow.Dock = DockStyle.Fill;

            ///Enable scrolls only if control's height is larger than panel's height
            bool isControlTallerThenPanel = controlToShow.Height > WorkPanel.Height;

            if (isControlTallerThenPanel)
            {
                EnableScrollingOnControl(controlToShow);
            }

            WorkPanel.Controls.Add(controlToShow);
            _currentControl = controlToShow;
        }

        /// <summary>
        /// Decide what option panel to show
        /// </summary>
        /// <param name="options">Options to be shown</param>
        private void ChangeOptionPanel(Options options)
        {
            switch (options)
            {
                case Options.General:
                {
                    var control = new GeneralOptionsControl();
                    LoadUserControl(control);
                }
                break;

                case Options.Theme:
                {
                    var control = new ThemeOptionsControl(mainForm);
                    LoadUserControl(control);
                }
                break;

                case Options.HotKeys:
                {
                    var control = new HotKeysOptionsControl(mainForm);
                    LoadUserControl(control);
                }
                break;
                case Options.Colors:
                 {
                    var control = new ColorsOptionsControl(mainForm!, this);
                    LoadUserControl(control);
                 }
                    break;
            }
        }

        /// <summary>
        /// On dataGrid cell content click, show option panel
        /// </summary>
        private void SetWorkPanel(object? sender, DataGridViewCellEventArgs e)
        {
            var dg = sender as DataGridView;
            var button = dg.CurrentCell.Value;
            switch (button)
            {
                case "General":
                    {
                        ChangeOptionPanel(Options.General);
                    }break;
                case "Theme":
                    {
                        ChangeOptionPanel(Options.Theme);
                    }break;
                case "HotKeys":
                    {
                        ChangeOptionPanel(Options.HotKeys);
                    }
                    break;
                case "Colors":
                    {
                        ChangeOptionPanel(Options.Colors);
                    }
                    break;
            }
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            LoadUserControl(new GeneralOptionsControl());
            SetDataGridItems();
            ValidateSize();
        }

        private void OptionsForm_SizeChanged(object sender, EventArgs e)
        {
            ValidateSize();
        }
    }
}
