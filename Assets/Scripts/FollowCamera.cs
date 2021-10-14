using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public void ChangeCameraPosition(Vector3 newPosition)
    {
        transform.position = newPosition;
    }
}
