using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchGame : MonoBehaviour
{
    private List<string> lostObjects = new List<string> { "Key", "Book", "Phone", "Wallet" };
    private List<string> foundObjects = new List<string>();
    
    public int maxAttempts = 5;
    private int attemptsLeft;

    void Start()
    {
        attemptsLeft = maxAttempts; 
        StartGame();
    }

    void StartGame()
    {
        Debug.Log("Welcome to the Search Game!");
      
        Debug.Log($"You have {maxAttempts} attempts. Good luck!");

     
        while (attemptsLeft > 0 && foundObjects.Count < lostObjects.Count)
        {
            Debug.Log($"Attempts left: {attemptsLeft}. Enter the name of an object:");              
            string playerInput =inputField.text;
            bool found = false;
            foreach (string obj in lostObjects)
            {
                if (obj.ToLower() == playerInput.ToLower() && !foundObjects.Contains(obj))
                {
                    foundObjects.Add(obj);
                    Debug.Log($"You found the {obj}!");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Debug.Log($"The {playerInput} is not on the list or already found.");
            }

            attemptsLeft--;
        }

        EndGame();
    }

    void EndGame()
    {
        if (foundObjects.Count == lostObjects.Count)
        {
            Debug.Log("Congratulations! You found all the objects!");
        }
        else
        {
            Debug.Log("Game over! You ran out of attempts.");
            Debug.Log($"You found {foundObjects.Count} out of {lostObjects.Count} objects.");
        }
    }


}
