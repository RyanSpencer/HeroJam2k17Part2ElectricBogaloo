using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    public GameObject manager;
    private int direction;
    public int x;
    public int y;
    public bool holding;
    public GameObject[] interactiveObj;

	// Use this for initialization
	void Start () {
        direction = 2;
        interactiveObj = GameObject.FindGameObjectsWithTag("Interact");
	}

    GameObject checkSpace(int spacex, int spacey)
    {
        for (int i = 0; i < interactiveObj.Length; i++)
        {
            if (interactiveObj[i].transform.position.x == spacey && interactiveObj[i].transform.position.y == -spacex)
            {
                return interactiveObj[i];
            }
        }

        return new GameObject();
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
        else if (Input.GetKeyDown(KeyCode.F))
        {
            switch (direction)
            {
                case 0:
                    if (y - 1 >= 0 && !holding)
                    {
                        if (manager.GetComponent<Stage>().stage1[y - 1, x] == 2)
                        {
                            holding = true;
                            manager.GetComponent<Stage>().stage1[y - 1, x] = 0;
                            checkSpace(y - 1, x).GetComponent<SpriteRenderer>().color = Color.white;
                        }
                    }
                    break;
                case 1:
                    if (x - 1 >= 0 && !holding)
                    {
                        if (manager.GetComponent<Stage>().stage1[y, x - 1] == 2)
                        {
                            holding = true;
                            manager.GetComponent<Stage>().stage1[y, x - 1] = 0;
                            checkSpace(y, x - 1).GetComponent<SpriteRenderer>().color = Color.white;
                        }
                    }
                    break;
                case 2:
                    if (y + 1 >= 0 && !holding)
                    {
                        if (manager.GetComponent<Stage>().stage1[y + 1, x] == 2)
                        {
                            holding = true;
                            manager.GetComponent<Stage>().stage1[y + 1, x] = 0;
                            checkSpace(y + 1, x).GetComponent<SpriteRenderer>().color = Color.white;
                        }
                    }
                    break;
                case 3:
                    if (x + 1 >= 0 && !holding)
                    {
                        if (manager.GetComponent<Stage>().stage1[y, x + 1] == 2)
                        {
                            holding = true;
                            manager.GetComponent<Stage>().stage1[y, x + 1] = 0;
                            checkSpace(y, x + 1).GetComponent<SpriteRenderer>().color = Color.white;
                        }
                    }
                    break;
                default:
                    print("This shouldn't happen");
                    break;
            }
        }
	}
}
