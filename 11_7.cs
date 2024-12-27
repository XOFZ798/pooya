using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections.Generic;
using UnityEngine;

public class StoreInventory : MonoBehaviour
{
    void Start()
    {
       
        Dictionary<string, int> inventory = new Dictionary<string, int>();

        
        inventory.Add("Laptop", 10);
        inventory.Add("Mouse", 25);
        inventory.Add("Keyboard", 15);
        inventory.Add("Monitor", 5);

        Debug.Log("** Initial store inventory **");
        foreach (KeyValuePair<string, int> product in inventory)
        {
            Debug.Log(product.Key + ": " + product.Value + " units");
        }

  
        string productToUpdate = "Mouse";
        if (inventory.ContainsKey(productToUpdate))
        {
            inventory[productToUpdate] += 10; 
            Debug.Log("New inventory of " + productToUpdate + ": " + inventory[productToUpdate]);
        }

        string minProduct = "";
        int minStock = int.MaxValue;
        foreach (KeyValuePair<string, int> product in inventory)
        {
            if (product.Value < minStock)
            {
                minProduct = product.Key;
                minStock = product.Value;
            }
        }
        Debug.Log("Product with the lowest inventory: " + minProduct + " with quantity " + minStock + " units");

       
        inventory.Add("Headphones", 12);
        Debug.Log("New product 'Headphones' added. Inventory: 12 units");

        
        Debug.Log("** Final store inventory **");
        foreach (KeyValuePair<string, int> product in inventory)
        {
            Debug.Log(product.Key + ": " + product.Value + " units");
        }
    }

   
    void Update()
    {
       
    }
}
