using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    class Edge
    {

        #region Members
        private int number;
        private int weight;
        #endregion


        #region Constructors
        public Edge(int weight)
        {

        }
        public Edge(int number, int weight)
        {

        }
        #endregion


        #region Properties
        public int Number
        {
            get { return this.number; }
            protected set { this.number = value; }
        }
        public int Weight
        {
            get { return this.weight; }
            protected set { this.weight = value; }
        }
        #endregion

    }
}
