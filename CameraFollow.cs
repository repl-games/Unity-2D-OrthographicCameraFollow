using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
  public Transform targetTransform;
  public float followSpeed = 5f;

  void FixedUpdate() {
     Vector3 newPosition = targetTransform.position;
     newPosition.z = -10;
     transform.position = Vector3.Slerp(transform.position, newPosition, followSpeed * Time.deltaTime);
  }
}
