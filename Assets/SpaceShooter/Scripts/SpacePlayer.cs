using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePlayer : MonoBehaviour
{
    [Range(1, 100)] [Tooltip("speed is good")] public float speed = 5.00f;


    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;

        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        transform.Translate(direction * speed * Time.deltaTime);

        //transform.position += direction * speed * Time.deltaTime;
    }
}
