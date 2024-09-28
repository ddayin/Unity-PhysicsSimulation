using UnityEngine;


public class GravityMoon : MonoBehaviour
{
    public float m_MoonGravity = 0f;
    public Rigidbody m_Rigidbody;
    
    void Awake()
    {
        m_MoonGravity = -1.62f;

        m_Rigidbody = GetComponent<Rigidbody>();
        m_Rigidbody.useGravity = false;

        Physics.gravity = new Vector3(0f, m_MoonGravity, 0f);
    }
}
