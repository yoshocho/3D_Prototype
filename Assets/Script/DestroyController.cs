using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour
{
    //[SerializeField] public GameObject targetObject = null;
    [SerializeField] float DestructionTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, DestructionTime);
       // this.transform.LookAt(targetObject, transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
