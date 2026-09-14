using System.Buffers;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class ShipMove : MonoBehaviour
{
    [SerializeField] float moveeSpeed = 5f;
    [SerializeField] float rotateSpeed = 120f;
    bool iskey = false;
    //SpritRenderer carRender;
    SpriteRenderer carRender;
    void Start()
    {
        carRender = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0f, 0f, -rotateSpeed * Time.deltaTime);
        }
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 Move = new Vector3(x, y, 0f);
        //transform.Rotate(0f, 0.4f, 0f);
        transform.Translate(Move * moveeSpeed * Time.deltaTime);

    }

        void OnCollisionEnter2D(Collision2D collision)
        { 
            Debug.Log("Collision happened " + collision.gameObject.name);
        if (collision.collider.CompareTag("TEST"))
        {
            Debug.Log("HitObstacle");
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Happened");
        Debug.Log(iskey);
        if (other.CompareTag("Newtag"));
        {
            iskey = true;
            Debug.Log("You trigger with an object"+other.gameObject.name);
            Debug.Log(iskey);
            carRender.color = Color.beige;
            Destroy(other.gameObject);
        }



    }

}




