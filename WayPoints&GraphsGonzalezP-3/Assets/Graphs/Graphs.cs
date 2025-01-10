using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graphs
{
    List<Edge> edges = new List<Edge>();
    List<Node> nodes = new List<Node>();
    List<Node> pathList = new List<Node>();

    public Graphs() { }

    public void AddNode(GameObject id)
    {
        Node node = new Node(id);
        nodes.Add(node);
    }

    public void AddEdge(GameObject fromNode, GameObject toNode)
    {
        Node from = FindNode(fromNode);
        Node to = FindNode(toNode);

        if (from != null && to != null)
        {
            Edge e = new Edge(from, to);
            edges.Add(e);
            from.edgeList.Add(e);
        }
    }

    Node FindNode(GameObject id)
    {
        foreach (Node n in nodes)
        {
            if (n.getId() == id) 
                return n;
        }
        return null;
    }

    float distance(Node a, Node b)
    {
        return(Vector3.SqrMagnitude(a.getId().transform.position - b.getId().transform.position));
    }

    int lowestF(List<Node> l)
    {
        float lowestf = 0;
        int count = 0;
        int iteratorCount = 0;

        lowestf = l[0].f;

        for (int i = 1; i < l.Count; i++)
        {
            if (l[i].f <= lowestf)
            {
                lowestf = l[i].f;
                iteratorCount = count;
            }
            count++;
        }
        return iteratorCount;
    }
}