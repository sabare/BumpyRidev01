using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public int life = 4;
    public GameObject go_screen;
    public Sprite[] lives;
    public Image lifeUI;
    public TMP_Text life1;
    public TMP_Text life2;
    public void Damage(int l)
    {   

        if(l==4){life1.text = "";life2.text = "100%";}
        else if (l==3){life1.text = "0";life2.text = "80%";}
        else if (l==2){life1.text = "0";life2.text = "40%";}
        else if (l==1){life1.text = "0";life2.text = "20%";}
        else if(l==0){/*go_screen.SetActive(true);*/life1.text = "0";life2.text = "00%";life2.color = new Color32(255, 255, 255, 255);}
        
        lifeUI.sprite = lives[l];
    }
}
