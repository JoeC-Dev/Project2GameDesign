using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddles : MonoBehaviour
{
    public GameObject leftPaddle;
    public GameObject rightPaddle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            leftPaddle.transform.Rotate(-35.0f, 0.0f, 0.0f, Space.Self);
            rightPaddle.transform.Rotate(35.0f, 0.0f, 0.0f, Space.Self);
        }
        if (Input.GetKeyUp("space"))
        {
            leftPaddle.transform.Rotate(35.0f, 0.0f, 0.0f, Space.Self);
            rightPaddle.transform.Rotate(-35.0f, 0.0f, 0.0f, Space.Self);
        }
    }
}
