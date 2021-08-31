using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    Rigidbody2D enemyRigidBody2D;
    public float EnemySpeed = 500;
    public bool _moveRight = true;

    // Use this for initialization
    public void Awake()
    {
        enemyRigidBody2D = GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    private void Update()
    {

        if (_moveRight)
        {
            enemyRigidBody2D.velocity = new Vector2(EnemySpeed * Time.deltaTime, enemyRigidBody2D.velocity.y);
            flip(_moveRight);
            _moveRight = false;
        }
        else
        {
            enemyRigidBody2D.velocity = new Vector2(EnemySpeed * Time.deltaTime, enemyRigidBody2D.velocity.y);
            flip(_moveRight);
            _moveRight = true;
        }

    }

    private void flip(bool dirc)
    {
        if (dirc)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
        else
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
    }
}
