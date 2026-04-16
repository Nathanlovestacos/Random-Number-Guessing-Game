using Unity.VisualScripting;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void Easy()
    {
        GameController.instance.targetNumber = Random.Range(1, 6);
    }

    public void Normal()
    {
        GameController.instance.targetNumber = Random.Range(1, 11);
    }

    public void Hard()
    {
        GameController.instance.targetNumber = Random.Range(1, 51);
    }

    public void Impossible()
    {
        GameController.instance.targetNumber = Random.Range(1, 101);
    }
}
