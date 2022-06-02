using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float spawnRateMin = 0.5f;

    public float spawnerRateMax = 3f;

    private Transform target;

    private float spawnRate;

    /// <summary>
    /// 최근 생성 시점에서 지난 시간
    /// </summary>
    private float timeAfterSpawn; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
