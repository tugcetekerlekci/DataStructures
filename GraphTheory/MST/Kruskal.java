

import java.io.DataInputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.Comparator;
import java.util.PriorityQueue;

class Submission
{
    static class Graph
    {
        int numOfVertices;
        ArrayList<Edge> Edges = new ArrayList<>();
        Graph(int numOfVertices)
        {
            this.numOfVertices = numOfVertices;
            NumberOfVertices = numOfVertices;
        }

       
        public void AddEdge(int source, int destination, int weight)
        {
            Edge edge = new Edge(source, destination, weight);
            Edges.add(edge); //add to total edges
        }

        public ArrayList<Edge> CreateMst()
        {
            PriorityQueue<Edge> minHeap =
                    new PriorityQueue<>(Edges.size(), Comparator.comparingInt(o -> o.weight));

            for (int i = 0; i <Edges.size() ; i++) {
                minHeap.add(Edges.get(i));
            }
            int [] from = new int[NumberOfVertices];

            MakeSet(from);

            ArrayList<Edge> ResultSet = new ArrayList<Edge>();

            int verticeIndex = 0;
            while (verticeIndex<NumberOfVertices && minHeap.size() > 0)
            {
                Edge edge  = minHeap.remove();
                int uSet = Find(from,edge.source);
                int vSet = Find(from,edge.destination);

                if (uSet != vSet)
                {
                    ResultSet.add(edge);
                    verticeIndex++;
                    Union(from,uSet,vSet);
                }
            }
            return ResultSet;
        }

        public static void MakeSet(int [] from){
            for (int i = 0; i <NumberOfVertices ; i++) {
                from[i] = i;
            }
        }
        //find the source
        public static int Find(int from [], int vertex)
        {
            if(from[vertex] != vertex)
            {
                return Find(from,from[vertex]);
            }
            return vertex;
        }

        public static void Union(int[] from,int u, int v)
        {
            int ufrom = Find(from,u);
            int vfrom = Find(from,v);
            from[vfrom] = ufrom;
        }

        public int FindFinalWeight(ArrayList<Edge> e)
        {
            int finalWeight = 0;
            for(int i = 0;i<e.size();i++)
            {
                finalWeight = e.get(i).weight + finalWeight;
            }
            return finalWeight;
        }

    }


}
