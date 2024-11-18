using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack: MonoBehaviour

{
public float distanceToPlayer = 8f;

public int energy = 15;
public bool isAngry = false;

public bool hasLineOfSight = true;
void Start()
{
if (distanceToPlayer < 10 && energy > 20 && hasLineOfSight)
{
print("Enemy attacks the player!");
}
else if (isAngry && distanceToPlayer < 10 && hasLineOfSight)
{
print("Enemy attacks aggressively despite low energy!");
}
else if (!hasLineOfSight)
{
print("Enemy cannot see the player and does not attack.");
}
else if (energy < 5)
{
print("Enemy is too weak to attack.");
}
else {
}

print("Enemy does not attack.");}}