using UnityEngine;

namespace ChainOfResponsibility
{
    public abstract class GameHandler : MonoBehaviour, IGameHandler
    {
        private IGameHandler _nextHandle;

        public virtual object Handler(object request)
        {
            if(this._nextHandle != null)
                return this._nextHandle.Handler(request);
            else
                return null;
        }

        public IGameHandler SetNext(IGameHandler nextHandler)
        {
            this._nextHandle = nextHandler;
            return nextHandler;
        }
    }
}