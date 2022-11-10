using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVVMSampleProject.Observable;

namespace MVVMSampleProject.Condition
{
    public partial class ConditionListView : UserControl
    {
        ConditionRepository conditionRepository;
        ConditionViewModel conditionViewModel;

        public ConditionListView(AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI)
        {
            InitializeComponent();

            conditionRepository = new ConditionRepository(axKHOpenAPI);
            conditionViewModel = new ConditionViewModel(conditionRepository);

            conditionViewModel.Conditions.Observers += Condition_Observer;
        }


        public void Condition_Observer(object sender, ObservableEventArgs<List<ConditionModel>> e)
        {
            for (int i = 0; i < e.value.Count; i++)
            {
                Console.WriteLine(e.value[i].Index + "|" + e.value[i].Name);
            }
            // update UI

            List<ConditionModel> conditions = e.value;
            for(int i=0; i<conditions.Count; i++)
            {
                int rowIndex = this.dataGridView.Rows.Add();
                dataGridView["ConditionIndex", rowIndex].Value = conditions[i].Index;
                dataGridView["ConditionName", rowIndex].Value = conditions[i].Name;
            }
            
        }


    }
}
