using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Doman
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        private Int32 index = 0;

        private List<String[]> sequence = new List<String[]>();
        public MainPage()
        {
            InitializeComponent();

            string[] sequence = { "Оля", "КУКУ", "всё" };
            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
                if (index >= sequence.Length)
                {
                    result.Text = "Закончили";
                }
                else
                {
                    result.Text = sequence[index];
                    index++;
                }
                // called every 1 second
                // do stuff here


                return true; // return true to repeat counting, false to stop timer
            });

        }


        private void Button_Clicked(object sender, EventArgs e) //Обработчик нажатия на кнопку
        {

       }
    }
}
