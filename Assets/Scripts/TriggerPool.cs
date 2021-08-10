using System.Collections.Generic;
using UnityEngine;

public class TriggerPool<T> : MonoBehaviour
{
    protected List<T> m_TriggerList = new List<T>();

    protected void OnTriggerEnter(Collider other)
    {
        var go = other.GetComponent<T>();
        if (go == null) return;
        m_TriggerList.Add(go);
    }

    protected void OnTriggerExit(Collider other)
    {
        var go = other.GetComponent<T>();
        if (go == null) return;
        m_TriggerList.Remove(go);
    }

    protected void CleanNullItems()
    {
        m_TriggerList.RemoveAll(item => item == null);
    }
}
