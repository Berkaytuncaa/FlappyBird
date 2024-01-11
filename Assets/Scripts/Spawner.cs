using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Bird birdScript;
    public GameObject Pipes;

    [SerializeField] private float height;

    [SerializeField] private float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    public IEnumerator SpawnObject(float time)
    {
        while (!birdScript.isDead)
        {
            Instantiate(Pipes, new Vector3(3, Random.Range(-height, height),0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
    }
}
