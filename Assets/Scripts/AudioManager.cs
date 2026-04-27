using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] soundEffects;

    public static AudioManager instance;

    private double audioChance = .25;

    public void Awake()
    {
        instance = this;
    }

    public void PlaySFX(int sound)
    {
        soundEffects[sound].Play();









}   }

