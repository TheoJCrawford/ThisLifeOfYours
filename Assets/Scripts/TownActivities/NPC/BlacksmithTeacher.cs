using TLY.SkillSystem;
using UnityEngine;
namespace TLY.TownActivities.NPC
{
    public class BlacksmithTeacher:NPCCore,SkillTrainer
    {
        private string _inquiryLine = "Can I help you with something?";

        public string inquiryLine { get => _inquiryLine; }
        public override void Speak(int direct)
        {
            _anima.SetDirection(direct);
            if (hasMet)
            {
                switch (curState)
                {
                    case NPCState.work:
                        GameObject.Find("Deus").GetComponent<UI.UIHandler>().ModifyText(_inquiryLine);
                        GameObject.Find("Deus").GetComponent<UI.UIHandler>().EnguageTrainerOption(gameObject);
                        break;
                }
            }
            else
            {
                GameObject.Find("Deus").GetComponent<UI.UIHandler>().ModifyText(IntroductionLine);
                hasMet = true;
            }
        }
        public SkillBlock TrainSkill()
        {
            return new SmithingSkillBlock();
        }
    }
}
