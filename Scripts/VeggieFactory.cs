using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VeggieFactory : AbstractFactory
{
    public override IVeggie GetVeggie(VeggieType veggieType)
    {
        switch (veggieType)
        {
            case VeggieType.Carrot:
                IVeggie carrot = new Carrot();
                return carrot;
            case VeggieType.Broccoli:
                IVeggie broccoli = new Broccoli();
                return broccoli;
            case VeggieType.Potato:
                IVeggie potato = new Potato();
                return potato;
        }
        return null;
    }

    public override IFruit GetFruit(FruitType fruitType)
    {
        return null;
    }
}
