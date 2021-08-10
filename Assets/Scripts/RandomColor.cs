using UnityEngine;

[RequireComponent(typeof(ChangeColor))]
public class RandomColor : MonoBehaviour
{
    [Range(0.0f, 1.0f)]
    public float m_RangeColor = 0.1f;

    private ChangeColor m_ChangeColor;

    private void Awake()
    {
        m_ChangeColor = GetComponent<ChangeColor>();
    }

    private void Start()
    {
        if (m_ChangeColor.m_ApplyOnAwake) {
            NextColor();
        }
    }

    public void NextColor()
    {
        float red = GetNextValue(m_ChangeColor.m_Color.r);
        float green = GetNextValue(m_ChangeColor.m_Color.g);
        float blue = GetNextValue(m_ChangeColor.m_Color.b);
        Color color = new Color(red, green, blue, 1.0f);
        m_ChangeColor.ApplyColor(color);
    }

    private float GetNextValue(float value)
    {
        value = value + Random.Range(-m_RangeColor, m_RangeColor);
        return Mathf.Clamp01(value);
    }
}
