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
    public void BreadGame_Scene()
    {
        SceneManager.LoadScene("BreadGame_Hub");
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
    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(0.4f);
    }
}