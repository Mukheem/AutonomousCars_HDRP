using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag("selectingSignifier");  //Find all GameObjects with specific tag

        foreach (GameObject go in taggedObjects)  //iterate through all returned objects, and find the one with the correct name
        {
            go.SetActive(false);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
