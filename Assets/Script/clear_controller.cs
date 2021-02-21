using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clear_controller : MonoBehaviour
{
    [SerializeField] string m_sceneToBeLoaded = "";
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadSceneAsync(m_sceneToBeLoaded);
        }
    }

}
