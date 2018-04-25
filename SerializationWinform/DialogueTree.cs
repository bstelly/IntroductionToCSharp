using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SerializationAssignment
{
    public class DialogueTree
    {
        public List<DialogueRoot> DialogRoots = new List<DialogueRoot>();

        public DialogueTree GenerateObject()
        {
            string json = JsonConvert.DeserializeObject<DialogueTree>(File.ReadAllText(@"C:\dialogue.json"));
            var statsTwo = JsonConvert.DeserializeObject<DialogueTree>(json);
        }
    }
}
