using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Foundation.ScribanExtensions.Cache
{
    public class ScribanRenderCache : IScribanRenderCache
    {
        private ConcurrentStack<string> _endFieldStack;

        protected virtual Stack<string> EndFieldStack => _endFieldStack ?? (_endFieldStack = new Stack<string>());

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
