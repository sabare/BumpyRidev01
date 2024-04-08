using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIToggle : MonoBehaviour
{
  public List<TMP_Text> info;
  public List<Image> meters;
  public float showTime = 2f;

  public GameObject endGame;
  public TMP_Text finalScore;

  void Start()
  {
    Show();
  }

  public void Show()
  {
    foreach(TMP_Text i in info)
    {
      Color t = i.color;
      t.a = 1f;
      i.color = t;

    }
    foreach(Image i in meters)
    {
      Color t = i.color;
      t.a = 1f;
      i.color = t;

    }

    Invoke("Hide", showTime);
  }
  void Hide()
  {
    foreach(TMP_Text i in info)
    {
      Color t = i.color;
      t.a = 0.3f;
      i.color = t;

    }
    foreach(Image i in meters)
    {
      Color t = i.color;
      t.a = 0.3f;
      i.color = t;

    }
  }
  public void MainMenu()
  {
    SceneManager.LoadScene(0);
  }
  public void Restart()
  {
    SceneManager.LoadScene(1);
  }
  public void Score()
  {
    finalScore.text = GameObject.Find("Player").GetComponent<coinCollector>().coins.ToString("0000");
  }
}
