using System;
namespace MethodExercise
{
	public class MadLib
	{
		public static void MadLibStory()
		{
            //Exercise 1

            //gathering input and declaring/assigning variables

            Console.Write("Before we begin, I have some questions for you. Let's go!" +
            "\nThere are quite a few questions, but answer all of them as best as you can." +
            "\n\nWhat's your name? First and Last, please: ");
            string yourName = Console.ReadLine();

            Console.Write("Where are you from? (state or region) ");
            string hometown = Console.ReadLine();

            Console.Write("Tell me the plural form of a piece of jewelry that is not a ring: ");
            string jewelry = Console.ReadLine();

            Console.Write("Now tell me the singular form of that same jewelry: ");
            string oneJewelry = Console.ReadLine();

            Console.Write("What is your favorite animal? Type its plural form: ");
            string favoriteAnimal = Console.ReadLine();

            Console.Write("The plural of an animal that burrows into the ground: ");
            string diggingAnimal = Console.ReadLine();

            Console.Write("The plural of a species of primate: ");
            string primate = Console.ReadLine();

            Console.Write("Name a fictional city: ");
            string fakeLand = Console.ReadLine();

            Console.Write("Tell me an emotion. Capitalize the first letter. ");
            string emotion = Console.ReadLine();

            Console.Write("Who is your favorite Disney villain? ");
            string disneyVillain = Console.ReadLine();

            Console.Write("Name a fictional country/region: ");
            string fakeCountry = Console.ReadLine();

            Console.Write("Name a Disney prince: ");
            string disneyPrince = Console.ReadLine();

            Console.Write("What is an instrument you play, or would like to learn how to play? ");
            string instrument = Console.ReadLine();

            Console.Write("Name a male Disney side character: ");
            string disneySidekick = Console.ReadLine();

            Console.Write("What is one mountain range that you know of? Don't put \"The\" in front of it: ");
            string mountainRange = Console.ReadLine();

            Console.Write("What animal first comes to mind when you hear, \"Small furry creature\"? (singluar form): ");
            string creature = Console.ReadLine();

            Console.Write("And what is the plural form of that same creature? ");
            string creatures = Console.ReadLine();

            //storytelling

            Console.WriteLine("\n\nI call this story: If Disney produced \"The Lord of the Rings\"");

            Console.WriteLine("\n\n\nThe world is changed...");

            Console.WriteLine("\nPress \"return\" to continue...");
            Console.ReadLine();

            Console.WriteLine("\nI feel it in the water." +
                "\nI feel it in the earth." +
                "\nI smell it in the air." +
                "\nMuch that once was is lost, for none now live who remember it.");

            Console.WriteLine("\nPress \"return\" to continue...");
            Console.ReadLine();


            Console.WriteLine($"\n\nIt began with the forging of the Great {jewelry}." +
                $"\nThree were given to the {favoriteAnimal}, immortal, wisest and fairest of all beings." +
                $"\nSeven to the {diggingAnimal}, great miners and craftsmen of the mountain halls." +
                $"\nAnd nine, nine {jewelry} were gifted to the race of {primate}, who above all else desire power." +
                $"\nFor within these {jewelry} was bound the strength and the will to govern each race.");

            Console.WriteLine("\nPress \"return\" to continue...");
            Console.ReadLine();

            Console.WriteLine($"\n\nBut they were all of them deceived, for another {oneJewelry} was made." +
                $"\nDeep in the land of {fakeLand}, in the Fires of Mount {emotion} the Dark Lord {disneyVillain} forged a master {oneJewelry}, " +
                $"\nand into this {oneJewelry} they poured their cruelty, their malice and their will to dominate all life.");

            Console.WriteLine("\nPress \"return\" to continue...");
            Console.ReadLine();

            Console.WriteLine($"\n\nOne by one, the free lands of {fakeCountry} fell to the power of the {oneJewelry}, but there were some who resisted." +
                $"\nA last alliance of {primate} and {favoriteAnimal} marched against the armies of {fakeLand}, " +
                $"\nand on the very slopes of Mount {emotion}, they fought for the freedom of {fakeCountry}." +
                $"\nVictory was near, but the power of the {oneJewelry} could not be undone." +
                $"\nIt was in this moment, when all hope had faded, " +
                $"\nthat {disneyPrince}, son of the king, took up his father’s {instrument}." +
                $"\n{disneyVillain}, enemy of the free {primate} of {fakeCountry}, was defeated." +
                $"\nThe {oneJewelry} passed to {disneyPrince}, who had this one chance to destroy evil forever, " +
                $"\nbut the hearts of {primate} are easily corrupted." +
                $"\nAnd the {oneJewelry} of power has a will of its own." +
                $"\nIt betrayed {disneyPrince}, to his death." +
                $"\nAnd some things that should not have been forgotten were lost." +
                $"\nHistory became legend." +
                $"\nLegend became myth." +
                $"\nAnd for two and a half thousand years, the {oneJewelry} passed out of all knowledge." +
                $"\nUntil, when chance came, it ensnared another bearer.");

            Console.WriteLine("Press \"return\" to continue...");
            Console.ReadLine();

            Console.WriteLine($"\n\nIt came to the creature {disneySidekick}, who took it deep into the tunnels of the {mountainRange}." +
                "\nAnd there it consumed him." +
                $"\nThe ring gave to {disneySidekick} unnatural long life." +
                $"\nFor five hundred years it poisoned his mind, and in the gloom of {disneySidekick}’s cave, it waited." +
                $"\nDarkness crept back into the forests of the world." +
                $"\nRumor grew of a shadow in the East, whispers of a nameless fear, " +
                $"\nand the {oneJewelry} of Power perceived its time had come." +
                $"\nIt abandoned {disneySidekick}, but then something happened that the {oneJewelry} did not intend." +
                $"\nIt was picked up by the most unlikely creature imaginable: a {creature}, {yourName}, of {hometown}.");

            Console.WriteLine($"\n\nFor the time will soon come when {creatures} will shape the fortunes of all.");

            Console.ReadLine();

            Console.WriteLine("Thanks for playing! Try again with different answers if you'd like. The possibilities are endless.");

            Console.ReadLine();
        }
	}
}

