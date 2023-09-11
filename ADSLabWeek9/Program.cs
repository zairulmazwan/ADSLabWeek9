// See https://aka.ms/new-console-template for more information

Graphs graph = new Graphs();
graph.createGraph();

Console.WriteLine("Number of nodes in the graph : "+graph.dfs.Count);
Console.WriteLine("Nodes in the graph are : ");
graph.printNodes();

Console.WriteLine("\nThe graph contains 60 ? : "+graph.containNode(60));

Console.WriteLine("\nEdges in 20 : ");
graph.printEdges(graph.dfs[1]);

Console.WriteLine("\nEdges in 30 : ");
graph.printEdges(graph.dfs[graph.dfs.IndexOf(graph.getNode(30))]);

Console.WriteLine();

Console.WriteLine("\nDFS Traverse starts from node 50 Algo 1 : ");
graph.traverseDFSAlgo1(60);

Console.WriteLine("\nBFS Traverse starts from node 50 : ");
graph.traverseBFS(60);

Console.WriteLine("\nDFS Traverse starts from node 50 Algo 2 : ");
List<Node> visited = new List<Node>();
visited = graph.traverseDFSAlgo2(60,visited);

graph.printNodes();
Console.WriteLine();