using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeColorBehaviour : MonoBehaviour
{
    private MeshRenderer _renderer;
    [SerializeField]
    private Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    private void OnMouseDown()
    {
        Vector4 color = new Vector4(Random.value, Random.value, Random.value, Random.value);
        _renderer.material.color = color;

        _text.text = "Color: " + color;
    }
}
