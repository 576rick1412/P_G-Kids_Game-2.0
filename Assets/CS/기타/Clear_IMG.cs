using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Clear_IMG : MonoBehaviour
{
    public int clear;
    public GameObject[] clear_IMG;
    void Start()
    {
        //SoundBox sound = GameObject.Find("소리담당김소드").GetComponent<SoundBox>();
        for (int i = 0; i < clear_IMG.Length; i++)
        {
            clear_IMG[i].SetActive(false);
        }
        clear = Random.Range(0, 3);
        clear_IMG[clear].SetActive(true);
    }
}
