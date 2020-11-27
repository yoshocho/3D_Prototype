using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
    public class GrapplingTargetController : MonoBehaviour
    {
       bool m_isTargetable = false;

    public bool IsHookable
    {
        get { return m_isTargetable; }
    }

    private void OnBecameInvisible()
    {
        m_isTargetable = true;
    }

    private void OnBecameVisible()
    {
        m_isTargetable = false;
    }

}

