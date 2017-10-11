using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour {
    //creates 3 number variables
    int min = 1;
    int max = 1000;
    int guess = 500;

    void NextGuess()
    {
        //this method will do the addition instead of typing it more than once in each if statement
       print("Is the number greater or smaller than " + guess + " ?");
       print("UP: Greater DOWN: Smaller ENTER: Equal");
    }

    void StartGame()
    {
        //prints once to the console (this is a method!) - This method will start the game
        print("Welcome to Number Wizard");
        Debug.Log("Please choose a number in your head between " + min + " and " + max);
        NextGuess();
    }

	// Use this for initialization
	void Start ()
    {
        StartGame();
	}
	
	// Update is called once per frame
	void Update () {
        //if the input from the keyboard is the DOWN arrow
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("DOWN arrow pressed");
            max = guess;
            guess = (min + max) / 2;
            NextGuess();

        }

        //if the input from the keyboard is the UP arrow
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Debug.Log("UP arrow pressed");
            min = guess;
            guess = (min + max) / 2;
            NextGuess();
            
        }

        //if the input from the keyboard is the ENTER arrow
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("ENTER button pressed");
            print("You won! The number was: " + guess);
        }	
	}
}
