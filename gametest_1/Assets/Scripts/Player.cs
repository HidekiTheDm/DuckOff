using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Animator myAnimation;

    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
        myAnimation = GetComponentInChildren<Animator>();
    }
    public CharacterController controller;
    public float speed = 6f;
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        myAnimation.SetFloat("speed", vertical);

        if(direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }
    }
}
