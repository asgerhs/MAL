import Impl.GraphImpl;
import Interfaces.Graph;

public class App {
    public static void main(String[] args) throws Exception {
        Graph g2 = new GraphImpl(8);
        g2.addEdge(0, 1);
        g2.addEdge(1, 2);
        g2.addEdge(2, 3);
        g2.addEdge(3, 4);
        g2.addEdge(4, 5);
        g2.addEdge(5, 6);
        g2.addEdge(6, 7);
        System.out.println("----------------------------------");
        System.out.println(g2);
    }
}
