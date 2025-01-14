 using UnityEngine;
using TMPro;
using System;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;
    [SerializeField] private int _numSeeds = 5;

    internal static void UpdateSeeds()
    {
        throw new NotImplementedException();
    }

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {

        
     seedsLeft += _numSeeds;
     seedsPlanted -= _numSeeds;
     _plantedText.text = seedsPlanted.ToString();
     _remainingText.text = seedsLeft.ToString();
        

    }
}