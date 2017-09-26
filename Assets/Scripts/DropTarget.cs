﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DropTarget : MonoBehaviour
{
  [SerializeField]
  private float dropDistance = 1.0f;
  [SerializeField]
  private float resetDelay = 0.5f;

  private static List<DropTarget> bank = new List<DropTarget>();

  private bool isDropped = false;

  public bool IsDropped
  {
    get
    {
      return isDropped == true;
    }
  }

  public void Reset()
  {
    transform.position += Vector3.up * dropDistance;
    isDropped = false;
  }

  public void Drop()
  {
    transform.position += Vector3.down * dropDistance;
    isDropped = true;
  }

  private void Awake()
  {
    bank.Add(this);
  }

  private void OnCollisionEnter(Collision collision)
  {
    if (!isDropped)
    {
      Drop();
      bool allDropped = bank.All(t => t.IsDropped);
      if (allDropped)
      {
        StartCoroutine(nameof(ResetBank));
      }
    }
  }

  private IEnumerator ResetBank()
  {
    yield return new WaitForSeconds(resetDelay);
    // reset all banks
    bank.ForEach(t => t.Reset());
  }
}
