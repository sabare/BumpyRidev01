using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDetection : MonoBehaviour
{
    // Start is called before the first frame update
    public ScoreUpdate scrupdt;
    public Animator anim;
    public floorSpeedctrl fsc;
    public CameraControl cc;

    private void OnTriggerEnter(Collider collision) {
        
        if (collision.gameObject.tag == "TrafficCone")
        {

            scrupdt.life = Mathf.Max(0, scrupdt.life-1); // reduces life by 1 from scoreUpdate script
            Destroy(collision.gameObject);
            anim.SetFloat("Movement", 0);
            scrupdt.Damage(scrupdt.life); // changes the UI and also shows the restart button
            StartCoroutine(cc.GotHit());
            StartCoroutine(fsc.changespeed());
            

            
        }

        else if(collision.gameObject.tag == "PowerUp"){

            scrupdt.life = Mathf.Min(4, scrupdt.life+1); // increases health by 1
            scrupdt.Damage(scrupdt.life);
            Destroy(collision.gameObject);
        }

        else if(collision.gameObject.tag == "Boost"){

            StartCoroutine(fsc.speedBoost()); //When we touch the speed boost this coroutine is called from floorSpeedCtrl
            Destroy(collision.gameObject);
        }
    }

    // IEnumerator play_anim(){
    //     anim.SetBool("hit", true);
    //     yield return new WaitForSeconds(0.5f);
    //     anim.SetBool("hit",false);
    // }


}
