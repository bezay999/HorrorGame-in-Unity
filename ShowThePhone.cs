using UnityEngine;
using TMPro;

public class ShowThePhone : MonoBehaviour
{
   public GameObject tv;
   public GameObject table;
   public GameObject screen;
   public GameObject phone;
   public TextMeshProUGUI questText;
   [TextArea] public string newQuestMessage;

   void OnTriggerEnter(Collider other)
   {
      if (other.tag == "Player")
      {
         Destroy(tv);
         Destroy(table);
         Destroy(screen);
         phone.SetActive(true);
        
         if (questText != null)
         {
            questText.text = newQuestMessage;
         }
      }
   }
}
