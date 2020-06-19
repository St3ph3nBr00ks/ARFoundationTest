using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DD_ARObjectPresentationManager : MonoBehaviour
{
    public Transform presentationObj;
    
    int i = 0;
    void Update()
    {
        if (FindObjectOfType<DD_Debug>().debugText)
        {
            //debugText.text = "transform.eulerAngles.x : " + transform.eulerAngles.x + " presentationObj.localEulerAngles : " + presentationObj.localEulerAngles;
        }

        if (Mathf.Abs(transform.eulerAngles.x) < 45 || 100 < Mathf.Abs(transform.eulerAngles.x))
        {

            if (FindObjectOfType<DD_Debug>().debugText)
            {
                FindObjectOfType<DD_Debug>().debugText.text = 
                    "transform.eulerAngles.x : " + transform.eulerAngles.x + "\n" + " " +
                    "presentationObj.localEulerAngles : " + presentationObj.localEulerAngles + "\n" + " " +
                    "rotate presentation obj " + i++;
            }
            presentationObj.localEulerAngles = new Vector3(-45,0,0); 
        }
        else
        {
            if (FindObjectOfType<DD_Debug>().debugText)
            {
                FindObjectOfType<DD_Debug>().debugText.text = " flatten presentation obj ";
            }
           // presentationObj.eulerAngles = Vector3.zero;
        }
    }
}