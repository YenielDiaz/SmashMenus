using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashCSS : MonoBehaviour
{
    [SerializeField] List<CharCell> chars = new List<CharCell>();
    [SerializeField] GameObject charCellPrefab;

    void Start()
    {

    }

    private void SpawnCharacterCell(CharCell character)
    {
        GameObject charCell = Instantiate(charCellPrefab, transform);

        Image charImage = charCell.transform.Find("Image").GetComponent<Image>();
        TextMeshProUGUI charText;
    }
}
