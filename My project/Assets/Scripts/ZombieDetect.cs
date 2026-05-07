using UnityEngine;
using UnityEngine.Audio;

public class ZombieDetect : MonoBehaviour
{
    private Animator animator;

    [Header("Configuración de Audio")]
    public AudioMixerSnapshot exploracionSnapshot;
    public AudioMixerSnapshot peligroSnapshot;
    public float tiempoTransicion = 2.0f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("Cerca", true);
            peligroSnapshot.TransitionTo(tiempoTransicion);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("Cerca", false);
            exploracionSnapshot.TransitionTo(tiempoTransicion);
        }
    }
}
