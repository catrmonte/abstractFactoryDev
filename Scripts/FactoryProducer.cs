
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryProducer : MonoBehaviour
{
    public static AbstractFactory GetFactory( FactoryType factoryType )
    {
        switch (factoryType)
        {
            case FactoryType.Fruit:
                AbstractFactory fruitFactory = new FruitFactory();
                return fruitFactory;
            case FactoryType.Veggie:
                AbstractFactory veggieFactory = new VeggieFactory();
                return veggieFactory;
        }

        return null;
    }
}
