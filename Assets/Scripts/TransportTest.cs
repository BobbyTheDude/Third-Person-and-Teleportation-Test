using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransportTest : MonoBehaviour
{
    public Transform TransportPoint;
    public Vector3 TransportVector;
    // Start is called before the first frame update
    void Start()
    {
        TransportVector = TransportPoint.transform.position;
        this.gameObject.transform.position = TransportVector;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
