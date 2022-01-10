using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(1, 10)] [Tooltip("speed is good")] public float speed = 5.00f;
    [SerializeField] AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;

        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        transform.position += direction * speed * Time.deltaTime;
        //transform.rotation *= Quaternion.Euler(5,5,5);
        //transform.localScale = new Vector3(2, 2, 2);

        if (Input.GetButtonDown("Fire1"))
        {

            audioSource.Play();
            GetComponent<Renderer>().material.color = Color.cyan;
            //transform.rotation *= Quaternion.Euler(5, 5, 5);
        }

        GameObject go = GameObject.Find("cube");
        if (go != null)
        {
            go.GetComponent<Renderer>().material.color = Color.magenta;
        }
    }
}
