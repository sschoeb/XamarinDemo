using System.Globalization;
using MonoTouch.UIKit;
using System.Drawing;
using XamarinDemo.Core;

namespace XamarinDemo.iOS
{
    public class CalcController : UIViewController
    {
        private readonly int _summandOne;
        private readonly int _summandTwo;
        private UITextView _uiTextView;

        public CalcController(int summandOne, int summandTwo)
        {
            _summandOne = summandOne;
            _summandTwo = summandTwo;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.Frame = UIScreen.MainScreen.Bounds;
            View.BackgroundColor = UIColor.White;
            View.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;

            Title = "Result";

            CreateUI();

            var calculator = new Calculator();
            int result = calculator.Sum(_summandOne, _summandTwo);
            _uiTextView.Text = result.ToString(CultureInfo.InvariantCulture);
        }

        private void CreateUI()
        {
            _uiTextView = new UITextView
            {
                Frame = new RectangleF(0, 0, View.Frame.Width, 20),
            };
            View.AddSubview(_uiTextView);
        }
    }
}

