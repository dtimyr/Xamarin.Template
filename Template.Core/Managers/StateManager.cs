using Template.Core.Delegates;
using Template.Core.Interfaces;
using Template.Core.Models.Enumerables;

namespace Template.Core.Managers
{
    public class StateManager : IStateManager
    {    
        public event StateHandler StateChanged;

        public EState ApplicationState;
        public EState InternetState;

        public void ChangeState(EState state)
        {
            if (state == EState.Foreground || state == EState.Background)
            {
                ApplicationState = state;
            }

            if (state == EState.InternetConnected || state == EState.InternetDisconnected)
            {
                InternetState = state;
            }

            StateChanged?.Invoke(state);
        }
    }
}