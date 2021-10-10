using System.Collections.Generic;
using UnityEngine;

public class TileReplacement : MonoBehaviour
{
    [SerializeField] private List<Ground> _tiles;
    [SerializeField] private Transform _hero;
    [SerializeField] private float _distanceOfReplacement;

    private Ground _firstTile;
    private Ground _endTile;

    private int index = 0;

    private void Awake()
    {
        LookForTheNewFirstTile();
        _endTile = _tiles[_tiles.Count - 1];
    }

    private void Update()
    {
        if (Vector2.Distance(_hero.position, _endTile.endPosition.position) < _distanceOfReplacement)
        {
            _firstTile.Replace(_endTile.endPosition);

            _endTile.endPosition.gameObject.SetActive(false);
            _endTile = _firstTile;
            LookForTheNewFirstTile();
        }
    }

    private void LookForTheNewFirstTile()
    {
        _firstTile = _tiles[index % _tiles.Count];
        index++;
    }
}
