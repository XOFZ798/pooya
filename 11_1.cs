using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
public GameObject spherePrefab; 
public List<GameObject> sphereList; 

void Start() {

sphereList = new List<GameObject>(); 
}
void Update()
{
if (Input.GetKeyDown (KeyCode.A)) 
{
AddSphere();
}
if (Input.GetKeyDown (KeyCode.D)) 
{RemoveLastSphere();
}

}

void AddSphere()
{
GameObject newSphere = Instantiate (spherePrefab);
newSphere.transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range (-5f, 5f), 0);
sphereList.Add(newSphere); 
Debug.Log("کره اضافه شد ! تعداد کره ها :"  + sphereList.Count);
}
void RemoveLastSphere()
{
if (sphereList.Count > 0)
{
GameObject lastSphere = sphereList [sphereList.Count -1];
Destroy (lastSphere); 
sphereList.RemoveAt(sphereList.Count - 1); 

Debug.Log("آخرین کره حذف شد! تعداد کره ها :" + sphereList.Count);}
else
{Debug.Log("لیست خالی است" );
}
}}
