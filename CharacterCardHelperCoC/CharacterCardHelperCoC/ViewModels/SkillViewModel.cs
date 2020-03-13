using CoCHelpers.Classes;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace CharacterCardHelperCoC.ViewModels
{
    public class SkillViewModel : ReactiveObject
    {
        private readonly Skill _skill;

        public SkillViewModel(Skill skill)
        {
            _skill = skill;
        }

        public string Name => _skill.Name;

        public int StartingValue => _skill.StartingValue;

        [Reactive]
        public int Value { get => _skill.Value; set => _skill.Value = value; }

        public SkillCategory Category => _skill.Category;

        public bool IsModern => _skill.IsModern;
    }
}
