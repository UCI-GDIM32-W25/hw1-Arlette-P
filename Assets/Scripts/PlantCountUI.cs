 using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;
    [SerializeField] private int _numSeeds = 5;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        seedsLeft += _numSeeds;
        seedsPlanted -= _numSeeds;
        _plantedText.SetText("Seeds Planted" + seedsPlanted);
        _remainingText.SetText("Seeds Remaining" + seedsLeft);

    }
}