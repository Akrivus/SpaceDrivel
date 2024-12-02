using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public float maxInterval = 2;
    public float maxBurst = 1f;
    public float maxFlicker = 0.2f;

    float defaultIntensity;
    bool isFlickering;
    float timer;
    float interval;

    Light _light;

    void Awake()
    {
        _light = GetComponent<Light>();
    }

    void Start()
    {
        defaultIntensity = _light.intensity;
        interval = Random.Range(0, maxInterval);
    }

    void Update()
    {
        if (!isFlickering)
        {
            timer += Time.deltaTime;
        }

        if (timer > interval)
        {
            interval = Random.Range(0, maxInterval);
            timer = 0;
            StartCoroutine(FlickerLight(Random.Range(0, maxBurst)));
        }
    }

    IEnumerator FlickerLight(float duration)
    {
        isFlickering = true;
        float totalTime = 0;
        float flickerTimer = 0;
        float flickerInterval = Random.Range(0, maxFlicker);

        while (totalTime < duration)
        {
            totalTime += Time.deltaTime;
            flickerTimer += Time.deltaTime;

            if (flickerTimer > flickerInterval)
            {
                _light.intensity = Random.Range(0.5f, defaultIntensity);
                flickerInterval = Random.Range(0, maxFlicker);
                flickerTimer = 0;
            }
            yield return null;
        }

        _light.intensity = defaultIntensity;
        isFlickering = false;
    }
}
