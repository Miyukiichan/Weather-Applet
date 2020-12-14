using System.Windows.Forms;
using Weather.Controllers;
using System.Collections.Generic;
using System.Drawing;

namespace Weather
{
    public partial class Form1 : Form
    {
        readonly Controller controller;
        bool blockRefresh = true;
        public Form1()
        {
            InitializeComponent();
            controller = new Controller();
            cbCountry.Text = controller.Country;
            Units = controller.Units;
            cbLocation.Text = controller.City;
            pbWeatherIcon.SizeMode = PictureBoxSizeMode.StretchImage | PictureBoxSizeMode.CenterImage;
            PopulateCountries();
            blockRefresh = false;
            RefreshMainWeather();
        }
        protected void RbChanged(RadioButton rb)
        {
            if (!rb.Checked)
                return;
            controller.Units = Units;
            RefreshMainWeather();
        }
        protected string Units
        {
            get => rbC.Checked ? "C" : "F";
            set
            {
                RadioButton rb = value == "C" ? rbC : rbF;
                rb.Checked = true;
            }
        }
        protected void RefreshMainWeather()
        {
            controller.Refresh();
            if (cbLocation.Text == string.Empty)
            {
                testOutput.Text = "";
                pbWeatherIcon.Image = null;
                return;
            }
            testOutput.Text = controller.MainWeather;
            pbWeatherIcon.Image = Image.FromFile(controller.IconFile);
        }
        protected void PopulateCombo(ComboBox combo, IEnumerable<string> items)
        {
            string original = combo.Text;
            combo.Items.Clear();
            foreach (string s in items)
                combo.Items.Add(s);
            combo.Text = combo.Items.Contains(original) ? original : "";
        }
        protected void PopulateCities()
        {
            PopulateCombo(cbLocation, controller.Cities);
        }
        protected void PopulateCountries()
        {
            PopulateCombo(cbCountry, controller.Countries);
        }

        private void cbCountry_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (!blockRefresh) controller.Country = cbCountry.Text;
            PopulateCities();
            if (!blockRefresh) RefreshMainWeather();
        }

        private void cbLocation_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (blockRefresh) return;
            controller.City = cbLocation.Text;
            RefreshMainWeather();
        }

        private void rbC_CheckedChanged(object sender, System.EventArgs e)
        {
            if (blockRefresh) return;
            RbChanged(rbC);
        }

        private void rbF_CheckedChanged(object sender, System.EventArgs e)
        {
            if (blockRefresh) return;
            RbChanged(rbF);
        }
    }
}
