using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinematicController : MonoBehaviour {

    [SerializeField] float speed = 1f;

    void Update() {

        Vector3 direction = Vector3.zero;

        direction.x = Input.GetAxis( "Horizontal" );
        direction.z = Input.GetAxis( "Vertical" );

        transform.position += direction.normalized * speed * Time.deltaTime;

    }

}
