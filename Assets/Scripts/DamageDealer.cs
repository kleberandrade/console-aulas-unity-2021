public class DamageDealer : TriggerPool<IDamageable>
{
    public float m_Damage = 2.0f;

    private void LateUpdate()
    {
        CleanNullItems();
        foreach (var item in m_TriggerList)
        {
            item.TakeDamage(m_Damage);
        }        
    }
}
