using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObjects/ItemData", order = 0)]
public class ItemData : ScriptableObject
{
    public ItemType Type => _type;
    public ItemBase Item => _item;

    [SerializeField]
    [Header("�A�C�e���̎��")]
    ItemType _type;

    [SerializeField]
    [Header("�A�C�e��")]
    ItemBase _item;
}
