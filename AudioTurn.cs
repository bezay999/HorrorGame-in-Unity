using UnityEngine;

public class AudioTurn : MonoBehaviour
{
  public GameObject radio;
  public GameObject secondRadio;

  void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Player")
    {
      radio.GetComponent<AudioSource>().mute = false;
      secondRadio.GetComponent<AudioSource>().Stop();
      
      Destroy(gameObject);
    }
  }
}
