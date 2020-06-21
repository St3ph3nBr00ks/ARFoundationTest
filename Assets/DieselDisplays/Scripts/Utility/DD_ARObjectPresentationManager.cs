using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DD_ARObjectPresentationManager : MonoBehaviour
{
    public Transform referenceObj;

    public List<GameObject> horzPresentationObjs;
    public List<GameObject> vertPresentationObjs;

    void Update()
    {
        // If target image is laying down (horizontal)
        if (Mathf.Abs(referenceObj.eulerAngles.x) < 45 || 300 < Mathf.Abs(referenceObj.eulerAngles.x))
        {
            for (int i = 0; i < vertPresentationObjs.Count; i++)
            {
                vertPresentationObjs[i].SetActive(false);
            }

            for (int i = 0; i < horzPresentationObjs.Count; i++)
            {
                horzPresentationObjs[i].SetActive(true);
            }
        }
        // If target image is standing up (vertical)
        else if (45 < Mathf.Abs(referenceObj.eulerAngles.x) && Mathf.Abs(referenceObj.eulerAngles.x) < 300)
        {
            for (int i = 0; i < horzPresentationObjs.Count; i++)
            {
                horzPresentationObjs[i].SetActive(false);
            }

            for (int i = 0; i < vertPresentationObjs.Count; i++)
            {
                vertPresentationObjs[i].SetActive(true);
            }
        }
        else
        {
            transform.localEulerAngles = Vector3.zero;
        }

        //if (FindObjectOfType<DD_Debug>() && FindObjectOfType<DD_Debug>().debugText)
        //{
        //    FindObjectOfType<DD_Debug>().debugText.text =
        //        "transform.eulerAngles.x : " + referenceObj.eulerAngles.x + "\n" + " " +
        //        "presentationObj.localEulerAngles : " + transform.localEulerAngles;
        //}
    }
}
