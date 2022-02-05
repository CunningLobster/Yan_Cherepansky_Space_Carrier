using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceCarrier.SpaceShips
{
    public class ShipAudio : MonoBehaviour
    {
        [SerializeField] private AudioSource thrustSource;
        [SerializeField] private AudioSource eventAudioSource;

        [SerializeField] private AudioClip explosionAudioClip;
        [SerializeField] private AudioClip harvestingAudioClip;
        public bool isThrusting;

        public void PlayThrustAudioEffect(Vector3 movingVector)
        {
            if (movingVector == Vector3.zero)
            {
                thrustSource.pitch = 0.1f;
                isThrusting = true;
                return;
            }
            if(isThrusting) 
            {
                isThrusting = false;
            }
            thrustSource.pitch = movingVector.sqrMagnitude * 1.5f;
        }

        public void PlayExplosionAudioEffect()
        {
            thrustSource.Stop();
            eventAudioSource.PlayOneShot(explosionAudioClip);
        }

        public void PlayHarvestingAudioClip()
        {
            eventAudioSource.PlayOneShot(harvestingAudioClip);
        }
    }
}
