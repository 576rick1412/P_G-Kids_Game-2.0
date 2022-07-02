using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI_Button : MonoBehaviour
{
    public void Hub_Scene()
    {
        Sound_USE();
        SceneManager.LoadScene("Main_Scene");
    }
    public void PuzzleGame_Scene()
    {
        Sound_USE();
        SceneManager.LoadScene("PuzzleGame_Hub");
    }
    public void BreadGame_Scene()
    {
        Sound_USE();
        SceneManager.LoadScene("BreadGame_Hub");
    }
    public void MedicGame_Scene()
    {
        Sound_USE();
        SceneManager.LoadScene("MedicGame_Hub");
    }

    public void AniamlGame_Scene()
    {
        Sound_USE();
        SceneManager.LoadScene("AnimalGame_Hub");
    }

    public void AppleGame_Scene()
    {
        Sound_USE();
        SceneManager.LoadScene("AppleGame_Hub");
    }

    public void SandGame_Scene()
    {
        Sound_USE();
        SceneManager.LoadScene("SandGame_Hub");
    }

    public void Main_Scene()
    {
        Sound_USE();
        SceneManager.LoadScene("Main_Scene");
    }
    public void goHome()
    {
        Sound_USE();
        SceneManager.LoadScene("Title_Scene");
    }
    public void goQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void Sound_USE()
    {
        SoundBox sound = GameObject.Find("소리담당김소드").GetComponent<SoundBox>();
        sound.Button();
    }
}