using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private Transform Spawn;
    [SerializeField] private int _numSeeds = 5;
    [SerializeField] private PlantCountUI _plantCountUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_numSeeds > 0)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(_plantPrefab, Spawn.position, Quaternion.identity);
                _numSeeds--;
            }
            PlantCountUI.UpdateSeeds();


        }
        
    }
}
