using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ContainerVervoer.Container;

namespace ContainerVervoer
{
    public partial class Form1 : Form
    {
        private readonly Port RotterdamHarbor = new Port();
        private readonly ShipFactory Factory = new ShipFactory();
        public List<Container> NormalContainers { get; internal set; } = new List<Container>();
        public List<Container> ValuableContainers { get; internal set; } = new List<Container>();
        public List<Container> CooledContainers { get; internal set; } = new List<Container>();
        public Form1()
        {
            InitializeComponent();
            ContainerTypeCB.DataSource = Enum.GetValues(typeof(ContainerType));
        }
        //Creating a ship
        private void SetShipBtn_Click(object sender, EventArgs e)
        {
            int shipLength = (int)ShipLengthNum.Value;
            int shipWidth = (int)ShipWidthNum.Value;
            int shipHeight = (int)ShipHeightNum.Value;
            Factory.CreateShip(shipLength, shipWidth, shipHeight, ValuableContainers.Count, CooledContainers.Count);
            SendFactory();
            SetShipBtn.Enabled = false;
            PlanContainersBtn.Enabled = true;

        }

        //Filling the list with containers to add
        private void AddContanerBtn_Click(object sender, EventArgs e)
        {
            int containerWeigth = (int)ContainerWeightNum.Value;
            for (int i = 0; i < 4; i++)
            {
                ValuableContainers.Add(new Container(ContainerType.Valuable, 30));
            }
            for (int i = 0; i < 12; i++)
            {
                CooledContainers.Add(new Container(ContainerType.Cooled, 30));
            }
            for (int i = 0; i < 48; i++)
            {
                NormalContainers.Add(new Container(ContainerType.Normal, 30));
            }
            foreach (var container in ValuableContainers)
            {
                AddedContainerLB.Items.Add(container);
            }
            foreach (var container in CooledContainers)
            {
                AddedContainerLB.Items.Add(container);
            }
            foreach (var container in NormalContainers)
            {
                AddedContainerLB.Items.Add(container);
            }


         

        }
        //Arrangin all containers over ship
        private void PlanContainersBtn_Click(object sender, EventArgs e)
        {
            Stack1Lb.Items.Clear();
            RotterdamHarbor.SetContainerList(NormalContainers, ValuableContainers, CooledContainers);
            RotterdamHarbor.BuildStacks();
            RotterdamHarbor.GetStack();
            foreach (var container in RotterdamHarbor.GetStack())
            {
                Stack1Lb.Items.Add(container);
            }
            RotterdamHarbor.AssignRow();
        }
        //Sending same factory to port classe
        public void SendFactory() { RotterdamHarbor.SetFactory(Factory); }

        private void ShowVisual_Click(object sender, EventArgs e)
        {
            Factory.GetShip().Visualizer();
        }
    }
}
