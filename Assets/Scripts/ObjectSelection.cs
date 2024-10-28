using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("selectingSignifier").gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectUnSelectObject(GameObject currentGameObject)
    {
        Debug.Log("Trigger Entered");
       // GameObject.FindGameObjectWithTag("selectingSignifier").gameObject.SetActive(true);

        List<GameObject> foundObjects = new List<GameObject>();
        GameObject[] allObjects = GameObject.FindObjectsOfType<GameObject>(true);

        foreach (GameObject obj in allObjects)
        {
            if (obj.CompareTag("selectingSignifier"))
            {
                obj.SetActive(true);
            }
        }
    }
}
