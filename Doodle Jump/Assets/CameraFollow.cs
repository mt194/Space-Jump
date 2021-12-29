using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;

    void LateUpdate() {
        if (target.position.y > transform.position.y) {                                                     //if doodler is above camera
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPos;                                                                    //new camera position is that of doodler
        }
    }
}
