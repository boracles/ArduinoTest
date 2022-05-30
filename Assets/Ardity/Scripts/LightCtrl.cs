using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class LightCtrl : MonoBehaviour
{
   public Light dirLight;

    void Start()
    {
    }
    //
    // void Update()
    // {
    //     float _intensity = (1-(float.Parse(serialCtrl.message)/780));
    //     dirLight.intensity = _intensity;
    //     Debug.Log( $"조도 = {_intensity}");
    // }
}
