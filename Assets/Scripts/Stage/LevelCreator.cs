using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour {

    public GameObject squarePrefab;

	// Use this for initialization
	void Start () {
        CreateLevel(GameObject.Find("GameManager").GetComponent<Stage>().stage1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void CreateLevel(int[,] stage)
    {
        for (int i = 0; i < stage.GetLength(0); ++i)
        {
            for (int j = 0; j < stage.GetLength(1); ++j)
            {
                GameObject currentSquare = Instantiate(squarePrefab);
                currentSquare.transform.Translate(new Vector2(-5, 2));

                print(stage[i, j]);
                ModifyQuad(currentSquare, stage[i,j], -i, j);
            }
        }
    }


    void ModifyQuad(GameObject square, int objectType, int i, int j)
    {
        switch (objectType) {
            case 0:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.white;
                square.tag = "Untagged";
                square.name = "Ground";
                break;
            case 1:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.cyan;
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
                square.GetComponent<SpriteRenderer>().color = Color.white;
                square.tag = "Untagged";
                square.name = "Ground";
                break;
            case 4:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.yellow;
                square.tag = "Solid";
                square.name = "PlayerFrom";
                break;
            case 5:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.green;
                square.tag = "Goal";
                square.name = "PlayerTo";
                break;
            case 6:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.gray;
                square.tag = "Pickup";
                square.name = "Rock";
                break;
            case 7:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.red;
                square.tag = "Pickup";
                square.name = "Matches";
                break;
            case 8:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.blue;
                square.tag = "Pickup";
                square.name = "Water";
                break;
            case 9:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.magenta;
                square.tag = "Interact";
                square.name = "Plate";
                break;
            case 10:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.white;
                square.tag = "Solid";
                square.name = "Bushes";
                break;
            case 11:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.cyan;
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
                square.GetComponent<SpriteRenderer>().color = Color.white;
                square.tag = "Interact";
                square.name = "EmptyNode";
                break;
            case 14:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.yellow;
                square.tag = "Interact";
                square.name = "Gate";
                break;
            case 15:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.green;
                square.tag = "Untagged";
                square.name = "TopLeftWire";
                break;
            case 16:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.gray;
                square.tag = "Untagged";
                square.name = "BottomRightWire";
                break;
            case 17:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.red;
                square.tag = "Untagged";
                square.name = "BottomLeftWire";
                break;
            case 18:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.blue;
                square.tag = "Untagged";
                square.name = "TopRightWire";
                break;
            case 19:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.magenta;
                square.tag = "Untagged";
                square.name = "StraightUpWire";
                break;
            case 20:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.white;
                square.tag = "Untagged";
                square.name = "StraightRightWire";
                break;
            case 21:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.cyan;
                square.tag = "Solid";
                square.name = "FilledNodeDown";
                break;
            case 22:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.clear;
                square.tag = "Solid";
                square.name = "FilledNodeRight";
                break;
            case 23:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.white;
                square.tag = "Solid";
                square.name = "FilledNodeUp";
                break;
            case 24:
                square.transform.Translate(new Vector2(j, i));
                square.GetComponent<SpriteRenderer>().color = Color.yellow;
                square.tag = "Solid";
                square.name = "FilledNodeLeft";
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
