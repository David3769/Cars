using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCar : MonoBehaviour
{
    [Header("GameObject")]
    [SerializeField] private GameObject[] _cars;
    [Header("Float")]
    [SerializeField] private float[] _positionOnCreate;
    [Header("Scripts")]
    [SerializeField] private SpeedCreateCar _speedCreateCars;

    private void Start()
    {
        StartCoroutine(CoroutineCar());
    }

    private IEnumerator CoroutineCar()
    {
        while (true)
        {
            Instantiate(
                _cars[Random.Range(0, _cars.Length)],
                new Vector2(_positionOnCreate[Random.Range(0, _positionOnCreate.Length)], 40f),
                Quaternion.Euler(new Vector3(0, 0, 180))
                );

            yield return new WaitForSeconds(_speedCreateCars.speedCreateCar);
        }
    }
}
