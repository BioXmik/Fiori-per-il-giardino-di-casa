using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Image imageFlower;
    public TMP_Text nameFlower;
    public TMP_Text descriptionFlower;

    public int thisFlower;
    public FlowerType flowerType;
    private int countFlowers;

    public List<Flower> flowersInSpring = new List<Flower>();
    public List<Flower> flowersInSummer = new List<Flower>();

    public void OpenFlowersInSpringList()
    {
        flowerType = FlowerType.flowersInSpring;
        if (flowerType == FlowerType.flowersInSpring)
        {
            countFlowers = flowersInSpring.Count;
        }
        SetFlower();
    }

    public void OpenFlowersInSummerList()
    {
        flowerType = FlowerType.flowersInSummer;
        if (flowerType == FlowerType.flowersInSummer)
        {
            countFlowers = flowersInSummer.Count;
        }
        SetFlower();
    }

    public void Left()
    {
        if (thisFlower > 0)
        {
            thisFlower--;
            SetFlower();
        }
    }

    public void Right()
    {
        if (thisFlower < countFlowers - 1)
        {
            thisFlower++;
            SetFlower();
        }
    }

    private void SetFlower()
    {
        if (flowerType == FlowerType.flowersInSpring)
        {
            imageFlower.sprite = flowersInSpring[thisFlower].image;
            nameFlower.text = flowersInSpring[thisFlower].name;
            descriptionFlower.text = flowersInSpring[thisFlower].description;
        }
        else if (flowerType == FlowerType.flowersInSummer)
        {
            imageFlower.sprite = flowersInSummer[thisFlower].image;
            nameFlower.text = flowersInSummer[thisFlower].name;
            descriptionFlower.text = flowersInSummer[thisFlower].description;
        }
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ReadPrivacyPolicy()
    {
        Application.OpenURL("https://docs.google.com/document/d/1_qBGJYQhvO2f9dGnq04h48db66n9uTbdWTxvo3tzeHs/edit?usp=sharing");
    }
}

public enum FlowerType
{
    flowersInSpring,
    flowersInSummer
}

[System.Serializable]
public class Flower
{
    public Sprite image;
    public string name;
    public string description;
}
