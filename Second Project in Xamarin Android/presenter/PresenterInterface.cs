using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Second_Project_in_Xamarin_Android.presenter
{
    interface PresenterInterface{
        void calcula(String gasolina, String alcool);
    }
}