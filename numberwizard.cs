using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberwizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        print("hello gda welcome to unity");
        Debug.Log("Welcome to number wizard game");
        Debug.Log("pick a number dont tell me what it is ");
        Debug.Log("take  number between 1 to 1000");
        Debug.Log("tell me if your number higher or lower to 500");
        Debug.Log("Higher = press up key, Lower = press down key, Correct = press enter key");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
           
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am genius....");
            Debug.Log("-----------------------------------------");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("it is higher or lower than..." + guess);
    }
}
