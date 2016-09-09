using System;
using System.Windows.Forms;

namespace PressureSpotFixer
{
    partial class SettingsForm : Form
    {
        public readonly TrayContext trayContext;

        public SettingsForm(TrayContext trayContext)
        {
            this.trayContext = trayContext;
            InitializeComponent();

            /* Set file path label */
            filePath.Text = Properties.Settings.Default.filePath;

            /* Update form location when form is moved */
            UpdatePosNumericBox(); // and update the numeric boxes now
        } 
        
        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        public void FixerForm_LocationChanged(object sender, EventArgs e)
        {
            UpdatePosNumericBox();   
        }

        private void UpdatePosNumericBox()
        {
            xNumericBox.Value = GetFixerForm().Location.X;
            yNumericBox.Value = GetFixerForm().Location.Y;
        }

        private TrayContext GetTrayContext()
        {
            return this.trayContext;
        }

        private FixerForm GetFixerForm()
        {
            return this.GetTrayContext().GetFixerForm();
        }

       

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetTrayContext().HideSettings();
        }

        private void SelectImgButton_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                filePath.Text = path;
                Properties.Settings.Default.filePath = path;
                Properties.Settings.Default.Save();

                this.GetTrayContext().ReloadFixerForm(true);
            }
        }

        private void SavePositionButton_Click(object sender, EventArgs e)
        {       
            GetFixerForm().SavePosition();
        }

        private void PreviousPositionButton_Click(object sender, EventArgs e)
        {
            GetTrayContext().ReloadFixerForm(true);
        }

        private void SetPositionButton_Click(object sender, EventArgs e)
        {
            GetFixerForm().SetPosition((int) xNumericBox.Value, (int) yNumericBox.Value);
        }
    }
}
