//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class DrawManager : MonoBehaviour
//{
//    private Camera _cam;
//    [SerializeField] private Line _linePrefab;

//    public const float RESOLUTION = .1f;

//    private Line _currentLine;
//    void Start()
//    {
//        _cam = Camera.main;
//    }


//    void Update()
//    {
//        Vector2 mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);

//        if (Input.GetMouseButtonDown(0)) _currentLine = Instantiate(_linePrefab, mousePos, Quaternion.identity);

//        if (Input.GetMouseButton(0)) _currentLine.SetPosition(mousePos);
//    }
//}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawManager : MonoBehaviour
{
    private Camera _cam;
    [SerializeField] private Line _linePrefab;

    public const float RESOLUTION = .1f;

    private Line _currentLine;
    private List<Line> _previousLines = new List<Line>();

    void Start()
    {
        _cam = Camera.main;
    }

    void Update()
    {
        Vector2 mousePos = _cam.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            // Détruire les anciennes lignes
            DestroyPreviousLines();

            // Créer une nouvelle ligne
            _currentLine = Instantiate(_linePrefab, mousePos, Quaternion.identity);
            _previousLines.Add(_currentLine);
        }

        if (Input.GetMouseButton(0))
        {
            _currentLine.SetPosition(mousePos);
        }
    }

    private void DestroyPreviousLines()
    {
        foreach (var line in _previousLines)
        {
            Destroy(line.gameObject);
        }
        _previousLines.Clear();
    }
}