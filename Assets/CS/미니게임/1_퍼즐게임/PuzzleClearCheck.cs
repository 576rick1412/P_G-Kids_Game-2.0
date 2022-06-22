using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleClearCheck : MonoBehaviour
{
    public GameObject clear;
    public GameObject clearART;
    void Start()
    {
        clearART.SetActive(false);
        clear.SetActive(false);
    }

    void Update()
    {
        Puzzle_Manager check1 = GameObject.Find("1번자리").GetComponent<Puzzle_Manager>();
        Puzzle_Manager check2 = GameObject.Find("2번자리").GetComponent<Puzzle_Manager>();
        Puzzle_Manager check3 = GameObject.Find("3번자리").GetComponent<Puzzle_Manager>();
        Puzzle_Manager check4 = GameObject.Find("4번자리").GetComponent<Puzzle_Manager>();

        if (check1.cheak_Clear == true &&
           check2.cheak_Clear == true &&
           check3.cheak_Clear == true &&
           check4.cheak_Clear == true)
        {
            clearART.SetActive(true);
            clear.SetActive(true);
            Debug.Log("클리어");
        }
    }
}
