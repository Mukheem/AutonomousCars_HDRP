using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Varjo.XR;
using Varjo.XR.Input;

public class SceneManager : MonoBehaviour
{
    public DateTime sceneStartTime;
    public DateTime sceneEndTime;
    //public DateTime sceneCompletionTime;

    void Awake()
    {
        //VarjoCamera.SetTrackingMode(VarjoCamera.TrackingMode.RotationOnly);
        //VarjoHMD
    }
    // Start is called before the first frame update
    void Start()
    {
        sceneStartTime = System.DateTime.Now;
        Debug.Log("Scene Start Time:"+sceneStartTime.ToString());
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

    private void OnApplicationQuit()
    {
        sceneEndTime = System.DateTime.Now;
        Debug.Log("Scene End Time:" + sceneEndTime.ToString());

        TimeSpan sceneCompletionTime = (sceneEndTime - sceneStartTime).Duration();
        Debug.Log("Scene Completion Time:" + sceneCompletionTime.ToString());

    }
}
