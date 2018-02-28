using Template.iOS.Screens.Home;
using UIKit;

namespace Template.iOS.Managers
{
    public class NavigationManager
    {
        public static NavigationManager Instance = new NavigationManager();

        private UINavigationController _navigationController;

        public void Initialize(UIWindow window)
        {
            var rootViewController = new HomeViewController();

            _navigationController = new UINavigationController(rootViewController);
            _navigationController.SetNavigationBarHidden(true, false);
            _navigationController.SetToolbarHidden(true, false);

            window.RootViewController = _navigationController;
            window.MakeKeyAndVisible();
        }
        
    }
}