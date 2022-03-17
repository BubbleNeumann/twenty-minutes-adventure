using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    [Range(0, .3f)][SerializeField] private float m_MovementSmoothing = .05f;
    public Animator animator;

    private Rigidbody2D m_Rigidbody2D;

    private Vector3 m_Velocity = Vector3.zero;
    float horizontalMove = 0f;

    float walkSpeed = 8f;

    void Move(float move)
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
        // Move the character by finding the target velocity
        Vector3 targetVelocity = new Vector2(move * 10f, m_Rigidbody2D.velocity.y);
        // And then smoothing it out and applying it to the character
        m_Rigidbody2D.velocity = Vector3.SmoothDamp(m_Rigidbody2D.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * walkSpeed;
    }


    void FixedUpdate()
    {
        Move(horizontalMove * Time.fixedDeltaTime);
    }
}
