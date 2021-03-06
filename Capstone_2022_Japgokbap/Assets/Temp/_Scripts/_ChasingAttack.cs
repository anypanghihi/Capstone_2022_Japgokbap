using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ChasingAttack : Skill
{
    [SerializeField] private float m_cooltime;

    [SerializeField] private float skillDuration;

    [SerializeField] private float DestoryTime;

    private void Start() {
        m_cooltime = skillSO.skillCooltime;

        StopCoroutine(DoSkill());
        StartCoroutine(DoSkill());
    }
    
    private void Update() {
        CoolTimeCheck(m_cooltime);
    }
    public override IEnumerator DoSkill()
    {
        if(skillSO.coolCheck){
            Destroy(this.gameObject, m_cooltime + 1.0f);
            skillSO.coolCheck = false;
            playerTransform.rotation = Quaternion.LookRotation(PlayerController.mouseDir);
            PlayerController.lockBehaviour = true;
            playerAnimator.SetTrigger("doShoot");
            // GameObject spawnParticle = Instantiate(skillParticle, playerTransform.position + new Vector3(0, 3.0f, 0) + playerTransform.forward*3, playerTransform.rotation);

            yield return new WaitForSeconds(skillDuration);

            GameObject intantePrefab = Instantiate(skillPrefab, playerTransform.position + new Vector3(0, 3.0f, 0), playerTransform.rotation);
            
            // instantePrefab.transform.parent = this.transform;
            // spawnParticle.transform.parent = this.transform;

            
            PlayerController.lockBehaviour = false;

            Destroy(intantePrefab, DestoryTime);
        }
    }
}
