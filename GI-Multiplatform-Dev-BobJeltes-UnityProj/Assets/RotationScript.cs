using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

    [Range(1, 100)]
    public float rotationSpeed;
    private float halfScreenHeight = 2048/2;

    float swipePosPrevious;
    float swipePosCurrent;
    public float swipePosDelta;

    void Start() {

    }


	void Update () {


        
        if (Input.touchCount > 0) {

            swipePosCurrent = Input.mousePosition.y;

            swipePosDelta = swipePosCurrent - swipePosPrevious;

            swipePosPrevious = swipePosCurrent;
        }

        //rotationSpeed = (Input.mousePosition.y - halfScreenHeight) / 100;
        

        transform.Rotate(Vector3.right * swipePosDelta / -20);


        

	}
}
