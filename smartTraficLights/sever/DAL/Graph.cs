using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Graph
    {
        private int _v;

        private bool _direct;

        LinkedList<int>[] _adj;

        public Graph(int v, bool direct)

        {

            _adj = new LinkedList<int>[v];

            for (int i = 0; i < _adj.Length; i++)

            {

                _adj[i] = new LinkedList<int>();

            }

            _v = v;

            _direct = direct;

        }

        public void Add_Edge(int v, int w)

        {

            _adj[v].AddLast(w);

            if (!_direct)

            {

                _adj[w].AddLast(v);

            }

        }

        public void BreadthFirstSearch(int s)

        {

            bool[] visited = new bool[_v];

            for (int i = 0; i < _v; i++)

                visited[i] = false;

            // Create a queue for BFS

            LinkedList<int> queue1 = new LinkedList<int>();

            visited[s] = true;

            queue1.AddLast(s);

            while (queue1.Any())

            {

                // Dequeue a vertex from queue and print it

                s = queue1.First();

                Console.Write(s + " ");

                queue1.RemoveFirst();

                LinkedList<int> list = _adj[s];

                foreach (var value in list)

                {

                    if (!visited[value])

                    {

                        visited[value] = true;

                        queue1.AddLast(value);

                    }

                }

            }
        }
    }
}