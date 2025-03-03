using UnityEngine;

public class MovementScript : MonoBehavior
{
    float speed = 5f;

    void Update()////////////////////////////////////////
    {
        hMove();
        vMove();
    }///////////////////////////////////////////////////

    void hMove(){
        float hInput = Input.GetAxis("Horizontal")
        transform.Translate(Vector3.right * speed * hInput * Time.deltaTime)
    }

    void vMove()
    {
        
    }
}