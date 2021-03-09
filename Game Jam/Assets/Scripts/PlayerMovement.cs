using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;
    

    private Vector3 moveDirection;
    private CharacterController controller;
    private Animator anim;
    
    public int points=0;


    public bool end=false;
    [SerializeField] private GameObject panel;


    void Start()
    {
        
        controller = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }

    
    void Update()
    {
        Move();
        EndGame();
    }

    private void EndGame()
    {
        if (end)
        {
            panel.SetActive(true);
        }
    }

    private void Move()
    {
        
        float moveZ = Input.GetAxis("Vertical");
        float moveX = Input.GetAxis("Horizontal");

        moveDirection = new Vector3(moveX, 0, moveZ);
        moveDirection = transform.TransformDirection(moveDirection);

        if (moveDirection != Vector3.zero && !Input.GetKey(KeyCode.LeftShift))
        {
            Walk();
        }else if(moveDirection!=Vector3.zero && Input.GetKey(KeyCode.LeftShift))
        {
            Run();
        }else if (moveDirection == Vector3.zero)
        {
            Idle();
        }

        moveDirection *= moveSpeed;
        controller.Move(moveDirection * Time.deltaTime);
    }

    private void Idle()
    {
        anim.SetFloat("Speed", 0, 0.1f, Time.deltaTime);
    }

    private void Walk()
    {
        moveSpeed = walkSpeed;
        anim.SetFloat("Speed", 0.5f, 0.1f, Time.deltaTime);
    }

    private void Run()
    {
        moveSpeed = runSpeed;
        anim.SetFloat("Speed", 1f,0.1f,Time.deltaTime);
    }



}
