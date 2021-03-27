using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawmScript : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] AttackerScript[] attackerPrefabArray;

    bool spawn = true;
    IEnumerator Start()
    {
        while(spawn)
        {

            yield return new WaitForSeconds(UnityEngine.Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    private void SpawnAttacker()
    {
        var attackerIndex = Random.Range(0, attackerPrefabArray.Length);
        Spawn(attackerPrefabArray[attackerIndex]);
    }

    private void Spawn(AttackerScript myAttacker)
    {
        AttackerScript newAttacker = Instantiate(myAttacker, transform.position, transform.rotation) as AttackerScript;
        newAttacker.transform.parent = transform;

    }

   
}
