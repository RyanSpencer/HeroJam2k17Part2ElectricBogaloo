using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour {

    public int[,] stage1;


	// Use this for initialization
	void Start () {

        stage1 = new int[11,7]{
            { 2,2,2,5,2,2,2 },
            { 1,1,1,1,1,1,1 },
            { 1,0,0,0,0,0,1 },
            { 1,0,0,9,0,0,1 },
            { 1,0,0,0,0,0,1 },
            { 1,0,0,0,0,0,1 },
            { 1,0,0,6,0,0,1 },
            { 1,0,0,0,0,0,1 },
            { 1,0,0,0,0,0,1 },
            { 1,1,1,3,1,1,1 },
            { 2,2,2,4,2,2,2 }
        };

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
