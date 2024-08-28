namespace Decorator
{
    public abstract class ChatMessageDecorator : IChatMessage
    {
        protected IChatMessage _chatMessage;
        protected ChatMessageDecorator(IChatMessage chatMessage)
        {
            _chatMessage = chatMessage;
        }

        public virtual string getMessage()
        {
            return _chatMessage.getMessage();
        }
    }
}

// Base Decorator
