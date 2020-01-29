using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitFactory : AbstractFactory
{
    public override IFruit GetFruit(FruitType fruitType)
    {
        switch (fruitType)
        {
            case FruitType.Apple:
                IFruit apple = new Apple();
                return apple;
            case FruitType.Banana:
                IFruit banana = new Banana();
                return banana;
            case FruitType.Avocado:
                IFruit avocado = new Avocado();
                return avocado;
        }
        return null;
    }

    // protect against calling the wrong function
    public override IVeggie GetVeggie(VeggieType veggieType)
    {
        return null;
    }
}
