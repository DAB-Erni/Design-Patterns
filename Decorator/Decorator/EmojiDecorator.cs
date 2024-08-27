namespace Decorator
{
    public class EmojiDecorator : ChatMessageDecorator
    {
        public EmojiDecorator(IChatMessage message) : base(message)
        {
        }

        public override string getMessage()
        {
            return AddEmojis(_chatMessage.getMessage());
        }

        private string AddEmojis(string message)
        {
            return message.Replace(":)", "✨");
        }
    }
}

