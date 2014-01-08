using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace XamarinDemo.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow window;
        InputController viewController;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            window = new UIWindow(UIScreen.MainScreen.Bounds);

            var navController = new UINavigationController();
            navController.PushViewController(new InputController(), false);

            window.RootViewController = navController;

            window.MakeKeyAndVisible();

            return true;
        }
    }
}

