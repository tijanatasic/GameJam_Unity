using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] private float sensitivity;
    private Transform parent;

    void Start()
    {
        parent = transform.parent;
    }
    

    void Update()
    {
        float rotateX = Input.GetAxis("Horizontal") * sensitivity * Time.deltaTime;
        parent.Rotate(Vector3.up, rotateX);
    }
}
