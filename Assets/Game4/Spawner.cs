using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnerPoints;
    [SerializeField] private GameObject _mobPrefab;

    private float _timeSpawn = 0f;

    private void Update()
    {
        _timeSpawn += Time.deltaTime;
        if (_timeSpawn >= Random.Range(1f, 3f))
        {
            GameObject mob =  Instantiate(_mobPrefab);
            mob.transform.position = _spawnerPoints[Random.Range(0, 3)].position;
            _timeSpawn = 0f;
        }
    }
}
