using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyHP : MonoBehaviour
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

    [SerializeField] public GameObject EnemyDamageUI;

    public Slider Slider;

    // Start is called before the first frame update
    void Start()
    {
        Slider.value = 1;

        HP = maxHP;

        
    }

    public Canvas canvas;

    private void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "PlayerAttack")
        {
            Slider.gameObject.SetActive(true);
            if (DamegeEffect)
            {
                Instantiate(DamegeEffect, this.transform.position, DamegeEffect.transform.rotation);
            }
            //ダメージを受けるとダメージ数を出すUI
            var UI = Instantiate<GameObject>(EnemyDamageUI, collision.bounds.center, Quaternion.identity);
            
            //クリティカルダメージ

            int damege = 20;
           
            HP = HP - damege;
            Slider.value = (float)HP / (float)maxHP;

            ///HPが0になると
            if (HP == 0)
            {
               /// 敵が消滅し、死亡アニメーションをプレハブから呼び、敵の位置に配置(2Dシューティングで先生がやっていたこと)
                if (m_enemydeath)
                {
                    Instantiate(m_enemydeath, this.transform.position, m_enemydeath.transform.rotation);
                }
                Destroy(this.gameObject);
            }
           

        }
    }
    
    // Update is called once per frame
    void Update()
    {
        ///敵のキャンバスを常にメインカメラに向かせる
        canvas.transform.rotation = Camera.main.transform.rotation;
    }
}
