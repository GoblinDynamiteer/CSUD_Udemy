using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

    public Text text;
    enum States {Cell, Mirror, Sheets0,
        Lock0, CellMirror, Sheets1, Lock1, Freedom};
    States myState;

	// Use this for initialization
	void Start()
    {
        myState = States.Cell;
	}
	
	// Update is called once per frame
	void Update()
    {
        print(myState);
        if (myState == States.Cell)
        {
            StateCell();
        }

        else if (myState == States.Sheets0)
        {
            StateSheets();
        }

	}

    void StateCell()
    {
        //text.text = "Space pressed!";
        text.text = "You are in space prison!!\n" +
            "Your sad excuse for a bed is covered with stained sheets.\n" +
            "There is a mirror hanging by the locked cell door.\n\n" +
            "Press S to view Sheets, M to view Mirror, " +
            "L to view Locks";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myState = States.Sheets0;
        }
    }

    void StateSheets()
    {
        text.text = "Disgusting!!! \n\nPress R to return to " +
            "roaming your space prison cell!";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.Cell;
        }
    }
}
