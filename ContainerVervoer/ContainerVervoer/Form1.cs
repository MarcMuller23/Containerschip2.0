using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static ContainerVervoer.Container;

namespace ContainerVervoer
{
    public partial class Form1 : Form
    {
        private readonly Port RotterdamHarbor = new Port();
        public List<Container> NormalContainerList { get; internal set; } = new List<Container>();
        public List<Container> ValuableContainerList { get; internal set; } = new List<Container>();
        public List<Container> CooledContainerList { get; internal set; } = new List<Container>();
        public Form1()
        {
            InitializeComponent();
            ContainerTypeCB.DataSource = Enum.GetValues(typeof(ContainerType));
        }
        private void SetShipBtn_Click(object sender, EventArgs e)
        {
            int shipLength = (int)ShipLengthNum.Value;
            int shipWidth = (int)ShipWidthNum.Value;
            int shipHeight = (int)ShipHeightNum.Value;
            RotterdamHarbor.CreateShip(shipLength, shipWidth, shipHeight);
            SetShipBtn.Enabled = false;
            PlanContainersBtn.Enabled = true;

        }
        private void AddContanerBtn_Click(object sender, EventArgs e)
        {
            int containerWeigth = (int)ContainerWeightNum.Value;
            AddedContainerLB.Items.Add(new Container((ContainerType)ContainerTypeCB.SelectedItem, containerWeigth));
            if ((ContainerType)ContainerTypeCB.SelectedItem == ContainerType.Valuable)
            {
                ValuableContainerList.Add(new Container((ContainerType)ContainerTypeCB.SelectedItem, containerWeigth));
            }
            else if ((ContainerType)ContainerTypeCB.SelectedItem == ContainerType.Cooled)
            {
                CooledContainerList.Add(new Container((ContainerType)ContainerTypeCB.SelectedItem, containerWeigth));
            }
            NormalContainerList.Add(new Container((ContainerType)ContainerTypeCB.SelectedItem, containerWeigth));
        }
        private void PlanContainersBtn_Click(object sender, EventArgs e)
        {
            Stack1Lb.Items.Clear();
            RotterdamHarbor.SetContainerList(NormalContainerList, ValuableContainerList, CooledContainerList);
            RotterdamHarbor.BuildStacks();
            RotterdamHarbor.GetStack();
            foreach (var container in RotterdamHarbor.GetStack())
            {
                Stack1Lb.Items.Add(container);
            }
        }
    }
}
