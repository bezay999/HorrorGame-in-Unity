using UnityEngine;

public class LightClicker : MonoBehaviour
{
    public float minIntensity = 1f;
    public float maxIntensity = 3f;
    public float speed = 10f; // Швидкість коливання

    private Light myLight;
    private float noiseOffset;

    void Start()
    {
        myLight = GetComponent<Light>();
        noiseOffset = Random.Range(0f, 100f); // Щоб різні лампи не блимали однаково
    }

    void Update()
    {
        // Perlin Noise створює плавну хвилю випадковості
        float noise = Mathf.PerlinNoise(Time.time * speed, noiseOffset);
        
        // Перетворюємо шум на яскравість
        myLight.intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
    }
}