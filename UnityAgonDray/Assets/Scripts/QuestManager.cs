using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestManager : MonoBehaviour
{
    public GameObject InstructionText;
    public TMP_Text Obj;
    public GameObject Obj2;
    public GameObject newTrig;
    private void Start()
    {
        InstructionText.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            InstructionText.SetActive(true);
            Obj.fontStyle = FontStyles.Strikethrough;
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1);
        Obj2.SetActive(true);
        newTrig.SetActive(true);
        Destroy(InstructionText);
        Destroy(gameObject);
    }
}