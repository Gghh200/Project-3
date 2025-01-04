namespace Project3;
class UnweightedGraph
{
    LinkedList<int>[] adjacencyList;
    public UnweightedGraph(int vertices)
    {
        adjacencyList = new LinkedList<int>[vertices];
        for (int i = 0; i < adjacencyList.Length; ++i)
        {
            adjacencyList[i] = new LinkedList<int>();
        }
    }

    public void addEdge(int srcVertex, int destVertex)
    {
        adjacencyList[srcVertex].AddLast(destVertex);
    }

    public int getNumberOfNodes()
    {
        return adjacencyList.Length;
    }

    
    public float[] CalcScore(){
        float[] scores = new float[adjacencyList.Length];
        bool[] visited = new bool[adjacencyList.Length];
        int visitedInt = 0;
        int total = 0;
        Queue<int[]> hold = new Queue<int[]>();
        for(int i = 0; i < adjacencyList.Length; i++){
            for(int j = 0; j < visited.Length; j++){
                visited[j] = false;
            }
            visitedInt = 1;
            total = 0;
            visited[i] = true;
            hold.Enqueue([i,0]);
            while(visitedInt != visited.Count() && hold.Count() != 0){
                int next = hold.Peek()[0];
                int degree = hold.Peek()[1] + 1;
                hold.Dequeue();
                for(int j = 0; j < adjacencyList[next].Count(); j++){
                    if(visited[adjacencyList[next].ElementAt(j)] == false){
                        total+= degree;
                        visited[adjacencyList[next].ElementAt(j)] = true;
                        visitedInt++;
                        hold.Enqueue([adjacencyList[next].ElementAt(j), degree]);
                    }
                } 
            }
            hold.Clear();
            if(total == 0){
                scores[i] = 0;
            }else{
                scores[i] = (float)(adjacencyList.Length - 1)/total;
            }
        }
        return scores;
    }
}