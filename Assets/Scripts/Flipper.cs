using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour
{
  [SerializeField]
  private float maxAngle = 20.0f;     // assume the current editor position is min
  [SerializeField]
  private float maxDegreesDelta = 20.0f;
  [SerializeField]
  private string keyName = "Fire1";
  [SerializeField]
  private bool flipped = false;

  private Quaternion initialRotation = Quaternion.identity;
  private Quaternion finalRotation = Quaternion.identity;

  private void Start()
  {
    initialRotation = transform.rotation;
    finalRotation.eulerAngles = new Vector3(initialRotation.eulerAngles.x, 
      initialRotation.eulerAngles.y + (flipped ? -maxAngle : maxAngle), 
      initialRotation.eulerAngles.z);
  }

  private void Update()
  {
    if (Input.GetButton(keyName))
    {
      transform.rotation = Quaternion.RotateTowards(initialRotation, finalRotation, maxDegreesDelta);
    }
    else
    {
      transform.rotation = Quaternion.RotateTowards(transform.rotation, initialRotation, maxDegreesDelta);
    }
  }
}
