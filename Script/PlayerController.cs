using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        // position.x = position.x + 0.1f;
        position.x += Input.GetAxis("Horizontal") * moveSpeed *Time.deltaTime;
        position.y += Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        // position.y = position.y + 0.1f;
        transform.position = position;
    }
}
