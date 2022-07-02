using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hub_Button : MonoBehaviour
{
    // ===========<�������>===========
    public void Puzzle_Stage_01()
    {
        Sound_USE();
        SceneManager.LoadScene("PuzzleGame_1");
    }

    public void Puzzle_Stage_02()
    {
        Sound_USE();
        SceneManager.LoadScene("PuzzleGame_2");
    }

    public void Puzzle_Stage_03()
    {
        Sound_USE();
        SceneManager.LoadScene("PuzzleGame_3");
    }
    // ===========<�˾����>===========
    public void Medic_Stage_01()
    {
        Sound_USE();
        SceneManager.LoadScene("MedicGame_1");
    }

    public void Medic_Stage_02()
    {
        Sound_USE();
        SceneManager.LoadScene("MedicGame_2");
    }

    public void Medic_Stage_03()
    {
        Sound_USE();
        SceneManager.LoadScene("MedicGame_3");
    }
    // ===========<�������>===========
    public void Apple_Stage_01()
    {
        Sound_USE();
        SceneManager.LoadScene("AppleGame_1");
    }

    public void Apple_Stage_02()
    {
        Sound_USE();
        SceneManager.LoadScene("AppleGame_2");
    }

    public void Apple_Stage_03()
    {
        Sound_USE();
        SceneManager.LoadScene("AppleGame_3");
    }
    // ===========<��������>===========
    public void Animal_Stage_01()
    {
        Sound_USE();
        SceneManager.LoadScene("AnimalGame_1");
    }

    public void Animal_Stage_02()
    {
        Sound_USE();
        SceneManager.LoadScene("AnimalGame_2");
    }

    public void Animal_Stage_03()
    {
        Sound_USE();
        SceneManager.LoadScene("AnimalGame_3");
    }
    // ===========<�𷡰���>===========
    public void Sand_Stage_01()
    {
        Sound_USE();
        SceneManager.LoadScene("SandGame_1");
    }
    public void Sand_Stage_02()
    {
        Sound_USE();
        SceneManager.LoadScene("SandGame_2");
    }
    public void Sand_Stage_03()
    {
        Sound_USE();
        SceneManager.LoadScene("SandGame_3");
    }
    // ===========<���װ���>===========
    public void Bread_Stage_01()
    {
        Sound_USE();
        SceneManager.LoadScene("BreadGame_1");
    }
    public void Bread_Stage_02()
    {
        Sound_USE();
        SceneManager.LoadScene("BreadGame_2");
    }
    public void Bread_Stage_03()
    {
        Sound_USE();
        SceneManager.LoadScene("BreadGame_3");
    }
    public void Sound_USE()
    {
        SoundBox sound = GameObject.Find("�Ҹ�����ҵ�").GetComponent<SoundBox>();
        sound.Button();
    }
}
