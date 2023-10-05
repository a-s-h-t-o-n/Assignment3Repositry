using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioClip[] audioTracks = new AudioClip[4];
    [SerializeField ]private AudioSource audio;

    IEnumerator playAudio(AudioClip track)
    {
        audio = GetComponent<AudioSource>();
        audio.clip = track;
        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        
    }
    void Start()
    {
        audio = GetComponent<AudioSource>();
        playAudio(audioTracks[0]);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i < 4; i++)
        {
            playAudio(audioTracks[i]);
        }
    }
}
