using SpaceCarrier.Wormholes;
using UnityEngine;

namespace SpaceCarrier.SpaceShips
{
    public class HyperDriver : MonoBehaviour
    {
        private Wormhole wormhole;
        [SerializeField] private float preparationTime = 3f;
        private float timeToJump = 0;
        private Collider shipCollider;

        private void Awake()
        {
            shipCollider = GetComponent<Collider>();
        }

        private void OnTriggerStay(Collider other)
        {
            if (!other.TryGetComponent<Wormhole>(out Wormhole wormhole)) return;
            this.wormhole = wormhole;
        }

        private void OnTriggerExit(Collider other)
        {
            this.wormhole = null;
        }

        public void Hyperjump(bool jumpStarted)
        {
            if (!jumpStarted || wormhole == null)
            {
                timeToJump = 0;
                return;
            }

            wormhole.Gravity.PullObject(shipCollider);

            timeToJump += Time.fixedDeltaTime;
            if (timeToJump >= preparationTime)
                wormhole.PullShip();
        }
    }
}