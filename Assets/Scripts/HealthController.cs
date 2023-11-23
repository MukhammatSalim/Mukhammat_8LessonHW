using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthController : MonoBehaviour
{
    [SerializeField] private Slider[] _HPBar;
    [SerializeField] private float _HP;
    [SerializeField] private float _MaxHP;
    [SerializeField] private float _fillspeed;
    [SerializeField] private float _HPRegen;
    public TMP_Text _HPShow;
    private float _HPpercent;

    public void Start()
    {
        _HPpercent = _HP / _MaxHP;
    }

    public void MakeDMG(float dmg)
    {
        if (_HP > 0)
        {
            _HP -= dmg;
        }
        else
        {
            _HP = 0;
        }
    }

    public void AddMaxHP(float AddMaxHPValue)
    {
        _MaxHP += AddMaxHPValue;
    }

    private void Update()
    {
        if (_MaxHP > _HP)
        {
            _HP += _HPRegen;
        }
        else
        {
            _HP = _MaxHP;
        }
        _HPpercent = _HP / _MaxHP;
        foreach (var item in _HPBar)
        {
            item.value = Mathf.Lerp(item.value, _HPpercent, Time.deltaTime * _fillspeed);
        }
        _HPShow.text = "Health " + _HP + "/" + _MaxHP; 
    }
}
