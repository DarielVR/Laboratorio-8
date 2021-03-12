using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActions : MonoBehaviour
{
    public Camera cam;
    public GameObject lintern;
    public Text text;

    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            lintern.SetActive(!lintern.activeSelf);
            GetComponent<AudioSource>().Play();
        }

        ObjectInfo();
    }

    private void ObjectInfo() {
        RaycastHit hitInfo;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo)){
            if(hitInfo.collider.tag != "Untagged"){
                text.text = hitInfo.collider.tag;
            } else {
                text.text = null;
            }
        }
    }
}
