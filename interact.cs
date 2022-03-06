using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class interact : MonoBehaviour
{
    private KeyCode level1;
    private KeyCode level2;
    

    // Start is called before the first frame update
    void Start()
    {
        level1 = KeyCode.Alpha1;
        level2 = KeyCode.Alpha2;
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void nextlevel()
    {
        SceneManager.LoadScene("level2");
    }
}
