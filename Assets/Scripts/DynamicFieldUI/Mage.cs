using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : MonoBehaviour {
    public AbilityFactory PrimarySpell;
    public int SpellPower = 50;
    public int Health = 100;

    private Ability m_primarySpell = null;

    private void Awake()
    {
        m_primarySpell = PrimarySpell.CreateAbility();
    }

    private void Start()
    {
        m_primarySpell.Execute();
    }
}
