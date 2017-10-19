using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dao;
using Entidades;

namespace Pantalla
{
    public partial class StandardsPreference : Form
    {
        public int standardCounter = 70;
        public List<Entidades.Standard> standardList;
        public Entidades.Standard mainStandard;
        public DecisionProblem decision;
        public List<string> preferences = new List<string> { "Igualmente Importante.", "Moderadamente Importante.", "Fuertemente más Importante.", "Muy Fuertemente Importante.", "Absolutamente más Importante." };
        private List<StandardPreferencesEntity> standardPreferenceList = new List<StandardPreferencesEntity>();
        private int listIndex;
        private Button leftButton = new Button();
        private Button rightButton = new Button();
        private Preferences thisPreference;

        public List<StandardPreferencesEntity> getStandardPreferencesList()
        {
            return standardPreferenceList;
        }

        public StandardsPreference(DecisionProblem DECISION, List<Entidades.Standard> StandardList)
        {
            InitializeComponent();
            this.standardList = StandardList;
            this.mainStandard = StandardList[0];
            this.decision = DECISION;
        }

        private void loadPreferencesList(List<Entidades.Standard> list)
        {
            for (int i = 0; i < list.Count(); i++)
            {
                StandardPreferencesEntity StandardPreferences = new StandardPreferencesEntity(list[i]);
                standardPreferenceList.Add(StandardPreferences);
            }
        }

        private void StandardsPreference_Load(object sender, EventArgs e)
        {
            int startIndex = 1;
            int mainIndex = 0;
            int optionCounter = 0;

            loadPreferencesList(standardList);
            //int numberPreference = 0;
            // int preferenceIndex = 0;
            //int preferenceLength = 10;

            while (startIndex < standardList.Count)
            {
                for (int i = startIndex; i < standardList.Count(); i++)
                //foreach (Entidades.Standard standards in standardList)
                {
                    Button btn_Choice = new System.Windows.Forms.Button();
                    btn_Choice.Location = new System.Drawing.Point(150, standardCounter);
                    btn_Choice.Name = mainStandard.IdStandard.ToString();
                    btn_Choice.Size = new System.Drawing.Size(70, 26);
                    btn_Choice.Text = mainStandard.Name.ToString();
                    btn_Choice.BackColor = System.Drawing.Color.LightGray;
                    btn_Choice.Click += new System.EventHandler(this.MyButtonEvent_Click);
                    this.Controls.Add(btn_Choice);

                    Button btn_Indiferent = new System.Windows.Forms.Button();
                    btn_Indiferent.Location = new System.Drawing.Point(250, standardCounter);
                    btn_Indiferent.Name = "btn_Indiferent";
                    btn_Indiferent.Size = new System.Drawing.Size(70, 26);
                    btn_Indiferent.Text = "Indiferentes";
                    btn_Indiferent.Click += new System.EventHandler(this.MyButtonEvent_Click);
                    this.Controls.Add(btn_Indiferent);

                    Button btn_SecondChoice = new System.Windows.Forms.Button();
                    btn_SecondChoice.Location = new System.Drawing.Point(350, standardCounter);
                    btn_SecondChoice.Name = standardList[i].IdStandard.ToString();
                    btn_SecondChoice.Size = new System.Drawing.Size(70, 26);
                    btn_SecondChoice.Text = standardList[i].Name.ToString();
                    btn_SecondChoice.Click += new System.EventHandler(this.MyButtonEvent_Click);
                    this.Controls.Add(btn_SecondChoice);

                    standardCounter += 80;

                    optionCounter += 1;
                    //AddHandler btn_firstChoice, AddressOf boton1_click

                    //btn_Finish.Text = "Empezar";

                    //if (standardList[i].IdStandard != mainStandard.IdStandard)
                    //{


                    //preferenceIndex = standarCounter + 35;
                    //standarCounter += 25;
                    //foreach (string preference in preferences)
                    //{
                    //    RadioButton radio = new RadioButton();
                    //    radio.Text = preference.ToString();
                    //    radio.Tag = numberPreference;
                    //    radio.Location = new System.Drawing.Point(10, standarCounter);
                    //    radio.Size = new System.Drawing.Size(200, 23);
                    //    Controls.Add(radio);
                    //    numberPreference++;
                    //    // preferenceIndex += 25;
                    //    standarCounter += 25;
                    //    //preferenceLength += 100;
                    //}

                    // preferenceIndex = 0;
                    //preferenceLength = 10;
                    //standarCounter += 25;
                    //}
                }

                if (standardList.Count > 2)
                {
                    mainIndex++;
                    this.mainStandard = standardList[mainIndex];
                }
                startIndex++;
            }

            Button btn_Finish = new System.Windows.Forms.Button();
            btn_Finish.Location = new System.Drawing.Point(500, standardCounter);
            btn_Finish.Name = "btn_Finish";
            btn_Finish.Size = new System.Drawing.Size(30, 23);
            btn_Finish.Text = "Terminar";
            btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            Controls.Add(btn_Finish);
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            if (validateSelections())
                this.Close();
            else
                MessageBox.Show("Debe indicar una preferencia para cada par de criterios antes de continuar.", "Optimal Decision", MessageBoxButtons.OK);
        }

