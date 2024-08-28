namespace Decorator
{
    public class BasicChatMessage : IChatMessage
    {
        private string _content;
        public BasicChatMessage(string content)
        {
            _content = content;
        }
        public string getMessage()
        {
            return _content;
        }
    }
}

//Concrete Component
