using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheels : MonoBehaviour
{
    float rotationSpeed = 600f;

    void Update(){
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
