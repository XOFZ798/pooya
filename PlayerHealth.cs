using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerHealth: MonoBehaviour
{
public int health = 75;
public bool hasShield = false; 
void Start()
{
if (health > 70 && hasShield) {
print("Player is in excellent condition!");
} else if (health > 70 && !hasShield) {
print("Player is healthy but unprotected!");
} else if (health >= 30 && health <= 70 && hasShield) {
print("Player is in moderate condition but has shield protection");
} else if (health >= 30 && health <= 70 && ! hasShield) { print("Player is vulnerable!");
} else if (health < 30 && hasShield) {
print("Player is in critical condition but has shield protection");
} else {
print("Player is in critical condition and unprotected!");
}
}}