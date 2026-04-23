using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        AudioManager.instance.PlaySFX(0);
    }

    void Update()
    {
        
    }

    public void StartGame()
    {
        AudioManager.instance.PlaySFX(1);
        SceneManager.LoadScene(2);

    }

    public void Setting()
    {
        AudioManager.instance.PlaySFX(1);
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        AudioManager.instance.PlaySFX(1);
        Application.Quit();
    }

}
