using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 10f;

    void Update()
    {
        Vector3 pos = transform.position;
         this.GetComponent<SpriteRenderer>().color = Color.white;

        if (Input.GetKey("w"))
        {
            this.GetComponent<SpriteRenderer>().color = Color.red;
            pos.y += speed * Time.deltaTime;
            
        }

        if (Input.GetKey("s"))
        {
            this.GetComponent<SpriteRenderer>().color = Color.blue;
            pos.y -= speed * Time.deltaTime;
            
        }

        if (Input.GetKey("d"))
        {
            this.GetComponent<SpriteRenderer>().color = Color.green;
            pos.x += speed * Time.deltaTime;
            
        }

        if (Input.GetKey("a"))
        {
            this.GetComponent<SpriteRenderer>().color = Color.yellow;
            pos.x -= speed * Time.deltaTime;
            
        }


        transform.position = pos;
    }
}
