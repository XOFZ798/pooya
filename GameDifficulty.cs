using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameDifficulty : MonoBehaviour
{


    public int difficultyLevel = 1;

    void Start()
    {

        switch (difficultyLevel)
        {
            case 1:
                print("Difficulty Level: Easy");
                print("You have chosen the Easy level. Good luck!"); break;
            case 2:
                print("Difficulty Level: Medium");
                print("You have chosen the Medium level. Be cautious!"); break;
            case 3:
                print("Difficulty Level: Hard");
                print("Difficulty Level: Hard. Prepare for a challenge!"); break;
            default:
                print("Invalid difficulty level! Please choose a valid level (1, 2, or 3)."); break;
        }
    }
}