using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Apple_Button : MonoBehaviour
{
    public bool clearIN = false;
    public GameObject clear;
    public float Clear_time;
    private void Start()
    {
        clear.SetActive(false);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && clearIN == true)
        {
            SceneManager.LoadScene("Main_Scene");
        }
    }
    public void Right_B()
    {
        Debug.Log("�ߺ�!! ����");
        clear_void();
    }
    public void False_B()
    {
        SoundBox sound = GameObject.Find("�Ҹ�����ҵ�").GetComponent<SoundBox>();
        sound.Wrong();
        Debug.Log("�ߺ�!! ����");
    }

    public void clear_void()
    {
        clearIN = true;
        clear.SetActive(true);
        Debug.Log("Ŭ����"); Sound_Clear();
        Invoke("Clear_Timer", Clear_time);
    }
    public void Clear_Timer()
    {
        clear.SetActive(false);
    }
    public void Sound_Clear()
    {
        SoundBox sound = GameObject.Find("�Ҹ�����ҵ�").GetComponent<SoundBox>();
        sound.Clear();
    }
}