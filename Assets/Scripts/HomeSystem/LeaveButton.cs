using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceCarrier.HomeSystem
{
    public class LeaveButton : MonoBehaviour
    {
        public void LeaveHomeSystem()
        {
            SceneManager.LoadScene(1);
        }
    }
}