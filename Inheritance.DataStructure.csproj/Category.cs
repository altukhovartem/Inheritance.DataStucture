using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.DataStructure
{
    class Category: IComparable
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

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Category CategoryToCompare = obj as Category;
            if (CategoryToCompare == null)
            {
                throw new Exception("Can not compare objects of different types");
            }

            if (string.Compare(this.CurrentTitle, CategoryToCompare.CurrentTitle) == -1)
                return -1;
            else if (string.Compare(this.CurrentTitle, CategoryToCompare.CurrentTitle) == 1)
                return 1;
            else if (this.CurrentMessageType.CompareTo(CategoryToCompare.CurrentMessageType) == -1)
                return -1;
            else if (this.CurrentMessageType.CompareTo(CategoryToCompare.CurrentMessageType) == 1)
                return 1;
            else if (this.CurrentMessageTopic.CompareTo(CategoryToCompare.CurrentMessageTopic) == -1)
                return -1;
            else if (this.CurrentMessageTopic.CompareTo(CategoryToCompare.CurrentMessageTopic) == 1)
                return 1;
            else
                return 0;
        }

        public static bool operator >(Category c1, Category c2)
        {
            int result = c1.CompareTo(c2);
            if (result == 1)
                return true;
            else
                return false;
        }

        public static bool operator <(Category c1, Category c2)
        {
            int result = c1.CompareTo(c2);
            if (result == -1)
                return true;
            else
                return false;
        }

        public static bool operator >=(Category c1, Category c2)
        {
            int result = c1.CompareTo(c2);
            if (result == 0 || result == 1)
                return true;
            else
                return false;
        }

        public static bool operator <=(Category c1, Category c2)
        {
            int result = c1.CompareTo(c2);
            if (result == 0 || result == -1)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}.{2}", CurrentTitle, CurrentMessageType, CurrentMessageTopic);
        }
    }

}
