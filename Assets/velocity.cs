using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
public class velocity : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Transform startPos, targetPos;
    [SerializeField] float duration, upVelocity;
    [SerializeField] float freeFall;
    Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        transform.position = startPos.position;
    }
    // Update is called once per frame
    void Update()
    {
        upVelocity = Mathf.Sqrt(2 * MathF.Abs(Physics.gravity.y) *
        (targetPos.position.y - startPos.position.y));
        Debug.Log(upVelocity);
        if (Input.GetKey(KeyCode.Space))
        {
            rigidBody.linearVelocity = new Vector2(0f, upVelocity);
        }
        freeFall = Mathf.Sqrt(2 * Mathf.Abs(startPos.position.y -
        transform.position.y) / Mathf.Abs(Physics.gravity.y));
        Debug.Log("Time to reach the ground: " + freeFall + " Seconds");
    }
}