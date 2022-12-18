using UnityEngine;

public class CameraBob : MonoBehaviour
{
    // Variables for the camera bobbing effect
    public float maxBobbingAmount = 0.1f;
    public float bobbingSpeed = 2.0f;
    public float bobbingHeight = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // Get the player's movement speed
        float speed = Input.GetAxis("Vertical");

        // Calculate the amount of bobbing based on the player's movement speed
        float bobbingAmount = maxBobbingAmount * speed;

        // Calculate the camera's position based on the bobbing variables
        float y = bobbingAmount * Mathf.Sin(Time.time * bobbingSpeed);
        float z = bobbingAmount * Mathf.Cos(Time.time * bobbingSpeed);

        // Offset the camera's position based on the player's movement
        float x = transform.position.x * 0.1f;

        // Set the camera's position to the calculated values
        transform.position = new Vector3(x, y, z);
    }
}
