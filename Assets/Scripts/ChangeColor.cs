using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public bool m_ApplyOnAwake = true;
    public Color m_Color = Color.white;

    private Renderer m_Renderer;

    private void Awake()
    {
        m_Renderer = GetComponent<Renderer>();
        if (m_ApplyOnAwake)
        {
            ApplyColor(m_Color);
        }
    }

    public void ApplyColor(Color color)
    {
        m_Renderer.material.SetColor("_Color", color);
    }

    public Color GetCurrentColor()
    {
        return m_Renderer.material.color;
    }
}