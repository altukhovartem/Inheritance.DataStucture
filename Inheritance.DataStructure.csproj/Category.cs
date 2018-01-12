using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.DataStructure
{
    class Category
    {
        public string CurrentBukva { get; set; }
        public MessageType CurrentMessageType { get; set; }
        public MessageTopic CurrentMessageTopic { get; set; }

        public Category(string bukva, MessageType messageType, MessageTopic messageTopic)
        {
            CurrentBukva = bukva;
            CurrentMessageType = messageType;
            CurrentMessageTopic = messageTopic;
        }

        public override bool Equals(object obj)
        {
            Category CategoryToCompare = obj as Category;
            if (CategoryToCompare == null)
            {
                throw new Exception();
            }


        }
    }

}
