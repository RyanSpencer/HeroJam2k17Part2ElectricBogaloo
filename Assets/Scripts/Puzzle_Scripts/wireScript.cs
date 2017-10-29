using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour {

    private int length;

    private int curLength;

    public LinkedList<int> wire = new LinkedList<int>();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void powerWire(int[] world) {

        //if start of wire is next/connected to a generator && end of wire is next/connected to a node == run node



    }

    public void placePath(int spaceX, int spaceY) {

        if (curLength < length)
        {

            curLength += 1;

        }
        else
        {

            //do nothing code || soundeffect

        }

    }

    public void removePath() {

        if (curLength > 0)
        {

            curLength -= 0;

        }
        else
        {

            //do nothing code || soundeffect

        }

    }

}
