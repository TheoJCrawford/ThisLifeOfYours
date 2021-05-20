using TLY.SkillSystem;
using UnityEngine;
namespace TLY.TownActivities.NPC
{
    public class BlacksmithTeacher:NPCCore
    {
        private string _inquiryLine = "Can I help you with something?";

        public string inquiryLine { get => _inquiryLine; }
        public override void Speak(Vector2 direct)
        {
            _anima.SetDirection(direct);
            if (hasMet)
            {
                switch (curState)
                {
                    case NPCState.work:
                        ;
                        break;
                    case NPCState.talk:
                        
                        
                        break;
                }
            }
            else
            {
                hasMet = true;
            }
        }
    }
}
