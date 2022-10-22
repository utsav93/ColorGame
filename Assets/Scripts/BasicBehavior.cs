using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBehavior : MonoBehaviour
{
    private SpriteRenderer m_spriteRenderer;
    void Start()
    {
        m_spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void Update()
    {
        m_spriteRenderer.color = Color.Lerp(Color.red, Color.green, Mathf.PingPong(Time.time, 1));
    }
}
