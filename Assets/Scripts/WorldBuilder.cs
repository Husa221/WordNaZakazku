using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WorldBuilder : MonoBehaviour
{
    [SerializeField] GameObject[] buildings;
    [SerializeField] Transform spawn1, spawn2, spawn3;
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(buildings[StaticManager.firstChoice],new Vector3(spawn1.position.x, spawn1.position.y, spawn1.position.z), new Quaternion(spawn1.rotation.x, spawn1.rotation.y, spawn1.rotation.z, 1));
        Instantiate(buildings[StaticManager.secondChoice], new Vector3(spawn2.position.x, spawn2.position.y, spawn2.position.z), new Quaternion(spawn2.rotation.x, spawn2.rotation.y, spawn2.rotation.z, 1));
        Instantiate(buildings[StaticManager.lastChoice], new Vector3(spawn3.position.x, spawn3.position.y, spawn3.position.z), new Quaternion(spawn3.rotation.x, spawn3.rotation.y, spawn3.rotation.z, 1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
