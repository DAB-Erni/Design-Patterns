namespace Decorator
{
    public class ReactionDecorator : ChatMessageDecorator
    {
        private string _reaction;
        public ReactionDecorator(IChatMessage message, string reaction) : base(message)
        {
            _reaction = reaction;
        }

        public override string getMessage()
        {
            return _chatMessage.getMessage() + " [" + _reaction + "]";
        }
    }
}

