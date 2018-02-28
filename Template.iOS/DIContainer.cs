using Template.Core.Interfaces;
using Template.Core.Managers;
using Unity;

namespace Template.iOS
{
    public class DIContainer
    {
        public static UnityContainer Container { get; set; }
        
        public static void Initialize()
        {
            Container = new UnityContainer();
            
            Container.RegisterSingleton<IStateManager, StateManager>();
        }
    }
}