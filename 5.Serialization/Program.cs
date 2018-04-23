using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using _1.Containers;

namespace _5.Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var strength = new Stat("Strength", 10, "Determines which weapons a character can use");
            var dexterity = new Stat("Dexterity", 4, "A measure of a character's attack, movement speed, and accuracy.");
            var constitution = new Stat("Constitution", 5, "A measure of how sturdy a character is");
            var intelligence = new Stat("Intelligence", 6, "A measure of a character's problem-solving ability.");
            var wisdom = new Stat("Wisdom", 5, "A measure of a character's common sense and/or spirituality.");
            var charisma = new Stat("Charisma", 4, "A measure of a characters social skills");
            var statsOne = new Stats();
            statsOne.statList.Add(strength);
            statsOne.statList.Add(dexterity);
            statsOne.statList.Add(constitution);
            statsOne.statList.Add(intelligence);
            statsOne.statList.Add(wisdom);
            statsOne.statList.Add(charisma);

            JsonSerializer serializer = new JsonSerializer();
            TextWriter writer = new StreamWriter("output.json");
            serializer.Serialize(writer, statsOne);
            writer.Close();

            System.IO.TextReader readFile  = new StreamReader("output.json");
            JsonReader reader = new JsonTextReader(readFile);
            var statsTwo = serializer.Deserialize(reader);
        }
    }
}
