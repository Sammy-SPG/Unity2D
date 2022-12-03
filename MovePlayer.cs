using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{

    public float speed = 2f;
    public Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector2 movement = direction.normalized * speed * Time.deltaTime;
        // transform.position = new Vector2(transform.position.x + movement.x, transform.position.y + movement.y);
        // transform.Translate(movement);

        //Eventos 
        //1. mouse 
        if(Input.GetMouseButtonDown(0)){
            Debug.Log("button pressed");
        }

        if(Input.GetMouseButton(0)){
            Debug.Log("button is pressed");
        }

        if(Input.GetMouseButtonUp(0)){
            Debug.Log("button released");
        }

        //2. keyboard
        // if(Input.GetKeyDown(KeyCode.Space)){
        //     Debug.Log("Player jump");
        // }

        if(Input.GetButtonDown("Jump")){
            Debug.Log("Player jump");
        }

        float horizontal = Input.GetAxis("Horizontal"); // -1 to 1
        float vertical = Input.GetAxis("Vertical"); // -1 to 1

        if(horizontal <  0f || horizontal > 0f){
            Debug.Log("Horizontal axis is " + horizontal);
            Vector2 movement = direction.normalized * horizontal * Time.deltaTime;
            transform.Translate(movement);
        }

         if(vertical <  0f || vertical > 0f){
            Debug.Log("Vertical axis is " + vertical);
        }
    }
}
