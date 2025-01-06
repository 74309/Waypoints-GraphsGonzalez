using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWP : MonoBehaviour
{
    public GameObject[] wayPoints;
    int currentWP = 0;

    public float speed = 10.0f;
    public float rotSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        tracker = GameObject.CreatePrimitive(Primitive.Cylinder);
        DestroyImmediate(tracker.GetComponent<Collider>());
    }
    void ProgressTracker()
    {
        if (Vector3.Distance(this.transform.position, wayPoints[currentWP].transform.position) < 5)
            currentWP++;
        if (currentWP >= wayPoints.Length)
            currentWP = 0;
        if (currentWP >= wayPoints[currentWP].transform)
            currentWP = 0;
        tracker.transform.LookAt(wayPoints[currentWP].transform);
        tracker.transform.Translate(0, 0, (speed + 20) * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
       ProgressTracker():
       Quaternion lookatWP = Quaternion.LookRotation(wayPoints[currentWP].transform.position - this.transform.position);
       this.transform.rotation = Quaternion.Slerp(this.transform.rotation, lookatWP, rotSpeed * Time.deltaTime);
       this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
