using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // creates a vector so when we add, it knows the bracket is a vector
    Vector3 cameraDistance = new Vector3(0,0,-10);
    // this thing's position (camera) should be the same as the car's position
    // don't need start since it will happen every frame
    // lateUpdate makes the code run after all the other frames stuff so no camera jitter
    // in terms of camera fighting with the car to check position etc
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + cameraDistance;
    }
}
