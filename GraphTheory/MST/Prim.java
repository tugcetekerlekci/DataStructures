import java.util.HashSet;
import java.util.LinkedList;
import java.util.PriorityQueue;

public class Prim {

    public static void main(String[] args) {
        System.out.println("hello");

        int numberOfVertices = 3;
        int numberOfBlackEdges = 3;
        int numberOfWhiteEdges = 3;

        Graph graph = new Graph(numberOfVertices);
        graph.addVertex(1,2,3);
        graph.addVertex(2,3,4);
        graph.addVertex(1,3,2);

        prim(graph, numberOfVertices, numberOfBlackEdges, numberOfWhiteEdges);

        System.out.println("world");
    }


    private static void prim(Graph graph, int numberOfVertices, int numberOfBlackEdges, int numberOfWhiteEdges) {
        Long[] prev = new Long[numberOfVertices];
        Vertex[] dist = new Vertex[numberOfVertices];
        HashSet<Long> setOfVertices = new HashSet<>();
        PriorityQueue<Vertex> minHeap = new PriorityQueue<>();

        for(long i=0;i<numberOfVertices;i++)
        {
            prev[(int) i] = null;
            dist[(int) i] = new Vertex(i, Long.MAX_VALUE);
        }

        Vertex start = new Vertex(0, (long) 0);
        minHeap.add(start);
        dist[0] = start;
        prev[0] = start.id;

        for(int i=1;i<numberOfVertices;i++)
        {
            minHeap.add(dist[i]);
        }

        while(minHeap.size() > 0)
        {
            Vertex v = minHeap.poll();
            setOfVertices.add(v.id);

            for (Vertex vertex : graph.vertices[(int) v.id])
            {
                if(!setOfVertices.contains(vertex.id) && dist[(int) vertex.id].distance > vertex.distance)
                {
                    minHeap.remove(dist[(int)vertex.id]);
                    dist[(int)vertex.id].distance = vertex.distance;
                    minHeap.add(dist[(int)vertex.id]);
                    prev[(int) vertex.id] = v.id;
                }
            }
        }

        long total = 0;
        for (long i = 1; i < graph.numberOfVertices; i++) 
        {
            System.out.println(prev[(int) i] + " "
                    + "-"
                    + " " + i);
            total += dist[(int) i].distance;
        }
        System.out.println("total: " + total);

    }
}

class Graph {
    long numberOfVertices;
    LinkedList<Vertex> vertices[];


    public Graph(long numberOfVertices) {
        this.numberOfVertices = numberOfVertices;
        this.vertices = new LinkedList[(int)numberOfVertices];
        for(int i=0;i<numberOfVertices;i++)
        {
            this.vertices[i] = new LinkedList<>();
        }
    }

    public void addVertex(long vertice1, long vertice2, long distance) {
        this.vertices[(int)vertice1-1].add(new Vertex(vertice2-1, distance));
        this.vertices[(int)vertice2-1].add(new Vertex(vertice1-1, distance));
    }
}

class Vertex implements Comparable<Vertex>{
    long id;
    Long distance;

    public Vertex(long id, Long distance) {
        this.id = id;
        this.distance = distance;
    }

    @Override
    public int compareTo(Vertex o) {
        if(this.distance>o.distance)
        {
            return 1;
        } else if (this.distance<o.distance)
        {
            return 0;
        }
        return -1;
    }
}
