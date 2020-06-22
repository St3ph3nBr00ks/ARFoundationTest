using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DD_OrientTowardViewer : MonoBehaviour
{
    public void OrientTowardViewer()
    {
        if (FindObjectOfType<DD_ARObjectMasterRotationObject>())
        {
            Debug.Log("rotate toward user");

            Transform ddObj = FindObjectOfType<DD_ARObjectMasterRotationObject>().transform;

            ddObj.LookAt( Camera.main.transform.position);

            ddObj.eulerAngles = new Vector3(0, ddObj.eulerAngles.y, 0);                      
        }
    }
}
