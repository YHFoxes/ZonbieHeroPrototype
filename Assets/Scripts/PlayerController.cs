using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform playerTransform;
    private Animator animator;

    [SerializeField]
    private FloatingJoystick joystick;
    [SerializeField]
    private float speed;

    private void Awake()
    {
        playerTransform = GetComponent<Transform>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        animator.SetFloat("LeftRight", joystick.Horizontal);
        animator.SetFloat("ForwardBackward", joystick.Vertical);
        playerTransform.position += new Vector3(joystick.Vertical * -speed * Time.deltaTime, 0, joystick.Horizontal * speed * Time.deltaTime);
    }
}
