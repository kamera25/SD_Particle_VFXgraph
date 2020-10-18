using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace UnityStandardAssets.Effects
{
    public class SmokeParticles : MonoBehaviour
    {
        public AudioClip[] extinguishSounds;


        private void Start()
        {
            if( extinguishSounds.Length == 0)
            {
                return;
            }

            GetComponent<AudioSource>().clip = extinguishSounds[Random.Range(0, extinguishSounds.Length)];
            GetComponent<AudioSource>().Play();
        }
    }
}
