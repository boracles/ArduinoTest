using System;
using UnityEngine;

public class SampleMessageListener : MonoBehaviour
{
    private Rigidbody rigidbody;
    public bool isGround;


    public float jumpPower = 1.5f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    
    public void OnMessageArrived(string msg)
    {
        Debug.Log(msg);
        if (msg == "1" && isGround)
        {
            rigidbody.AddForce(Vector3.up*jumpPower, ForceMode.Impulse);
        }
    }
    
    void OnConnectionEvent(bool success)
    {
        if (success)
            Debug.Log("Connection established");
        else
            Debug.Log("Connection attempt failed or disconnection detected");
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("GROUND"))
        {
            isGround = true;
        }
        else
        {
            isGround = false;
        }
    }
}
