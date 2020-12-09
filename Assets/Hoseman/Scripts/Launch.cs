using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Launch : MonoBehaviour
{
    public GameObject pad;
    public GameObject[] positions;
    public float speed = 1.0f;
    public Rigidbody pebble;
    private Transform target;
    public static int score = 0000;
    public Text scoring;
    public static int lives = 0;
    public int win;
    public bool pass = false;
    public Text winScreen;
    public Text loseScreen;
    public GameObject button;
    public bool finish = true;
    int i = 0;
    void Awake()
    {
        target = pad.transform;
        scoring.text = "Score: 0000";
        winScreen.enabled = false;
        loseScreen.enabled = false;
        button.SetActive(false);
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
            clone.velocity = new Vector3(0, 0, -50 * i);
        }
        scoring.text = "Score: " + score.ToString();
        if (score > win)
            pass = true;
        if (lives == 3 && finish)
        {
            finish = false;
            EndLevel();
        }
    }
    void EndLevel()
    {
        if(pass == true)
        {
            winScreen.enabled = true;
        }
        else
        {
            loseScreen.enabled = true;
        }
        button.SetActive(true);
    }
}
