using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI_Button : MonoBehaviour
{
    public void Hub_Scene()
    {
        SceneManager.LoadScene("Main_Scene");
    }
    public void PuzzleGame_Scene()
    {
        SceneManager.LoadScene("PuzzleGame_Hub");
    }

    public void MedicGame_Scene()
    {
        SceneManager.LoadScene("MedicGame_Hub");
    }

    public void AniamlGame_Scene()
    {
        SceneManager.LoadScene("AnimalGame_Hub");
    }

    public void AppleGame_Scene()
    {
        SceneManager.LoadScene("AppleGame_Hub");
    }

    public void SandGame_Scene()
    {
        SceneManager.LoadScene("SandGame_Hub");
    }

    public void Main_Scene()
    {
        SceneManager.LoadScene("Main_Scene");
    }
    public void goHome()
    {
        SceneManager.LoadScene("Title_Scene");
    }
    public void Setting()
    {
        Debug.Log("세팅 눌림");
    }
    public void goQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
    public void MedicQues_1()
    {
        Debug.Log("물음표11");
    }
}