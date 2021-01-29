using System;
using TLY.SkillSystem;
using UnityEngine;

namespace TLY.TownActivities.NPC
{
    public interface SkillTrainer
    {
        string inquiryLine { get; }
        SkillBlock TrainSkill();
    }
}
