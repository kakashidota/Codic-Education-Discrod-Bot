using DSharpPlus;
using DSharpPlus.EventArgs;
using System;
using System.Threading.Tasks;

namespace Codic_Education_Discrod_Bot
{
    class Program
    {
        public static async Task Main(string[] args)
        {

            var discordClient = new DiscordClient(new DiscordConfiguration
            {
                Token = "ODM5NDMzNTg4ODM5MDIyNjEy.YJJlcw.JxpDGZscTxF155eVlv_lMCrrRfA",
                TokenType = TokenType.Bot
            });

            discordClient.MessageCreated += OnMessageCreated;

            await discordClient.ConnectAsync();
            await Task.Delay(-1);
        }
        //https://discordapp.com/oauth2/authorize?client_id=839433588839022612&scope=bot&permissions=0
        private static async Task OnMessageCreated(MessageCreateEventArgs user)
        {
            if(string.Equals(user.Message.Content, "hjälp", StringComparison.OrdinalIgnoreCase))
            {
                await user.Message.RespondAsync(user.Message.Author.Username + " ge inte upp, det blir bättre!");
            }
        }

    }
}
