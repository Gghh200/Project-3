namespace Project3;
class WeightedGraph
{
    LinkedList<int[]>[] adjacencyList;
    public WeightedGraph(int vertices)
    {
        adjacencyList = new LinkedList<int[]>[vertices];
        for (int i = 0; i < adjacencyList.Length; ++i)
        {
            adjacencyList[i] = new LinkedList<int[]>();
        }
    }

    public void addEdge(int srcVertex, int destVertex, int weight)
    {
        adjacencyList[srcVertex].AddLast([destVertex, weight]);
    }

    public int getNumberOfNodes()
    {
        return adjacencyList.Length;
    }

    public float[] CalcScore(){
        float[] scores = new float[adjacencyList.Length];
        int total = 0;
        Queue<int[]> hold = new Queue<int[]>();
        for(int i = 0; i < adjacencyList.Length; i++){
            total = 0;
            foreach(int j in dijkstra(i)){
                total += j;
            }
            if(total == 0){
                scores[i] = 0;
            }else{
                scores[i] = (float)(adjacencyList.Length - 1)/total;
            }
        }
        return scores;
    }


    public int[] dijkstra(int start)
    {
        int n = getNumberOfNodes();
        int[] distance = new int[n];
        for (int i = 0; i < n; i++){
            distance[i] = 1000;
        }
        distance[start] = 0;
        List<int> hold = new List<int>();
        hold.Add(start);


        while (hold.Count > 0)
        {
            int current = hold.First();
            hold.Remove(current);
            LinkedList<int[]> neighbors = adjacencyList[current];

            foreach (int[] neighbor in neighbors)
            {
                if (distance[current] + neighbor[1] < distance[neighbor[0]])
                {
                    distance[neighbor[0]] = distance[current] + neighbor[1];
                    hold.Add(neighbor[0]);
                }
            }
        }
        return distance;
    }
}