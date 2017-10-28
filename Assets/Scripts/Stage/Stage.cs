using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour {

    public int[,] stage1;


	// Use this for initialization
	void Start () {

        stage1 = new int[4,4]{
            { 0,0,0,2 },
            { 0,0,1,0 },
            { 1,0,0,0 },
            { 0,0,0,1 }
        };

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
