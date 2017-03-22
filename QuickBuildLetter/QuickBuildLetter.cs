/// Author: Miguel Bermudez
/// App: QuickBuildLetter
/// Brief: Quickly generate a letter to send to corporations based on service

using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace QuickBuildLetter
{
    public partial class QuickBuildLetter : Form
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public QuickBuildLetter()
        {
            InitializeComponent();
            SetDefaults();
            UpdateView();
        }

        /// <summary>
        /// Set the defaults of designer
        /// </summary>
        private void SetDefaults()
        {
            //Set the buttons and textboxes
            positiveButton.Checked = true;
            negativeButton.Checked = false;
            dateButton.Checked = true;
            dateTimePicker.Enabled = true;
            serverNameButton.Checked = true;
            serverNameText.Enabled = true;

            //Set folder browser to default to pointing to MyComputer
            folderBrowserDialog.RootFolder =
                Environment.SpecialFolder.MyComputer;

            //Try to set the default location for save to set default in config
            try
            {
                saveLocation.Text = Properties.Settings.Default.saveLocation;
            } catch
            {
                saveLocation.Text = "";
            }
        }

        /// <summary>
        /// Preform a click when enter or return is pressed
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Key pressed</param>
        private void dateButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dateButton.Checked)
            {
                dateTimePicker.Enabled = true;
            }
            else
            {
                dateTimePicker.Enabled = false;
            }

            UpdateView();
        }

        /// <summary>
        /// Preform a click when enter or return is pressed
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Key pressed</param>
        private void dateButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (dateButton.Checked)
                {
                    dateButton.Checked = true;
                }
                else
                {
                    dateButton.Checked = false;
                }
            }
        }

        /// <summary>
        /// Preform a click when enter or return is pressed
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Key pressed</param>
        private void serverNameButton_CheckedChanged(object sender, EventArgs e)
        {
            if (serverNameButton.Checked)
            {
                serverNameText.Enabled = true;
            }
            else
            {
                serverNameText.Enabled = false;
            }

            UpdateView();
        }

        /// <summary>
        /// Preform a click when enter or return is pressed
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Key pressed</param>
        private void serverNameButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                if (serverNameButton.Checked)
                {
                    serverNameButton.Checked = true;
                } else
                {
                    serverNameButton.Checked = false;
                }
            }
        }

        /// <summary>
        /// Preform a click when enter or return is pressed
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Key pressed</param>
        private void folderSelectButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                saveLocation.Text = folderBrowserDialog.SelectedPath;
            }

            UpdateView();
        }

        /// <summary>
        /// Run the program
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void runButton_Click(object sender, EventArgs e)
        {
            string fileName = saveLocation.Text + businessText.Text +
                DateTime.Today.ToString("yyMMdd") + ".doc";

            if (!Directory.Exists(saveLocation.Text))
            {
                Directory.CreateDirectory(saveLocation.Text);
            }

            try
            {
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.Write(previewBox.Text);
                    outputFile.Flush();
                }

                MessageBox.Show("Successfully created file: \n" + fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating file. Error message: \n" +
                    ex.Message);
            }
        }

        /// <summary>
        /// Writes the letter if a positive review
        /// </summary>
        /// <returns>String</returns>
        private string PositiveLetter()
        {
            StringBuilder tempString = new StringBuilder();

            

            return tempString.ToString();
        }

        /// <summary>
        /// Writes the letter if a negative review
        /// </summary>
        /// <returns>String</returns>
        private string NegativeLetter()
        {
            StringBuilder tempString = new StringBuilder();



            return tempString.ToString();
        }

        /// <summary>
        /// Updates what is shown in the richTextBox view
        /// </summary>
        private void UpdateView()
        {
            StringBuilder letter = new StringBuilder();

            letter.Append(DateTime.Today.ToString("MM/dd/yyyy"));
            letter.Append("\r\n\r\nTo whomever this might concern at ");
            letter.Append(businessText.Text);
            letter.Append(",\r\n");

            if (positiveButton.Checked)
            {
                letter.Append(PositiveLetter());
            }
            else
            {
                letter.Append(NegativeLetter());
            }
            
            letter.Append("\r\n\r\nThank you for your time,\r\n");
            letter.Append(signatureName.Text);

            previewBox.Text = letter.ToString();
            Application.DoEvents();
        }

        private void businessText_Leave(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void serverNameText_Leave(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void directionText_Leave(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void dateTimePicker_Leave(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void signatureName_Leave(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void freehand_CheckedChanged(object sender, EventArgs e)
        {
            if (freehand.Checked)
            {
                freehandText.Enabled = true;
            }
            else
            {
                freehandText.Enabled = false;
            }

            UpdateView();
        }

        private void food_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void service_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void wait_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void dirty_CheckedChanged(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void freehandText_Leave(object sender, EventArgs e)
        {
            UpdateView();
        }
    }
}
