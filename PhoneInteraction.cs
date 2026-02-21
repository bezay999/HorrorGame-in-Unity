using UnityEngine;
using TMPro;

public class PhoneInteraction : MonoBehaviour
{
   public AudioSource audioSource;
   public AudioSource audioSource2;
   public AudioSource audioSource3;
   public AudioSource audioSource4;
   public GameObject playerRoot;
   public GameObject trigger;
   private bool isInteracted = false;
   public GameObject firstRoom;
   public GameObject secondRoom;
   public TextMeshProUGUI questText;
   [TextArea] public string newQuestMessage;

   public void Interact()
   {
      if(isInteracted == false)
      {
         audioSource.Stop();
         audioSource2.Play();
         audioSource3.PlayScheduled(5);
      
         isInteracted = true;
      }
      else
      {
         Interact2();
         isInteracted = false;
      }
   }

   public void Interact2()
   {
      secondRoom.SetActive(true);
      audioSource4.Play();
      CharacterController cc = playerRoot.GetComponent<CharacterController>();
      
      if (cc != null) cc.enabled = false;

      playerRoot.transform.position = trigger.transform.position;

      Physics.SyncTransforms(); 

      if (cc != null) cc.enabled = true;
      
      Debug.Log("Teleported to: " + trigger.transform.position);
      Destroy(trigger);
      firstRoom.SetActive(false);

      if (questText != null)
      {
         questText.text = newQuestMessage;
      }
   }
}
