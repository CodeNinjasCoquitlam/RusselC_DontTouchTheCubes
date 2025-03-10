﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    [Header("Rigidbody")]
    //Rigidbody component
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //variable rb equals to component rigidbody
        rb = GetComponent<Rigidbody>();
        //game is at normal pace
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //rotating the game object on the zaxis mutiplied by the game frame rate by 7
        transform.rotation *= Quaternion.Euler (0, 0, 7 * Time.deltaTime);

        //time scale of the game plus physics and other fixed frame rate updates
        Time.timeScale += Time.fixedDeltaTime * 0.01f;

        //movement and rotation of the camera on the yaxis horizontally
        rb.velocity += transform.rotation * (Vector3.right * Input.GetAxisRaw("Horizontal") * 10f * Time.deltaTime);

        //Movement and rotation of the camerra on the yaxis vertically
        rb.velocity += transform.rotation * (Vector3.up * Input.GetAxisRaw("Vertical") * 10f * Time.deltaTime);

        //Keeping the camera position in bounds
        //refractor the clamping into separate variables for clarity
        float clampedX = Mathf.Clamp(transform.position.x, -30f, 30);
        float clampedZ = Mathf.Clamp(transform.position.z, -30f, 30);

        //apply the clamped values to the transforms position
        transform.position = new Vector3(clampedX, 0, clampedZ);
    }
}
