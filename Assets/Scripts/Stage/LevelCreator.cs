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
        for (uint i = 0; i < stage.GetLength(0); ++i)
        {
            for (uint j = 0; j < stage.GetLength(1); ++j)
            {
                GameObject currentSquare = GameObject.CreatePrimitive(PrimitiveType.Quad);
                float newX = currentSquare.transform.position.x + j;
                float newY = currentSquare.transform.position.y - i;

                currentSquare.transform.position = new Vector2(newX, newY);

                Debug.Log(stage[i,j]);
                
            }
        }
    }

}
