using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    [SerializeField] private Transform target;
    private const float LERP_TIME = 10f;

    private void LateUpdate() {
        transform.position = Vector3.Lerp( transform.position, target.position, LERP_TIME );
    }
}
