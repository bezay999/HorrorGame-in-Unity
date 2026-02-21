using UnityEngine;
using UnityEngine.SceneManagement; 
public class TeleportationFromLightPlace : MonoBehaviour
{
    [Header("Налаштування переходу")]
    [Tooltip("Точна назва сцени, яку треба завантажити (наприклад: Level2)")]
    public string sceneToLoad; 

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!string.IsNullOrEmpty(sceneToLoad))
            {
                Debug.Log("Завантажуємо сцену: " + sceneToLoad);
                
                SceneManager.LoadScene(sceneToLoad);
            }
            else
            {
                Debug.LogError("Ви забули вписати назву сцени в інспекторі!");
            }
        }
    }
}