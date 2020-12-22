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
    public Text Text;

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

            if (DamegeEffect)
            {
                Instantiate(DamegeEffect, this.transform.position, DamegeEffect.transform.rotation);
            }

            
            //クリティカルダメージ
            //int critical = Random.Range(1,10);

            int damege = 20;
            //if (critical / 2 == 0)
            //{
            //    HP = HP - damege;
            //    Slider.value = (float)HP / (float)maxHP;

            //}
            //else
            //{
            //    HP = HP - damege + Probabilitydamage;
            //    Debug.Log("クリティカル！");
            //    Slider.value = (float)HP / (float)maxHP;
            //}

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
