using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 10;

    public int level = 1;

    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Health: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        // Get the current position of the NPC
        Vector3 newPosition = transform.position;

        // Update the position along the Z-axis based on speed and time
        newPosition.z += speed * Time.deltaTime;

        // Update the NPC's position
        transform.position = newPosition;    }
}