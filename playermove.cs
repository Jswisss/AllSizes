using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class playermove : MonoBehaviour
{
    [SerializeField]
    private CharacterController controller;
    Rigidbody rb;
    [SerializeField]
    public Animator anim;

    //Movement variables
    [HideInInspector]
    public float horizontialMovement;
    float verticalMovement;
    public float runSpeed = 6.0f;
    bool jump = false;
    bool yMovement = false;
    private Camera cam;
    //bool fullScreen = false;
    bool playerMove = true;
    RigidbodyConstraints previous;
    public float jumpSpeed = 8.0f;
    private Vector3 moveDirection = Vector3.zero;

    private void Awake()
    {

        rb = this.gameObject.GetComponent<Rigidbody>();
        cam = Camera.main;
        previous = rb.constraints;
        controller = GetComponent<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            moveDirection.y = jumpSpeed;
        }

        moveDirection = new Vector3(CrossPlatformInputManager.GetAxisRaw("Horizontal"), 0.0f, CrossPlatformInputManager.GetAxisRaw("Vertical"));
        moveDirection *= runSpeed;

        controller.Move(moveDirection * Time.deltaTime);
    }


}
