using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_manager : MonoBehaviour
{

    [SerializeField] GameObject menuObj = null;
    int munu_count = 1;
    int mouse_count = 1;
    // Start is called before the first frame update
    void Start()
    {
        menuObj.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("change"))
        {
            munu_count += 1;
        }

        if (munu_count % 2 == 0)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            menuObj.SetActive(true);
            Time.timeScale = 0f;

        }
        else
        {
            menuObj.SetActive(false);
            Time.timeScale = 1f;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        //if (Input.GetButtonDown("mouse"))
        //{
        //    mouse_count += 1;
        //}

        //if (mouse_count % 2 == 0)
        //{
        //    Cursor.visible = true;
        //    Cursor.lockState = CursorLockMode.None;

        //}
        //else
        //{
        //    Cursor.visible = false;
        //    Cursor.lockState = CursorLockMode.Locked;

        //}

    }
}
