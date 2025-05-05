using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(-5,5,0);
    public float rotationSpeed = 5.0f;

    private Vector3 currentOffset;
    private float yaw;
    private float pitch;
    void Start()
    {
        this.player = GameObject.Find("Player").transform;
        currentOffset = offset;
    }
    void Update()
    {
        yaw += Input.GetAxis("Mouse X") * rotationSpeed;
        pitch -= Input.GetAxis("Mouse Y") * rotationSpeed;
        pitch = Mathf.Clamp(pitch, -80, 80); 

        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0);

        currentOffset = rotation * offset;

        transform.position = player.position + currentOffset;
        transform.LookAt(player.position);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
    }
}
