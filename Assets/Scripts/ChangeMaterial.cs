using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material Color;

    void Start()
    {
        //this.gameObject.GetComponent<MeshRenderer>().material = Color;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("This should be working");
            this.gameObject.GetComponent<MeshRenderer>().material = Color;
        }
    }
}
