using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting;
using UnityEngine;

public class WorldBuilder : MonoBehaviour
{
    [SerializeField] GameObject[] buildings;
    [SerializeField] Transform spawn1, spawn2, spawn3;
    int building1 = 100, building2 = 100, building3 = 100;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(StaticManager.firstChoice);
        Debug.Log(StaticManager.secondChoice);
        Debug.Log(StaticManager.lastChoice);
        Debug.Log("========================");
        for (int i = 0; i < buildings.Length; i++)
        {
           
            if (buildings[i].name == StaticManager.firstChoice)
            {
                building1 = i;
            }else if (buildings[i].name == StaticManager.secondChoice) {
                building2 = i; 
            }else if(buildings[i].name == StaticManager.lastChoice)
            {
                building3 = i;
            }
            

        }
        if (building1 == 100)
        {
            building1 = 0;
            Debug.Log("Budova nebyla nalezena nahrada na indexu 0");
        }
        if (building2 == 100)
        {
            building2 = 0;
            Debug.Log("Budova nebyla nalezena nahrada na indexu 0");
        }
        if (building3 == 100)
        {
            building3 = 0;
            Debug.Log("Budova nebyla nalezena nahrada na indexu 0");
        }
        Debug.Log(buildings[building1].name);
        Debug.Log(buildings[building2].name);
        Debug.Log(buildings[building3].name);

        Instantiate(buildings[building1],new Vector3(spawn1.position.x, spawn1.position.y, spawn1.position.z), new Quaternion(spawn1.rotation.x, spawn1.rotation.y, spawn1.rotation.z, 1));
        Instantiate(buildings[building2], new Vector3(spawn2.position.x, spawn2.position.y, spawn2.position.z), new Quaternion(spawn2.rotation.x, spawn2.rotation.y, spawn2.rotation.z, 1));
        Instantiate(buildings[building3], new Vector3(spawn3.position.x, spawn3.position.y, spawn3.position.z), new Quaternion(spawn3.rotation.x, spawn3.rotation.y, spawn3.rotation.z, 1));
    }
}
