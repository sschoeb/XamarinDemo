using System.Globalization;
using Android.App;
using Android.OS;
using Android.Widget;
using XamarinDemo.Core;

namespace XamarinDemo.Android
{
    public class CalcActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_calc);

            int summandOne = Intent.Extras.GetInt("summandOne");
            int summandTwo = Intent.Extras.GetInt("summandTwo");

            var calculator = new Calculator();
            int result = calculator.Sum(summandOne, summandTwo);

            var textViewResult = FindViewById<TextView>(Resource.Id.textViewResult);
            textViewResult.Text = result.ToString(CultureInfo.InvariantCulture);
        }
    }
}