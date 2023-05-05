using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Race_Assignment_MaxGuclu_FSCS.Models;
using Spectre.Console;


namespace Race_Assignment_MaxGuclu_FSCS.Utilities
{
    public class UI
    {
        public static async void TableGenerator(Track[] tracks, Car[] contenders, Event[] events)
        {

            int i = 0;
            while (true)
            {
                var root = new Tree("Race");
                await Task.Delay(3000);
                Console.Clear();
                // Add some nodes
                var foo = root.AddNode("[yellow]Snabba Sixten[/]");
                var table = foo.AddNode(new Table()
                    .RoundedBorder()
                    .AddColumn("1 KM")
                    .AddColumn("2 Km")
                    .AddColumn("3 Km")
                    .AddColumn("4 Km")
                    .AddColumn("5 Km")
                    .AddColumn("6 Km")
                    .AddColumn("7 Km")
                    .AddColumn("8 Km")
                    .AddColumn("9 Km")
                    .AddColumn("10 Km")
                    .AddRow($"{i}", "2"));

                var foo2 = root.AddNode("[yellow]Brännarn Bettan[/]");
                var table2 = foo2.AddNode(new Table()
                    .RoundedBorder()
                    .AddColumn("1 KM")
                    .AddColumn("2 Km")
                    .AddColumn("3 Km")
                    .AddColumn("4 Km")
                    .AddColumn("5 Km")
                    .AddColumn("6 Km")
                    .AddColumn("7 Km")
                    .AddColumn("8 Km")
                    .AddColumn("9 Km")
                    .AddColumn("10 Km")
                    .AddRow($"1", "2"));


                if (true)
                {
                    var foo4 = root.AddNode("[yellow]Brännarn Bettan[/]");
                    var table4 = foo4.AddNode(new Table()
                        .RoundedBorder()
                        .AddColumn("1 KM")
                        .AddColumn("2 Km")
                        .AddColumn("3 Km")
                        .AddColumn("4 Km")
                        .AddColumn("5 Km")
                        .AddColumn("6 Km")
                        .AddColumn("7 Km")
                        .AddColumn("8 Km")
                        .AddColumn("9 Km")
                        .AddColumn("10 Km")
                        .AddRow($"{i}", "2"));
                }

                var foo3 = root.AddNode("[yellow]Hala Hasse[/]");
                var table3 = foo3.AddNode(new Table()
                    .RoundedBorder()
                    .AddColumn("1 KM")
                    .AddColumn("2 Km")
                    .AddColumn("3 Km")
                    .AddColumn("4 Km")
                    .AddColumn("5 Km")
                    .AddColumn("6 Km")
                    .AddColumn("7 Km")
                    .AddColumn("8 Km")
                    .AddColumn("9 Km")
                    .AddColumn("10 Km")
                    .AddRow($"{i}", "2"));

                // Render the tree
                AnsiConsole.Write(root);
                i++;

            }

        }
    }
}
