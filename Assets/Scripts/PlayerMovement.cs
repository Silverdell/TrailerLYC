using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 moveValue;
    [SerializeField] private float moveSpeed = 1;

    private void OnMovement(InputValue value)
    {
        moveValue = value.Get<Vector2>();
    }

    void Update()
    {
        transform.Translate(new Vector3(moveValue.x, 0, moveValue.y) * moveSpeed * Time.deltaTime);
    }
}
