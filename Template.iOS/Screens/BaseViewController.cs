using System;
using Template.Core.Interfaces;
using Template.Core.Models.Enumerables;
using UIKit;
using Unity;

namespace Template.iOS.Screens
{
    public class BaseViewController : UIViewController
    {
        private readonly IStateManager _stateManager;

        public BaseViewController()
        {
            _stateManager = DIContainer.Container.Resolve<IStateManager>();
        }

        
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Subscribe();
        }


        public virtual void Subscribe()
        {
            _stateManager.StateChanged += OnStateChanged;
        }

        public virtual void Unsubscribe()
        {
            _stateManager.StateChanged -= OnStateChanged;
        }


        private void OnStateChanged(EState state)
        {
            throw new NotImplementedException();
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            
            Unsubscribe();
        }

    }
}
