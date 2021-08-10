using UnityEngine;

[RequireComponent(typeof(Health))]
[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour, IDamageable
{
    private Health m_Health;

    private void Awake()
    {
        m_Health = GetComponent<Health>();
    }

    public void TakeDamage(float value)
    {
        m_Health.TakeDamage(value);
        if (!m_Health.HaveEnergy)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
