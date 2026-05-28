using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightFadeIn : MonoBehaviour
{
    public Light2D spotLight;
    public float fadeDuration = 60f;
    public float targetIntensity = 1f;

    private float timer = 0f;

    void Start()
    {
        if (spotLight == null)
            spotLight = GetComponent<Light2D>();

        spotLight.intensity = 0f;
    }

    void Update()
    {
        if (timer < fadeDuration)
        {
            timer += Time.deltaTime;
            spotLight.intensity = Mathf.Lerp(0f, targetIntensity, timer / fadeDuration);
        }
    }
}