using UnityEngine;

[RequireComponent(typeof(ChangeColor))]
public class Colorable : MonoBehaviour, IColorable
{
    private Color m_SourceColor;
    private ChangeColor m_ChangeColor;

    private void Awake()
    {
        m_ChangeColor = GetComponent<ChangeColor>();
    }

    private void Start()
    {
        m_SourceColor = m_ChangeColor.GetCurrentColor();
    }

    public void Blend(Color blendColor, Vector3 position, float radius)
    {
        float distance = Vector3.Distance(transform.position, position);
        Color color = Color.Lerp(blendColor, m_SourceColor, distance / radius);
        m_ChangeColor.ApplyColor(color);
    }
}
