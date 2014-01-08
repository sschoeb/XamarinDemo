using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace XamarinDemo.Android
{
    public class InputActivity : Activity
    {
        private TextView _summandOneTextView;
        private TextView _summandTwoTextView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_input);

            var button = FindViewById<Button>(Resource.Id.calcButton);
            button.Click += CalculateButtonClicked;

            _summandOneTextView = FindViewById<TextView>(Resource.Id.textViewSummandOne);
            _summandTwoTextView = FindViewById<TextView>(Resource.Id.textViewSummandTwo);
        }

        private void CalculateButtonClicked(object sender, EventArgs eventArgs)
        {
            var intent = new Intent(this, typeof(CalcActivity));
            intent.PutExtra("summandOne", int.Parse(_summandOneTextView.Text));
            intent.PutExtra("summandTwo", int.Parse(_summandTwoTextView.Text));
            StartActivity(intent);
        }
    }
}