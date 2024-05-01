using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCreator : MonoBehaviour
{
    public Rigidbody2D spellOriginal;
    public Transform spellContainer;
    public float num_clicked = 3;

    // Update is called once per frame
    void Update()
    {
        if (num_clicked > 0)
        {
            if (Input.GetButtonDown("Vertical"))
            {
            CreateSpells();
            num_clicked -= 1;
            }
        }
    }

    public void CreateSpells()
    {
        Rigidbody2D SpellClone = Instantiate(spellOriginal, spellContainer.position, spellOriginal.transform.rotation);
        SpellClone.transform.parent = spellContainer.transform;
        SpellClone.name = "SpellSpawn";
    }

}
