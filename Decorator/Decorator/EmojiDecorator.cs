namespace Decorator
{
    public class EmojiDecorator : ChatMessageDecorator
    {
        private string _emoji;
        public EmojiDecorator(IChatMessage message, string emoji) : base(message)
        {
            _emoji = emoji;
        }

        public override string getMessage()
        {
            return _chatMessage.getMessage() + " " + _emoji;
        }
    }
}

