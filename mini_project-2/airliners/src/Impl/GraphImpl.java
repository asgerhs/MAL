package Impl;
import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.util.ArrayList;
import Interfaces.*;

public class GraphImpl implements Graph {

    private static final ArrayList<Integer> emptyList = new ArrayList<>(0);
    private ArrayList<Integer>[] graph;
    private int edgeCount;

    public GraphImpl(int verticeCount){
        graph = new ArrayList[verticeCount];
        edgeCount= 0;
    }

    public GraphImpl(String fileName) throws IOException{
        InputStream in = new FileInputStream(fileName);
        try(BufferedReader br = new BufferedReader(new InputStreamReader(in))){
            String line = br.readLine();
            int v = Integer.parseInt(line);
            graph = new ArrayList[v];
            edgeCount = 0;
            line = br.readLine();
            int e = Integer.parseInt(line);
            for(int i = 0; i < e; i++){
                line = br.readLine();
                String[] vs = line.split(" ");
                int v1 = Integer.parseInt(vs[0]);
                int v2 = Integer.parseInt(vs[1]);
                addEdge(v1, v2);
            }
        }
    }

    @Override
    public int getV() {
        return graph.length;
    }


    @Override
    public int getE() {
        return edgeCount;
    }

    @Override
    public void addEdge(int v1, int v2) {
        ArrayList<Integer> list = graph[v1];
        if(list == null){
            list = new ArrayList<>();
            graph[v1] = list; 
        }
        list.add(v2);
        edgeCount++;
    }

    @Override
    public Iterable<Integer> adj(int v) {
        ArrayList<Integer> list = graph[v];
        if(list == null){
            return emptyList;
        }
        return list;
    }

    @Override
    public String toString(){
        StringBuffer res = new StringBuffer();
        res.append(graph.length);
        res.append("\n");
        res.append(edgeCount);
        res.append("\n");
        for(int i = 0; i < graph.length; i++){
            Iterable<Integer> adjList = adj(i);
            for(int a : adjList){
                res.append(i);
                res.append(" ");
                res.append(a);
                res.append("\n");
            }
        }
        
        return res.toString();
    }
    
}
