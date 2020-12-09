using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pebble")
        {
            Destroy(other.gameObject);
            Launch.lives += 1;
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
