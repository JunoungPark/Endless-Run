using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioSource audioSource;

    public AudioClip[] audioClip;
    // Start is called before the first frame update
    void Start()
    {   
        instance = this;
    }
    // Update is called once per frame
    public void SoundCall(string name)
    {
        switch (name)
        {
            case "Collision":
                audioSource.clip = audioClip[0];
                audioSource.Play();
                break;
            case "LevelDesign":
                audioSource.clip = audioClip[1];
                audioSource.Play();
                break;
            case "Move":
                audioSource.clip = audioClip[2];
                audioSource.Play();
                break;
        }
    }
}
