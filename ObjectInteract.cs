using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
   public void Interact()
   {

      if (GetComponent<AudioSource>().mute == false && GetComponent<AudioSource>().isPlaying)
      {
         GetComponent<AudioSource>().mute = true;
      }
      else if (!GetComponent<AudioSource>().isPlaying && !GetComponent<AudioSource>().mute)
      {
         GetComponent<AudioSource>().mute = true;
         GetComponent<AudioSource>().Play();
      }
      else
      {
         GetComponent<AudioSource>().mute = false;
      }
   }
}
