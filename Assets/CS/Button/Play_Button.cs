using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
public class Play_Button : MonoBehaviour
{
    public PlayableDirector LOGO_Anime; //타임라인 불러오기
    private int num = 0;
    private void Start()
    {
        num = 0;
    }
    void Update()
    {
        if (Input.anyKey && num == 0)
        {
            Sound_USE();
            LOGO_Anime.gameObject.SetActive(true);
            LOGO_Anime.Play(); num++;
            Invoke("late_b", 1.2f);
        }
    }
    private void late_b()
    {
        SceneManager.LoadScene("Main_Scene");
    }
    public void Sound_USE()
    {
        SoundBox sound = GameObject.Find("소리담당김소드").GetComponent<SoundBox>();
        sound.Button();
    }
}
