using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HelloWorld1
{
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow window;
		HelloWorldViewController hwViewController;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            window = new UIWindow(UIScreen.MainScreen.Bounds);

			hwViewController = new HelloWorldViewController();
			window.RootViewController = hwViewController;

            window.MakeKeyAndVisible();

            return true;
        }
    }
}

