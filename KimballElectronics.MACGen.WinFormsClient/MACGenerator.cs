using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace KimballElectronics.MACGen.WinFormsClient
{
    public partial class MACGenerator : Form
    {
        private Random random;
        private int quantity;
        string prefix;
        char separator;

        private string result;

        public MACGenerator()
        {
            InitializeComponent();

            random = new Random();

            ComboBoxSeparator.SelectedItem = "-";
        }

        private void ButtonGenerateMACAddress_Click(object sender, EventArgs e)
        {
            GenerateMACAdress();
        }

        private void GenerateMACAdress()
        {
            this.prefix = TextBoxPrefix.Text;

            string selectedSeparator = (string)ComboBoxSeparator.SelectedItem; // rzutowanie (konwersja typu) casting

            this.separator = char.Parse(selectedSeparator);
            this.quantity = (int) InputQuantity.Value;

            GeneratorBackgroundWorker.RunWorkerAsync();
        }

        private void GenerateMACAdresses()
        {
            for (int i = 1; i < quantity; i++)
            {
                string macAddress = GetRandomMac(random, prefix, separator);

                //TextBoxMACAddress.Text = macAddress;

                result += macAddress + Environment.NewLine;

                //TextBoxMACAddresses.Text += macAddress + Environment.NewLine;

                // Zaraportowanie postępu

                int percentage = i * 100 / quantity;

                GeneratorBackgroundWorker.ReportProgress(percentage);
            }
        }

        // DRY Don't Repeator Yourself (nie powtarzaj się)
        static string GetRandomMac(Random random, string prefix, char separator = '-')     // parametr opcjonalny
        {
            Thread.Sleep(1000); // symulacja opóźnienia

            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
            string segment4 = random.Next(0, 255).ToString("X");
            string segment5 = random.Next(0, 255).ToString("X");
            string segment6 = random.Next(0, 255).ToString("X");

            string macAddress = $"{prefix}{separator}{segment4}{separator}{segment5}{separator}{segment6}";

            return macAddress;
        }

        private void CheckBoxRandom_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPrefix.Enabled = !CheckBoxRandom.Checked;
        }

        private void TextBoxPrefix_DoubleClick(object sender, EventArgs e)
        {
            GenerateMACAdress();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Close Window", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog(); // okienko modalne (tylko jedno okno jest aktywne)

            // settingsForm.Show(); // okno niemodalne (równocześnie kilka okien może być aktywnych)
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GeneratorBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            GenerateMACAdresses();
        }

        private void GeneratorBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            GenerateMACAddressProgressBar.Value = e.ProgressPercentage;
        }

        private void GeneratorBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            TextBoxMACAddresses.Text = result;

            GenerateMACAddressProgressBar.Value = 0;
        }

        private void GenerateCancelButton_Click(object sender, EventArgs e)
        {
            GeneratorBackgroundWorker.CancelAsync();


        }
    }
}
