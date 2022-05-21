using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{
    private Camera camera;

    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;

    void Start()
    {
        camera = Camera.main;
    }

    void Update()
    {
        camera.transform.position = new Vector3(player.transform.position.x - offset.x, 0 - offset.y, player.transform.position.z - offset.z);
    }
}
