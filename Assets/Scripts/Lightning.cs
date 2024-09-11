using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    [SerializeField] float minTime = 0.5f;
    [SerializeField] float threshold = 0.5f;
    [SerializeField] Light light;
    private float lastTime = 0;

    private void Update(){
        if (Time.time - lastTime > minTime){
            if (Random.value > threshold){
                light.enabled = true;
                lastTime = Time.time; 
            } else {
                light.enabled = false;
                lastTime = Time.time; 
            }
        }
    }
}
