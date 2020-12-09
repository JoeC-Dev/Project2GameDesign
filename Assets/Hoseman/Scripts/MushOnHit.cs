using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushOnHit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pebble")
        {
            other.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-150f, 150f), 0, Random.Range(-150f, 150f));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
