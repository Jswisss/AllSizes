using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datasizer : MonoBehaviour
{

    public float mindata;
    public float maxdata;
    public float normalx;
    public float normalz;
    public float normaly;
    // Start is called before the first frame update
    void Start()
    {
        normalx = this.gameObject.transform.localScale.x;
        normaly = this.gameObject.transform.localScale.y;
        normalz = this.gameObject.transform.localScale.z;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
