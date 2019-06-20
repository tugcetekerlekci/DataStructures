public class Vertex<T>
{
	public Vertex(T value,params Vertex<T>[] parameters):
		this(value, (IEnumerable<Vertex<T>>)parameters){}
	
	public Vertex(T value, IEnumerable<Vertex<T>> neighbors = null)
	{
		Value = value; 
		Neighbors = neighbors?.ToList() ?? new List<Vertex<T>>();
		IsVisited = false;
	}
	
	#region Properties
	
	public T Value {get;}
	
	public List<Vertex<T>> Neighbors {get;}
	
	public bool IsVisited {get; set;}
	
	public int NeigborCount => Neighbors.Count; 

	#endregion
	
		
	public void AddEdge(Vertex<T> vertex)
	{
		Neighbors.Add(vertex);
	}
	
	public void AddEdges(IEnumerable<Vertex<T>> newNeighbors)
	{
		Neighbors.AddRange(newNeighbors);
	}
	
	public void RemoveEdge(Vertex<T> vertex)
	{
		Neighbors.Remove(vertex);
	}
	
	public override string ToString()
    {
        return Neighbors.Aggregate(new StringBuilder($"{Value}: "), (sb, n) => sb.Append($"{n.Value} ")).ToString();
    }

}
