using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool hasGreenKey = false;
    public bool hasBlueKey = false;
    public bool hasRedKey = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) //changed KeyCode.A to KeyCode.E, based on directions
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
            {
                if (hit.collider.tag == "Door")
                {
                    LockedDoor door = hit.collider.GetComponent<LockedDoor>(); // ????
                    
                    if (door.isDoorLocked == true)
                    {
                        //Open The Door
                    }
                    else 
                    {
                        if ((door.keyColorRequired == KeyColor.Green && hasGreenKey) ||
                            (door.keyColorRequired == KeyColor.Blue && hasBlueKey) || //changed hasGreenKey to hasBlueKey
                            (door.keyColorRequired == KeyColor.Red && hasRedKey))
                        {
                            //Open The Door
                        }
                    }
                    
                }
            }
        }
    }
}
