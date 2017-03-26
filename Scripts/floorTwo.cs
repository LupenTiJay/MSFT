using UnityEngine;

public class floorTwo : MonoBehaviour
{
    Vector3 originalPosition;

    // Use this for initialization
    void Start()
    {
        // Grab the original local position of the sphere when the app starts.
        originalPosition = this.transform.localPosition;
        this.GetComponent<Renderer>().enabled = false;
    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        // If the sphere has no Rigidbody component, add one to enable physics.
        if (!this.GetComponent<Rigidbody>())
        {
            var rigidbody = this.gameObject.AddComponent<Rigidbody>();
            rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        }
    }

    // Called by SpeechManager when the user says the "Reset world" command
    void OnMorning()
    {
        // If the sphere has a Rigidbody component, remove it to disable physics.

        this.GetComponent<Renderer>().enabled = false;
        // Put the sphere back into its original local position.


    }

    void OnNoon()
    {
        this.GetComponent<Renderer>().enabled = true;
        this.transform.localPosition = originalPosition;
    }

    void OnNight()
    {
        this.GetComponent<Renderer>().enabled = false;
    }

    // Called by SpeechManager when the user says the "Drop sphere" command
    void OnDrop()
    {
        // Just do the same logic as a Select gesture.
        OnSelect();
    }
}