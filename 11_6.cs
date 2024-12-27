using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerScores : MonoBehaviour
{
  
    void Start()
    {
       
        Dictionary<string, int> scores = new Dictionary<string, int>();

     
        scores.Add("Ali", 90);
        scores.Add("Sara", 85);
        scores.Add("Reza", 95);
        scores.Add("Mina", 88);

  
        Debug.Log("** List of players and scores **");
        foreach (KeyValuePair<string, int> player in scores)
        {
            Debug.Log(player.Key + ": " + player.Value);
        }

        
        string playerName = "Ali";
        if (scores.ContainsKey(playerName))
        {
            Debug.Log("Score of " + playerName + ": " + scores[playerName]);
        }

        string topPlayer = "";
        int topScore = 0;
        foreach (KeyValuePair<string, int> player in scores)
        {
            if (player.Value > topScore)
            {
                topPlayer = player.Key;
                topScore = player.Value;
            }
        }
        Debug.Log("Player with the most points: " + topPlayer + " with points " + topScore);
    }

  
    void Update()
    {
        
    }
}
