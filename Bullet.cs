using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 1f;
    public Vector2 direction;

    public float liveTime = 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        // Destruye la bala despues de un tiempo
        Destroy(gameObject, liveTime);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = direction.normalized * horizontal * Time.deltaTime;
        transform.Translate(movement);
    }
}
