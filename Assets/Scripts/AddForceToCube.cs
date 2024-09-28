using UnityEngine;

public class AddForceToCube : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    public Vector3 m_Force = Vector3.zero;

    private void Awake()
    {
        m_Rigidbody = transform.GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Force();
    }


    public void Force()
    {
        m_Rigidbody.AddForce(m_Force, ForceMode.Impulse);
    }
}
