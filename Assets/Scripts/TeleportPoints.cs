using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPoints : MonoBehaviour
{
    public Transform Teleport1;
    public Transform Teleport2;
    public Vector3 T1Vector;
    public Vector3 T2Vector;
    public GameObject Player;
    public bool T1 = false;
    public bool T2 = false;
    
    void Start()
    {
        T1Vector = Teleport1.transform.position;
        T2Vector = Teleport2.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (T1)
        {
            Player.transform.position = T2Vector;
            T1 = false;
        }
    }
}
