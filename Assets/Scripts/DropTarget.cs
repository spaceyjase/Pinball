using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropTarget : MonoBehaviour
{
  [SerializeField]
  private float dropDistance = 1.0f;

  private bool isDropped = false;

  private void OnCollisionEnter(Collision collision)
  {
    if (!isDropped)
    {
      transform.position += Vector3.down * dropDistance;
      isDropped = true;
    }
  }
}
