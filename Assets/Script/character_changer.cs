using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityChan;

public class character_changer : MonoBehaviour
{
    [SerializeField] GameObject character_change = null;

    [SerializeField] GameObject character = null;

    int chra = 1;
    // Start is called before the first frame update
    void Start()
    {
        character_change.SetActive(true);
        character.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("change"))
        {
            chra += 1;
        }

        if (chra % 2 == 0)
        {
            character_change.SetActive(false);
            character.SetActive(true);
            character.transform.position = character_change.transform.position;

        }
        else
        {
            
            
            character_change.SetActive(true);
            character.SetActive(false);
            //character_change.transform.position = character.transform.position;
        }

    }
}
