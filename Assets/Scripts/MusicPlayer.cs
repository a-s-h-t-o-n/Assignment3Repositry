using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioClip[] audioTracks = new AudioClip[4];

    IEnumerator playIntro(AudioClip track)
    {
        GetComponent<AudioSource>().clip = track;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(track.length);
        StartCoroutine(playTracks());
    }

    IEnumerator playTracks()
    {
        for (int i = 1; i < 4; i++)
        {
            GetComponent<AudioSource>().clip = audioTracks[i];
            GetComponent<AudioSource>().Play();
            yield return new WaitForSeconds(audioTracks[i].length);
        }
        StartCoroutine(playTracks());
        

    }
    void Start()
    {
        StartCoroutine(playIntro(audioTracks[0]));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
