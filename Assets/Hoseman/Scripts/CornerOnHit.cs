using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerOnHit : MonoBehaviour
{
    public float x;
    public float y;
    public float z;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pebble")
        {
            other.GetComponent<Rigidbody>().velocity = new Vector3(x,y,z);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
