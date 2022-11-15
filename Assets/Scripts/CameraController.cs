using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    public Vector3 Offset;

    private void LateUpdate()
    {
        transform.position = Player.position - Player.forward * 15 + Vector3.up * 6;
        transform.LookAt(Player);
    }
}
