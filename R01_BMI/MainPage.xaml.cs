using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R01_BMI
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string s1 = tBox1.Text;
            string s2 = tBox2.Text;
            double res = 0;

            double height = double.Parse(s1);
            double weight = double.Parse(s2);
            height = height / 100; //m変換

            res = weight / (height * height);
            res=(Math.Round(res, 2, MidpointRounding.AwayFromZero));
            lbl.Text = res.ToString();





        }
    }
}

