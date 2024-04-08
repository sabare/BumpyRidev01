using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpinner : MonoBehaviour
{
    // Start is called before the first frame update

    float rotationSpeed = -150f;


    void Update(){
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
