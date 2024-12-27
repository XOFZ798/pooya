using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class JaggedArrayExample : MonoBehaviour
{
    void Start()
    {
        
        int[][] enemies = new int[3][]; 

       
        enemies[0] = new int[] { 100, 20 };         
        enemies[1] = new int[] { 80, 15, 10 };    
        enemies[2] = new int[] { 120, 25, 5, 30 };  
        for (int i = 0; i < enemies.Length; i++)
        {
            string enemyInfo = "Enemy " + (i + 1) + " Features: ";
            for (int j = 0; j < enemies[i].Length; j++)
            {
                enemyInfo += enemies[i][j] + " ";
            }
            Debug.Log(enemyInfo);
        }

       
        float totalHealth = 0;
        for (int i = 0; i < enemies.Length; i++)
        {
            totalHealth += enemies[i][0]; 
        }

        float averageHealth = totalHealth / enemies.Length;
        Debug.Log("Average enemy health: " + averageHealth);
    }

    void Update()
    {
        
    }
}
