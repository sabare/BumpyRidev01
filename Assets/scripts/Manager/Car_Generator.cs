using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Generator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject car;
    bool isRunning = false;


    // Update is called once per frame
    void Update()
    {

        if(!isRunning){isRunning  = true;StartCoroutine("gen");}
    }

    IEnumerator gen(){
        
        Vector3 pos = new Vector3(-20, 1f, 1);
        pos+=transform.position;
        Quaternion rotation = Quaternion.Euler(0f, 90f, 0f);
        GameObject go = Instantiate(car, pos, rotation);
        go.transform.parent = gameObject.transform;
        yield return new WaitForSeconds(5f);
        isRunning = false;
    }
}
