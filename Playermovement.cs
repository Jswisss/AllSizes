using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Playermovement : MonoBehaviour
{
    public Joystick joystick;
   // protected joybutton joybutton;
    public Button jumpbutton;
    protected bool jump;
    private Animator player;
    
    // Start is called before the first frame update
    void Start()
    {
        //joystick = FindObjectOfType<Joystick>();
        //joybutton = FindObjectOfType<joybutton>();
        player = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = this.gameObject.GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal * 100f, rigidbody.velocity.y, joystick.Vertical * 100f);

        if(CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            jump = true;
            rigidbody.velocity += Vector3.up*6;
            player.Play("Jump");
        }

        if(CrossPlatformInputManager.GetButtonUp("Jump"))
        {
            jump = false;
        }
    }


}
