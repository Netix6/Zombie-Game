using UnityEngine;
using UnityEngine.UI;

public class DynamicCrosshair : MonoBehaviour
{
  public Image crosshairImage;
  public float crosshairDistance = 10.0f;
  public float crosshairSize = 32.0f;
  public Camera camera;

  void Update()
  {
    // Calculate the position of the crosshair based on the aim direction
    Ray ray = new Ray(camera.transform.position, camera.transform.forward);
    Vector3 crosshairPosition = ray.GetPoint(crosshairDistance);

    // Convert the crosshair position to screen space
    Vector2 screenPoint = camera.WorldToScreenPoint(crosshairPosition);

    // Set the position and size of the crosshair image
    crosshairImage.rectTransform.position = screenPoint;
    crosshairImage.rectTransform.sizeDelta = new Vector2(crosshairSize, crosshairSize);
  }
}
