namespace Decorator;
class Program
{
    static void Main(string[] args)
    {
        IChatMessage chatMessage = new BasicChatMessage("Hello World!");
        Console.WriteLine($@"Chat message: {chatMessage.getMessage()}");

        chatMessage = new EmojiDecorator(chatMessage, "😊");
        Console.WriteLine($@"Chat message: {chatMessage.getMessage()}");

        chatMessage = new ReactionDecorator(chatMessage, "Like");
        Console.WriteLine($@"Chat message: {chatMessage.getMessage()}");

        chatMessage = new FileShareDecorator(chatMessage, "exercise.pdf");
        Console.WriteLine($@"Chat message: {chatMessage.getMessage()}");

        // chatMessage = new EmojiDecorator(chatMessage, "😲");
        // Console.WriteLine($@"Chat message: {chatMessage.getMessage()}");

        // chatMessage = new ReactionDecorator(chatMessage, "Share");
        // Console.WriteLine($@"Chat message: {chatMessage.getMessage()}");
    }
}