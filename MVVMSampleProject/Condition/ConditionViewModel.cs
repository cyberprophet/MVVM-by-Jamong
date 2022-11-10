using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMSampleProject.Observable;


namespace MVVMSampleProject.Condition
{
    
    class ConditionViewModel
    {
        private ConditionRepository conditionRepository;
        public ObservableDataList<ConditionModel> Conditions { get; set; }

        public ConditionViewModel(ConditionRepository conditionRepository)
        {
            this.conditionRepository = conditionRepository;
            Conditions = conditionRepository.GetConditions();
        }


    }
}
