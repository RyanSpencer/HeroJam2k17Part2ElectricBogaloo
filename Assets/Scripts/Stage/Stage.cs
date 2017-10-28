using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour {

    public int[,] stage1;


	// Use this for initialization
	void Start () {

        stage1 = new int[11,7]{
            { 24,24,24,22,24,24,24 },
            { 21,21,21,21,21,21,21 },
            { 21,0,0,0,0,0,21 },
            { 21,0,0,3,0,0,21 },
            { 21,0,0,0,0,0,21 },
            { 21,0,0,0,0,0,21 },
            { 21,0,0,2,0,0,21 },
            { 21,0,0,0,0,0,21 },
            { 21,0,0,0,0,0,21 },
            { 21,0,0,0,0,0,21 },
            { 24,24,24,23,24,24,24 }
        };

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
