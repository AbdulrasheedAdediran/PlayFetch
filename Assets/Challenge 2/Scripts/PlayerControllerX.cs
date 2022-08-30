using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    // Minimum time interval (seconds) for spawning a dog
    private float spawnDogInterval = 2.5f;
    private float timer = 0.0f;

    void Start()
    {
        // Sets a valid time for spawning dog on start
        timer = 2.5f;
    }

    // Update is called once per frame
    void Update()
    {
        // Updates time (seconds) since last spawn
        timer += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (timer > spawnDogInterval))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            // Resets timer upon spawning
            timer = 0.0f;
        }
    }
}
