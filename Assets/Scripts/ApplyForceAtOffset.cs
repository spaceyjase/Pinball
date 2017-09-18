using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForceAtOffset : MonoBehaviour
{
  [SerializeField]
  private float force = 100f;
  [SerializeField]
  private Vector3 offset;
  [SerializeField]
  private Vector3 forceDirection = Vector3.forward;
  [SerializeField]
  private string keyName = "Fire1";

  private Rigidbody rb;

  private void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  private void Update()
  {
    if (Input.GetButton(keyName))
    {
      rb.AddForceAtPosition(forceDirection.normalized * force, transform.position + offset);
    }
    else
    {
      rb.AddForceAtPosition(forceDirection.normalized * -force, transform.position + offset);
    }
  }
}
