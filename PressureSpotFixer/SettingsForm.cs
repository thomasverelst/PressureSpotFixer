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
            updatePosNumericBox(); // and update the numeric boxes now
        } 
        
        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        public void fixerForm_LocationChanged(object sender, EventArgs e)
        {
            updatePosNumericBox();   
        }

        private void updatePosNumericBox()
        {
            xNumericBox.Value = getFixerForm().Location.X;
            yNumericBox.Value = getFixerForm().Location.Y;
        }

        private TrayContext getTrayContext()
        {
            return this.trayContext;
        }

        private FixerForm getFixerForm()
        {
            return this.getTrayContext().getFixerForm();
        }

       

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            getTrayContext().hideSettings();
        }

        private void selectImgButton_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                path = file.FileName;
                filePath.Text = path;
                Properties.Settings.Default.filePath = path;
                Properties.Settings.Default.Save();

                this.getTrayContext().reloadFixerForm(true);
            }
        }

        private void savePosButton_Click(object sender, EventArgs e)
        {       
            getFixerForm().savePosition();
        }

        private void resetPrevPosButton_Click(object sender, EventArgs e)
        {
            getTrayContext().reloadFixerForm(true);
        }

        private void setPositionButton_Click(object sender, EventArgs e)
        {
            getFixerForm().setPos((int) xNumericBox.Value, (int) yNumericBox.Value);
        }
    }
}
