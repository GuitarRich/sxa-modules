namespace Foundation.ScribanExtensions.Cache
{
    public interface IScribanRenderCache
    {
        void PushEndFieldStack(string lastPart);
        string PopEndFieldStack();
    }
}
