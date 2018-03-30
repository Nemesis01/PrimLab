using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    class Node
    {

        #region Members
        private int x;
        private int y;
        private bool isVisited;
        #endregion


        #region Properties
        public Node(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
            this.IsVisited = false;
        }
        #endregion


        #region Properties
        public int X {
            get { return this.x; }
            protected set { this.x = value; }
        }
        public int Y
        {
            get { return this.y; }
            protected set { this.x = value; }
        }
        public bool IsVisited
        {
            get { return this.isVisited; }
            protected set { this.isVisited = value; }
        }
        public bool IsEntryPoint
        {
            get { return (X == 0 && Y == 0) ? true : false; }
        }
        #endregion
    }
}
