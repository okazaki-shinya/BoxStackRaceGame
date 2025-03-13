using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempPlayerMover : MonoBehaviour {
    [SerializeField] private float _moveSpeed = 2.0f;

    private void FixedUpdate() {
        Vector3 targetPosition = transform.position + transform.right * _moveSpeed * Time.deltaTime;
        transform.position = targetPosition;
    }
}
