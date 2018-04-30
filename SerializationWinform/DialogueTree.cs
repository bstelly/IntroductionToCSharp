using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SerializationWinform
{
    public class DialogueTree
    {
        public List<DialogueRoot> DialogueRoots = new List<DialogueRoot>();

        public DialogueTree GenerateObject()
        {
            var directory = Environment.CurrentDirectory;
            var path = directory + @"\Dialogue.json";
            //var paths = Directory.GetFiles(@"c:\", "d*");
            //string path = "";
            //for (int i = 0; i < paths.Length; i++)
            //{
            //    if (paths[i] == "dialogue.json")
            //    {
            //        path = paths[i];
            //    }
            //}
            var trial = JsonConvert.DeserializeObject<DialogueTree>(File.ReadAllText("Dialogue.json"));
            //Console.WriteLine(trial.DialogueRoots.);
            var asd = File.ReadAllText(path);
            //var json = JsonConvert.DeserializeObject<DialogueTree>(asd);
            //var statsTwo = JsonConvert.DeserializeObject<DialogueTree>(json);
            //var temp = JsonConvert.DeserializeObject<DialogueTree>(json);
            return trial;
        }
    }
}
