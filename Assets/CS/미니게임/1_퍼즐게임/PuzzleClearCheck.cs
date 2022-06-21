using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleClearCheck : MonoBehaviour
{
    public int max_int = 0;
    public int clear;
    public GameObject clearART;
    public GameObject[] clear_IMG;
    void Start()
    {
        clearART.SetActive(false);
        for(int i = 0;i<clear_IMG.Length;i++)
        {
            clear_IMG[i].SetActive(false);
        }
    }

    void Update()
    {
        Puzzle_Manager check1 = GameObject.Find("1���ڸ�").GetComponent<Puzzle_Manager>();
        Puzzle_Manager check2 = GameObject.Find("2���ڸ�").GetComponent<Puzzle_Manager>();
        Puzzle_Manager check3 = GameObject.Find("3���ڸ�").GetComponent<Puzzle_Manager>();
        Puzzle_Manager check4 = GameObject.Find("4���ڸ�").GetComponent<Puzzle_Manager>();

        if (check1.cheak_Clear == true &&
           check2.cheak_Clear == true &&
           check3.cheak_Clear == true &&
           check4.cheak_Clear == true)
        {
            clearART.SetActive(true);
            Debug.Log("Ŭ����");
            int clear = Random.Range(0, max_int);

            clear_IMG[clear].SetActive(true);

        }
    }
}
