using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject mainmenu;
    public GameObject chamberSelect;


    public void startgame()
    {
        SceneManager.LoadScene("level1");
    }

    public void ActivateTC()
    {
        mainmenu.SetActive(false);
        chamberSelect.SetActive(true);
    }

    public void selectchamber(string levelname)
    {
        SceneManager.LoadScene(levelname);
    }

    public void returntoMain()
    {
        mainmenu.SetActive(true);
        chamberSelect.SetActive(false);
    }
}
