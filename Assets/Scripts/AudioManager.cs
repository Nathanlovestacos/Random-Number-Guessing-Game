using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] soundEffects;

    public static AudioManager instance;

    public void Awake()
    {
        instance = this;
    }

    public void PlaySFX(int sound)
    {
        soundEffects[sound].Play();
    }



}
