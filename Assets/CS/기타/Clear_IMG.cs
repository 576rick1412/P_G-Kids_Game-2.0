using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear_IMG : MonoBehaviour
{
    public GameObject[] clear_IMG;
    void Start()
    {
        for (int i = 0; i < clear_IMG.Length; i++)
        {
            clear_IMG[i].SetActive(false);
        }
        int clear = Random.Range(0, clear_IMG.Length);
        clear_IMG[clear].SetActive(true);
    }
}
