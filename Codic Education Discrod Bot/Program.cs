using DSharpPlus;
using DSharpPlus.EventArgs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Codic_Education_Discrod_Bot
{
    class Program
    {
        static List<string> listOfQuotes = new List<string>();

        public static async Task Main(string[] args)
        {

            AddMockData();

            var discordClient = new DiscordClient(new DiscordConfiguration
            {
                Token = "ODM5NDMzNTg4ODM5MDIyNjEy.YJJlcw.YWGFZmBi7ytR_Dzu2Unt7SpqF-8",
                TokenType = TokenType.Bot
            });

            discordClient.MessageCreated += OnMessageCreated;

            await discordClient.ConnectAsync();
            await Task.Delay(-1);
        }

        private static void AddMockData()
        {
            listOfQuotes.Add("Jag backar inte bot systemet, så nej// Född skeptiker");
            listOfQuotes.Add("Alla är legender inför Niklas ögon // Legenden han själv");
            listOfQuotes.Add("Sluta gråta börja jobba..// Livets tuffa skola");
            listOfQuotes.Add("Håll ut, det är dom fem första dagarna efter helgen som är jobbigast! //Mannen myten legenden");
            listOfQuotes.Add("Potatis kan vara potatismos, pommes, hasselback, gratäng, potatis, batteri. Och du kan inte koda... // En ensam potatis");
            listOfQuotes.Add("A redbull a day, keeps the sanity away // Kakashi");
            listOfQuotes.Add("I can save the world but i cant c#");
            listOfQuotes.Add("Dra tomten i skägget och fråga om en present");
        }

        private static async Task OnMessageCreated(MessageCreateEventArgs user)
        {
            Random rd = new Random();
            int num = rd.Next(listOfQuotes.Count);

            if (string.Equals(user.Message.Content, "hjälp", StringComparison.OrdinalIgnoreCase))
            {
                await user.Message.RespondAsync(user.Message.Author.Username + listOfQuotes[num]);
            }
            else if (string.Equals(user.Message.Content, "inspo", StringComparison.OrdinalIgnoreCase))
            {
                await user.Message.RespondAsync("vad kan jag hjälpa dig med " + user.Message.Author.Username + " ?");
            }
        }

    }
}
