using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pplateScript : MonoBehaviour {

    // Use this for initialization

    private bool on;
    public bool On {

        get { return on; }

        set { this.on = value; }

    }

    private string namePlate;
    public string NamePlate {

        get { return namePlate; }

        set { this.namePlate = value; }

    }

	void Start () {

        on = false;

	}
	
	// Update is called once per frame
	void Update () {
		


	}

    public void toggle() {

        on = !on;

    }

}
