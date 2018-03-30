using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Classes
{
    /// <summary>
    /// Représente un labyrinthe de n * m noeuds.
    /// </summary>
    class Maze
    {

        #region Members
        private int n;
        private int m;
        private int lines;
        private int columns;
        private int edges;
        private int nodes;
        private List<Edge> egdesList = new List<Edge>();
        private List<Node> nodesList = new List<Node>();
        #endregion


        #region Constructors
        public Maze(int n, int m)
        {
            this.n = n;
            this.m = m; 
        }
        #endregion


        #region Properties
        private int Edges
        {
            get { return ((m - 1) * n) + ((n - 1) * m); }
        }
        private int Nodes
        {
            get { return n * m; }
        }
        #endregion


        #region Other Methods
        public void Prim()
        {

        }

        private void InitializeMaze()
        {

        }
        #endregion

    }
}
