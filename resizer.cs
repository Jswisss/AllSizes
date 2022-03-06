using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class resizer : MonoBehaviour
{
    public GameObject shape = null;
    public GameObject child = null;
    public float resizespeed = 5.0f;
    public float min;
    public float max;

    Vector3 touchstart;

    void Update()
    {
        if(Input.touchCount==0)
        {
            // select and deselects object to be resized
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit isSelected;
            if(Physics.Raycast(ray, out isSelected))
            {
                if(isSelected.transform.gameObject.tag == "resizable")
                {
                shape = isSelected.transform.gameObject;
                    shape.GetComponent<Rigidbody>().isKinematic = false;
                    min = shape.gameObject.GetComponent<Datasizer>().mindata;
                    max = shape.gameObject.GetComponent<Datasizer>().maxdata;
                    child = shape.transform.GetChild(0).gameObject;
                child.gameObject.SetActive(true);
                }

            }
            if(Physics.Raycast(ray, out isSelected)== false)
            {
                shape.GetComponent<Rigidbody>().isKinematic = true;
                shape = null;
                child.gameObject.SetActive(false);
                child = null;
            }
        }


        if(Input.touchCount ==2)
        {
            //calculates the distance between fingers
            Touch touchzero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);
            Vector2 touchzeroPrevpos = touchzero.position - touchzero.deltaPosition;
            Vector2 touchOnePrevpos = touchOne.position - touchOne.deltaPosition;

            float prevsize = (touchzeroPrevpos - touchOnePrevpos).magnitude;
            float currentSize = (touchzero.position - touchOne.position).magnitude;

            float difference = currentSize - prevsize;
            resize(difference * .01f);
        }

        //resize(Input.GetAxis("Mouse ScroolWheel"));
    }

    void resize(float increment)
    {
        // resizes objects
        if(shape.transform.localScale.x<=min || shape.transform.localScale.x>=max)
        {
            if(shape.transform.localScale.x >= max && increment<0)
            {
                shape.transform.localScale += new Vector3(increment, increment, increment);
            }
            if(shape.transform.localScale.x <= min && increment > 0)
            {
                shape.transform.localScale += new Vector3(increment, increment, increment);
            }
            else if(shape.transform.localScale.x >= max)
            {
                //shape.transform.localScale = new Vector3(max, max, max);
            }
            else if (shape.transform.localScale.x <= min)
            {
                //shape.transform.localScale = new Vector3(min, min, min);
            }
        }
        else
        {
            shape.transform.localScale += new Vector3(increment, increment, increment);
        }
    }
}
