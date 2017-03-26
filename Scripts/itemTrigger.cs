using UnityEngine;

public class itemTrigger : MonoBehaviour
{
    Vector3 originalPosition;
    
    // Use this for initialization
    void Start()
    {
        // Grab the original local position of the sphere when the app starts.

        originalPosition = this.transform.localPosition;
    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void itemTriggered()
    {
        if (!this.GetComponent<Rigidbody>())
        {
            var rigidbody = this.gameObject.AddComponent<Rigidbody>();
            rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;


            // add your stuff here
        }
    }
}
