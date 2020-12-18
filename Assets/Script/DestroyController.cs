using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour
{
    [SerializeField] float DestructionTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, DestructionTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
