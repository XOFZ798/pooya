using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class JaggedArray : MonoBehaviour
{
    void Start()
    {
        int[][] playerScores = new int[3][];
        playerScores[0] = new int[] { 100, 200, 150 };
        playerScores[1] = new int[] { 300, 250 };
        playerScores[2] = new int[] { 50, 100, 75, 125 };

    
        for (int i = 0; i < playerScores.Length; i++)
        {
            int totalScore = 0;
            for (int j = 0; j < playerScores[i].Length; j++)
            {
                totalScore += playerScores[i][j];
            }
            Debug.Log("Total player points for Player " + (i + 1) + ": " + totalScore);
        }
    }

    void Update()
    {
      
    }
}
