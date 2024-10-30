using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Metadata;

public class ObjectSelection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectUnSelectObject(GameObject currentGameObject)
    {
      
        foreach (Transform child in currentGameObject.transform)
        {
           
            if (child.tag == "selectingSignifier")
            {
                if(child.gameObject.activeInHierarchy)
                {
                    child.gameObject.SetActive(false);
                }
                else
                {
                    child.gameObject.SetActive(true);
                }
            }
        }

       /* List<GameObject> foundObjects = new List<GameObject>();
        GameObject[] allObjects = GameObject.FindObjectsOfType<GameObject>(true);

        foreach (GameObject obj in allObjects)
        {
            if (obj.CompareTag("selectingSignifier"))
            {
                obj.SetActive(true);
            }
        }
       */
    }
}
