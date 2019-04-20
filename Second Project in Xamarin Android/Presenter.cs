using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Second_Project_in_Xamarin_Android.view;
using Android.Widget;
using System.Globalization;

namespace Second_Project_in_Xamarin_Android
{
    class Presenter : presenter.PresenterInterface
    {
        private View view;
        private const double VALUE = 0.7;

        public Presenter(View view)
        {
            this.view = view;
        }

        public void calcula(string gasolina, string alcool)
        {
           
        }
    }
}