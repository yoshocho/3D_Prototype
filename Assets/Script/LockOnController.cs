using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class LockOnController : MonoBehaviour
{
    bool m_isTargetable = false;

    /// <summary>
    /// オブジェクトが画面内にあるかどうかを返す
    /// </summary>
    public bool IsHookable
    {
        get { return m_isTargetable; }
    }

    private void OnBecameVisible()
    {
        m_isTargetable = true;
    }

    private void OnBecameInvisible()
    {
        m_isTargetable = false;
    }
}
