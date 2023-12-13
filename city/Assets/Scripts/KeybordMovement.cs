using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeybordMovement : MonoBehaviour
{
    public Transform characterTransform;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = characterTransform.position;
        if (Input.GetKey("up") || Input.GetKey(KeyCode.W))
        {
            position.x = position.x + speed;
        }
        if (Input.GetKey("down") || Input.GetKey(KeyCode.S))
        {
            position.x = position.x - speed;
        }
        if (Input.GetKey("left") || Input.GetKey(KeyCode.A))
        {
            position.z = position.z + speed;
        }
        if (Input.GetKey("right") || Input.GetKey(KeyCode.D))
        {
            position.z = position.z - speed;
        }
        characterTransform.position = position;


    }
}
