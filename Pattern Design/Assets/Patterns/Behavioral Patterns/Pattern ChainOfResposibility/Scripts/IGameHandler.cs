namespace ChainOfResponsibility
{
    public interface IGameHandler
    {
        object Handler(object request);

        IGameHandler SetNext(IGameHandler nextHandler);
    }
}