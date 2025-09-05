using System;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject pipePrefab;
    [Header("Settings")]
    [SerializeField] private float spawnStartTime = 1f;
    [SerializeField] private float spawnRateTime = 3f;
    [SerializeField] private float randomRangeY = 7f;

    private bool _active = true;
        
    public void StopSpawning() => _active = false;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnPipe), spawnStartTime, spawnRateTime);
    }

    private void SpawnPipe()
    {
        if (!_active) return;
        
        var randomY = UnityEngine.Random.Range(-randomRangeY, randomRangeY);
        var spawnPos  = new Vector3(0, randomY, 0);
        spawnPos += transform.position;
        Instantiate(pipePrefab, spawnPos, Quaternion.identity);
    }
    
}
