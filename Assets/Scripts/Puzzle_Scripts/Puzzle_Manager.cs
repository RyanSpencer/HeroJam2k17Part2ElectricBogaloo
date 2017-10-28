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

    public bool interactDoor()
    {

        return true;

    }

    public bool interactBush()
    {

        return true;

    }

    public bool interactPlate()
    {

        return true;

    }

    public bool interactWire()
    {

        return true;

    }

}
