using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField]
    [Header("アイテム")]
    List<Items> _items = new();

    [SerializeField]
    [Header("クールタイム")]
    float _coolTime = 1;

    List<int> _probabilityData = new();

    int _sum;
    int _num;
    int _probability;
    int _index;

    Vector2 _pos;

    const int THREE = 3;
    const float TWO_F = 2f;
    const float FIVE_F = 5f;
    const float TEN_F = 10f;

    void Awake()
    {
        _sum = _items
            .Sum(probability =>
                probability
                    .Probability);
        _items
            .ForEach(probability =>
            {
                _probabilityData
                    .Add(probability.Probability + _num);
                _num = probability.Probability;
            });

        StartCoroutine(Generate());
    }

    IEnumerator Generate()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0f, _coolTime));
            _probability = Random.Range(0, _sum);
            _index = _probabilityData.TakeWhile(x => x <= _probability).ToArray().Length;
            if (_index >= THREE) _index--; 
            Debug.Log(_index);
            _pos = new Vector2(TEN_F,Random.Range(-FIVE_F,TWO_F));
            Instantiate(_items[_index].ItemData.Item,_pos,Quaternion.identity,gameObject.transform);
        }
    }


    [System.Serializable]
    public class Items
    {
        public int Probability => _probability;

        public ItemData ItemData => _itemData;

        [SerializeField]
        [Tooltip("生成確率")]
        int _probability;

        [SerializeField]
        [Tooltip("アイテム")]
        ItemData _itemData;
    }
}
