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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
