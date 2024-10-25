using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAlignment : MonoBehaviour
{
    public GameObject driverSeatPosition;  // Reference to the driver seat GameObject in the scene
    public GameObject xrOrigin;  // The XR Rig (parent of the Camera Offset)

    // Start is called before the first frame update
    void Start()
    {
        AlignToDriverSeat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AlignToDriverSeat()
    {
        if (driverSeatPosition != null && xrOrigin != null)
        {
            // Position the XR Rig at the driver's seat
            xrOrigin.transform.position = driverSeatPosition.transform.position;

            // Rotate the XR Rig to match the driver's seat rotation
            xrOrigin.transform.rotation = driverSeatPosition.transform.rotation;
        }
        else
        {
            Debug.LogWarning("Driver seat or XR Rig reference is missing.");
        }
    }
}
