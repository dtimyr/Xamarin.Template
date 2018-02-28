using Cirrious.FluentLayouts.Touch;
using UIKit;

namespace Template.iOS.Screens.Home
{
    public partial class HomeViewController
    {
        private UILabel _label;
        
        public void CreateView()
        {
            View.BackgroundColor = UIColor.White;
            
            _label = new UILabel {Text = "Template", TextColor = UIColor.Black};
            View.Add(_label);
            
            SetupConstraints();
        }

        private void SetupConstraints()
        {
            View.AddConstraints(
                _label.CenterY().EqualTo().CenterYOf(View),
                _label.CenterX().EqualTo().CenterXOf(View)
            );

            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
        }
        
    }
}