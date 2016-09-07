using System;
using System.Windows.Forms;


namespace PressureSpotFixer
{
    class TrayContext : ApplicationContext
    {
        private readonly NotifyIcon notifyIcon = new NotifyIcon();
        private FixerForm fixerForm;
        private SettingsForm settingsForm;
       

        public TrayContext()
        {
            reloadFixerForm(false);


            /* Add tray context menu items */
            MenuItem configMenuItem = new MenuItem("Settings", new EventHandler(showSettings));
            MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));

            notifyIcon.Icon = PressureSpotFixer.Properties.Resources.AppIcon;
            notifyIcon.DoubleClick += new EventHandler(showSettings);
            notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] { configMenuItem, exitMenuItem });
            notifyIcon.Visible = true;
        }

        /*********** Fixer Form ************/

        public FixerForm getFixerForm(){
            return this.fixerForm;
        }

        public void reloadFixerForm(bool draggable)
        {
            if (this.fixerForm != null)
            {
                this.fixerForm.Close();
            }
            this.fixerForm = new FixerForm(draggable);

            if (settingsForm != null)
            {
                this.getFixerForm().LocationChanged += new System.EventHandler(settingsForm.fixerForm_LocationChanged);
            }
            fixerForm.Show();
        }

        /*********** Settings Form ************/

        void showSettings(object sender, EventArgs e)
        {
            if (settingsForm == null)
                settingsForm = new SettingsForm(this);

            if (settingsForm.Visible)
                settingsForm.Focus();
            else
                settingsForm.Show();
            
            reloadFixerForm(true);
        }

        public void hideSettings()
        {
            reloadFixerForm(false);
            settingsForm = null;
            //GC.Collect();
        }

        void Exit(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
        }
    }
}
