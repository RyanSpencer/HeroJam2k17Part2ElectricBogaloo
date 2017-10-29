using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeechScript : MonoBehaviour {

    // All dialogue
    string[,] dialogue = new string[12, 20];

    // Button script / object
    public GameObject buttonObject;
    public Button button;
    public Text buttonText;

    // Whether the dialogue tree has been finished; used to increment scene
    bool dialogueFinished;

    // Which scene the dialogue is currently being used in (left int)
    int dialogueScene;

    // Which dialogue is currently being said (right int)
    int currentDialogueNumber;

    // How many dialogues there are within a specific scene
    int[] dialogueNumber;

    // Whether the mouse is down
    bool clicked;

    // Whether the scene is finished, so everything can increment
    bool sceneFinished;

    public Button testB;




    public bool DialogueFinished
    {
        get { return dialogueFinished; }
        set { dialogueFinished = value; }
    }

	// Use this for initialization
	void Start () {
        dialogue[0, 0] = "What a loser!";
        dialogue[0, 1] = "Spineless!";
        dialogue[0, 2] = "He's been disarmed!";
        dialogue[0, 3] = "Of course noBODY likes you. You don't even have one of your own!";
        dialogue[0, 4] = "What a bonehead!";
        dialogue[0, 5] = "HAHAHAHAHAHA!";
        dialogue[0, 6] = "Don't bother hanging out with us again. Creep.";
        dialogue[0, 7] = "Freak.";
        dialogue[0, 8] = "Loser.";
        dialogue[0, 9] = "(..........................)";
        dialogue[0, 10] = "Sweetie, what's the matter?";
        dialogue[0, 11] = "(Mom?)";
        dialogue[0, 12] = "Is everything all right?";
        dialogue[0, 13] = "(Dad?)";
        dialogue[0, 14] = "(Where are you?? Where did you go??)";
        dialogue[0, 15] = "Just take deep breaths, my darling. One at a time.";
        dialogue[0, 16] = "Did you hurt yourself anywhere? Bump your funny bone? Can you walk??";
        dialogue[0, 17] = "(......................I guess I can move...but...)";
        dialogue[0, 18] = "No buts. Everything will be OK. First, let's get you out of here. One step at a time.";
        dialogue[0, 19] = "(...........OK...)";

        dialogue[1, 0] = "You need to get out...can you take a closer look at what we've got in this room?";
        dialogue[1, 1] = "Way to get aHEAD of that one!";
        dialogue[1, 2] = "Just keep moving forward, and you'll be out in no time.";

        dialogue[2, 0] = "See, dear? You've already found your torso! You'll be able to pull yourself together easily.";
        dialogue[2, 1] = "CHEST keep on going! We know it's tough, be we believe in you!";

        dialogue[3, 0] = "There's no shame in falling apart. Sometimes all you can do is pick up the pieces and start again.";

        dialogue[4, 0] = "Nice job! You're no longer disarmed.";
        dialogue[4, 1] = "Not ver humerus, my dear...";

        dialogue[5, 0] = "You're almost there, my darling! We're waiting for you.";

        dialogue[6, 0] = "I knew you could pick yourself up again!";

        dialogue[7, 0] = "There you are!";
        dialogue[7, 1] = "We've been looking all over for you, kiddo.";
        dialogue[7, 2] = "(Mom? Dad?)";
        dialogue[7, 3] = "Where have you been?? We've been worried sick!";
        dialogue[7, 4] = "Oh, don't be so STERNUM with the kid!";
        dialogue[7, 5] = "This isn't funny, Frank!";
        dialogue[7, 6] = "TIBIA honest, I find this quite HUMERUS, wouldn't you say?";
        dialogue[7, 7] = "FRANK!";
        dialogue[7, 8] = "Oh, don't be so STERNUM. I'm not telling a FIBULA!";

        dialogue[8, 0] = "What an odd-looking plate. Maybe try putting something heavy on top?";
        dialogue[8, 1] = "Maybe try putting something on top of this plate?";
        dialogue[8, 2] = "What an inconspicuous place to put a plate. It's in a prime location to put something on top of it.";

        dialogue[9, 0] = "Oh dear. You can't power this without electricity!";
        dialogue[9, 1] = "I wonder if you can get something around here to power this device?";

        dialogue[10, 0] = "What thick foliage! It doesn't look like you'll be able to push your way through this.";
        dialogue[10, 1] = "I don't think you'll be able to push your way through without some help, dear.";

        dialogue[11, 0] = "This is a rather hot situation. I wonder if you can cool it down a little?";
        dialogue[11, 1] = "You are NOT walking through that fire, child.";

        buttonObject = GameObject.FindGameObjectWithTag("Button");
        button = buttonObject.GetComponent<Button>();

        dialogueFinished = false;
        dialogueScene = 0;
        currentDialogueNumber = 0;

        dialogueNumber = new int[8];
        dialogueNumber[0] = 20;
        dialogueNumber[1] = 3;
        dialogueNumber[2] = 2;
        dialogueNumber[3] = 1;
        dialogueNumber[4] = 2;
        dialogueNumber[5] = 1;
        dialogueNumber[6] = 1;
        dialogueNumber[7] = 9;

        clicked = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (!sceneFinished) {
            if (!dialogueFinished)
            {
                buttonText.text = dialogue[dialogueScene, currentDialogueNumber];
            }
            else
            {
                sceneFinished = true;
                DisableButton();
            }

            if (Input.GetMouseButtonDown(0) && !clicked)
            {
                clicked = true;
                IncrementText();
            }
            else if (Input.GetMouseButtonUp(0))
            {
                clicked = false;
            }
        }
	}

    public void IncrementText()
    {
        currentDialogueNumber++;
        if (currentDialogueNumber >= dialogueNumber[dialogueScene])
        {
            dialogueFinished = true;
        }
    }

    public void IncrementScene()
    {
        dialogueScene++;
        sceneFinished = false;
        currentDialogueNumber = 0;
        dialogueFinished = false;
        clicked = false;

        EnableButton();
    }

    void DisableButton()
    {
        buttonObject.SetActive(false);
    }

    void EnableButton()
    {
        buttonObject.SetActive(true);
    }
}
