using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour
{
    int max;
    int min;
    int guess;

    /* Use this for initialization */
    void Start()
    {
        StartGame();
    }

    /* Update is called once per frame */
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow pressed");
            min = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow pressed");
            max = guess;
            NextGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");

            StartGame();
        }

    }

    void StartGame()
    {
        max = 1001;
        min = 1;
        guess = 500;

        print("--------------------------");
        print("Welcome to Number Wizard!");
        print("Pick a number in your head, " +
            "but dont tell me!");

        print("The highest number you can pick is " + (max - 1));
        print("The lowest number you can pick is " + min);

        print("Is the number higher, lower, " +
            "or equal to " + guess + " ?");
        print("Press UP for higher, DOWN for lower, " +
            "RETURN for equal");
    }

    void NextGuess()
    {
        guess = (max + min) / 2; // Binary chop
        print("Is the number higher, " +
            "lower, or equal to " + guess + " ?");
        print("Press UP for higher, DOWN for lower, " +
            "RETURN for equal");
    }

}
