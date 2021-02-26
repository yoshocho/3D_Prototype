using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPcontroller : MonoBehaviour
{
    /// <summary>
    /// 最大HP
    /// </summary>
    [SerializeField] int maxHP = 100;

    //[SerializeField] int maxMP = 100;

    /// <summary>
    /// 現在のHP
    /// </summary>
    int HP = 0;

    //int MP = 0;


    /// <summary>
    /// シリンダー（HPバー）をセット
    /// </summary>
    public Slider HPbar;

    //public Slider MPbar;

    void Start()
    {
        ///シリンダーの量をマックスにし、最大HPを現在のHPに入れる
        HPbar.value = 1;

        //MPbar.value = 1;

        HP = maxHP;

        //MP = maxMP;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "HeelItem" && Input.GetKey(""))
        {
            HP = HP += 40;

            HPbar.value = (float)HP / (float)maxHP;
        }

    }

    // Update is called once per frame
    /// <summary>
    /// Enemyタグのものに触れるとHPを減らす
    /// </summary>
    /// <param name="collision">敵の接触</param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            ///攻撃を受けたらノックバックする
            var knock = GetComponent<Rigidbody>();
            knock.AddForce(-transform.forward * 20f, ForceMode.VelocityChange);

            int damege = 10;

            Debug.Log("atata");

            ///ダメージを現在のHPから減らす
            HP = HP - damege;

            ///HPをシリンダーに反映させる
            HPbar.value = (float)HP / (float)maxHP;

        }
        
    }
   

}
