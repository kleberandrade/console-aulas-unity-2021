using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ChangeColor))]
public class Blink : MonoBehaviour
{
    public float m_Interval = 0.3f;
    private ChangeColor m_ChangeColor;
    private Color m_Color;

    private void Start()
    {
        m_ChangeColor = GetComponent<ChangeColor>();
        m_Color = m_ChangeColor.GetCurrentColor();
        Play();
    }

    public void Play()
    {
        InvokeRepeating("Blinking", 0.0f, m_Interval);
    }

    public void Blinking()
    {
        if (m_ChangeColor.GetCurrentColor() == m_Color)
        {
            m_ChangeColor.ApplyColor(Color.white) ;
        }
        else
        {
            m_ChangeColor.ApplyColor(m_Color);
        }   
    }

    private void Stop()
    {
        CancelInvoke("Blinking");
        m_ChangeColor.ApplyColor(m_Color);
    }
}
