using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationWinform
{
    public class DialogueNode
    {
        public string ConverstationID { get; set; }
        public string ParticipantName { get; set; }
        public string EmoteType { get; set; }
        public string Side { get; set; }
        public string Line { get; set; }
        public string SpecialtyAnimation { get; set; }
        public string SpecialtyCamera { get; set; }
        public string Participants { get; set; }
        public string ConversationSummary { get; set; }

        //public DialogueNode()
        //{
        //    ConverstationID = null;
        //    ParticipantName = null;
        //    EmoteType = null;
        //    Side = null;
        //    Line = null;
        //    SpecialtyAnimation = null;
        //    SpecialtyCamera = null;
        //    Participants = null;
        //    ConversationSummary = null;
        //}
    }
}
