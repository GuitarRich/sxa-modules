using System.Collections.Concurrent;

namespace Foundation.ScribanExtensions.Cache
{
    public class ScribanRenderCache : IScribanRenderCache
    {
        private ConcurrentStack<string> _endFieldStack;

        protected virtual ConcurrentStack<string> EndFieldStack => _endFieldStack ?? (_endFieldStack = new ConcurrentStack<string>());

        public void PushEndFieldStack(string lastPart)
        {
            EndFieldStack.Push(lastPart);
        }

        public string PopEndFieldStack()
        {
            return EndFieldStack.Pop();
        }
    }
}
