using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Volume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }


    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Play()
    {
        SceneManager.LoadScene(2);
    }

}
