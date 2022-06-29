using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBox : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip clear;
    public AudioClip right;
    public AudioClip wrong;
    public AudioClip button;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void Clear()
    {
        audioSource.clip = clear;
        audioSource.Play();
    }
    public void Right()
    {
        audioSource.clip = right;
        audioSource.Play();
    }
    public void Wrong()
    {
        audioSource.clip = wrong;
        audioSource.Play();
    }
    public void Button()
    {
        audioSource.clip = button; 
        audioSource.Play();
    }
}
