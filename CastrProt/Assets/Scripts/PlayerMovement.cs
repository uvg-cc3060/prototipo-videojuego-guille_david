using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        if (change != Vector3.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
        }
    }

    void MoveCharacter()
    {
        myRigidbody.MovePosition(
            transform.position + change * speed * Time.deltaTime
        );
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Option1"))
        {
            SceneManager.LoadScene("MenuCong", LoadSceneMode.Additive);
        }
        else if (collision.tag.Equals("Option2"))
        {
            SceneManager.LoadScene("Menu2");
        }
    }


}
