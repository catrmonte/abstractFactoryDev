using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    private IFruit m_Apple;
    private IFruit m_Banana;
    private IFruit m_Avocado;

    private IVeggie m_Carrot;
    private IVeggie m_Broccoli;
    private IVeggie m_Potato;

    public GameObject applePrefab;
    public GameObject bananaPrefab;
    public GameObject avocadoPrefab;
    public GameObject carrotPrefab;
    public GameObject potatoPrefab;
    public GameObject broccoliPrefab;

    private AbstractFactory factory;

    public void SpawnFruit(ProduceRequirements requirements)
    {

        factory = FactoryProducer.GetFactory(FactoryType.Fruit);

        if (requirements.green) // If it is a green fruit, spawn an avocado
        {
            GameObject produce = Instantiate(avocadoPrefab);

            m_Avocado = factory.GetFruit(FruitType.Avocado);
            m_Avocado.Fruitify();
        }
        else if (requirements.yellow) // if it is a yellow fruit, spawn a banana
        {
            GameObject produce = Instantiate(bananaPrefab);

            m_Banana = factory.GetFruit(FruitType.Banana);
            m_Banana.Fruitify();
        }
        else if (requirements == null) // if no requirements are given, spawn all fruits
        // This is for the case when the user presses the fruit key
        {
            m_Apple = factory.GetFruit(FruitType.Apple);
            m_Banana = factory.GetFruit(FruitType.Banana);
            m_Avocado = factory.GetFruit(FruitType.Avocado);

            m_Apple.Fruitify();
            m_Banana.Fruitify();
            m_Avocado.Fruitify();
        }
        else // Otherwise spawn an apple
        {
            GameObject produce = Instantiate(applePrefab);

            m_Apple = factory.GetFruit(FruitType.Apple);
            m_Apple.Fruitify();
        }
        
    }

    public void SpawnVeggies(ProduceRequirements requirements)
    {
        factory = FactoryProducer.GetFactory(FactoryType.Veggie);

        if (requirements.green) // If it's a green vegetable, spawn Broccoli
        {
            GameObject produce = Instantiate(broccoliPrefab);

            m_Broccoli = factory.GetVeggie(VeggieType.Broccoli);
            m_Broccoli.Vegetate();
        }
        else if (requirements.yellow) // If it's a yellow vegetable, spawn a Potato
        {
            GameObject produce = Instantiate(potatoPrefab);

            m_Potato = factory.GetVeggie(VeggieType.Potato);
            m_Potato.Vegetate();
        }
        else if (requirements == null) // if no requirements are given, spawn all vegetables
        //This is the case for when the user presses the vegetable key
        {
            m_Carrot = factory.GetVeggie(VeggieType.Carrot);
            m_Broccoli = factory.GetVeggie(VeggieType.Broccoli);
            m_Potato = factory.GetVeggie(VeggieType.Potato);

            m_Carrot.Vegetate();
            m_Broccoli.Vegetate();
            m_Potato.Vegetate();
        }
        else // Otherwise spawn a carrot
        {
            GameObject produce = Instantiate(carrotPrefab);

            m_Carrot = factory.GetVeggie(VeggieType.Carrot);
            m_Carrot.Vegetate();
        }
    }
}
