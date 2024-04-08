using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
   public GameObject obj;

    public void change(){

        obj.SetActive(false);
        GetComponent<Animator>().Play("Camera_Movement", -1, 0f);
        Invoke("SwitchScene", 1.45f);
    }

    private void SwitchScene()
    {
        SceneManager.LoadScene(1);
    }
}
