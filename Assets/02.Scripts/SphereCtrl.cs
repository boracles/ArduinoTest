using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCtrl : MonoBehaviour
{
    public bool isGround;
    private RaycastHit hit;

    void Update()
    {
        CheckGround();
    }
    
    void CheckGround()
    {
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.2f))
        {
            if (hit.transform.tag == "GROUND")
            {
                isGround = true;
                Debug.Log("땅닿음");
            }
            else
            {
                isGround = false;
            }
        }
    }
}
