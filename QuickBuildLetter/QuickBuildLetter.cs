/// Author: Miguel Bermudez
/// App: QuickBuildLetter
/// Brief: Quickly generate a letter to send to corporations based on service

using System;
using System.IO;
using System.Net.Mail;
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
        /// Updates what is shown in the richTextBox view
        /// </summary>
        private void UpdateView()
        {
            StringBuilder letter = new StringBuilder();

            letter.Append(IntroExp());

            if (positiveButton.Checked)
            {
                letter.Append(PositiveExp());
            }
            else
            {
                letter.Append(NegativeExp());
            }

            letter.Append("\r\n\r\nThank you for your time,\r\n");
            letter.Append(signatureName.Text);

            previewBox.Text = letter.ToString();
            Application.DoEvents();
        }

        private string IntroExp()
        {
            StringBuilder letter = new StringBuilder();

            letter.Append(DateTime.Today.ToString("MM/dd/yyyy"));
            letter.Append("\r\n\r\nTo whomever this might concern at ");
            letter.Append(businessText.Text);
            letter.Append(",\r\nMy name is ");
            letter.Append(signatureName.Text);
            letter.Append(" and I am writting to you today due to ");

            if (positiveButton.Checked)
            {
                letter.Append("a great experience ");
            }
            else
            {
                letter.Append("a less than positive experience ");
            }

            letter.Append("I recently had at ");

            if (directionBox.Checked)
            {
                letter.Append(directionText.Text);
            }
            else
            {
                letter.Append("one of your locations");
            }

            if (dateButton.Checked)
            {
                letter.Append(" on ");
                letter.Append(dateTimePicker.Value.ToString("MM-dd-yyyy"));
            }

            letter.Append(". While ");

            // Add code to check for dining, shopping, or visiting

            letter.Append(" I was ");
            //Add code to check for dining, shopping, or visiting
            letter.Append(" by ");

            if (serverNameButton.Checked)
            {
                letter.Append(serverNameText.Text);
                letter.Append(". ");
                letter.Append(serverNameText.Text.Split(' ')[0]);
                letter.Append(" was ");

            }
            else
            {
                letter.Append("the staff. They were ");
            }

            return letter.ToString();
        }

        private string PositiveExp()
        {
            StringBuilder letter = new StringBuilder();
            int counter = 0;

            letter.Append("tremendously ");
            //Add code to check for dining, shopping, or visiting
            letter.Append(" and elevated my experience beyond my expectations.");

            if (food.Checked)
            {
                letter.Append(" The food I ate was fresh and excellent");
                ++counter;
            }

            if (service.Checked)
            {
                if (counter > 0)
                {
                    letter.Append(" and");
                }

                letter.Append(" I received amazingly friendly and helpful service");

                counter = 1;
            }
            letter.Append(". I was ");

            if (counter > 0)
            {
                letter.Append("also ");
            }

            if (wait.Checked)
            {
                letter.Append("impressed by the short wait times");

                if (cleaness.Checked)
                {
                    letter.Append(", ");
                }
                else
                {
                    letter.Append(" and ");
                }

                letter.Append("promptness of service");
                ++counter;
            }

            if (cleaness.Checked)
            {
                if (counter > 0)
                {
                    letter.Append("and ");
                }
                letter.Append("impressed by the cleanliness of the location.");
            }
            else
            {
                letter.Append('.');
            }

            if (freehand.Checked)
            {
                letter.Append(' ');
                letter.Append(freehandText.Text);
            }

            letter.Append(" After such a positive experience, I will be sure to recommend your business to friends and family. Thanks again to ");
            letter.Append(serverNameText.Text);
            letter.Append(" for their amazing ");

            //code for food/business/etc.

            letter.Append(" and I hope to see them again next time I come in!");

            return letter.ToString();
        }

        private string NegativeExp()
        {
            StringBuilder letter = new StringBuilder();
            int counter = 0;
            
            letter.Append("not very ");
            //Add code to check for dining, shopping, or visiting
            letter.Append(" and it left me with a negative experience.");

            if (food.Checked)
            {
                letter.Append(" The food I ate was unfortuently not very good");
                ++counter;
            }

            if (service.Checked)
            {
                if (counter > 0)
                {
                    letter.Append(" and");
                }

                letter.Append(" the service I received was rushed and unfriendly");

                counter = 1;
            }

            letter.Append(". I was ");

            if (counter > 0)
            {
                letter.Append("also ");
            }

            if (wait.Checked)
            {
                letter.Append("not impressed by the long wait times");

                if (cleaness.Checked)
                {
                    letter.Append(", ");
                }
                else
                {
                    letter.Append(" and ");
                }

                letter.Append("slow service");
                ++counter;
            }

            if (cleaness.Checked)
            {
                if (counter > 0)
                {
                    letter.Append("and ");
                }
                letter.Append("not happy with the dirtyness that I observed.");
            }
            else
            {
                letter.Append('.');
            }

            if (freehand.Checked)
            {
                letter.Append(' ');
                letter.Append(freehandText.Text);
            }

            letter.Append(" I feel like this is not up to the standards that I have come to expect from ");
            letter.Append(businessText.Text);
            letter.Append(" and I hope that it is not indicative of future experiences.");

            return letter.ToString();
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

        private void emailButton_Click(object sender, EventArgs e)
        {
            if (companyEmail.Text == "")
            {
                if (FindCompanyAddress())
                {
                    SendEmail();
                } else
                {
                    MessageBox.Show("Please fill in Company Email Address");
                }
            }
            else if (ValidateEmail(companyEmail.Text))
            {
                SendEmail();
            }
            else
            {
                MessageBox.Show("Company Email is not valid");
            }
        }

        private bool FindCompanyAddress()
        {
            bool emailFound = false;
            string foundEmail = "";

            ///**** add search for the email through google ****///

            if (ValidateEmail(foundEmail))
            {
                emailFound = true;
                companyEmail.Text = foundEmail;
            }

            return emailFound;
        }

        private bool ValidateEmail( string email )
        {
            bool validEmail = true;

            try
            {
                MailAddress mail = new MailAddress(email);
            } catch
            {
                validEmail = false;
            }

            return validEmail;
        }

        private void SendEmail()
        {
            StringBuilder link = new StringBuilder();
            link.Append("mailto:");
            link.Append(companyEmail.Text);
            link.Append("?Subject=Feedback%20on%20recent%20visit&body=");
            link.Append(previewBox.Text.Replace(" ", 
                "%20").Replace("\r\n", "%0D%0A"));

            System.Diagnostics.Process.Start(link.ToString()); 
        }

        private void userName_Leave(object sender, EventArgs e)
        {
            UpdateView();
        }

        private void directionBox_CheckedChanged(object sender, EventArgs e)
        {
            if (directionBox.Checked)
            {
                directionText.Enabled = true;
            }
            else
            {
                directionText.Enabled = false;
            }

            UpdateView();
        }
    }
}
