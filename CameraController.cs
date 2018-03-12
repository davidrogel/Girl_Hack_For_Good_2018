using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector2 offset;
    public Transform target;
    private Transform myTransform;

	void Start ()
    {
        myTransform = transform;
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        myTransform.position = target.position + (Vector3)offset + new Vector3(0, 0, -10);
	}
}
