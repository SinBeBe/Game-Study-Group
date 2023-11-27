using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Setting")]
    [SerializeField] private float speed;
    
    private Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        Direction(h, v);

        Vector3 playerPosition = transform.position;
        
        playerPosition.x += h * speed * Time.deltaTime;
        playerPosition.y += v * speed * Time.deltaTime;
        
        transform.position = playerPosition;
    }

    void Direction(float h, float v)
    {
        if (h > 0)
            transform.rotation = Quaternion.Euler(0f, 0f, -90f);
        else if (h < 0)
            transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        else if (v > 0)
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        else if (v < 0)
            transform.rotation = Quaternion.Euler(0f, 0f, 180f);
    }
}
