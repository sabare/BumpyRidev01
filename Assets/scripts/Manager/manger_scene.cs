using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manger_scene : MonoBehaviour
{
     public void nextlvl(int k){

        SceneManager.LoadScene(k);
    }
}
