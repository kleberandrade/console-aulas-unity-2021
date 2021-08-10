using UnityEngine;

public class Painter : TriggerPool<IColorable>
{
    public Color m_Color = Color.white;
    public float m_Radius = 4.0f;
    [Space(10)]
    [Header("Debug")]
    [Range(0.0f, 1.0f)]
    public float m_Opacity = 0.1f;
    private SphereCollider m_Collider;

    private void Start()
    {
        m_Collider = GetComponent<SphereCollider>();
        m_Collider.isTrigger = true;
    }

    private void LateUpdate()
    {
        m_Collider.radius = m_Radius;
        CleanNullItems();
        foreach (var item in m_TriggerList)
        {
            item.Blend(m_Color, transform.position, m_Radius);
        }
    }   

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(m_Color.r, m_Color.g, m_Color.b, m_Opacity);
        Gizmos.DrawSphere(transform.position, m_Radius);
    }
}
