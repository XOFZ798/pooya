using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class VehicleCheck : MonoBehaviour
{
    public int fuel = 60;
    public int passengers = 3;
    void Start()
    {
        if (fuel > 50)
        {
            if (passengers <= 4)
            {
                print("Vehicle is ready for the trip!");
            }
            else
            {
                print("Vehicle needs more fuel for more passengers.");

            }

        }
        else
        {
            if (passengers <= 2)
            {
                print("Vehicle can go, but refuel during the trip.");

            }
            else
            {
                print("Vehicle is not suitable for the trip with current fuel and passengers.");
            }
        }
    }
}