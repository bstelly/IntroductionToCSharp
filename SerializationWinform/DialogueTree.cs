using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SerializationWinform
{
    [Serializable]
    public class DialogueTree
    {
        public List<DialogueRoot> DialogueRoot = new List<DialogueRoot>();

        //public DialogueTree()
        //{
        //    DialogueRoot = new List<DialogueRoot>();
        //}
    }
}
