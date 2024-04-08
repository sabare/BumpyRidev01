using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text clockText_min; 
    public TMP_Text clockText_min_1; 
    public TMP_Text clockText_min_2; 

    public TMP_Text clockText_sec;
    private float distance;
    public int tunnel_cnt = 0;
    float speed;
    int area =  0;
    int oldArea = 0;

    public float totalTimeInSeconds;
    private float currentTime;

    void Start()
    {
        distance = 0;
    }

    // Update is called once per frame
    public GameObject[] bgs;
    void Update()
    {
        speed = GameObject.Find("ScoreManager").GetComponent<floorSpeedctrl>().speed;
        distance  += Time.deltaTime*speed*(-0.5f);
        //timerText.text = distance.ToString("0");
        
        //states when to change the map
        if(distance<350)tunnel_cnt = 0;
        else if(distance>350 && distance<750)tunnel_cnt = 1;
        else if(distance>750 && distance<1000)tunnel_cnt = 2;
        else tunnel_cnt = 2;


        //States when to change the bg picture, has 50 buffer space
        if(distance>400 && distance<770)area = 1;
        else if(distance>770)area = 2;




        if(area==1 && area!=oldArea){

            bgs[0].SetActive(false);bgs[1].SetActive(true);
            oldArea = 1;
        }
        else if(area==2 && area!=oldArea){

            bgs[1].SetActive(false);bgs[2].SetActive(true);
            oldArea = 2;
        }
        
        currentTime += Time.deltaTime;
        
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);

        if(minutes==0);
        else if(minutes>0 && minutes<10){clockText_min_1.text = "";clockText_min.text = minutes.ToString();}
        else {clockText_min_2.text  = "";clockText_min.text = minutes.ToString();}
        string formattedTime = $":{seconds:00}";

        clockText_sec.text = formattedTime;
    }
}
