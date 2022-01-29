using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceCarrier.HomeSystem
{
    public class TradeStationMenu : MonoBehaviour
    {
        [SerializeField] GameObject homeSystemMainMenu;

        public void BackToHomeSystemMainMenu()
        { 
            homeSystemMainMenu.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}