using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace Academy
{
	public partial class MainForm : Form
	{
		Connector connector;
		public readonly Dictionary<string, int> d_directions;
		public readonly	Dictionary<string, int> d_groups;
		DataGridView[] tables;
		Query[] queries = new Query[]
		{
			new Query(
						"last_name,first_name,middle_name,birth_date,group_name, direction_name",
						"Students JOIN Groups ON ([group]=group_id) JOIN Directions ON (direction=direction_id)"
						//"[group]=group_id AND direction=direction_id"
					),
			new Query   (
						"last_name,first_name,middle_name,birth_date,group_name, direction_name",
						"Students,Groups, Directions",
						"[group]=group_id AND direction=direction_id"
						),
			new Query (
					"direction_name,COUNT(DISTINCT group_id) AS N'Количество группов', COUNT(stud_id) AS N'Количество студентов'",
					"Students RIGHT JOIN Groups ON ([group]=group_id) RIGHT JOIN Directions ON (direction=direction_id)",
					"group_id!=0 OR stud_id!=0",
					"direction_name"
				),
			new Query ("*", "Disciplines"),
			new Query ("*", "Teachers")

	};
		string[] status_massages = new string[]
		{
			$"Количество студентов: ",
			$"Количество групп: ",
			$"Количество направлений: ",
			$"Количество дисциплин: ",
			$"Количество преподавателей: ",
		};

        public MainForm()
		{
			InitializeComponent();
			tables = new DataGridView[]
			{
				dgvStudents,
				dgvGroups,
				dgvDirections,
				dgvDisciplines,
				dgvTeacher
			};
			

			connector = new Connector
				(
					ConfigurationManager.ConnectionStrings["PV_319_Import"].ConnectionString
				);

			d_directions = connector.GetDictionary("*", "Directions");  //d_ - Dictionary
			d_groups = connector.GetDictionary("group_id,group_name", "Groups");
			cbStudentsGroup.Items.AddRange(d_groups.Select(g => g.Key).ToArray()); //KeyValuePair
			cbGroupsDirection.Items.AddRange(d_directions.Select(d => d.Key).ToArray()); //KeyValuePair
			cbStudentsDirection.Items.AddRange(d_directions.Select(d => d.Key).ToArray());
			cbStudentsGroup.Items.Insert(0, "Все группы");
			cbStudentsDirection.Items.Insert(0, "Все направления");
			cbGroupsDirection.Items.Insert(0, "Все направления");
			cbStudentsGroup.SelectedIndex = 0;
			cbStudentsDirection.SelectedIndex = 0;
			cbGroupsDirection.SelectedIndex = 0;
			//dgv - DataGridView
			dgvStudents.DataSource = connector.Select
				(
					"last_name,first_name,middle_name,birth_date,group_name,direction_name",
					"Students,Groups,Directions",
					"[group]=group_id AND direction=direction_id"
				);
			toolStripStatusLabelCount.Text = $"Количество студентов:{dgvStudents.RowCount - 1}.";
		}
		void LoadPage(int i,Query query=null)
		{ 
			if(query==null) query = queries[i];
			tables[i].DataSource= connector.Select(query.Columns, query.Tables, query.Condition, query.Group_by);
			toolStripStatusLabelCount.Text = status_massages[i]+CountRecordsInDGV(tables[i]);
		}
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        { string tab_name = tabControl.SelectedTab.Name;
			LoadPage(tabControl.SelectedIndex);
			//int i = tabControl.SelectedIndex;
			/*switch(tabControl.SelectedIndex)
            {
				case 0:
					dgvStudents.DataSource = connector.Select
						(
						"last_name,first_name,middle_name,birth_date,group_name, direction_name",
						"Students,Groups, Directions",
						"[group]=group_id AND direction=direction_id"
						);
					toolStripStatusLabelCount.Text = $"Количество студентов:{dgvStudents.RowCount - 1}.";
					break;
				case 1:
					dgvGroups.DataSource = connector.Select
						(
						"group_name,dbo.GetLearningDaysFor(group_name) AS weekdays,start_time,direction_name",
						"Groups, Directions",
						"direction=direction_id");
					toolStripStatusLabelCount.Text = $"Количество групп:{dgvGroups.RowCount - 1}.";
					break;
				case 2:
					dgvDirections.DataSource = connector.Select
                        //(
                        //"direction_name, COUNT(DISTINCT group_id) AS N'Количество групп', COUNT(stud_id) AS 'Количество студентов'" , 
                        //"Students,Groups,Directions",
                        //"[group]=group_id AND direction=direction_id",
                        //"direction_name"
                        //);
                        (
                        "direction_name, COUNT(DISTINCT group_id) AS N'Количество групп', COUNT(stud_id) AS 'Количество студентов'",
                        "Students RIGHT JOIN Groups ON([group]=group_id) RIGHT JOIN Directions ON (direction=direction_id)",
                        "",
                        "direction_name"
                        );


                    toolStripStatusLabelCount.Text = $"Количество направлений:{dgvDirections.RowCount - 1}.";
					break;
				case 3:
					dgvDisciplines.DataSource = connector.Select("*", "Disciplines");
					toolStripStatusLabelCount.Text = $"Количество дисциплин:{dgvDisciplines.RowCount - 1}.";
					break;
				case 4:
					dgvTeacher.DataSource = connector.Select("*", "Teachers");
					toolStripStatusLabelCount.Text = $"Количество преподавателей:{dgvTeacher.RowCount - 1}.";
					break;
            }*/
        }

  //      private void cbGroupsDirection_SelectedIndexChanged(object sender, EventArgs e)
  //      {
		//	dgvGroups.DataSource = connector.Select
		//	(
		//		"group_name,dbo.GetLearningDaysFor(group_name) AS weekdays,start_time,direction_name",
		//		"Groups, Directions",
		//		$"direction=direction_id AND direction=N'{d_directions[cbGroupsDirection.SelectedItem.ToString()]}'"
		//	);
		//	toolStripStatusLabelCount.Text = $"Количество групп:{CountRecordsInDGV(dgvGroups)}.";

		//}
		int CountRecordsInDGV(DataGridView dgv)
        {
			return dgv.RowCount == 0 ? 0 : dgv.RowCount - 1;
        }
		private void cbDirections_CheckedChanged(object sender, EventArgs e)
		{
			dgvDirections.DataSource = connector.Select
				(
					"direction_name,COUNT(DISTINCT group_id) AS N'Количество групп', COUNT(stud_id) AS N'Количество студентов'",
					"Students RIGHT JOIN Groups ON ([group]=group_id) RIGHT JOIN Directions ON (direction=direction_id)",
					"",
					"direction_name"
				);
		}

		private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string combo_box_name = (sender as ComboBox).Name;
			Console.WriteLine(combo_box_name);
			string tab_name = tabControl.SelectedTab.Name;
			Console.WriteLine(tab_name);

			int last_capital_index = Array.FindLastIndex<char>(combo_box_name.ToCharArray(), Char.IsUpper);
			string cb_suffix = combo_box_name.Substring(last_capital_index, combo_box_name.Length-last_capital_index);
			Console.WriteLine(cb_suffix);

			int i = cbStudentsDirection.SelectedIndex;
			string dictionary_name = $"d_{cb_suffix.ToLower()}s";

			Dictionary<string, int> dictionary = 
				this.GetType().GetField(dictionary_name).GetValue(this) as Dictionary<string, int>;
			Dictionary<string, int> d_groups = connector.GetDictionary

				(
				"group_id,group_name",
				"Groups",
				i <= 0 ? "" : $"{cb_suffix.ToLower()}={dictionary[(sender as ComboBox).SelectedItem.ToString()]}"
				) ;
			cbStudentsGroup.Items.Clear();
			cbStudentsGroup.Items.AddRange(d_groups.Select(g => g.Key).ToArray());

			//int t = tabControl.SelectedIndex;
			//dgvStudents.DataSource =
			//	connector.Select(
			//	queries[t].Columns,
			//	queries[t].Tables,
			//	i == 0 ? "" : $"direction={ d_directions[cbStudentsDirections.SelectedItem.ToString()]}"
			//	);
			Query query = new Query(queries[tabControl.SelectedIndex]);
			string condition =
				(i == 0 || (sender as ComboBox).SelectedItem == null ? "" : $"[{cb_suffix.ToLower()}]={dictionary[$"{(sender as ComboBox).SelectedItem}"]}");
			if (query.Condition == "") query.Condition = condition;
			else if (condition != "") query.Condition += $" AND {condition}";
			LoadPage(tabControl.SelectedIndex, query);
		}

     
    }
}
