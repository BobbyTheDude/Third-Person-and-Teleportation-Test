using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTeleport : MonoBehaviour
{
    //public GameObject TeleportTo;
    //public Vector3 TeleportPoint;
    // Start is called before the first frame update
    //GameObject Controller = GameObject.FindGameObjectWithTag("TeleportController");
    public Transform Teleport2;
    void Start()
    {
        //TeleportPoint = TeleportTo.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Collider works" + other.gameObject.name);
            //Controller.gameObject.GetComponent<TeleportPoints>().T1 = true;
            other.transform.position = Teleport2.transform.position;
        }
    }
}
