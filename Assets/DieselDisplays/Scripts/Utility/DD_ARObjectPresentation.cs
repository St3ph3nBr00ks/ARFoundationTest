using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DD_ARObjectPresentation : MonoBehaviour
{
    public Transform referenceObj;

    public Transform yRotRef;

    public Vector3 horzPresentationRot;
    public Vector3 vertPresentationRot;

    void Update()
    {       
        // If target image is laying down (horizontal)
        if (Mathf.Abs(referenceObj.eulerAngles.x) < 45 || 300 < Mathf.Abs(referenceObj.eulerAngles.x))
        {
            transform.localEulerAngles = horzPresentationRot;
            //transform.localEulerAngles = new Vector3(horzPresentationRot.x, yRotRef.localEulerAngles.y, horzPresentationRot.z);

            transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotRef.eulerAngles.y, transform.eulerAngles.z);
        }
        // If target image is standing up (vertical)
        else if (45 < Mathf.Abs(referenceObj.eulerAngles.x) && Mathf.Abs(referenceObj.eulerAngles.x) < 300)
        {
            transform.localEulerAngles = vertPresentationRot;
            //transform.localEulerAngles = new Vector3(vertPresentationRot.x, yRotRef.localEulerAngles.y, vertPresentationRot.z);

            //transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotRef.eulerAngles.y, transform.eulerAngles.z);
        }
        else
        {
            transform.localEulerAngles = Vector3.zero;

            //transform.eulerAngles = new Vector3(transform.eulerAngles.x, yRotRef.eulerAngles.y, transform.eulerAngles.z);
        }

        if (FindObjectOfType<DD_Debug>() && FindObjectOfType<DD_Debug>().debugText)
        {
            FindObjectOfType<DD_Debug>().debugText.text =
                "transform.eulerAngles.x : " + referenceObj.eulerAngles.x + "\n" + " " +
                "presentationObj.localEulerAngles : " + transform.localEulerAngles;
        }
    }
}