using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movementSpeed = 0f;
    Rigidbody rb;
    public float gain = 0.3f;
    public float loss = 0.2f;
    bool inActive = true;
    public Animator anim;
    private void Awake(){

        rb = GetComponent<Rigidbody>();   
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // if(Input.touchCount>0){

        //     Touch touch  = Input.GetTouch(0);
        //     //Debug.Log(touch.position);
        // }

        if(GameObject.Find("ScoreManager").GetComponent<ScoreUpdate>().life == 0)movementSpeed=0;
        
        else if(GameObject.Find("ScoreManager").GetComponent<floorSpeedctrl>().speed>-2.5f)movementSpeed = 0;
        else {

        
            if(Input.GetKey("right") || (Input.touchCount>0 && Input.GetTouch(0).position.x > (Screen.width/2) + 10) ){
                movementSpeed=Mathf.Min(3.5f, movementSpeed+gain);
                transform.position = new Vector3(Mathf.Min(3.75f, transform.position.x + Time.deltaTime*movementSpeed), transform.position.y, transform.position.z);
                anim.SetFloat("Movement", 2);
            }
            else if(Input.GetKey("left")|| (Input.touchCount>0 && Input.GetTouch(0).position.x < (Screen.width/2) - 10)){
                movementSpeed=Mathf.Max(-3.5f, movementSpeed-gain);
                transform.position = new Vector3(Mathf.Max(-3.75f, transform.position.x + Time.deltaTime*movementSpeed), transform.position.y, transform.position.z);
                anim.SetFloat("Movement", -2);
            }
            else {
                
                anim.SetFloat("Movement", 0);

                if(movementSpeed>0){
                    movementSpeed=Mathf.Max(0f, movementSpeed-loss);
                    transform.position = new Vector3(Mathf.Min(3.75f, transform.position.x + Time.deltaTime*movementSpeed), transform.position.y, transform.position.z);
                }
                else if(movementSpeed<0){
                    movementSpeed=Mathf.Min(0f, movementSpeed+loss);
                    transform.position = new Vector3(Mathf.Max(-3.75f, transform.position.x + Time.deltaTime*movementSpeed), transform.position.y, transform.position.z);
                }
            }
        }

        // if(GameObject.Find("ScoreManager").GetComponent<floorSpeedctrl>().speed<-9 && inActive){

        //     StartCoroutine(randomMotion());
        // }
        
    }

    // IEnumerator randomMotion(){

    //     inActive = false;
    //     float timec  = 0;
    //     float z_value = Random.Range(-0.03f,0.03f);
    //     float startpos = transform.position.z;
    //     while(timec<0.2f){
    //         timec+=Time.deltaTime;
    //         transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Lerp(startpos, z_value, timec/0.2f));
    //     }
    //     yield return new WaitForSeconds(0.2f);
    //     inActive = true;

    // }

    /*void FixedUpdate(){

        if(lane!=oldlane)
            MoveChar(lane);
    }*/

    /*void MoveChar(){
        
    }

        IEnumerator MoveToLane(int targetLane){
        isMoving = true;

        // Calculate the target position based on the lane offset
        Vector3 targetPosition = transform.position + new Vector3((targetLane - lane) * 2.5f, 0, 0);

        // Smoothly move towards the target position
        while (transform.position != targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, movementSpeed * Time.deltaTime);
            yield return null;
        }

        lane = targetLane;
        //Debug.Log(oldlane);
        isMoving = false;
    }*/

    
}
