using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCreator : MonoBehaviour {

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
                GameObject currentSquare = GameObject.CreatePrimitive(PrimitiveType.Quad);

                ModifyQuad(currentSquare, stage[i,j], i, j);
                
                Debug.Log(stage[i,j]);
                
            }
        }
    }


    void ModifyQuad(GameObject square, int objectType, int i, int j)
    {
        switch (objectType) {
            case 0:
                square.transform.Translate(new Vector2(j, -i));
                square.GetComponent<SpriteRenderer>().color = Color.white;
                square.tag = "untagged";
                square.name = "Ground";
                break;
            case 1:
                square.transform.Translate(new Vector2(j, -i));
                square.GetComponent<SpriteRenderer>().color = Color.cyan;
                square.tag = "Solid";
                square.name = "Wall";
                break;
            case 2:
                square.transform.Translate(new Vector2(j, -i));
                square.GetComponent<SpriteRenderer>().color = Color.clear;
                square.tag = "Solid";
                square.name = "Blank";
                break;
            case 3:
                square.transform.Translate(new Vector2(j, -i));
                square.GetComponent<SpriteRenderer>().color = Color.white;
                square.tag = "untagged";
                square.name = "Ground";
                break;
            case 4:
                square.transform.Translate(new Vector2(j, -i));
                square.GetComponent<SpriteRenderer>().color = Color.yellow;
                square.tag = "Solid";
                square.name = "PlayerFrom";
                break;
            case 5:
                square.transform.Translate(new Vector2(j, -i));
                square.GetComponent<SpriteRenderer>().color = Color.green;
                square.tag = "untagged";
                square.name = "PlayerTo";
                break;
            case 6:
                square.transform.Translate(new Vector2(j, -i));
                square.GetComponent<SpriteRenderer>().color = Color.gray;
                square.tag = "Pickup";
                square.name = "Rock";
                break;
            case 7:
                square.transform.Translate(new Vector2(j, -i));
                square.GetComponent<SpriteRenderer>().color = Color.red;
                square.tag = "Pickup";
                square.name = "Matches";
                break;
            case 8:
                square.transform.Translate(new Vector2(j, -i));
                square.GetComponent<SpriteRenderer>().color = Color.blue;
                square.tag = "Pickup";
                square.name = "Water";
                break;
            case 9:
                square.transform.Translate(new Vector2(j, -i));
                square.GetComponent<SpriteRenderer>().color = Color.magenta;
                square.tag = "Interact";
                square.name = "Plate";
                break;
            default:
                square.transform.Translate(new Vector2(j, -i));
                square.GetComponent<SpriteRenderer>().color = Color.white;
                square.tag = "untagged";
                square.name = "Ground";
                break;
        }
    }

}
