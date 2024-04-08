using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coinCollector : MonoBehaviour
{

    public int coins = 0;
    public TMP_Text coin_text;
    public TMP_Text coin_1;
    public TMP_Text coin_2;
    public TMP_Text coin_3;

    void Update()
    {
        if(coins<10);
        else if(coins<100 && coins>=10){coin_1.text = "";}
        else if(coins<1000 && coins>=100){coin_2.text = "";}
        else {coin_3.text = "";}
        coin_text.text = coins.ToString();
    }
    
    private void OnTriggerEnter(Collider col) {

        if(col.gameObject.tag=="coin"){

            coins++;
            Destroy(col.gameObject);
        }
    }
}
