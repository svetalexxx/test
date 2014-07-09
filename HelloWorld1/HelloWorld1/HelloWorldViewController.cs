
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace HelloWorld1
{
	public partial class HelloWorldViewController : UIViewController
	{
		public HelloWorldViewController () : base ("HelloWorldViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
            buttonPrev.TouchUpInside += buttonPrev_TouchUpInside;
            buttonNext.TouchUpInside += buttonNext_TouchUpInside;
		}

        void buttonNext_TouchUpInside(object sender, EventArgs e)
        {
            labelTitle.Text = "Prev Clicked";
            txtDescription.Text = "This is test description when Prev button clicked";
            imageHW.Image = UIImage.FromBundle("cute_cat_1");
        }

        void buttonPrev_TouchUpInside(object sender, EventArgs e)
        {
            labelTitle.Text = "Next Clicked";
            txtDescription.Text = "This is test description when Next button clicked";
            imageHW.Image = UIImage.FromBundle("cute_cat_2");
        }
	}
}

