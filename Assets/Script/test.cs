using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[RequireComponent(typeof(PlayableDirector))]
public class test : MonoBehaviour
{
    private PlayableDirector _director = null;

    // Start is called before the first frame update
    void Start()
    {
        _director = GetComponent<PlayableDirector>();
    }

    public void PlayTimeline()
    {
        if(_director.playableAsset == null)
        {
            Debug.LogError("タイムラインをセットしてないよ");
            return;
        }

        _director.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            PlayTimeline();
        }
    }
}
