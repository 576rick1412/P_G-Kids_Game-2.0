using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hub_Button : MonoBehaviour
{
    public void Puzzle_Stage_01()
    {
        SceneManager.LoadScene("PuzzleGame_1");
    }

    public void Puzzle_Stage_02()
    {
        SceneManager.LoadScene("PuzzleGame_2");
    }

    public void Puzzle_Stage_03()
    {
        SceneManager.LoadScene("PuzzleGame_3");
    }

    public void Medic_Stage_01()
    {
        SceneManager.LoadScene("MedicGame_1");
    }

    public void Medic_Stage_02()
    {
        SceneManager.LoadScene("MedicGame_2");
    }

    public void Medic_Stage_03()
    {
        SceneManager.LoadScene("MedicGame_3");
    }

    public void Apple_Stage_01()
    {
        SceneManager.LoadScene("AppleGame_1");
    }

    public void Apple_Stage_02()
    {
        SceneManager.LoadScene("AppleGame_2");
    }

    public void Apple_Stage_03()
    {
        SceneManager.LoadScene("AppleGame_3");
    }

    public void Animal_Stage_01()
    {
        SceneManager.LoadScene("AnimalGame_1");
    }

    public void Animal_Stage_02()
    {
        SceneManager.LoadScene("AnimalGame_2");
    }

    public void Animal_Stage_03()
    {
        SceneManager.LoadScene("AnimalGame_3");
    }
}
