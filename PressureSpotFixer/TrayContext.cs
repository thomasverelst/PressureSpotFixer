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
            ReloadFixerForm(false);


            /* Add tray context menu items */
            MenuItem configMenuItem = new MenuItem("Settings", new EventHandler(ShowSettings));
            MenuItem exitMenuItem = new MenuItem("Exit", new EventHandler(Exit));

            notifyIcon.Icon = PressureSpotFixer.Properties.Resources.AppIcon;
            notifyIcon.DoubleClick += new EventHandler(ShowSettings);
            notifyIcon.ContextMenu = new ContextMenu(new MenuItem[] { configMenuItem, exitMenuItem });
            notifyIcon.Visible = true;
        }

        /*********** Fixer Form ************/

        public FixerForm GetFixerForm(){
            return this.fixerForm;
        }

        public void ReloadFixerForm(bool draggable)
        {
            if (this.fixerForm != null)
            {
                this.fixerForm.Close();
            }
            this.fixerForm = new FixerForm(draggable);

            if (settingsForm != null)
            {
                this.GetFixerForm().LocationChanged += new System.EventHandler(settingsForm.FixerForm_LocationChanged);
            }
            fixerForm.Show();
        }

        /*********** Settings Form ************/

        void ShowSettings(object sender, EventArgs e)
        {
            if (settingsForm == null)
                settingsForm = new SettingsForm(this);

            if (settingsForm.Visible)
                settingsForm.Focus();
            else
                settingsForm.Show();
            
            ReloadFixerForm(true);
        }

        public void HideSettings()
        {
            ReloadFixerForm(false);
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
