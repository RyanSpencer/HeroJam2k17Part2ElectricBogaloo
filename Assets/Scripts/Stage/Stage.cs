﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour {

    public int[,] stage1;
    public int[,] stage2;
    public int[,] stage3;
    public int[,] stage4;
    public int[,] stage5;

    public int currentStage;


    private void Awake()
    {
        currentStage = 1;
        stage1 = new int[11, 7]{
            { 2,2,2,5,2,2,2 },
            { 1,1,1,14,1,1,1 },
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


        stage2 = new int[11, 7]{
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

        stage3 = new int[11, 7]{
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

        stage4 = new int[11, 7]{
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

        stage5 = new int[11, 7]{
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

    // Use this for initialization
    void Start () {



        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
