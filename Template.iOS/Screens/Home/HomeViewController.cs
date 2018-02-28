using System;

namespace Template.iOS.Screens.Home
{
    public partial class HomeViewController : BaseViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            CreateView();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
