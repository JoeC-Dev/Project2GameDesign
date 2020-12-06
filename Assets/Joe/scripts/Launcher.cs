using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Vector3 originalPos;
    public GameObject block;
    // Start is called before the first frame update
    void Start()
    {
        originalPos = block.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
