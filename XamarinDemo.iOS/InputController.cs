using System;
using MonoTouch.UIKit;
using System.Drawing;

namespace XamarinDemo.iOS
{
    public class InputController : UIViewController
    {
        private UITextField _summandOneTextField;
        private UITextField _summandTwoTextField;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View.Frame = UIScreen.MainScreen.Bounds;
            View.BackgroundColor = UIColor.White;
            View.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;

            Title = "Calculator";

            CreateUI();
        }

        private void CreateUI()
        {
            _summandOneTextField = new UITextField { Frame = new RectangleF(0, 0, View.Frame.Width, 20) };
            View.AddSubview(_summandOneTextField);

            _summandTwoTextField = new UITextField { Frame = new RectangleF(0, 30, View.Frame.Width, 20) };
            View.AddSubview(_summandTwoTextField);

            var calcButton = UIButton.FromType(UIButtonType.RoundedRect);
            calcButton.SetTitle("Calculate", UIControlState.Normal);
            calcButton.Frame = new RectangleF(0, 60, View.Frame.Width, 20);
            View.AddSubview(calcButton);

            calcButton.TouchUpInside += CalculateClicked;
        }

        private void CalculateClicked(object sender, EventArgs eventArgs)
        {
            int summandOne = int.Parse(_summandOneTextField.Text);
            int summandTwo = int.Parse(_summandTwoTextField.Text);

            var calcController = new CalcController(summandOne, summandTwo);
            NavigationController.PushViewController(calcController, true);
        }
    }
}

