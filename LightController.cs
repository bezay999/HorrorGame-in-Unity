using UnityEngine;

public class LightController : MonoBehaviour
{
  public GameObject lantern;
  public GameObject lantern_2;
  private bool isActive = false;

  public void Interact()
  {
    isActive = !isActive; 

    if (lantern != null) lantern.SetActive(isActive);
    if (lantern_2 != null) lantern_2.SetActive(isActive);
  
    Debug.Log("Світло переключено: " + isActive);
  }
}
