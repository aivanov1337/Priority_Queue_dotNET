using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Codecamp_Priority_Queue
{
    public class PriorityQueue
    {
        public List<PriorityObject> list = new List<PriorityObject>();

        public void Enqueue(PriorityObject obj)
        {
            list.Sort((first, second) => first.priority.CompareTo(second.priority));

            for(int i=0; i<Size(); i++)
            {
                if(list[i].priority > obj.priority)
                {   
                    list.Insert(i, obj);
                    break;
                }
            }
        }

        public PriorityObject Dequeue(PriorityObject obj)
        {
            if (list.Contains(obj))
            {
                list.Remove(obj);
                return obj;
            }
            return null;
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public int Size()
        {
            return list.Count;
        }

        public PriorityObject Front()
        {
            if (IsEmpty())
            {
                return null;
            }
            return list[list.Count - 1];
        }
    }
}
