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

            var trial = JsonConvert.DeserializeObject<DialogueTree>(File.ReadAllText("Dialogue.json"));
            //Console.WriteLine(trial.DialogueRoots.);

            return trial;
        }
    }
}
