using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_manager : MonoBehaviour
{

    [SerializeField] GameObject menuObj = null;
    int count = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        menuObj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("change"))
        {
            count += 1;
        }

        if (count % 2 == 0)
        {
            menuObj.SetActive(true);
            Time.timeScale = 0f;

        }
        else
        {
            menuObj.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
