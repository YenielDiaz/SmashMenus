using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Character", menuName = "character")]
public class CharCell : ScriptableObject
{
    [SerializeField] string characterName;
    [SerializeField] Sprite characterImage;
}
