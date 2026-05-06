using UnityEngine;
public class MonsterSound : MonoBehaviour
{
    void PlayMonsterSound()
    {
        GetComponent<AudioSource> ().Play();
    }
}
