using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class nav_controller : MonoBehaviour
{

    public GameObject player; //プレイヤー
    public NavMeshAgent agent; 
    public float distance; //プレイヤーと敵の距離
    [SerializeField] Animator m_animator;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();　
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

        //距離を計算して一定値になれば追跡する
        distance = Vector3.Distance(transform.position, player.transform.position);
        //Debug.Log(distance);

        if (distance < 5)
        {

            agent.destination = player.transform.position; 
        }
        if (m_animator)
        {
            m_animator.SetFloat("Speed", agent.velocity.magnitude);
        }
    }
}
