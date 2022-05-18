using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _XAttack : Skill
{
    [SerializeField] private float m_cooltime;
    [SerializeField] private float animDelay;
    [SerializeField] private float skillDuration;
    
    private void Start() {
        StopCoroutine(DoSkill());
        StartCoroutine(DoSkill());
    }
    private void Update() {
        CoolTimeCheck(m_cooltime);
    }
    public override IEnumerator DoSkill()
    {
        if(readySkill){
            readySkill = false;
            PlayerController.lockBehaviour = true;
            //playerAnimator.SetTrigger("doXAttack");
            yield return new WaitForSeconds(animDelay);

            GameObject instantePrefab= Instantiate(skillPrefab, playerTransform.position, playerTransform.rotation);
            GameObject spawnParticle = Instantiate(skillParticle, playerTransform.position + playerTransform.forward + new Vector3(0,2,0), playerTransform.rotation);

            instantePrefab.transform.parent = this.transform;
            spawnParticle.transform.parent = this.transform;
            yield return new WaitForSeconds(skillDuration);

            PlayerController.lockBehaviour = false;
            Debug.Log("tse");
            Destroy(this.gameObject);
        } 
    }
}
