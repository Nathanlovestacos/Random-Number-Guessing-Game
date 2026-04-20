using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixerGroup masterVolume;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        volumeSlider.value = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Volume()
    {

    }

}
