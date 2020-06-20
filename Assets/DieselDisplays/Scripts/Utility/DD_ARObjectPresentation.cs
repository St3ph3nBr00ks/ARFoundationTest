using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DD_ARObjectPresentation : MonoBehaviour
{
    public Transform referenceObj;
    
    public Vector3 horzPresentationRot;
    public Vector3 vertPresentationRot;

    void Update()
    {       
        // If target image is laying down (horizontal)
        if (Mathf.Abs(referenceObj.eulerAngles.x) < 45 || 300 < Mathf.Abs(referenceObj.eulerAngles.x))
        {
            transform.localEulerAngles = horzPresentationRot;
        }
        // If target image is standing up (vertical)
        else if (45 < Mathf.Abs(referenceObj.eulerAngles.x) && Mathf.Abs(referenceObj.eulerAngles.x) < 300)
        {

            transform.localEulerAngles = vertPresentationRot;
        }
        else
        {
            transform.localEulerAngles = Vector3.zero;
        }

        if (FindObjectOfType<DD_Debug>().debugText)
        {
            FindObjectOfType<DD_Debug>().debugText.text =
                "transform.eulerAngles.x : " + referenceObj.eulerAngles.x + "\n" + " " +
                "presentationObj.localEulerAngles : " + transform.localEulerAngles;
        }
    }
}