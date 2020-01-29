using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public FoodSpawner m_SpawnerFood;

    public bool fruit; // if not fruit, vegetable
    public bool green; // first will check if it's green
    public bool yellow; // if not green, will check if yellow

    public void Start()
    {
        ProduceRequirements requirements = new ProduceRequirements();
        requirements.green = green;
        requirements.yellow = yellow;

        if (fruit) // fruit is a requirement
        {
            m_SpawnerFood.SpawnFruit(requirements);
        } 
        else // if not a fruit, it will be a vegetable
        {
            m_SpawnerFood.SpawnVeggies(requirements);
        }
    }

    public void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.F))
        {
            m_SpawnerFood.SpawnFruit(null);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            m_SpawnerFood.SpawnVeggies(null);
        }*/
    }
}
