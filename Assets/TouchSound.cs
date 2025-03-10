using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSound : MonoBehaviour
{
    public AudioClip impactSound; // Аудиофайл удара
    public float minImpactSpeed = 2f; // Минимальная скорость удара для звука
    public string ignoreTag = "Ball"; // Тег, который нужно игнорировать при столкновении

    private AudioSource audioSource;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = impactSound;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Проверяем, если объект сталкивается с таким же по тегу — не воспроизводим звук
        if (collision.gameObject.CompareTag(ignoreTag))
        {
            return;
        }

        // Проверяем скорость и проигрываем звук
        if (rb != null && rb.velocity.magnitude >= minImpactSpeed && impactSound != null)
        {
            audioSource.Play();
        }
    }
}
