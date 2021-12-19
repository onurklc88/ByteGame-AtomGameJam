using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Vector3 offset;
    [Range(1, 10)] public float smooth;


    private void FixedUpdate()
    {
        Follow();
    }

    private void Follow()
    {
        Vector3 targetPos = Player.position + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, targetPos, smooth * Time.fixedDeltaTime);
        transform.position = smoothPos;
    }




}
