public class Graph<T>
{
	 public Graph(params Vertex<T>[] initialNodes)
        : this((IEnumerable<Vertex<T>>)initialNodes) { }
		
	public Graph(IEnumerable<Vertex<T>> initialNodes = null)
    {
        Vertices = initialNodes?.ToList() ?? new List<Vertex<T>>();
    }

	#region Properties
	
	public List<Vertex<T>> Vertices { get; }

    public int Size => Vertices.Count;

	#endregion 
	
	
    public void AddPair(Vertex<T> first, Vertex<T> second)
    {
        AddToList(first);
        AddToList(second);
        AddNeighbors(first, second);
    }
	
	public void AddToList(Vertex<T> vertex)
	{
		Vertices.Add(vertex);
	}
	
	public void AddNeighbors(Vertex<T> vertex1, Vertex<T> vertex2)
	{
		AddNeighbor(vertex1,vertex2);
		AddNeighbor(vertex2,vertex1);
	}
	
	public void AddNeighbor(Vertex<T> vertex1, Vertex<T> vertex2)
	{
		if (!vertex1.Neighbors.Contains(vertex2))
		{
			vertex1.AddEdge(vertex2);
		}
	}
	
	private void UnvisitAll()
    {
        foreach(var vertex in Vertices)
        {
            vertex.IsVisited = false;
        }
    }
	
}
