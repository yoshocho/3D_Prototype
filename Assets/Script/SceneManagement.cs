using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagement : MonoBehaviour
{

    //[SerializeField] Image m_fadePanel = null;

    //[SerializeField] float m_fadeTime = 2f;

    //[SerializeField] string restart = "";

    //[SerializeField] string title = "";

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PushButtonRestart()
    {
        SceneManager.LoadSceneAsync("GameScens");

    }
    public void PushButtonTitle()
    {
        SceneManager.LoadSceneAsync("title_scene");
    }

    //IEnumerator LoadSceneWithFadeRestart(float fadeTime)
    //{
    //    float timer = 0;
    //    Color panelColor = m_fadePanel.color;
    //    float alpha = 0;

    //    // フェード処理
    //    while (timer < fadeTime)
    //    {
    //        timer += Time.deltaTime;
    //        alpha += Time.deltaTime / m_fadeTime;
    //        panelColor.a = alpha;
    //        m_fadePanel.color = panelColor;
    //        yield return new WaitForEndOfFrame();
    //    }

    //    if (restart.Length > 0)
    //    {
    //        SceneManager.LoadSceneAsync(restart);
    //    }
    //}

    //IEnumerator LoadSceneWithFade(float fadeTime)
    //{
    //    float timer = 0;
    //    Color panelColor = m_fadePanel.color;
    //    float alpha = 0;

    //    // フェード処理
    //    while (timer < fadeTime)
    //    {
    //        timer += Time.deltaTime;
    //        alpha += Time.deltaTime / m_fadeTime;
    //        panelColor.a = alpha;
    //        m_fadePanel.color = panelColor;
    //        yield return new WaitForEndOfFrame();
    //    }

    //    if (restart.Length > 0)
    //    {
    //        SceneManager.LoadSceneAsync(title);
    //    }
    //}

}
