using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureGame : MonoBehaviour
{
    // Player variables
    private int health = 50;
    private int energy = 30;
    private bool hasWeapon = false;
    private bool isEnemyVisible = true;
    private int damage=100;

    // Enemy variables
    private string enemyType = "Goblin"; 
    private int enemyHealth = 70;

    void Start()
    {
        Debug.Log("Game started!");
        PlayGame(); 
    }
    public void PlayGame()
    {
        
        Debug.Log("Starting player actions...");
        
        AttackEnemy(); // Attempt to attack
        EscapeEnemy(); // Attempt to escape
        SearchResources(); // Attempt to search for resources

        Debug.Log("Game ended!");
    }


    public void AttackEnemy()
    {
        if (!hasWeapon)
        {
            Debug.Log("You cannot attack without a weapon!"); }
        else if (hasWeapon && energy > 20)
        {
            switch (enemyType)
            {
                case "Goblin":
                    damage-= 30;
                    break;
                case "Orc":
                    damage-= 20;
                    break;
                case "Dragon":
                    damage-= 10;
                    break;
                default:
                    Debug.Log("Unknown enemy type!");
                    break;
            }

            Debug.Log($"You attacked the {enemyType}. Enemy health: {enemyHealth}");

            if (enemyHealth <= 0)
            {
                Debug.Log("Enemy defeated!");
            }
        }
     
        
        else
        {
            Debug.Log("Not enough energy to attack!");
        }
    }

  
    public void EscapeEnemy()
    {
        if (isEnemyVisible && energy < 20)
        {
            if (enemyType == "Dragon")
            {
                Debug.Log("You cannot escape from the Dragon!");
            }
            else
            {
                Debug.Log("You escaped successfully!");
                isEnemyVisible = false; // Enemy no longer visible after escaping
            }
        }
        else
        {
            Debug.Log("You cannot escape under these conditions!");
        }
    }

   
    public void SearchResources()
    {
        if (!isEnemyVisible && energy < 10)
        {
            Debug.Log("You found an energy potion!");
            energy += 20;
            Debug.Log($"Your energy increased to {energy}.");
        }
        else
        {
            Debug.Log("No resources found.");
        }
    }

   

    void Update()
    {
       
    }
}
