using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{

    Vector3 target = new Vector3(20, 2.5f, 1);
    float step;
    void Start(){
        
        step =  8*Time.deltaTime;
    }

    void FixedUpdate(){
        
        transform.localPosition = Vector3.MoveTowards(transform.localPosition, target, step);
        if(transform.localPosition.x>=19.9f)Destroy(gameObject);
    }
}
