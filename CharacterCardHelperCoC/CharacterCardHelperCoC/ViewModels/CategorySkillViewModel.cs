using CoCHelpers.Classes;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive;

namespace CharacterCardHelperCoC.ViewModels
{
    public class CategorySkillViewModel : SkillViewModel
    {
        private readonly CategorySkill _categorySkill;

        public CategorySkillViewModel(CategorySkill skill) : base(skill)
        {
            _categorySkill = skill;
            Skills = new ReadOnlyObservableCollection<Skill>(_categorySkill.Skills);
            AddSkill = ReactiveCommand.Create<Skill>(s =>
            {
                _categorySkill.Skills.Add(s);
            });
        }

        public ReadOnlyObservableCollection<Skill> Skills { get; }

        public ReactiveCommand<Skill, Unit> AddSkill { get; }
    }
}
