using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bread_Cheak : MonoBehaviour
{
    public int cheak_Num;
    public int target; // ���� ������Ʈ ��

    public GameObject Bread;
    public GameObject This_OBJ;

    public GameObject clear;
    public float Clear_time;
    public bool clearIN = false;
    void Start()
    {
        Bread.SetActive(false);
        cheak_Num = 0;
        clear.SetActive(false);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && clearIN == true)
        {
            SceneManager.LoadScene("Main_Scene");
        }
    }
    public void Clear_void()
    {
        if (cheak_Num >= target)
        {
            clearIN = true;
            Bread.SetActive(true);
            This_OBJ.SetActive(false);
            Debug.Log("Ŭ����");
            clear.SetActive(true);
            Sound_Clear();
            Invoke("end_clear", Clear_time);
        }
    }
    public void end_clear()
    {
        clear.SetActive(false);
    }
    public void Sound_Clear()
    {
        SoundBox sound = GameObject.Find("�Ҹ�����ҵ�").GetComponent<SoundBox>();
        sound.Clear();
    }
}
