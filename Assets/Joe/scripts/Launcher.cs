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
    public GameObject oranLLight;
    public GameObject redLLight;


    //fields set dynamically
    [Header("Set Dynamically")]
    public float velocityMult = 5f;
    private Rigidbody projectileRigidbody;
    private Vector3 launchVector;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && aliveBall == 0 && velocityMult < 15f)
        {
            velocityMult += 5;
            //lightChanger();

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && aliveBall == 0 && velocityMult > 5f)
        {
            velocityMult -= 5;
            //lightChanger();
        }

        if (Input.GetKeyUp(KeyCode.Return) && aliveBall == 0)
            launchBall();

    }

    void launchBall()
    {
        projectileRigidbody = pinball.GetComponent<Rigidbody>();
        launchVector = launchPoint.transform.position;
        pinball.transform.position = launchVector;
        
        projectileRigidbody.AddForce(transform.forward * velocityMult);
        //projectileRigidbody.useGravity = true;
        aliveBall++;
    }

    void lightChanger()
    {
        if (velocityMult == 10f)
        {
            oranLLight.SetActive(true);
            redLLight.SetActive(false);
        }
        else if(velocityMult == 15f)
            redLLight.SetActive(true);
    }

    static void lostLife()
    {
        aliveBall--; 
    }
}
