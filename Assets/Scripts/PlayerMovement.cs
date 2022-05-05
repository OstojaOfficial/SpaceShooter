using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    float xAxis;
    float yAxis;

    public float maxSpeed = 50.0f;
    public float rotationSpeed = 3.0f;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuManager.ChangeSceneByName("MainMenu");
        }

        yAxis = Input.GetAxis("Vertical");
        xAxis = Input.GetAxis("Horizontal");
        body.angularVelocity = 0;

        ThrustForward(yAxis);
        Rotate(transform, -xAxis * rotationSpeed);
        ClampVelocity();
    }

    private void ClampVelocity()
    {
        float x = Mathf.Clamp(body.velocity.x, -maxSpeed, maxSpeed);
        float y = Mathf.Clamp(body.velocity.y, -maxSpeed, maxSpeed);

        body.velocity = new Vector2(x, y);
    }

    private void ThrustForward(float amount)
    {
        body.AddForce(transform.up * amount);
    }

    public void Rotate(Transform transform, float amount)
    {
        transform.Rotate(0, 0, amount);
    }
}
