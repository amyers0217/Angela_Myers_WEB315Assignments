using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesHistoricalFiguresAC;
using System;
using System.Linq;

namespace RazorPagesHistoricalFiguresAC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesHistoricalFiguresACContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesHistoricalFiguresACContext>>()))
            {
                if (context.HistoricalFiguresAC.Any())
                {
                    return; 
                }

                context.HistoricalFiguresAC.AddRange(
                    new HistoricalFiguresAC
                    {
                        Name = "Leonardo da Vinci",
                        DateOfBirth = DateTime.Parse ("1452-04-15"),
                        DateOfDeath = DateTime.Parse ("1519-05-02"),
                        Profession = "Polymath",
                        SeenIn = "Assassin's Creed 2, Assassin's Creed: Brotherhood",
                        Affiliation = "Assassins: Italian Brotherhood, Templars: Italian Rite (forcibly), Hermeticts (forcibly)"
                    },

                     new HistoricalFiguresAC
                    {
                        Name = "Mary Read",
                        DateOfBirth = DateTime.Parse ("1685-01-01"),
                        DateOfDeath = DateTime.Parse ("1721-04-28"),
                        Profession = "Pirate",
                        SeenIn = "Assassin's Creed 4: Black Flag",
                        Affiliation = "Assassins: West Indies Brotherhood, British Army, Pirate Republic"
                    },

                    new HistoricalFiguresAC
                    {
                        Name = "Benjamin Franklin",
                        DateOfBirth = DateTime.Parse ("1706-01-17"),
                        DateOfDeath = DateTime.Parse ("1790-04-17"),
                        Profession = "Polymath",
                        SeenIn = "Assassin's Creed 3, Assassin's Creed: Rouge, Assassin's Creed: Unity",
                        Affiliation = "Assassins: Colonial Brotherhood, Templars: American Rite, Patriots, Founding Fathers, Freemasons"
                    },

                    new HistoricalFiguresAC
                    {
                        Name = "Niccolo di Bernardo dei Machiavelli",
                        DateOfBirth = DateTime.Parse ("1469-05-03"),
                        DateOfDeath = DateTime.Parse ("1527-06-21"),
                        Profession = "Doplomat, Philosopher, Historian",
                        SeenIn = "Assassin's Creed 2, Assassin's Creed: Brotherhood",
                        Affiliation = "Assassins: Italian Brotherhood, Mercenaries: Renaissance"
                    },

                    new HistoricalFiguresAC
                    {
                        Name = "Edward Thatch AKA Blackbeard",
                        DateOfBirth = DateTime.Parse ("1680-01-01"),
                        DateOfDeath = DateTime.Parse ("1718-11-22"),
                        Profession = "Pirate",
                        SeenIn = "Assassin's Creed 4: Black Flag",
                        Affiliation = "Royal Navy, Pirate Republic, Captain of the Sea Dog's Bite, Captain of the Queen Anne's Revenge"
                    },

                    new HistoricalFiguresAC
                    {
                        Name = "Alexandrina Victoria",
                        DateOfBirth = DateTime.Parse ("1819-05-24"),
                        DateOfDeath = DateTime.Parse ("1901-01-22"),
                        Profession = "Queen",
                        SeenIn = "Assassin;s Creed: Syndicate",
                        Affiliation = "House of Hanover, British Empire, Order of the Sacred Garter"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}