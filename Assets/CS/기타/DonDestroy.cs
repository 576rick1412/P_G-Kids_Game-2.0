using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonDestroy : MonoBehaviour
{
    void Start()
    {
        var obj = FindObjectsOfType<DonDestroy>();
        if (obj.Length == 1){DontDestroyOnLoad(gameObject); return; }
        Destroy(gameObject);
    }
}
