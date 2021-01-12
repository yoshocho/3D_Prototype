using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageUI : MonoBehaviour
{
    /// <summary>
    /// テキストをセット
    /// </summary>
    private test damageText;
    /// <summary>
    /// ゆっくり消えてくスピード
    /// </summary>
    private float fadespeed = 1f;

    [SerializeField] private float moveSpeed = 0.4f;


    // Start is called before the first frame update
    void Start()
    {
        damageText = GetComponentInChildren<test>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Camera.main.transform.rotation;
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;

    }
}
