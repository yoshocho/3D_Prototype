using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class lock_on_manager : MonoBehaviour
{
    [SerializeField] float m_targetRange = 5f;

    List<LockOnController> m_targets = new List<LockOnController>();

    LockOnController m_target;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (!player) return;
        m_targets.Clear();
        // 現在のターゲットから画面から消えた、または射程距離外に外れたら、ターゲットを消す
        if (m_target && (!m_target.IsHookable || Vector3.Distance(m_target.transform.position, player.transform.position) > m_targetRange))
        {
            m_target = null;
            Debug.Log("target lost.");
        }

        // 画面に映っている、かつ射程距離内にある GrapplingTarget を全て取得し、リストに入れる
        LockOnController[] targets = transform.GetComponentsInChildren<LockOnController>();
        foreach (LockOnController t in targets)
        {
            if (t.IsHookable && Vector3.Distance(player.transform.position, t.transform.position) < m_targetRange)
            {
                m_targets.Add(t);
            }
        }

        // 現在のターゲットがない時は、一番近いものをターゲットとする
        if (!m_target && m_targets.Count > 0)
        {
            m_target = m_targets.OrderBy(target =>
            {
                return Vector3.Distance(player.transform.position, target.transform.position);
            }).First();
           // m_crosshair.GetComponent<Animator>().Play("CrosshairTargeted"); // アニメーションを再生する
            //if (m_cursorSfx)
            //{
            //    m_audio.PlayOneShot(m_cursorSfx);
            //}
            //Debug.Log(m_target.name + " is current target");
        }
    }

//    Vector3 Posi()
//    {
//        return m_target();
//    }
}
