using UnityEngine;


public class GravityMoon : MonoBehaviour
{
    public float m_MoonGravity = -1.62f;
    public Rigidbody m_Rigidbody;
    private Vector3 m_Force = Vector3.zero;
    
    void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.useGravity = false;

        m_Force = new Vector3(0f, m_MoonGravity, 0f);
        Physics.gravity = m_Force;
    }

    void FixedUpdate()
    {
        m_Rigidbody.AddForce(m_Force * m_Rigidbody.mass);
    }
}
