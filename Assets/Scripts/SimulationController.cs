using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimulationController : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0;
    }

    public void StartSimulation()
    {
        Time.timeScale = 1;
    }
}
