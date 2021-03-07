using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraFolow : MonoBehaviour
{
    [SerializeField]
    private Transform player;
    [SerializeField]
    private Vector2 offset;

    private void Update()
    {
        transform.position = new Vector3(player.position.x + offset.x, player.position.y + offset.y, player.position.z);
    }
}
