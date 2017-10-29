using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Manager : MonoBehaviour {

    private enum puzzleType {

        Plate,
        Rock,
        Wire,
        Bush,
        Door

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void puzzleInteract() {


    }

    public void interactPlate(playerController plyCon, Stage curStage)
    {
        /*
        if (plyCon.manager.GetComponent<Stage>().stage1[plyCon.y - 1, plyCon.x] == 2)
        {
            plyCon.holding = true;
            plyCon.holdObj = 2;
            plyCon.manager.GetComponent<Stage>().stage1[plyCon.y - 1, plyCon.x] = 0;
            plyCon.checkSpace(plyCon.y - 1, plyCon.x).GetComponent<SpriteRenderer>().color = Color.white;
            plyCon.setSolidTag(plyCon.y - 1, plyCon.x);
        }
        */

    }

    public bool interactBush()
    {

        return true;

    }

    /*public bool interactPlate()
    {

        return true;

    }*/

    public bool interactWire()
    {

        return true;

    }

}
