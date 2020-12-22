using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody), typeof(Animator))]
public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Vector3 velocity;
    [SerializeField] private float movespeed;


    Animator m_anim = null;
    Rigidbody m_rd = null;

    // Update is called once per frame
    private void Start()
    {
        m_anim = GetComponent<Animator>();
        m_rd = GetComponent<Rigidbody>();

    }
    void Update()
    {
        //キー操作
        velocity = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            velocity.z += 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x -= 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity.z -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x += 1;
        }

        velocity = velocity.normalized * movespeed * Time.deltaTime;

        if (velocity.magnitude > 0)
        {
            transform.position += velocity;

        }

    }
}
