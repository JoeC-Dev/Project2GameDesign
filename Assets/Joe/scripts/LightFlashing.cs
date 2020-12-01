using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlashing : MonoBehaviour
{
    private int counter = 0;
    [Header("Set in Inspector")]
    public GameObject light;
    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter % 100 == 0 && !light.activeSelf)
            light.SetActive(true);
        else if (counter % 100 == 0 && light.activeSelf)
            light.SetActive(false);
        

    }
}
