using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitEffect : MonoBehaviour
{
    Transform m_player = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Canvas canvas;

    // Update is called once per frame
    void Update()
    {
       

        canvas.transform.rotation = Camera.main.transform.rotation;
        Destroy(this.gameObject, 1f);
    }

}
