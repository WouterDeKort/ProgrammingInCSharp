using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Startup
{
    public static class Starter
    {
        private static List<Type> samples;

        public static void Run(Assembly assembly)
        {
            samples = LoadSamples(assembly);

            DisplaySamples();

            int index = SelectSample();

            RunSample(index);
        }

        private static void RunSample(int index)
        {
            Console.Clear();

            var descriptionAttribute =
                (DescriptionAttribute) samples[index].GetCustomAttribute(typeof (DescriptionAttribute));


            Console.WriteLine();
            Console.WriteLine("Running sample: {0}", descriptionAttribute.Description);
            Console.WriteLine("Sample output: ");
            Console.WriteLine("-----------------");

            var sample = (ISample) Activator.CreateInstance(samples[index]);
            sample.Run();
            Console.WriteLine("-----Finished--------");

            bool? reset = null;
            Console.WriteLine("Do you want to run another sample? y/n");
            while (reset == null)
            {
                string command = Console.ReadLine();
                if (command.ToUpper() == "N")
                {
                    reset = false;
                }
                else if (command.ToUpper() == "Y")
                {
                    reset = true;
                }
            }

            if (reset == true)
            {
                DisplaySamples();
                index = SelectSample();

                RunSample(index);
            }
        }

        private static int SelectSample()
        {
            Console.WriteLine("Run: ");
            bool foundValidIndex = false;
            int index = -1;

            while (!foundValidIndex)
            {
                foundValidIndex = true;
                string input = Console.ReadLine();

                if (!int.TryParse(input, out index))
                {
                    Console.WriteLine("Please enter a number");
                    foundValidIndex = false;
                }
                else
                {
                    index--;
                    if (index < 0 || index > samples.Count - 1)
                    {
                        Console.WriteLine("Please enter number between 0 and {0}", samples.Count);
                        foundValidIndex = false;
                    }
                }
            }
            return index;
        }

        private static void DisplaySamples()
        {
            Console.Clear();

            for (int x = 0; x < samples.Count; x++)
            {
                Type sampleType = samples[x];
                var descriptionAttribute =
                    (DescriptionAttribute) sampleType.GetCustomAttribute(typeof (DescriptionAttribute));

                Console.WriteLine("({0}): {1}", x + 1, descriptionAttribute.Description);
            }
        }

        private static List<Type> LoadSamples(Assembly assembly)
        {
            List<Type> samples = assembly.GetTypes()
                .Where(t => typeof (ISample).IsAssignableFrom(t))
                .OrderBy(GetIndex)
                .ToList();
            return samples;
        }

        private static int GetIndex(Type t)
        {
            var descriptionAttribute = (DescriptionAttribute) t.GetCustomAttribute(typeof (DescriptionAttribute));

            var regEx = new Regex(@"\d+");
            MatchCollection listingNumbers = regEx.Matches(descriptionAttribute.Description);

            string listing = listingNumbers[1].Value;
            return int.Parse(listing);
        }
    }
}