using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    public GameObject pad;
    public GameObject[] positions;
    public float speed = 1.0f;
    public Rigidbody pebble;
    private Transform target;
    int i = 0;
    void Awake()
    {
        target = pad.transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        target.position = Vector3.MoveTowards(target.position, positions[i].transform.position, speed);
        i++;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody clone;
        if (Input.GetKeyDown(KeyCode.DownArrow) && i < positions.Length)
        {
            while (target.position != positions[i].transform.position)
            {
                target.position = Vector3.MoveTowards(target.position, positions[i].transform.position, speed);
            }
            i++;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && i > 1)
        {
            i = i - 2;
            while (target.position != positions[i].transform.position)
            {
                target.position = Vector3.MoveTowards(target.position, positions[i].transform.position, speed);
            }
            i++;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            clone = Instantiate(pebble, new Vector3(target.position.x, target.position.y, target.position.z), Quaternion.identity);
            clone.velocity = new Vector3(0, -30, -200);
        }
    }
}
