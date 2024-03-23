using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAlgoCodes.DataStructure
{
    public class Nodes
    {
        public Nodes Next;
        public Nodes Left;
        public Nodes Right;
        public int data;
        public Nodes(int data)
        {
            this.data = data;
            Next = null;
            this.Left = null;
            this.Right = null;
        }
    }
}
