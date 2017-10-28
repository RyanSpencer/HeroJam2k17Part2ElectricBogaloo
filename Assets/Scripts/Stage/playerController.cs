using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public GameObject manager;
    private int direction;
    private int x;
    private int y;

	// Use this for initialization
	void Start () {
        direction = 2;
        x = 0;
        y = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = 0;
            if (y - 1 >= 0)
            {
                if (manager.GetComponent<Stage>().stage1[y - 1, x] == 0)
                {
                    y--;
                    this.gameObject.transform.Translate(new Vector3(0, 1));

                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            direction = 1;
            if (x - 1 >= 0)
            {
                if (manager.GetComponent<Stage>().stage1[y, x - 1] == 0)
                {
                    x--;
                    this.gameObject.transform.Translate(new Vector3(-1, 0));
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            direction = 2;
            if (y + 1 <= 3)
            {
                if (manager.GetComponent<Stage>().stage1[y + 1, x] == 0)
                {
                    y++;
                    this.gameObject.transform.Translate(new Vector3(0, -1));
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            direction = 3;
            if (x + 1 <= 3)
            {
                if (manager.GetComponent<Stage>().stage1[y, x + 1] == 0)
                {
                    x++;
                    this.gameObject.transform.Translate(new Vector3(1, 0));
                }
            }
        }
	}
}
