using UnityEngine;
using System.Collections;

/**
 * When creating your message listeners you need to implement these two methods:
 *  - OnMessageArrived
 *  - OnConnectionEvent
 */
public class SampleMessageListener : MonoBehaviour
{
    public Light dirLight;
    
    public void OnMessageArrived(string msg)
    {
        //Debug.Log("Message arrived: " + msg);
        float _intensity = (1 - (float.Parse(msg) / 780));
        dirLight.intensity = _intensity;
        Debug.Log( $"조도 = {_intensity}");
    }

    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        if (success)
            Debug.Log("Connection established");
        else
            Debug.Log("Connection attempt failed or disconnection detected");
    }
}
