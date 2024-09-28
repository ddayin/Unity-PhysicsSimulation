using UnityEngine;

public class AddForceToCube : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    public float force = 10f;

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
        m_Rigidbody.AddForce(0, 0, force, ForceMode.Impulse);
    }
}
