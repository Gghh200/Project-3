namespace Project3;

class Project3{
    // static void Main(string[] args){
    //     List<string> people = new List<string>{"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
    //     WeightedGraph graph = new WeightedGraph(people.Count());
    //     graph.addEdge(0, 1, 1);
    //     graph.addEdge(0, 2, 1);
    //     graph.addEdge(0, 4, 5);

    //     graph.addEdge(1, 0, 1);
    //     graph.addEdge(1, 2, 4);
    //     graph.addEdge(1, 4, 1);
    //     graph.addEdge(1, 6, 1);
    //     graph.addEdge(1, 7, 1);

    //     graph.addEdge(2, 0, 1);
    //     graph.addEdge(2, 1, 4);
    //     graph.addEdge(2, 3, 3);
    //     graph.addEdge(2, 4, 1);

    //     graph.addEdge(3, 2, 3);
    //     graph.addEdge(3, 4, 2);
    //     graph.addEdge(3, 5, 1);
    //     graph.addEdge(3, 6, 5);

    //     graph.addEdge(4, 0, 5);
    //     graph.addEdge(4, 1, 1);
    //     graph.addEdge(4, 2, 1);
    //     graph.addEdge(4, 3, 2);
    //     graph.addEdge(4, 6, 2);

    //     graph.addEdge(5, 3, 1);
    //     graph.addEdge(5, 6, 1);

    //     graph.addEdge(6, 1, 1);
    //     graph.addEdge(6, 3, 5);
    //     graph.addEdge(6, 4, 2);
    //     graph.addEdge(6, 5, 1);
    //     graph.addEdge(6, 7, 2);

    //     graph.addEdge(7, 1, 1);
    //     graph.addEdge(7, 6, 2);
    //     graph.addEdge(7, 8, 3);

    //     graph.addEdge(8, 7, 3);
    //     graph.addEdge(8, 9, 3);

    //     graph.addEdge(9, 8, 3);

    //     float[] scores = graph.CalcScore();
    //     for(int i = 0; i < people.Count(); i++){
    //         Console.WriteLine(people[i] + " has a score of " + scores[i]);
    //     }
    // }
     static void Main(string[] args){
        List<string> people = new List<string>{"A", "B", "C", "D", "E", "F", "G", "H"};
        UnweightedGraph graph = new UnweightedGraph(people.Count());
        graph.addEdge(0, 1);

        graph.addEdge(1, 0);
        graph.addEdge(1, 2);

        graph.addEdge(2, 1);
        graph.addEdge(2, 3);

        graph.addEdge(3, 2);
        graph.addEdge(3, 4);
        graph.addEdge(3, 7);

        graph.addEdge(4, 3);
        graph.addEdge(4, 5);
        graph.addEdge(4, 6);
        graph.addEdge(4, 7);

        graph.addEdge(5, 4);
        graph.addEdge(5, 6);

        graph.addEdge(6, 4);
        graph.addEdge(6, 5);
        graph.addEdge(6, 7);

        graph.addEdge(7, 3);
        graph.addEdge(7, 4);
        graph.addEdge(7, 6);

        float[] scores = graph.CalcScore();
        for(int i = 0; i < people.Count(); i++){
            Console.WriteLine(people[i] + " has a score of " + scores[i]);
        }
    }
}