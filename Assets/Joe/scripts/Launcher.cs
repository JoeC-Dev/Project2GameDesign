using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    static int aliveBall = 0;
    //fields set in unity pane
    [Header("Set in Inspector")]
    public GameObject pinball;
    public GameObject launchPoint;


    //fields set dynamically
    [Header("Set Dynamically")]
    public float velocityMult = 20f;

    public void Start()
    {
        aliveBall = 0;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && aliveBall == 0 && velocityMult < 60f)
        {
            velocityMult += 20;
            print(velocityMult);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && aliveBall == 0 && velocityMult > 20f)
        {
            velocityMult -= 20;
            print(velocityMult);
        }

        if (Input.GetKeyDown(KeyCode.Return))
            launchBall();

    }

    void launchBall()
    {
        print("hello");
    }
}
