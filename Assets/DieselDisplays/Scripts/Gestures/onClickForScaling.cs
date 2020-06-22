using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class onClickForScaling : MonoBehaviour
{
    public List<Transform> objsToScale;

	void Update()
    {
        if(Input.GetMouseButton(0) || Input.GetMouseButton(1))
        for (int i = 0; i < objsToScale.Count; i++)
        {
           //Debug.Log("scale " + objsToScale[i]);
            CSharpscaling.Instance.Scale(objsToScale[i]);
        }
	}
}