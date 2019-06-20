Main()
{
	List<Vertex<string>> vertices = new List<Vertex<string>>
    (
        new Vertex<string> []
            {
            new Vertex<string>("Los Angeles"),
            new Vertex<string>("San Francisco"),
            new Vertex<string>("Las Vegas"),
            new Vertex<string>("Seattle"),
            new Vertex<string>("Austin"),
            new Vertex<string>("Portland")
            }
    );
	
	vertices[0].AddEdges(new List<Vertex<string>>(new Vertex<string>[] 
    {
        vertices[1], vertices[2], vertices[5]
    }));
	
    vertices[1].AddEdges(new List<Vertex<string>>(new Vertex<string>[]
    {
        vertices[0], vertices[3], vertices[5]
    }));
	
    vertices[2].AddEdges(new List<Vertex<string>>(new Vertex<string>[]
    {
        vertices[0], vertices[1], vertices[4]
    }));
	
    vertices[3].AddEdges(new List<Vertex<string>>(new Vertex<string>[]
    {
        vertices[1], vertices[5]
    }));
	
    vertices[4].AddEdges(new List<Vertex<string>>(new Vertex<string>[]
    {
        vertices[2]
    }));
	
    vertices[5].AddEdges(new List<Vertex<string>>(new Vertex<string>[]
    {
        vertices[1], vertices[3]
    }));
	
	Graph<string> testGraph = new Graph<string>(vertices);

    foreach(Vertex<string> vertex in vertices)
    {
        Console.WriteLine(vertex.ToString());
    }

	foreach (var vertex in new DFS<string>(vertices[0]).Iterate())
        Console.WriteLine(vertex.Value);
}
