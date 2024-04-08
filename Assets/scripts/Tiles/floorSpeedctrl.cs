using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class floorSpeedctrl : MonoBehaviour
{
    // Start is called before the first frame update

    public float time = 0;
    public float speed = -13.5f;
    public float past_spd = -13.5f;
    public GameObject obj;
    
    public Sprite[] SpeedBar;
    public Image SpeedBarUI;

    void Start()
    {
        StartCoroutine("changespeed");
    }

    void Update()
    {
        time+=Time.deltaTime;
        if(GameObject.Find("ScoreManager").GetComponent<ScoreUpdate>().life == 0)speed=0;
        if(time>10f){
            
            speed = Mathf.Max(-30, speed*1.03f);
            past_spd = speed;
            // Speedupdate(speed);
            time = 0;
        }

        Speedupdate(speed);
        // Debug.Log(speed);
        // if(boost_time>0){

        //     boost_time-=Time.deltaTime;
        //     speed = -20f;
            
        // }   
    }

    public IEnumerator speedBoost(){// turns on the speed boost for 1.2sec and also the blur and lines

        float oldSpeed = past_spd;
        obj.SetActive(true);
        speed = oldSpeed-10f;
        // Speedupdate(speed);
        yield return new WaitForSeconds(1f);
        speed = oldSpeed;
        // Speedupdate(speed);
        obj.SetActive(false);
    }

    public IEnumerator changespeed(){

        speed = 0f;
        // Speedupdate(speed);
        time= 0;
        while(speed>past_spd){
            speed-=Time.deltaTime*3.5f;
            yield return null;
        }
        speed = past_spd;
        // Speedupdate(speed);

    }

    public void Speedupdate(float spd)
    {   

        if(spd>-13.3f)SpeedBarUI.sprite = SpeedBar[0];
        else if(spd<=-13.3f && spd>-16)SpeedBarUI.sprite = SpeedBar[1];
        else if(spd<=-16 && spd>-20)SpeedBarUI.sprite = SpeedBar[2];
        else if(spd<=-20 && spd>-23)SpeedBarUI.sprite = SpeedBar[3];
        else if(spd<=-23 && spd>-27)SpeedBarUI.sprite = SpeedBar[4];
        else if(spd<=-27 && spd>-31)SpeedBarUI.sprite = SpeedBar[5];
        else if(spd<=-31 && spd>-35)SpeedBarUI.sprite = SpeedBar[6];
        else if(spd<=-35)SpeedBarUI.sprite = SpeedBar[7];

        
        // if(l==0)go_screen.SetActive(true);
        // else lifeUI.sprite = lives[l-1];
    }
}
