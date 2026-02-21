using UnityEngine;
using TMPro;

public class EndOfTheStory : MonoBehaviour
{
   public TextMeshProUGUI questText;
   [TextArea] public string newQuestMessage;

   void OnTriggerEnter(Collider other)
   {
      if (other.CompareTag("Player"))
      {
         EndGame();
      }
   }

   void EndGame()
   {
      if (questText != null)
      {
         questText.text = newQuestMessage;
         questText.fontSize = 64; 

         questText.alignment = TextAlignmentOptions.Center;
         
         RectTransform rect = questText.GetComponent<RectTransform>();
         
         rect.anchorMin = new Vector2(0.5f, 0.5f);
         rect.anchorMax = new Vector2(0.5f, 0.5f);
         rect.pivot = new Vector2(0.5f, 0.5f);

         rect.anchoredPosition = Vector2.zero;
         
         rect.sizeDelta = new Vector2(1000, 500);
      }

      Time.timeScale = 0f; 
      
      Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;
      
      Debug.Log("Game Over!");
   }
}
