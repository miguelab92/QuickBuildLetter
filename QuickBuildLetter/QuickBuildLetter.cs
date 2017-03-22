/// Author: Miguel Bermudez
/// App: QuickBuildLetter
/// Brief: Quickly generate a letter to send to corporations based on service

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
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
        private void businessText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                runButton.PerformClick();
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
        private void serverNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                runButton.PerformClick();
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
        }

        /// <summary>
        /// Preform a click when enter or return is pressed
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Key pressed</param>
        private void saveLocation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                runButton.PerformClick();
            }
        }

        /// <summary>
        /// Run the program
        /// </summary>
        /// <param name="sender">Not Used</param>
        /// <param name="e">Not Used</param>
        private void runButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
