using UnityEngine;

public class PlayerInteractUi : MonoBehaviour
{
   [SerializeField] private GameObject container;
   [SerializeField] private IInterctable _interactable;

   private void Update()
   {
      if (_interactable.GetInteractibleObject() != null)
      {
         Show();
      }
      else if (_interactable.GetInteractiblePhone() != null)
      {
         Show();
      }
      else if (_interactable.GetLightController() != null)
      {
         Show();
      } 
      else if (_interactable.GetTVController() != null)
      {
         Show();
      }
      else
      {
         Hide();
      }
   }
   private void Show()
   {
      container.SetActive(true);
   }

   private void Hide()
   {
      container.SetActive(false);
   }
}
