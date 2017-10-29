using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour {

    public GameObject squarePrefab;
    public List<GameObject> quadList;
    public GameObject player;

    public Sprite t0;
    public Sprite t1;
    public Sprite t3;
    public Sprite t4;
    public Sprite t5;
    public Sprite t6;
    public Sprite t7;
    public Sprite t8;
    public Sprite t9;
    public Sprite t11;
    public Sprite t14;
    public Sprite t15;
    public Sprite t16;
    public Sprite t17;
    public Sprite t18;
    public Sprite t19;
    public Sprite t20;
    public Sprite t21;
    public Sprite t22;
    public Sprite t23;
    public Sprite t24;

    // Use this for initialization
    void Start () {
        quadList = new List<GameObject>();
        CreateLevel(GameObject.Find("GameManager").GetComponent<Stage>().stage1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // Creates the stage out of quads
    public void CreateLevel(int[,] stage)
    {
        for (int i = 0; i < stage.GetLength(0); ++i)
        {
            for (int j = 0; j < stage.GetLength(1); ++j)
            {
                quadList.Add(Instantiate(squarePrefab));
                quadList[quadList.Count - 1].transform.Translate(new Vector2(-5, 2));
                
                
                ModifyQuad(quadList[quadList.Count - 1], stage[i,j], -i, j);
            }
        }
        
        player.GetComponent<playerController>().lookAtLevel();
    }


    // Deletes the quads on the screen
    public void DeleteLevel()
    {
        Debug.Log("help");
        for (int i = 0; i < quadList.Count; ++i)
        {
            Destroy(quadList[i]);
        }
        quadList.Clear();
    }


    // Checks what type of quad to create and assigns it to the passed in quad
    void ModifyQuad(GameObject square, int objectType, int i, int j)
    {
        switch (objectType) {
            case 0:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t0;
                square.tag = "Floor";
                square.name = "Ground";
                break;
            case 1:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t1;
                square.tag = "Solid";
                square.name = "Wall";
                break;
            case 2:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.clear;
                square.tag = "Solid";
                square.name = "Blank";
                break;
            case 3:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t3;
                square.tag = "Untagged";
                square.name = "Ground";
                break;
            case 4:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t4;
                square.tag = "Solid";
                square.name = "PlayerFrom";
                break;
            case 5:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t5;
                square.tag = "Goal";
                square.name = "PlayerTo";
                break;
            case 6:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t6;
                square.tag = "Pickup";
                square.name = "Rock";
                break;
            case 7:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t7;
                square.tag = "Pickup";
                square.name = "Matches";
                break;
            case 8:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t8;
                square.tag = "Pickup";
                square.name = "Water";
                break;
            case 9:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t9;
                square.tag = "Interact";
                square.name = "Plate1";
                break;
            case 10:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.clear;
                square.tag = "Solid";
                square.name = "Bushes";
                break;
            case 11:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t11;
                square.tag = "Solid";
                square.name = "Fire";
                break;
            case 12:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.clear;
                square.tag = "Interact";
                square.name = "Generator";
                break;
            case 13:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.clear;
                square.tag = "Interact";
                square.name = "EmptyNode";
                break;
            case 14:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t14;
                square.tag = "Interact";
                square.name = "Gate1";
                break;
            case 15:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t15;
                square.tag = "Interact";
                square.name = "Gate2";
                break;
            case 16:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t16;
                square.tag = "Interact";
                square.name = "Gate3";
                break;
            case 17:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t17;
                square.tag = "Interact";
                square.name = "Gate4";
                break;
            case 18:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t18;
                square.tag = "Interact";
                square.name = "Gate5";
                break;
            case 19:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t19;
                square.tag = "Interact";
                square.name = "Gate6";
                break;
            case 20:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t20;
                square.tag = "Interact";
                square.name = "Plate2";
                break;
            case 21:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t21;
                square.tag = "Interact";
                square.name = "Plate3";
                break;
            case 22:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t22;
                square.tag = "Interact";
                square.name = "Plate4";
                break;
            case 23:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t23;
                square.tag = "Interact";
                square.name = "Plate5";
                break;
            case 24:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().sprite = t24;
                square.tag = "Interact";
                square.name = "Plate6";
                break;
            case 25:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.green;
                square.tag = "Untagged";
                square.name = "PlayerToTorso";
                break;
            case 26:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.gray;
                square.tag = "Untagged";
                square.name = "PlayerToArm";
                break;
            case 27:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.red;
                square.tag = "Untagged";
                square.name = "PlayerToLeg";
                break;
            default:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.white;
                square.tag = "Untagged";
                square.name = "Ground";
                break;
        }
    }

}
