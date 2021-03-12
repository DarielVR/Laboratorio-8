using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRoom : MonoBehaviour
{
    Light lit;
    // Start is called before the first frame update
    void Start()
    {
        lit = GetComponent<Light>();
        lit.intensity = 0;
    }

    private void OnTriggerStay(Collider other) {
        lit.intensity = Mathf.Abs(Mathf.Sin(Time.time));
    }

    private void OnTriggerExit(Collider other) {
        lit.intensity = 0.0f;
    }
}
