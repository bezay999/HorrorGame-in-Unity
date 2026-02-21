using UnityEngine;

public class TVController : MonoBehaviour
{
   public GameObject screen;
   private bool isActive = true;
   public GameObject lamp;

   public void Interact()
   {
      if (isActive)
      {
         screen.SetActive(false);
         isActive = false;
         lamp.SetActive(false);
      }
      else
      {
         screen.SetActive(true);
         isActive = true;
      }
   }
}
