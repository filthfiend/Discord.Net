using Discord;
using Discord.Rest;

public class Program
{
    private DiscordSocketClient _client;
    static void Main(string[] args) => new Program().Start().GetAwaiter().GetResult();
    
    public async Task Start()
    {
        _client = new DiscordSocketClient(new DiscordSocketConfig() {
			LogLevel = LogSeverity.Info
        });

        _client.Log += (message) => 
        { 
            Console.WriteLine($"{message.ToString()}");
            return Task.CompletedTask;
        };

	await _client.LoginAsync(TokenType.Bot, "bot token");
	await _client.ConnectAsync();
	    
	await Task.Delay(-1);
    }
}
