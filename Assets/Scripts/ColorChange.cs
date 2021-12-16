using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    
    public Material material1;
    public Material material2;
    public float transitionTime = 1f;


    void OnCollisionEnter (Collision collision) {
        gameObject.GetComponent<MeshRenderer>().material = material2;
    }


    void OnCollisionExit () {
        gameObject.GetComponent<MeshRenderer>().material.Lerp(gameObject.GetComponent<MeshRenderer>().material, material1, Time.deltaTime * transitionTime); 
    }

    private void Update() {
        OnCollisionExit();
    }
}