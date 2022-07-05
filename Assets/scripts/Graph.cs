using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab;
    [SerializeField]
    int resolution;
    void Awake()
    {
        Vector3 position = Vector3.zero;
        var scale = Vector3.one / 5f;

        for (int i = 0; i < resolution; i++)
        {
            Transform point = Instantiate(pointPrefab);
            // f(x) = x
            position.x = (i + 0.5f) / 5f - 1f;
            position.y = position.x * position.x;
            
            point.localPosition = position;
            point.localScale = scale;
        }
    }
}
