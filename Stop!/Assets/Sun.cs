using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public float m_speed;
    private void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(m_speed * Time.deltaTime, 0, 0);
    }
}
