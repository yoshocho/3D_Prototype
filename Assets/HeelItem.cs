using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeelItem : MonoBehaviour
{
    [SerializeField] GameObject TextObj = null;

    [SerializeField] int Heelpoint = 50;

    PlayerHPcontroller GPC;

    

    bool Isstay = false;
    // Start is called before the first frame update
    void Start()
    {
        TextObj.gameObject.SetActive(false);
        GPC = FindObjectOfType<PlayerHPcontroller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Isstay)
        {
            if (Input.GetKey("c"))
            {
                Debug.Log("Cキーが押された");
                GPC.HP += Heelpoint;
                GPC.HPheel(Heelpoint);
                Debug.Log($"{GPC.HP}, プレイヤーの体力");
            }

        }

    }


    //private void OnTriggerStay(Collider other)
    //{

    //    if (other.tag == "Player")
    //    {
    //        TextObj.gameObject.SetActive(true);
    //    }
       
    //}




    private void OnTriggerEnter(Collider other)
    {
       
        if (other.tag == "Player")
        {
            TextObj.gameObject.SetActive(true);
            Isstay = true;
           
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            Isstay = false;
            TextObj.gameObject.SetActive(false);
        }
    }
}
