using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnSuresi = 1f;
    public float minYuksek = -1f;
    public float maxYuksek = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnSuresi, spawnSuresi);
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Spawn()
    {
        GameObject borular = Instantiate(prefab, transform.position,Quaternion.identity);
        borular.transform.position += Vector3.up * Random.Range(minYuksek, maxYuksek);
    }
}
