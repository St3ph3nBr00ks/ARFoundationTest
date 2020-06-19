using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DD_NullParent : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.SetParent(null);
    }

    // Update is called once per frame
    void Awake()
    {
        transform.SetParent(null);
    }
}
