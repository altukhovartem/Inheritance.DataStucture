using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.DataStructure
{
    class Category
    {
        public string CurrentTitle { get; set; }
        public MessageType CurrentMessageType { get; set; }
        public MessageTopic CurrentMessageTopic { get; set; }

        public Category(string title, MessageType messageType, MessageTopic messageTopic)
        {
            CurrentTitle = title;
            CurrentMessageType = messageType;
            CurrentMessageTopic = messageTopic;
        }

        public override bool Equals(object obj)
        {
            Category CategoryToCompare = obj as Category;
            if (CategoryToCompare == null)
            {
                return false;
            }
            if (this.CurrentTitle == CategoryToCompare.CurrentTitle && this.CurrentMessageType == CategoryToCompare.CurrentMessageType && this.CurrentMessageTopic == CategoryToCompare.CurrentMessageTopic)
                return true;
            else
                return false;

        }
    }

}
