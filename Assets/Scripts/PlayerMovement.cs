using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private FollowCamera mainCamera;
    [SerializeField] float offset = 10;

    private Vector2 moveValue;
    [SerializeField] private float moveSpeed = 1;

    private void OnMovement(InputValue value)
    {
        moveValue = value.Get<Vector2>();
    }

    void Update()
    {
        transform.Translate(new Vector3(moveValue.x, 0, moveValue.y) * moveSpeed * Time.deltaTime);
        mainCamera.ChangeCameraPosition(new Vector3(
            transform.position.x,
            transform.position.y + offset,
            transform.position.z));
    }
}
