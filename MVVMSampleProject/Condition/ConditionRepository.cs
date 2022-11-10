using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMSampleProject.Observable;

namespace MVVMSampleProject.Condition
{
    class ConditionRepository
    {
        AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI;
        private ObservableDataList<ConditionModel> conditions;

        public ConditionRepository(AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI)
        {
            this.axKHOpenAPI = axKHOpenAPI;
            axKHOpenAPI.OnReceiveConditionVer += API_OnReceiveConditionVer;
        }

        void API_OnReceiveConditionVer(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveConditionVerEvent e)
        {
            Console.WriteLine("API_OnReceiveConditionVer()");
            Console.WriteLine("e.lRet :" + e.lRet);
            Console.WriteLine("e.sMsg: " + e.sMsg);

            string conditionNameList = axKHOpenAPI.GetConditionNameList().Trim();
            string[] conditionArray = conditionNameList.Split(';');

            List<ConditionModel> conditions = new List<ConditionModel>();
            for(int i=0; i<conditionArray.Length; i++)
            {
                if (!conditionArray[i].Contains('^'))
                    continue;

                string[] conditionTokens = conditionArray[i].Split('^');
                ConditionModel condition = new ConditionModel{
                    Index = int.Parse(conditionTokens[0]),
                    Name = conditionTokens[1]
                };

                conditions.Add(condition);
            }
            this.conditions.AddAll(conditions);
        }

        public ObservableDataList<ConditionModel> GetConditions()
        {
            if(conditions == null)
            {
                conditions = new ObservableDataList<ConditionModel>();
                axKHOpenAPI.GetConditionLoad();
            }

            return conditions;
        }
    }
}
