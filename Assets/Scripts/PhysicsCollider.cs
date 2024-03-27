using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCollider : MonoBehaviour {

    string status;

    private void OnCollisionEnter( Collision collision ) {

        status = "Collision entered: " + collision.gameObject.name;

    }

    private void OnCollisionStay( Collision collision ) {



    }

    private void OnCollisionExit( Collision collision ) {


        status = "Collision left: " + collision.gameObject.name;

    }

    private void OnTriggerEnter( Collider other ) {

        status = "Trigger entered: " + other.gameObject.name;

    }

    private void OnTriggerStay( Collider other ) {



    }

    private void OnTriggerExit( Collider other ) {


        status = "Trigger left: " + other.gameObject.name;

    }

    private void OnGUI() {

        GUI.skin.label.fontSize = 18;
        var screen = Camera.main.WorldToScreenPoint( transform.position );
        GUI.Label( new Rect( screen.x, Screen.height - screen.y, 250, 70 ), status );

    }

}
