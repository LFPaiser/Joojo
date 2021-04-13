using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour
{
    public Camera camera;
    public GameObject player;

    public float cameraX, cameraY, cameraZ;
    
    public Vector3 cameraPosition;
    public Quaternion cameraRotation;
    void Update()
    {
        camera = FindObjectOfType<Camera>();
        player = GameObject.FindGameObjectWithTag("Player");

        cameraX = player.transform.position.x;
        cameraY = 15f;
        cameraZ = player.transform.position.z - 15f;

        cameraPosition = new Vector3(cameraX, cameraY, cameraZ);
        cameraRotation = camera.transform.rotation;
        
        camera.transform.SetPositionAndRotation(cameraPosition, cameraRotation);
    }
}









