using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
       
    void OnCollisionEnter (Collision collisioninfo)
    {
        if(collisioninfo.collider.name == "Obstacle")
        {
            movement.enabled = false;
        }
    }

}
