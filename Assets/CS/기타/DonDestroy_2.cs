using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DonDestroy_2 : MonoBehaviour
{
    void Start()
    {
        var obj = FindObjectsOfType<DonDestroy_2>();
        if (obj.Length == 1){DontDestroyOnLoad(gameObject); return; }
        Destroy(gameObject);
    }
    private void Update()
    {
        SoundBox sound = GameObject.Find("소리담당김소드").GetComponent<SoundBox>();
        if (sound.Title == true)
        {
            Destroy(gameObject);
        }
    }
}
