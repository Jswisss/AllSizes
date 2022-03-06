using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{

    public GameObject pausepanel;
    public GameObject ingameUI;
    private bool paused;

    // Start is called before the first frame update
    void Start()
    {
        pausepanel.SetActive(false);
}

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pausegame()
    {
        Time.timeScale = 0;
        ingameUI.SetActive(false);
        pausepanel.SetActive(true);
    }

    public void Resumegame()
    {
        Time.timeScale = 1;
        ingameUI.SetActive(true);
        pausepanel.SetActive(false);
    }

    public void quittoMain()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
