using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioManager.instance.PlaySFX(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        AudioManager.instance.PlaySFX(1);
        SceneManager.LoadScene(1);

    }

    public void Setting()
    {
        AudioManager.instance.PlaySFX(1);
    }

    public void Quit()
    {
        AudioManager.instance.PlaySFX(1);
        Application.Quit();
    }

}
