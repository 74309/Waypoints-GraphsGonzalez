using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Link
{
    public enum directionn { UNI, BI }
    public GameObject node1;
    public GameObject node2;
    public directionn dir;
}
public class WPManager : MonoBehaviour
{
    public GameObject[] wwaypoints;
    public Link[] links;
    public Graphs graph = new Graphs();
    // Start is called before the first frame update
    void Start()
    {
        if (wwaypoints.Length > 0)
        {
            foreach (GameObject wp in wwaypoints)
            {
                graph.AddNode(wp);
            }
            foreach (Link l in links)
            {
                graph.AddEdge(l.node1, l.node2);
                if (l.dir == Link.directionn.BI)
                {
                    graph.AddEdge(l.node2, l.node1);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
