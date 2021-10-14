using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementWaypoint : MonoBehaviour
{
    [SerializeField] private FollowCamera mainCamera;
    [SerializeField] float offset = 10;

    [SerializeField] List<Transform> waypointsList = new List<Transform>();
    [SerializeField] private float moveSpeed = 5;
    private int waypointIndex = 0;
    private Transform target;

    private void Update()
    {
        if (target != null)
        {
            Move();
            MoveCamera();
        }
    }
    private void OnSetNextTarget()
    {
        waypointIndex++;
        if (waypointIndex < waypointsList.Count)
        target = waypointsList[waypointIndex].transform;
    }
    private void OnSetLastTarget()
    {
        waypointIndex--;
        if (waypointIndex > 0)
            target = waypointsList[waypointIndex].transform;
        else waypointIndex = 0;
    }
    private void MoveCamera()
    { 
        mainCamera.ChangeCameraPosition(new Vector3(
            transform.position.x,
            transform.position.y + offset,
            transform.position.z));
    }
    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        if (transform.position == target.position)
            target = null;
    }
}
