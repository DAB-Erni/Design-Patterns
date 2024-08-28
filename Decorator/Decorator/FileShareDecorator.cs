namespace Decorator
{
    public class FileShareDecorator : ChatMessageDecorator
    {
        private string _filename;
        public FileShareDecorator(IChatMessage message, string filename) : base(message)
        {
            _filename = filename;
        }

        public override string getMessage()
        {
            return _chatMessage.getMessage() + " (File uploaded: " + _filename + "]";
        }
    }
}

