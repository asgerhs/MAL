package Interfaces;

public interface Graph {

    int getV();

    int getE();

    void addEdge(int v1, int v2);

    Iterable<Integer> adj(int v);

    String toString();
}
