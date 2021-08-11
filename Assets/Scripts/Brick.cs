using UnityEngine;

public class Brick : MonoBehaviour
{
    public float m_Rate = 0.3f;
    public float m_Angle = 45.0f;

    private void Start()
    {
        Rotate();
        Destroy();
    }

    private void Rotate()
    {
        float angle = Random.Range(-m_Angle, m_Angle);
        transform.Rotate(Vector3.forward * angle);
    }

    private void Destroy()
    {
        if (Random.Range(0.0f, 1.0f) < m_Rate)
        {
            Destroy(gameObject);
        }
    }
}
