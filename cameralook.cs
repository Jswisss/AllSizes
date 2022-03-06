using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameralook : MonoBehaviour
{
    public Camera MAIN;
    public GameObject area;
    // Start is called before the first frame update
    void Start()
    {
        MAIN.gameObject.transform.LookAt(area.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
