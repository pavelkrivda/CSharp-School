namespace Server
{
    public interface IMessageProcessor
    {
        void Process(string message);
    }
}