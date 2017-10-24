using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class script : MonoBehaviour
{
    //creates 3 number variables
    int min = 1;
    int max = 1000;
    int guess = 500;
    int maxNumberOfGuesses = 10;

    public Text guessText;

    //the number is higher than the one guessed
    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    //the number is lower than the one guessed
    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        //update the text with the new guess
        guessText.text = guess.ToString();
        maxNumberOfGuesses--;
        //if the number of guesses left becomes 0, load up the 'Win' scene
        if (maxNumberOfGuesses == 0)
        {
            SceneManager.LoadScene("Win");
        }
    }

    void StartGame()
    {
        //prints once to the console (this is a method!) - This method will start the game
        print("Welcome to Number Wizard");
        Debug.Log("Please choose a number in your head between " + min + " and " + max);
        NextGuess();
    }

    // Use this for initialization
    void Start()
    {
        StartGame();
    }
}
