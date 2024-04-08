using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskObject : MonoBehaviour
{
  private MeshRenderer[] meshRenderers;

  void Start()
  {
      meshRenderers = GetComponentsInChildren<MeshRenderer>();

      foreach (MeshRenderer mr in meshRenderers)
      {
          mr.material.renderQueue = 3002;
      }
  }
}
