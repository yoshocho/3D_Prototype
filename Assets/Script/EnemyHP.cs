﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyController : MonoBehaviour
{
    /// <summary>
    /// 敵の最大HP
    /// </summary>
    [SerializeField] int maxHP = 100;
    /// <summary>
    /// クリティカルダメージ的な物をやろうとしましたが失敗、未使用
    /// </summary>
    [SerializeField] int Probabilitydamage = 20;
    /// <summary>
    /// 敵の死亡アニメーション
    /// </summary>
    [SerializeField] GameObject m_enemydeath = null;
    /// <summary>
    /// ダメージを喰らった時のエフェクト
    /// </summary>
    [SerializeField] GameObject DamegeEffect = null;
    /// <summary>
    /// 現在の敵のHP
    /// </summary>
    int HP = 0;

    //[SerializeField] float DeathTime = 2f;

    Animator m_anim;

    [SerializeField] public GameObject EnemyDamageUI;
    Transform enemyCanvas;
    public Slider Slider;
    GrapplingPlayerController m_gp;

    // Start is called before the first frame update
    void Start()
    {
        Slider.value = 1;

        HP = maxHP;

        m_gp = FindObjectOfType<GrapplingPlayerController>();

        m_anim = GetComponent<Animator>();

    }

    public Canvas canvas;

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "PlayerAttack")
        {

            if (DamegeEffect)
            {
                Instantiate(DamegeEffect, this.transform.position, DamegeEffect.transform.rotation);
            }

            Slider.gameObject.SetActive(true);
            //int damege = 20;

            HP = HP - m_gp.m_atackDamage;
            Slider.value = (float)HP / (float)maxHP;

            //ダメージを受けるとダメージ数を出すUI
            enemyCanvas = GameObject.FindGameObjectWithTag("EnemyCanvas").transform;
            //Instantiate<GameObject>(EnemyDamageUI, collision.bounds.center, Quaternion.identity);
            var UI = Instantiate(EnemyDamageUI, collision.bounds.center, Quaternion.identity);
            UI.transform.SetParent(enemyCanvas.transform);
            Debug.Log(EnemyDamageUI);


            ///HPが0になると
            if (HP == 0)
            {
                /// 敵が消滅し、死亡アニメーションをプレハブから呼び、敵の位置に配置(2Dシューティングで先生がやっていたこと)
                //if (m_enemydeath)
                //{
                //    Instantiate(m_enemydeath, this.transform.position, m_enemydeath.transform.rotation);
                //}
                if (m_anim)
                {
                    m_anim.SetTrigger("Death");
                }
                StartCoroutine(Death());
                Debug.Log("コルーチン開始");
            }
        }
    }

    IEnumerator Death()
    {  

        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
        Debug.Log("破棄");
    }

    // Update is called once per frame
    void Update()
    {
        ///敵のキャンバスを常にメインカメラに向かせる
        canvas.transform.rotation = Camera.main.transform.rotation;
    }
}
