using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour {

    private bool open;
    public bool Open {

        get { return open; }
        set { this.open = value; }

    }
    private string nameDoor;
    public string NameDoor
    {

        get { return nameDoor; }

        set { this.nameDoor = value; }

    }

    // Use this for initialization
    void Start () {

        open = false;

	}
	
	// Update is called once per frame
	void Update () {
		


	}

    public void toggleDoor()
    {

        open = !open;

        if (open)
        {

            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;

        }
        else
        {

            this.gameObject.GetComponent<SpriteRenderer>().enabled = true;

        }

    }

}
