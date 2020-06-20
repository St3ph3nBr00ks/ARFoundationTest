using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DD_AttachToMainCamera : MonoBehaviour
{
    private void Start()
    {
        AttachToMainCamera();
    }

    private void Awake()
    {
        AttachToMainCamera();
    }

    private void AttachToMainCamera()
    {
        if (Camera.main != null)
        {
            transform.SetParent(Camera.main.transform);
            transform.transform.SetPositionAndRotation(Camera.main.transform.position, Camera.main.transform.rotation);
        }
    }
}
