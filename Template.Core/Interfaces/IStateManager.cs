using Template.Core.Delegates;
using Template.Core.Models.Enumerables;

namespace Template.Core.Interfaces
{
    public interface IStateManager
    {
        event StateHandler StateChanged;

        void ChangeState(EState state);
    }
}
