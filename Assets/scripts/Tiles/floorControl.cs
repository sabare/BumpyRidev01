using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorControl : MonoBehaviour
{
    // Start is called before the first frame update
    float speed;

    // Update is called once per frame
    void Update()
    {
        speed = GameObject.Find("ScoreManager").GetComponent<floorSpeedctrl>().speed;
        transform.position += Vector3.forward * speed * Time.deltaTime; 

    }
}
