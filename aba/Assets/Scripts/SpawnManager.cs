using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 17.5f;
    private float spawnPositionZ = 20f;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;
    public InputActionAsset inputActions;
    private InputAction pauseAction;
    private InputAction unpauseAction;
    private bool active = true;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (pauseAction.WasPressedThisFrame())
        {
            active = false;
        }

        if (unpauseAction.WasPressedThisFrame())
        {
            active = true;
        }
    }

    void SpawnAnimal()
    {
        if (active)
        {
            // escolhe um animal aleatoriamente
            // animalPrefabs.Length retorna o tamanho do vetor
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            // escolhe um posi��o x aleatoriamente
            Vector3 randomPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPositionZ);
            Instantiate(animalPrefabs[animalIndex], randomPosition,
            animalPrefabs[animalIndex].transform.rotation);
        }

    }

    private void Awake()
    {
        pauseAction = InputSystem.actions.FindAction("Pause");
        unpauseAction = InputSystem.actions.FindAction("Unpause");
    }
}
