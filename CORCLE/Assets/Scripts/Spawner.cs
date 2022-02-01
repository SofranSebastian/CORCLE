using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Vector2 _range;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private GameObject _bonus;

    private void Start(){
        StartCoroutine( SpawnEnemy() );
        StartCoroutine( SpawnBonus() );
    }

    private IEnumerator SpawnEnemy(){
        yield return new WaitForSeconds(1.75f);
        Vector2 spawnPosition = transform.position + new Vector3( 0, Random.Range( -_range.y, _range.y ) );
        Instantiate( _enemy, spawnPosition, Quaternion.identity );
        StartCoroutine( SpawnEnemy() );
    }

    private IEnumerator SpawnBonus(){
        yield return new WaitForSeconds(2);
        Vector2 spawnPosition = transform.position + new Vector3( 0, Random.Range( -_range.y, _range.y ) );
        Instantiate( _bonus, spawnPosition, Quaternion.identity );
        StartCoroutine( SpawnBonus() );
    }
}