        private void MyButtonEvent_Click(object sender, EventArgs e)
        {
            Button mybutton = sender as Button;

            bool optionsHasValue = true;
            rightButton = this.Controls.OfType<Button>().Where(x => x.Location.Y == mybutton.Location.Y && x.Location.X == 350).ToList()[0];
            leftButton = this.Controls.OfType<Button>().Where(x => x.Location.Y == mybutton.Location.Y && x.Location.X == 150).ToList()[0];

            listIndex = standardPreferenceList.FindIndex(x => x.mainStandard.IdStandard == Convert.ToInt32(leftButton.Name));
            if (standardPreferenceList[listIndex].existsPreference(Convert.ToInt32(rightButton.Name)))
            {
                standardPreferenceList[listIndex].removePreference(Convert.ToInt32(rightButton.Name));
                listIndex = standardPreferenceList.FindIndex(x => x.mainStandard.IdStandard == Convert.ToInt32(rightButton.Name));
                standardPreferenceList[listIndex].removePreference(Convert.ToInt32(leftButton.Name));
            }

            if (mybutton.Name == "btn_Indiferent")
            {
                leftButton = this.Controls.OfType<Button>().Where(x => x.Location.Y == mybutton.Location.Y && x.Location.X == 150).ToList()[0];
                listIndex = standardPreferenceList.FindIndex(x => x.mainStandard.IdStandard == Convert.ToInt32(leftButton.Name));

                rightButton = this.Controls.OfType<Button>().Where(x => x.Location.Y == mybutton.Location.Y && x.Location.X == 350).ToList()[0];
                thisPreference = new Preferences(standardList.Find(x => x.IdStandard == Convert.ToInt32(rightButton.Name)), 1);

                standardPreferenceList[listIndex].addPreference(thisPreference);

                listIndex = standardPreferenceList.FindIndex(x => x.mainStandard.IdStandard == Convert.ToInt32(rightButton.Name));
                thisPreference = new Preferences(standardList.Find(x => x.IdStandard == Convert.ToInt32(leftButton.Name)), 1);

                standardPreferenceList[listIndex].addPreference(thisPreference);
            }
            else if (mybutton.Name != "btn_Indiferent")
            {
                Pantalla.Options optionsWindow = new Pantalla.Options();
                optionsWindow.ShowDialog();

                int value = optionsWindow.getValue();

                if (mybutton.Location.X == 150)
                {
                    this.rightButton = this.Controls.OfType<Button>().Where(x => x.Location.Y == mybutton.Location.Y && x.Location.X == 350).ToList()[0];

                    this.listIndex = standardPreferenceList.FindIndex(x => x.mainStandard.IdStandard == Convert.ToInt32(mybutton.Name));
                    this.thisPreference = new Preferences(standardList.Find(x => x.IdStandard == Convert.ToInt32(this.rightButton.Name)), value);

                    standardPreferenceList[this.listIndex].addPreference(this.thisPreference);

                    this.listIndex = standardPreferenceList.FindIndex(x => x.mainStandard.IdStandard == Convert.ToInt32(this.rightButton.Name));
                    this.thisPreference = new Preferences(standardList.Find(x => x.IdStandard == Convert.ToInt32(mybutton.Name)), (1 / value));

                    standardPreferenceList[this.listIndex].addPreference(this.thisPreference);
                }
                else
                {
                    this.leftButton = this.Controls.OfType<Button>().Where(x => x.Location.Y == mybutton.Location.Y && x.Location.X == 150).ToList()[0];

                    this.listIndex = standardPreferenceList.FindIndex(x => x.mainStandard.IdStandard == Convert.ToInt32(mybutton.Name));
                    this.thisPreference = new Preferences(standardList.Find(x => x.IdStandard == Convert.ToInt32(this.leftButton.Name)), value);

                    standardPreferenceList[this.listIndex].addPreference(this.thisPreference);

                    this.listIndex = standardPreferenceList.FindIndex(x => x.mainStandard.IdStandard == Convert.ToInt32(this.leftButton.Name));
                    this.thisPreference = new Preferences(standardList.Find(x => x.IdStandard == Convert.ToInt32(mybutton.Name)), (1 / value));

                    standardPreferenceList[this.listIndex].addPreference(this.thisPreference);
                }

                //Label lbl_Date = new System.Windows.Forms.Label();
                //lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //lbl_Date.Location = new System.Drawing.Point(10, standardCounter);
                //lbl_Date.Name = "Result";
                //lbl_Date.Size = new System.Drawing.Size(400, 23);
                //lbl_Date.Text = optionsWindow.value.ToString();
                //lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                //Controls.Add(lbl_Date);
            }

            foreach (Button anyButton in this.Controls.OfType<Button>().Where((anyButton) => anyButton.Location.Y == mybutton.Location.Y))
            { anyButton.BackColor = System.Drawing.Color.LightSalmon; }
            mybutton.BackColor = System.Drawing.Color.Green;
            mybutton.Focus();
        }


        private bool validateSelections()
        {
            bool missingPreferences = true;
            int height = -145;  // En ejecución por alguna razón cambia la posición "70" por "-145", y así respectivamente para cada botón.

            while (missingPreferences)
            {
                List<Button> buttonList = (this.Controls.OfType<Button>().Where((anyButton) => anyButton.Location.Y == height).ToList<Button>());
                if (buttonList.Exists(x => x.Name == "btn_Finish"))
                    missingPreferences = false;
                else if (!(buttonList.Exists(x => x.BackColor == System.Drawing.Color.Green)))
                    return false;
                height += 80;

            }
            return true;
        }

    }
}


