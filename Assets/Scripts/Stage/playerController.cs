using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour {

    Puzzle_Manager pzMan;
    public GameObject manager;
    private int direction;
    public int x;
    public int y;
    private int[,] relArray;

    private int prevY;
    private int prevX;

    public bool holding;
    public int holdObj;
    public GameObject[] interactiveObj;
    public GameObject[] nonInteractiveObj;
    public GameObject[] pickupObj;

    public int rock;
    public int matches;
    public int bucket;

    public int plate;
    public int bush;

    public int generator;
    public int node;

	// Use this for initialization
	void Start () {
        direction = 2;

        pzMan = gameObject.AddComponent(typeof(Puzzle_Manager)) as Puzzle_Manager;

        relArray = GameObject.Find("GameManager").GetComponent<Stage>().stage1;
	}

    public void lookAtLevel()
    {

        interactiveObj = GameObject.FindGameObjectsWithTag("Interact");
        nonInteractiveObj = GameObject.FindGameObjectsWithTag("Floor");
        pickupObj = GameObject.FindGameObjectsWithTag("Pickup");
        assignInt();

    }

    public void assignInt() {

        for(int i = 0; i < pickupObj.Length; i++)
        {

            if(pickupObj[i].gameObject.name == "Rock")
            {

                rock = relArray[(int)pickupObj[i].gameObject.transform.position.y * -1, (int)pickupObj[i].gameObject.transform.position.x];

            }
            if(pickupObj[i].gameObject.name == "Matches")
            {

                matches = relArray[(int)pickupObj[i].gameObject.transform.position.y * -1, (int)pickupObj[i].gameObject.transform.position.x];

            }
            if (pickupObj[i].gameObject.name == "Water")
            {

                bucket = relArray[(int)pickupObj[i].gameObject.transform.position.y * -1, (int)pickupObj[i].gameObject.transform.position.x];

            }

        }
        for(int i = 0; i < interactiveObj.Length; i++)
        {

            if(interactiveObj[i].gameObject.name == "Plate")
            {

                plate = relArray[(int)interactiveObj[i].gameObject.transform.position.y * -1, (int)interactiveObj[i].gameObject.transform.position.x];

            }
            if (interactiveObj[i].gameObject.name == "Bushes")
            {

                bush = relArray[(int)interactiveObj[i].gameObject.transform.position.y * -1, (int)interactiveObj[i].gameObject.transform.position.x];

            }

        }

    }

    public GameObject checkSpace(int spacey, int spacex)
    {
        for (int i = 0; i < pickupObj.Length; i++)
        {
            if (pickupObj[i].transform.position.x == spacex && pickupObj[i].transform.position.y == -spacey)
            {
                return pickupObj[i];
            }
        }

        return new GameObject();
    }
    public GameObject checkTile(int spacey, int spacex)
    {

        for (int i = 0; i < interactiveObj.Length; i++)
        {
            if (interactiveObj[i].transform.position.x == spacex && interactiveObj[i].transform.position.y == -spacey)
            {
                return interactiveObj[i];
            }
        }

        return new GameObject();

    }
    public GameObject checkFloor(int spacey, int spacex)
    {

        for (int i = 0; i < nonInteractiveObj.Length; i++)
        {
            if (nonInteractiveObj[i].transform.position.x == spacex && nonInteractiveObj[i].transform.position.y == -spacey)
            {
                return nonInteractiveObj[i];
            }
        }

        return new GameObject();

    }

    public void setinteractiveTag(int spacex, int spacey)
    {

        for (int i = 0; i < nonInteractiveObj.Length; i++)
        {
            if (nonInteractiveObj[i].transform.position.x == spacey && nonInteractiveObj[i].transform.position.y == -spacex)
            {
                nonInteractiveObj[i].tag = "Pickup";
            }
        }

        nonInteractiveObj = GameObject.FindGameObjectsWithTag("Floor");
        interactiveObj = GameObject.FindGameObjectsWithTag("Interact");
        pickupObj = GameObject.FindGameObjectsWithTag("Pickup");

    }

    public void setTileTag(int spacex, int spacey)
    {

        for (int i = 0; i < nonInteractiveObj.Length; i++)
        {
            if (interactiveObj[i].transform.position.x == spacey && interactiveObj[i].transform.position.y == -spacex)
            {
                interactiveObj[i].tag = "Interact";
            }
        }

        nonInteractiveObj = GameObject.FindGameObjectsWithTag("Floor");
        interactiveObj = GameObject.FindGameObjectsWithTag("Interact");
        pickupObj = GameObject.FindGameObjectsWithTag("Pickup");

    }

    public void setSolidTag(int spacex, int spacey) {

        for (int i = 0; i < interactiveObj.Length; i++)
        {
            if (interactiveObj[i].transform.position.x == spacey && interactiveObj[i].transform.position.y == -spacex)
            {
                interactiveObj[i].tag = "Floor";
            }
        }

        pickupObj = GameObject.FindGameObjectsWithTag("Pickup");
        interactiveObj = GameObject.FindGameObjectsWithTag("Interact");
        nonInteractiveObj = GameObject.FindGameObjectsWithTag("Floor");

    }

    void loadNewLevel()
    {
        Stage temp = GameObject.Find("GameManager").GetComponent<Stage>();

        GameObject.Find("GameManager").GetComponent<LevelCreator>().DeleteLevel();

        temp.currentStage++;
        //Debug.Log(temp.currentStage);
        
        switch(temp.currentStage)
        {
            case 2:
                relArray = temp.stage2;
                GameObject.Find("GameManager").GetComponent<LevelCreator>().CreateLevel(temp.stage2);
                break;
            case 3:
                relArray = temp.stage3;
                GameObject.Find("GameManager").GetComponent<LevelCreator>().CreateLevel(temp.stage3);
                break;
            case 4:
                relArray = temp.stage4;
                GameObject.Find("GameManager").GetComponent<LevelCreator>().CreateLevel(temp.stage4);
                break;
            case 5:
                relArray = temp.stage5;
                GameObject.Find("GameManager").GetComponent<LevelCreator>().CreateLevel(temp.stage5);
                break; 
            default:
                print("This shouldn't happen");
                break;
        }

        print(relArray[0,0]);

        for (int i = 0; i < relArray.GetLength(0); i++)
        {
            for (int j = 0; j < relArray.GetLength(1); j++)
            {
                if (relArray[i,j] == 3)
                {
                    this.x = j;
                    this.y = i;
                }
            }
        }
        transform.position = new Vector3(this.x, -this.y, -1);
        holding = false;
        holdObj = 0;

    }
	
	// Update is called once per frame
	void Update () {
        var goal = GameObject.FindGameObjectWithTag("Goal");
        if (transform.position.x == goal.transform.position.x && transform.position.y == goal.transform.position.y) 
        {
            loadNewLevel();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (direction != 0)
            {

                direction = 0;
            }
            else
            {
                if (y - 1 >= 0)
                {

                    if (relArray[y - 1, x] == 0 || relArray[y - 1, x] == 8 || relArray[y - 1, x] == 5)
                    {

                        prevY = y;
                        y--;
                        this.gameObject.transform.Translate(new Vector3(0, 1));
                        if (holdObj == 8 && relArray[prevY, x] == 0 && relArray[y, x] != 8)
                        {

                            relArray[prevY, x] = 8;
                            checkFloor(prevY, x).GetComponent<SpriteRenderer>().color = Color.grey;
                            setSolidTag(prevY, x);

                        }
                        else if (holdObj == 8 && relArray[y, x] == 8)
                        {

                            relArray[y, x] = 0;
                            checkFloor(y, x).GetComponent<SpriteRenderer>().color = Color.white;
                            setSolidTag(y, x);

                        }

                    }
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (direction != 1)
            {

                direction = 1;
            }
            else
            {
                if (x - 1 >= 0)
                {

                    if (relArray[y, x - 1] == 0 || relArray[y, x - 1] == 8 || relArray[y - 1, x] == 5)
                    {
                        prevX = x;
                        x--;
                        this.gameObject.transform.Translate(new Vector3(-1, 0));
                        if (holdObj == 8 && relArray[y, prevX] == 0 && relArray[y, x] != 8)
                        {

                            relArray[y, prevX] = 8;
                            checkFloor(y, prevX).GetComponent<SpriteRenderer>().color = Color.grey;
                            setSolidTag(y, prevX);

                        }
                        else if (holdObj == 8 && relArray[y, x] == 8)
                        {

                            relArray[y, x] = 0;
                            checkFloor(y, x).GetComponent<SpriteRenderer>().color = Color.white;
                            setSolidTag(y, x);

                        }


                    }
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (direction != 2)
            {

                direction = 2;
            }
            else
            {
                if (y + 1 < 11)
                {

                    if (relArray[y + 1, x] == 0 || relArray[y + 1, x] == 8 || relArray[y - 1, x] == 5)
                    {
                        prevY = y;
                        y++;
                        this.gameObject.transform.Translate(new Vector3(0, -1));
                        if (holdObj == 8 && relArray[prevY, x] == 0 && relArray[y, x] != 8)
                        {

                            relArray[prevY, x] = 8;
                            checkFloor(prevY, x).GetComponent<SpriteRenderer>().color = Color.grey;
                            setSolidTag(prevY, x);

                        }
                        else if (holdObj == 8 && relArray[y, x] == 8)
                        {

                            relArray[y, x] = 0;
                            checkFloor(y, x).GetComponent<SpriteRenderer>().color = Color.white;
                            setSolidTag(y, x);


                        }
                    }
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (direction != 3)
            {

                direction = 3;
            }
            else
            {
                if (x + 1 < 7)
                {

                    if (relArray[y, x + 1] == 0 || relArray[y, x + 1] == 8 || relArray[y - 1, x] == 5)
                    {
                        prevX = x;
                        x++;
                        this.gameObject.transform.Translate(new Vector3(1, 0));
                        if (holdObj == 8 && relArray[y, prevX] == 0 && relArray[y, x] != 8)
                        {

                            relArray[y, prevX] = 8;
                            checkFloor(y, prevX).GetComponent<SpriteRenderer>().color = Color.grey;
                            setSolidTag(y, prevX);

                        }
                        else if (holdObj == 8 && relArray[y, x] == 8)
                        {

                            relArray[y, x] = 0;
                            checkFloor(y, x).GetComponent<SpriteRenderer>().color = Color.white;
                            setSolidTag(y, x);

                        }

                    }
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {

            if (!holding)
            {
                pickUP();

            }
            else if (holding)
            {

                putDown();

            }

        }
	}

    private void pickUP()
    {

        switch (direction)
        {
            case 0:
                if (y - 1 >= 0)
                {
                    if (relArray[y - 1, x] == rock)
                    {
                        holding = true;
                        holdObj = rock;
                        relArray[y - 1, x] = 0;
                        checkSpace(y - 1, x).GetComponent<SpriteRenderer>().color = Color.white;
                        setSolidTag(y - 1, x);
                    }
                    else if (relArray[y - 1, x] == 4)
                    {
                        holding = true;
                        holdObj = 4;
                        relArray[y - 1, x] = 0;
                        checkSpace(y - 1, x).GetComponent<SpriteRenderer>().color = Color.white;
                        setSolidTag(y - 1, x);
                    }
                    else if (relArray[y - 1, x] == 36)
                    {
                        holding = true;
                        holdObj = rock;
                        relArray[y - 1, x] = plate;
                        checkTile(y - 1, x).GetComponent<SpriteRenderer>().color = Color.magenta;
                        setinteractiveTag(y - 1, x);
                    }
                    else if (relArray[y - 1, x] == 8)
                    {
                        holding = true;
                        holdObj = 8;
                        relArray[y - 1, x] = 0;
                        checkSpace(y - 1, x).GetComponent<SpriteRenderer>().color = Color.white;
                        setSolidTag(y - 1, x);
                    }

                }
                break;
            case 1:
                if (x - 1 >= 0)
                {
                    if (relArray[y, x - 1] == rock)
                    {
                        this.holding = true;
                        this.holdObj = rock;
                        relArray[y, x - 1] = 0;
                        checkSpace(y, x - 1).GetComponent<SpriteRenderer>().color = Color.white;
                        setSolidTag(y, x - 1);
                    }
                    else if (relArray[y, x - 1] == 4)
                    {
                        holding = true;
                        holdObj = 4;
                        relArray[y, x - 1] = 0;
                        checkSpace(y, x - 1).GetComponent<SpriteRenderer>().color = Color.white;
                        setSolidTag(y, x - 1);
                    }
                    else if (relArray[y, x - 1] == 36)
                    {
                        holding = true;
                        holdObj = rock;
                        relArray[y, x - 1] = plate;
                        checkTile(y, x - 1).GetComponent<SpriteRenderer>().color = Color.magenta;
                        setinteractiveTag(y, x - 1);
                    }
                    else if (relArray[y, x - 1] == 8)
                    {
                        holding = true;
                        holdObj = 8;
                        relArray[y, x - 1] = 0;
                        checkSpace(y, x - 1).GetComponent<SpriteRenderer>().color = Color.white;
                        setSolidTag(y, x - 1);
                    }
                }
                break;
            case 2:
                if (y + 1 >= 0)
                {
                    if (relArray[y + 1, x] == rock)
                    {
                        this.holding = true;
                        this.holdObj = rock;
                        relArray[y + 1, x] = 0;
                        checkSpace(y + 1, x).GetComponent<SpriteRenderer>().color = Color.white;
                        setSolidTag(y + 1, x);
                    }
                    else if (relArray[y + 1, x] == 4)
                    {
                        holding = true;
                        holdObj = 4;
                        relArray[y + 1, x] = 0;
                        checkSpace(y + 1, x).GetComponent<SpriteRenderer>().color = Color.white;
                        setSolidTag(y + 1, x);
                    }
                    else if (relArray[y + 1, x] == 36)
                    {
                        holding = true;
                        holdObj = rock;
                        relArray[y + 1, x] = plate;
                        checkTile(y + 1, x).GetComponent<SpriteRenderer>().color = Color.magenta;
                        setinteractiveTag(y + 1, x);
                    }
                    else if (relArray[y + 1, x] == 8)
                    {
                        holding = true;
                        holdObj = 8;
                        relArray[y + 1, x] = 0;
                        checkSpace(y + 1, x).GetComponent<SpriteRenderer>().color = Color.white;
                        setSolidTag(y + 1, x);
                    }
                }
                break;
            case 3:
                if (x + 1 >= 0)
                {
                    if (relArray[y, x + 1] == rock)
                    {
                        this.holding = true;
                        this.holdObj = rock;
                        relArray[y, x + 1] = 0;
                        checkSpace(y, x + 1).GetComponent<SpriteRenderer>().color = Color.white;
                        setSolidTag(y, x + 1);
                    }
                    else if (relArray[y, x + 1] == 4)
                    {
                        holding = true;
                        holdObj = 4;
                        relArray[y, x + 1] = 0;
                        checkSpace(y, x + 1).GetComponent<SpriteRenderer>().color = Color.white;
                        setSolidTag(y, x + 1);
                    }
                    else if (relArray[y, x + 1] == 36)
                    {
                        holding = true;
                        holdObj = rock;
                        relArray[y, x + 1] = rock;
                        checkTile(y, x + 1).GetComponent<SpriteRenderer>().color = Color.magenta;
                        setinteractiveTag(y, x + 1);
                    }
                    else if (relArray[y, x + 1] == 8)
                    { 
                        holding = true;
                        holdObj = 8;
                        relArray[y, x + 1] = 0;
                        checkSpace(y, x + 1).GetComponent<SpriteRenderer>().color = Color.white;
                        setSolidTag(y, x + 1);
                    }

                }
                break;
            default:
                print("This shouldn't happen");
                break;
        }

    }

    void putDown()
    {

        switch (direction)
        {
            case 0:
                if (y - 1 >= 0)
                {

                    if (relArray[y - 1, x] == 0 && holdObj == rock)
                    {
                        holding = false;
                        holdObj = 0;
                        relArray[y - 1, x] = rock;
                        checkFloor(y - 1, x).GetComponent<SpriteRenderer>().color = Color.grey;
                        setinteractiveTag(y - 1, x);

                    }
                    else if (relArray[y - 1, x] == 6 && holdObj == 4)
                    {

                        holding = false;
                        holdObj = 0;
                        relArray[y - 1, x] = 7;
                        checkFloor(y - 1, x).GetComponent<SpriteRenderer>().color = Color.red;
                        setinteractiveTag(y - 1, x);

                    }
                    else if (relArray[y - 1, x] == plate && holdObj == rock)
                    {

                        holding = false;
                        holdObj = 0;
                        relArray[y - 1, x] = 36;
                        checkTile(y - 1, x).GetComponent<SpriteRenderer>().color = Color.green;
                        setinteractiveTag(y - 1, x);

                    }

                }
                break;
            case 1:
                if (x - 1 >= 0)
                {

                    if (relArray[y, x - 1] == 0 && holdObj == rock)
                    {
                        holding = false;
                        holdObj = 0;
                        relArray[y, x - 1] = rock;
                        checkFloor(y, x - 1).GetComponent<SpriteRenderer>().color = Color.grey;
                        setinteractiveTag(y, x - 1);

                    }
                    else if (relArray[y, x - 1] == 6 && holdObj == 4)
                    {

                        holding = false;
                        holdObj = 0;
                        relArray[y, x - 1] = 7;
                        checkFloor(y, x - 1).GetComponent<SpriteRenderer>().color = Color.red;
                        setinteractiveTag(y, x - 1);

                    }
                    else if (relArray[y, x - 1] == plate && holdObj == rock)
                    {

                        holding = false;
                        holdObj = 0;
                        relArray[y, x - 1] = 36;
                        checkTile(y, x - 1).GetComponent<SpriteRenderer>().color = Color.green;
                        setinteractiveTag(y, x - 1);

                    }

                }
                break;
            case 2:
                if (y + 1 >= 0)
                {

                    if (relArray[y + 1, x] == 0 && holdObj == rock)
                    {
                        holding = false;
                        holdObj = 0;
                        relArray[y + 1, x] = rock;
                        checkFloor(y + 1, x).GetComponent<SpriteRenderer>().color = Color.grey;
                        setinteractiveTag(y + 1, x);

                    }
                    else if (relArray[y + 1, x] == 6 && holdObj == 4)
                    {

                        holding = false;
                        holdObj = 0;
                        relArray[y + 1, x] = 7;
                        checkFloor(y + 1, x).GetComponent<SpriteRenderer>().color = Color.red;
                        setinteractiveTag(y + 1, x);

                    }
                    else if (relArray[y + 1, x] == plate && holdObj == rock)
                    {

                        holding = false;
                        holdObj = 0;

                        relArray[y + 1, x] = 36;
                        checkTile(y + 1, x).GetComponent<SpriteRenderer>().color = Color.green;
                        setinteractiveTag(y + 1, x);

                    }

                }
                break;
            case 3:
                if (x + 1 >= 0)
                {

                    if (relArray[y, x + 1] == 0 && holdObj == rock)
                    {
                        holding = false;
                        holdObj = 0;
                        relArray[y, x + 1] = rock;
                        checkFloor(y, x + 1).GetComponent<SpriteRenderer>().color = Color.grey;
                        setinteractiveTag(y, x + 1);

                    }
                    else if (relArray[y, x + 1] == 6 && holdObj == 4)
                    {

                        holding = false;
                        holdObj = 0;
                        relArray[y, x + 1] = 7;
                        checkFloor(y, x + 1).GetComponent<SpriteRenderer>().color = Color.red;
                        setinteractiveTag(y, x + 1);

                    }

                    else if (relArray[y, x + 1] == plate && holdObj == rock)
                    {

                        holding = false;
                        holdObj = 0;
                        relArray[y, x + 1] = 36;
                        checkTile(y, x + 1).GetComponent<SpriteRenderer>().color = Color.green;
                        setinteractiveTag(y, x + 1);

                    }

                }
                break;
            default:
                print("This shouldn't happen");
                break;
        }

    }

}
