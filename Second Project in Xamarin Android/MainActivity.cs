
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using System.Globalization;

namespace Second_Project_in_Xamarin_Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private TextView text;
        private Button button;
        private EditText etGasolina, etAlcool;
        private String gasolina, alcool;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //Atribuindo valores as variáveis
            text = FindViewById<TextView>(Resource.Id.tvTeste);
            button = FindViewById<Button>(Resource.Id.btnTeste);
            etGasolina = FindViewById<EditText>(Resource.Id.etValorGasolina);
            etAlcool = FindViewById<EditText>(Resource.Id.etValorAlcool);

            button.Click += (Sender, e) =>
            {
                gasolina = etGasolina.Text;
                alcool = etAlcool.Text;
                Calcula();
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void Calcula()
        {
            const double VALUE = 0.7;
            if (!String.IsNullOrEmpty(gasolina) || !String.IsNullOrEmpty(alcool))
            {
                double gasolinaConverted = double.Parse(gasolina, CultureInfo.InvariantCulture.NumberFormat);
                double alcoolConverted = double.Parse(alcool, CultureInfo.InvariantCulture.NumberFormat);
                double resultado = gasolinaConverted * VALUE;
                if (resultado > alcoolConverted)
                {
                    text.Text = "Vale a pena utilizar o álcool";
                }
                else if (resultado < alcoolConverted)
                {
                    text.Text = "Vale a pena utilizar a gasolina";

                }
                else
                {
                    text.Text = "Tanto faz";

                }
            }
            else
            {
                text.Text ="Você não pode deixar nenhuma campo vazio";
            }
        }
    }

//    Multiplique o valor da gasolina no posto de combustível por 0,7. Se o resultado for maior que o valor do álcool, vale abastecer com álcool.Se o resultado for menor que valor do álcool, abasteça com gasolina.
}