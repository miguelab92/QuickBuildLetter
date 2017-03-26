using System;
using System.IO;
using System.Windows.Forms;

namespace QuickBuildLetter
{
    public partial class Settings : Form
    {
        readonly string APP_CONFIG = "QuickBuildLetter.exe.config";

        public Settings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On lead try to read from existing file and populate fields
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void Settings_Load(object sender, EventArgs e)
        {
            if (File.Exists(APP_CONFIG))
            {
                signatureName.Text = Properties.Settings.Default.usersName;
                saveLocation.Text = Properties.Settings.Default.saveLocation;
            }
        }

        private void signatureName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                saveButton.PerformClick();
            }
        }

        private void saveLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                saveButton.PerformClick();
            }
        }

        /// <summary>
        /// Use folder browser to get location
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void folderSelectButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                saveLocation.Text = folderBrowserDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Create config before exiting
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void saveButton_Click(object sender, EventArgs e)
        {
            CreateConfigFile();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Creates a config file for app
        /// </summary>
        private void CreateConfigFile()
        {
            StreamWriter outputFile;

            try
            {
                //If file already exists, delete it
                if (File.Exists(APP_CONFIG))
                {
                    File.Delete(APP_CONFIG);
                }

                //Generate the output stream
                outputFile = File.AppendText(APP_CONFIG);

                //Create the app config with added name and location
                outputFile.Write("<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n<configuration>\n<configSections>\n<sectionGroup name = \"userSettings\" type = \"System.Configuration.UserSettingsGroup, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\">\n<section name = \"QuickBuildLetter.Properties.Settings\" type = \"System.Configuration.ClientSettingsSection, System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\" allowExeDefinition = \"MachineToLocalUser\" requirePermission = \"false\"/>\n</sectionGroup>\n</configSections>\n<startup>\n<supportedRuntime version = \"v4.0\" sku = \".NETFramework,Version=v4.5\"/>\n</startup>\n<userSettings>\n<QuickBuildLetter.Properties.Settings>\n<setting name = \"saveLocation\" serializeAs = \"String\">\n<value>");
                outputFile.Write(saveLocation.Text);
                outputFile.Write("</value>\n </setting>\n<setting name = \"usersName\" serializeAs = \"String\">\n<value>");
                outputFile.Write(signatureName.Text);
                outputFile.Write("</value>\n</setting>\n</QuickBuildLetter.Properties.Settings>\n</userSettings>\n</configuration>");

                outputFile.Flush();
                outputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not enough writes given to user for folder containing QuickBuildLetter. Unable to use default settings.\nError: " + ex.Message);
                this.Close();
            }
        }
    }
}
