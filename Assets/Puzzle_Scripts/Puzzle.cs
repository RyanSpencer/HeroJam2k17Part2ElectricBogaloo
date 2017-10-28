using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour {

    public enum puzzleObj {

        rock,
        plate,
        matche,
        bush,
        bucket,
        fire,
        wire,
        generator,
        powerNode,
        door

    }

    public puzzleObj objType;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /*public bool interactDoor() {

        bool doorBool;

        return doorBool;

    }

    public bool interactBush() {

        bool bushBool;

        return bushBool;

    }

    public bool interactPlate() {

        bool plateBool;

        return plateBool;

    }

    public bool interactWire() {

        bool wireBool;

        return wireBool;

    }*/

}
